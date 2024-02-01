using DesignPatterns.Visitor.Converters;
using DesignPatterns.Visitor.Models;
using Shouldly;
using Xunit;

namespace DesignPatterns.Visitor.UnitTests;

public class SizeVisitorTests
{
    [Fact]
    public void GivenSize_WhenCallVisit_ThenInvalidOperationExceptionThrown()
    {
        var sizeVisitor = new SizeVisitor(Enumerable.Empty<ISizeConverter<ISize>>());
        var action = () => sizeVisitor.Visit(default);
        action.ShouldThrow<InvalidOperationException>();
    }

    [Theory]
    [MemberData(nameof(TestCases))]
    public void GivenSize_WhenCallVisit_ThenResultAsExpected(ISize size, ISize expectedResult)
    {
        var sizeVisitor = this.GetSut();
        var actualResult = sizeVisitor.Visit(size);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }

    private IVisitor<ISize, ISize> GetSut() =>
        new SizeVisitor([
            new KiloBytesToBytesConverter(),
            new MegaBytesToBytesConverter(),
            new GigaBytesToBytesConverter(),
            new TeraBytesToBytesConverter(),
            new PetaBytesToBytesConverter()
        ]);

    public static IEnumerable<object[]> TestCases()
    {
        yield return [new SizeInKiloBytes { Value = 100 }, new SizeInBytes { Value = 102400 }];
        yield return [new SizeInMegaBytes { Value = 200 }, new SizeInBytes { Value = 209715200 }];
        yield return [new SizeInGigaBytes { Value = 300 }, new SizeInBytes { Value = 322122547200 }];
        yield return [new SizeInTeraBytes { Value = 400 }, new SizeInBytes { Value = 439804651110400 }];
        yield return [new SizeInPetaBytes { Value = 500 }, new SizeInBytes { Value = 562949953421312000 }];
    }
}
