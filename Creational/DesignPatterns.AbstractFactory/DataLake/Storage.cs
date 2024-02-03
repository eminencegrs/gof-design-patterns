using Azure.Storage.Files.DataLake;

namespace DesignPatterns.AbstractFactory.DataLake;

public class Storage : IStorage
{
    private readonly StorageSettings settings;
    private readonly DataLakeServiceClient dataLakeServiceClient;

    public Storage(StorageSettings settings, DataLakeServiceClient dataLakeServiceClient)
    {
        this.settings = settings;
        this.dataLakeServiceClient = dataLakeServiceClient;
    }

    public async Task<IPathInfo> CreateDirectory(string name)
    {
        var fileSystemClient = this.dataLakeServiceClient.GetFileSystemClient(this.settings.FileSystemName);
        await fileSystemClient.CreateIfNotExistsAsync();
        var response = await fileSystemClient.CreateDirectoryAsync(name);
        if (!response.HasValue)
        {
            throw new DirectoryNotFoundException($"Could not create the '{name}' directory.");
        }

        return new Directory
        {
            Name = response.Value.Name,
            Path = response.Value.Path,
            Uri = response.Value.Path
        };
    }

    public async Task<IPathInfo> CreateFile(string name)
    {
        var fileSystemClient = this.dataLakeServiceClient.GetFileSystemClient(this.settings.FileSystemName);
        await fileSystemClient.CreateIfNotExistsAsync();
        var response = await fileSystemClient.CreateFileAsync(name);
        if (!response.HasValue)
        {
            throw new FileNotFoundException($"Could not create the '{name}' file.");
        }

        return new File
        {
            Name = response.Value.Name,
            Path = response.Value.Path,
            Uri = response.Value.Path
        };
    }
}
