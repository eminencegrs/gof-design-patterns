namespace DesignPatterns.Strategy;

public interface ISortingStrategy
{
    void Sort<T>(List<T> list) where T : IComparable<T>;
}
