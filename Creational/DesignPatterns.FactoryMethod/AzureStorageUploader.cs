using Azure.Storage.Blobs;

namespace DesignPatterns.FactoryMethod;

public class AzureStorageUploader : IFileUploader
{
    private readonly BlobContainerClient containerClient;

    public AzureStorageUploader(string connectionString, string containerName)
    {
        this.containerClient = new BlobContainerClient(connectionString, containerName);
    }

    public void UploadFile(string filePath)
    {
        var fileName = Path.GetFileName(filePath);
        var blobClient = this.containerClient.GetBlobClient(fileName);
        blobClient.Upload(filePath, true);
    }
}
