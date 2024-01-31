namespace DesignPatterns.Visitor;

public interface ISize
{
    double Value { get; }
    string Unit { get; }
    ISize Accept(IVisitor<ISize, ISize> visitor);
}
