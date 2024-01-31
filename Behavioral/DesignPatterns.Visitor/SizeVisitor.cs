namespace DesignPatterns.Visitor;

public class SizeVisitor : IVisitor<ISize, ISize>
{
    private readonly IEnumerable<ISizeConverter<ISize>> converters;

    public SizeVisitor(IEnumerable<ISizeConverter<ISize>> converters)
    {
        this.converters = converters;
    }

    public ISize Visit(ISize size)
    {
        var converter = this.converters.FirstOrDefault(x => x.CanConvert(size));
        return converter is null
            ? throw new InvalidOperationException("Could not find a proper converter.")
            : converter.Convert(size);
    }
}
