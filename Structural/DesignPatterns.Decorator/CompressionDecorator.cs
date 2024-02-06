namespace DesignPatterns.Decorator;

internal class CompressionDecorator : UploaderDecorator
{
    public CompressionDecorator(IFileUploader uploader)
        : base(uploader)
    {
    }

    public override async Task Upload(string name, Stream stream)
    {
        // TODO: add compression logic here.
        Console.WriteLine($"{nameof(CompressionDecorator)}.{nameof(Upload)}: started compressing a file...");
        await Task.Delay(1000);
        Console.WriteLine($"{nameof(CompressionDecorator)}.{nameof(Upload)}: completed compressing a file.");
        await base.Upload(name, stream);
    }
}
