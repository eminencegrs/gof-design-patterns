namespace DesignPatterns.Visitor;

public interface ISize
{
    long Value { get; }
    string Unit { get; }
    ISize Accept(IVisitor<ISize, ISize> visitor);
}
