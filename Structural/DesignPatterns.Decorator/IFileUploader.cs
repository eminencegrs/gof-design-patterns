namespace DesignPatterns.Decorator;

public interface IFileUploader
{
    Task Upload(string name, Stream stream);
}
