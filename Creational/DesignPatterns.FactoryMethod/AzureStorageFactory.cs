namespace DesignPatterns.FactoryMethod;

public class AzureStorageFactory : IStorageServiceFactory
{
    private readonly string connectionString;
    private readonly string containerName;

    public AzureStorageFactory(string connectionString, string containerName)
    {
        this.connectionString = connectionString;
        this.containerName = containerName;
    }

    public IFileUploader CreateUploader()
    {
        return new AzureStorageUploader(this.connectionString, this.containerName);
    }

    public IFileDownloader CreateDownloader()
    {
        return new AzureStorageDownloader(this.connectionString, this.containerName);
    }
}
