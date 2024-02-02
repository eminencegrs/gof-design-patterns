namespace DesignPatterns.AbstractFactory;

public interface IStorageFactory
{
}

public class LocalStorageFactory : IStorageFactory
{
}

public class AzureStorageFactory : IStorageFactory
{
}
