namespace DesignPatterns.Visitor;

public interface IVisitor<in TInput, out TResult>
{
    TResult Visit(TInput size); 
}
