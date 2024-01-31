using DesignPatterns.Visitor.Models;

namespace DesignPatterns.Visitor.Converters;

public class PetaBytesToBytesConverter : ISizeConverter<ISize>
{
    public ISize Convert(ISize size)
    {
        if (size is SizeInPetaBytes petaBytes)
        {
            return new SizeInBytes
            {
                Value = petaBytes.Value * 1024 * 1024 * 1024 * 1024 * 1024
            };
        }

        throw new InvalidOperationException("Could not convert PetaBytes to Bytes.");
    }

    public bool CanConvert(ISize size)
    {
        return size is SizeInPetaBytes;
    }
}
