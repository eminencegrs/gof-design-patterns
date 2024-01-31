namespace DesignPatterns.Visitor.Models;

public record class SizeInBytes : Size
{
    public override string Unit => "Bytes";
}
