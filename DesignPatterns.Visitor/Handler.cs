namespace DesignPatterns.Visitor;

public class Handler(IEnumerable<IVisitor> visitors)
{
    public IEnumerable<ISize> Process(ICollection<ISize> sizes)
    {
        var result = new List<ISize>();
        foreach (var visitor in visitors)
        {
            result.AddRange(sizes.Select(size => size.Accept(visitor)));
        }

        return result;
    }
}
