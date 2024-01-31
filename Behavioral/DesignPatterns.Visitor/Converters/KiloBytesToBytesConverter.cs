using DesignPatterns.Visitor.Models;

namespace DesignPatterns.Visitor.Converters;

public class KiloBytesToBytesConverter : ISizeConverter<ISize>
{
    public ISize Convert(ISize size)
    {
        if (size is SizeInKiloBytes kiloBytes)
        {
            return new SizeInBytes
            {
                Value = kiloBytes.Value * 1024
            };
        }

        throw new InvalidOperationException("Could not convert KiloBytes to Bytes.");
    }

    public bool CanConvert(ISize size)
    {
        return size is SizeInKiloBytes;
    }
}
