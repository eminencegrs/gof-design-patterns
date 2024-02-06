namespace DesignPatterns.Decorator;

internal class FileUploader : IFileUploader
{
    public async Task Upload(string name, Stream stream)
    {
        // TODO: add a client to upload files into cloud.
        Console.WriteLine($"{nameof(FileUploader)}.{nameof(this.Upload)}: started uploading a file...");
        await Task.Delay(1000);
        Console.WriteLine($"{nameof(FileUploader)}.{nameof(this.Upload)}: completed uploading a file.");
    }
}
