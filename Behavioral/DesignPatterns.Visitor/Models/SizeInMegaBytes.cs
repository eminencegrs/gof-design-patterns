namespace DesignPatterns.Visitor.Models;

public record class SizeInMegaBytes : Size
{
    public override string Unit => "MB";
}
