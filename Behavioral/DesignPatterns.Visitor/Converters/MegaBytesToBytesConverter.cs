using DesignPatterns.Visitor.Models;

namespace DesignPatterns.Visitor.Converters;

public class MegaBytesToBytesConverter : ISizeConverter<ISize>
{
    public ISize Convert(ISize size)
    {
        if (size is SizeInMegaBytes megaBytes)
        {
            return new SizeInBytes
            {
                Value = megaBytes.Value * 1024 * 1024
            };
        }

        throw new InvalidOperationException("Could not convert MegaBytes to Bytes.");
    }

    public bool CanConvert(ISize size)
    {
        return size is SizeInMegaBytes;
    }
}
