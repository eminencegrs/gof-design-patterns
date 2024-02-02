namespace DesignPatterns.AbstractFactory;

public class LocalStorage : IStorage
{
    public Task<IPath> CreateDirectory(string name)
    {
        throw new NotImplementedException();
    }

    public Task<IPath> CreateFile(string name)
    {
        throw new NotImplementedException();
    }
}
