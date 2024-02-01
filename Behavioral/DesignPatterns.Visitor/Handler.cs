namespace DesignPatterns.Visitor;

public class Handler
{
    public IEnumerable<ISize> ProcessStrings(
        ICollection<string> sizes,
        IEnumerable<IVisitor<string, ISize>> visitors)
    {
        var result = new List<ISize>();
        foreach (var visitor in visitors)
        {
            result.AddRange(sizes.Select(x => x.Accept(visitor)));
        }

        return result;
    }

    public IEnumerable<ISize> ProcessSizes(
        ICollection<ISize> sizes,
        IEnumerable<IVisitor<ISize, ISize>> visitors)
    {
        var result = new List<ISize>();
        foreach (var visitor in visitors)
        {
            result.AddRange(sizes.Select(x => x.Accept(visitor)));
        }

        return result;
    }
}
