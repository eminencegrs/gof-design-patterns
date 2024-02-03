namespace DesignPatterns.AbstractFactory;

public interface IStorage
{
    Task<IPathInfo> CreateDirectory(string name);
    Task<IPathInfo> CreateFile(string name);
}
