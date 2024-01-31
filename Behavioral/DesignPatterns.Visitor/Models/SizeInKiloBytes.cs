namespace DesignPatterns.Visitor.Models;

public record class SizeInKiloBytes : Size
{
    public override string Unit => "KB";
}
