namespace DesignPatterns.Visitor.Models;

public record class SizeInGigaBytes : Size
{
    public override string Unit => "GB";
}
