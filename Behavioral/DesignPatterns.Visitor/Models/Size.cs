namespace DesignPatterns.Visitor.Models;

public record class Size : ISize
{
    public long Value { get; init; }
    public virtual string Unit { get; init; }

    public ISize Accept(IVisitor<ISize, ISize> visitor)
    {
        return visitor.Visit(this);
    }

    public sealed override string ToString() => $"{this.Value.ToString()} {this.Unit}";
}
