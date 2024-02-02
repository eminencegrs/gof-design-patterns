namespace DesignPatterns.AbstractFactory;

public interface IStorage
{
    Task<IPath> CreateDirectory(string name);
    Task<IPath> CreateFile(string name);
}
