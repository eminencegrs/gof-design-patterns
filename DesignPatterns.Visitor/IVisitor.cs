namespace DesignPatterns.Visitor;

public interface IVisitor
{
    ISize Visit(ISize size); 
}
