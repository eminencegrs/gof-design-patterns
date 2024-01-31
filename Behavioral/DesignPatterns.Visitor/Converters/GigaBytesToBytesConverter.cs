using DesignPatterns.Visitor.Models;

namespace DesignPatterns.Visitor.Converters;

public class GigaBytesToBytesConverter : ISizeConverter<ISize>
{
    public ISize Convert(ISize size)
    {
        if (size is SizeInGigaBytes gigaBytes)
        {
            return new SizeInBytes
            {
                Value = gigaBytes.Value * 1024 * 1024 * 1024
            };
        }

        throw new InvalidOperationException("Could not convert GigaBytes to Bytes.");
    }

    public bool CanConvert(ISize size)
    {
        return size is SizeInGigaBytes;
    }
}
