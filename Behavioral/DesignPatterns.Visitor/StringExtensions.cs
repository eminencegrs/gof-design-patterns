namespace DesignPatterns.Visitor;

public static class StringExtensions
{
    public static ISize Accept(this string value, IVisitor<string, ISize> visitor)
    {
        return visitor.Visit(value);
    }
}
