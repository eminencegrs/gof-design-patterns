using DesignPatterns.Visitor.Converters;
using DesignPatterns.Visitor.Models;

namespace DesignPatterns.Visitor;

public class Context
{
    public IVisitor<string, ISize> GetStringVisitor() => new StringVisitor();

    public IVisitor<ISize, ISize> GetSizeVisitor() => new SizeVisitor(
        new List<ISizeConverter<ISize>>
        {
            new KiloBytesToBytesConverter(),
            new MegaBytesToBytesConverter(),
            new GigaBytesToBytesConverter(),
            new TeraBytesToBytesConverter(),
            new PetaBytesToBytesConverter(),
        });

    public (ICollection<string> strings, ICollection<ISize> sizes) GetData()
    {
        var strings = GetStringData().ToList();
        var sizes = GetSizes().ToList();
        return (strings, sizes);
    }

    private static IEnumerable<string> GetStringData()
    {
        yield return "1KB";
        yield return "2 KB";
        yield return "4MB";
        yield return "8 MB";
        yield return "16GB";
        yield return "32 GB";
        yield return "64TB";
        yield return "128 TB";
        yield return "256PB";
        yield return "512 PB";
    }

    private static IEnumerable<ISize> GetSizes()
    {
        yield return new SizeInKiloBytes { Value = 1 };
        yield return new SizeInKiloBytes { Value = 2 };
        yield return new SizeInMegaBytes { Value = 4 };
        yield return new SizeInMegaBytes { Value = 8 };
        yield return new SizeInGigaBytes { Value = 16 };
        yield return new SizeInGigaBytes { Value = 32 };
        yield return new SizeInTeraBytes { Value = 64 };
        yield return new SizeInTeraBytes { Value = 128 };
        yield return new SizeInPetaBytes { Value = 256 };
        yield return new SizeInPetaBytes { Value = 512 };
    }
}
