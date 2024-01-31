namespace DesignPatterns.Visitor.Models;

public record class Size : ISize
{
    public double Value { get; init; }
    public virtual string Unit { get; init; }

    public ISize Accept(IVisitor<ISize, ISize> visitor)
    {
        return visitor.Visit(this);
    }
}