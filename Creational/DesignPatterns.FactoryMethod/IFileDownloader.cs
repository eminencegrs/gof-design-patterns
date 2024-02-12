namespace DesignPatterns.FactoryMethod;

public interface IFileDownloader
{
    void DownloadFile(string fileName, string destinationPath);
}
