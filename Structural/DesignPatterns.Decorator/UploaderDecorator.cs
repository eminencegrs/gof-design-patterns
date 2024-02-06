namespace DesignPatterns.Decorator;

abstract class UploaderDecorator : IFileUploader
{
    private readonly IFileUploader uploader;

    public UploaderDecorator(IFileUploader uploader)
    {
        this.uploader = uploader;
    }

    public virtual Task Upload(string name, Stream stream)
    {
        return this.uploader.Upload(name, stream);
    }
}
