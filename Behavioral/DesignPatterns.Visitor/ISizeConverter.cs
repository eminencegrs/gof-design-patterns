namespace DesignPatterns.Visitor;

public interface ISizeConverter<in T> where T : ISize
{
    ISize Convert(T size);
    bool CanConvert(T size);
}
