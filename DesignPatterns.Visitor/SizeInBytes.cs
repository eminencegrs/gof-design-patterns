namespace DesignPatterns.Visitor;

public record class SizeInBytes : ISize
{
    public double Value { get; init; }
    public string Unit => "Bytes";

    public ISize Accept(IVisitor visitor)
    {
        return visitor.Visit(this);
    }
}
