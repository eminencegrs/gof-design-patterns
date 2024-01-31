namespace DesignPatterns.Visitor.Models;

public record class SizeInPetaBytes : Size
{
    public override string Unit => "PB";
}
