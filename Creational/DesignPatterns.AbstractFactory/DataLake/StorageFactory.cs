using Azure.Storage.Files.DataLake;

namespace DesignPatterns.AbstractFactory.DataLake;

public class StorageFactory : IStorageFactory
{
    private readonly StorageSettings settings;
    private readonly DataLakeServiceClient serviceClient;

    public StorageFactory(StorageSettings settings, DataLakeServiceClient serviceClient)
    {
        this.settings = settings;
        this.serviceClient = serviceClient;
    }

    public IStorage Create()
    {
        return new Storage(settings, serviceClient);
    }
}
