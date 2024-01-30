namespace DesignPatterns.Visitor;

public record class SizeInGB : ISize
{
    public double Value { get; init; }
    public string Unit => "GB";

    public ISize Accept(IVisitor visitor)
    {
        return visitor.Visit(this);
    }
}
