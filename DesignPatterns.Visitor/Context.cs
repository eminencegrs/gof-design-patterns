using AutoFixture;

namespace DesignPatterns.Visitor;

public class Context
{
    private readonly IFixture fixture = new Fixture();
    private readonly Random random = new Random();

    public (ICollection<ISize> itemsInBytes, ICollection<ISize> itemsInGB) GetData()
    {
        var inBytes = GetSizesInBytes().ToList();
        var inGB = GetSizesInGB().ToList();
        return (inBytes, inGB);
    }

    private static IEnumerable<ISize> GetSizesInBytes()
    {
        yield return new SizeInBytes { Value = 1073741824 };
        yield return new SizeInBytes { Value = 2147483648 };
        yield return new SizeInBytes { Value = 3221225472 };
    }

    private static IEnumerable<ISize> GetSizesInGB()
    {
        yield return new SizeInGB { Value = 10 };
        yield return new SizeInGB { Value = 20 };
        yield return new SizeInGB { Value = 30 };
    }
}
