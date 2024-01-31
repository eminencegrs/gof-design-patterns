namespace DesignPatterns.Visitor.Models;

public record class SizeInTeraBytes : Size
{
    public override string Unit => "TB";
}
