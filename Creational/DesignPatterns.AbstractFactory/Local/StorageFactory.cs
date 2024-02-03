namespace DesignPatterns.AbstractFactory.Local;

public class StorageFactory : IStorageFactory
{
    private readonly StorageSettings settings;

    public StorageFactory(StorageSettings settings)
    {
        this.settings = settings;
    }

    public IStorage Create()
    {
        return new Storage(this.settings);
    }
}
