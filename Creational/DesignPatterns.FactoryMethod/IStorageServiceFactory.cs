namespace DesignPatterns.FactoryMethod;

public interface IStorageServiceFactory
{
    IFileUploader CreateUploader();
    IFileDownloader CreateDownloader();
}
