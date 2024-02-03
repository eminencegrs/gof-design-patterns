namespace DesignPatterns.AbstractFactory.DataLake;

public class Directory : IPathInfo
{
    public string Name { get; init; }
    public string Path { get; init; }
    public string Uri { get; init; }
}
