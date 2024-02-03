namespace DesignPatterns.AbstractFactory.Local;

public class Storage : IStorage
{
    private readonly StorageSettings settings;

    public Storage(StorageSettings settings)
    {
        this.settings = settings;
    }

    public Task<IPathInfo> CreateDirectory(string name)
    {
        var directoryPath = Path.Combine(this.settings.Path, name);
        var directoryInfo = new DirectoryInfo(directoryPath);
        directoryInfo.Create();
        var result = new Directory
        {
            Name = directoryInfo.Name,
            Path = directoryInfo.FullName
        };

        return Task.FromResult<IPathInfo>(result);
    }

    public Task<IPathInfo> CreateFile(string name)
    {
        var filePath = Path.Combine(this.settings.Path, name);
        var fileInfo = new FileInfo(filePath);
        fileInfo.Create();
        var result = new File
        {
            Name = fileInfo.Name,
            Path = fileInfo.FullName
        };

        return Task.FromResult<IPathInfo>(result);
    }
}
