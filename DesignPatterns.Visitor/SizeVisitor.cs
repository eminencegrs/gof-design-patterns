namespace DesignPatterns.Visitor;

public class SizeVisitor : IVisitor
{
    public ISize Visit(ISize size)
    {
        return size switch
        {
            SizeInBytes bytes => ConvertToGb(bytes),
            SizeInGB gigaBytes => ConvertToBytes(gigaBytes),
            _ => throw new ArgumentOutOfRangeException(nameof(size), "Could not recognize a unit.")
        };
    }

    private static ISize ConvertToGb(SizeInBytes size)
    {
        var result = new SizeInGB
        {
            Value = size.Value / (1024 * 1024 * 1024.0)
        };

        return result;
    }

    private static ISize ConvertToBytes(SizeInGB size)
    {
        var result = new SizeInBytes
        {
            Value = size.Value * (1024 * 1024 * 1024.0)
        };

        return result;
    }
}
