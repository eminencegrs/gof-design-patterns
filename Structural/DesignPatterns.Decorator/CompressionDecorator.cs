using System.IO.Compression;

namespace DesignPatterns.Decorator;

internal class CompressionDecorator : UploaderDecorator
{
    public CompressionDecorator(IFileUploader uploader)
        : base(uploader)
    {
    }

    public override async Task Upload(string name, Stream stream)
    {
        using MemoryStream compressedStream = new MemoryStream();
        await using var compressor = new GZipStream(compressedStream, CompressionMode.Compress);
        await stream.CopyToAsync(compressor);
        await base.Upload(name, compressor.BaseStream);
    }
}
