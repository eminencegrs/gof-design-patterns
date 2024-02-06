namespace DesignPatterns.Decorator;

internal class EncryptionDecorator : UploaderDecorator
{
    public EncryptionDecorator(IFileUploader uploader)
        : base(uploader)
    {
    }

    public override async Task Upload(string name, Stream stream)
    {
        // TODO: add encryption logic here.
        Console.WriteLine($"{nameof(EncryptionDecorator)}.{nameof(Upload)}: started encrypting a file...");
        await Task.Delay(1000);
        Console.WriteLine($"{nameof(EncryptionDecorator)}.{nameof(Upload)}: completed encrypting a file.");
        await base.Upload(name, stream);
    }
}
