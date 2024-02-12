using Azure.Storage.Blobs;

namespace DesignPatterns.FactoryMethod;

public class AzureStorageDownloader : IFileDownloader
{
    private readonly BlobContainerClient containerClient;

    public AzureStorageDownloader(string connectionString, string containerName)
    {
        this.containerClient = new BlobContainerClient(connectionString, containerName);
    }

    public void DownloadFile(string fileName, string destinationPath)
    {
        BlobClient blobClient = this.containerClient.GetBlobClient(fileName);
        blobClient.DownloadTo(destinationPath);
    }
}
