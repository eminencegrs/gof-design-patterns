using DesignPatterns.Visitor.Models;
using Shouldly;
using Xunit;

namespace DesignPatterns.Visitor.UnitTests;

public class StringVisitorTests
{
    [Theory]
    [InlineData("256KB", 256, typeof(SizeInKiloBytes))]
    [InlineData("512 KB", 512, typeof(SizeInKiloBytes))]
    [InlineData("256MB", 256, typeof(SizeInMegaBytes))]
    [InlineData("512 MB", 512, typeof(SizeInMegaBytes))]
    [InlineData("256GB", 256, typeof(SizeInGigaBytes))]
    [InlineData("512 GB", 512, typeof(SizeInGigaBytes))]
    [InlineData("256TB", 256, typeof(SizeInTeraBytes))]
    [InlineData("512 TB", 512, typeof(SizeInTeraBytes))]
    [InlineData("256PB", 256, typeof(SizeInPetaBytes))]
    [InlineData("512 PB", 512, typeof(SizeInPetaBytes))]
    public void GivenStringValue_WhenCallVisit_ThenResultAsExpected(string inputValue, long expectedValue, Type expectedType)
    {
        var stringVisitor = new StringVisitor();
        var result = stringVisitor.Visit(inputValue);
        result.ShouldBeOfType(expectedType);
        result.Value.ShouldBe(expectedValue);
    }

    [Fact]
    public void GivenNull_WhenCallVisit_ThenArgumentExceptionThrown()
    {
        var stringVisitor = new StringVisitor();
        var action = () => stringVisitor.Visit(null!);
        action.ShouldThrow<ArgumentException>();
    }

    [Theory]
    [InlineData("1ZB")]
    public void GivenInvalidValue_WhenCallVisit_ThenArgumentExceptionThrown(string value)
    {
        var stringVisitor = new StringVisitor();
        var action = () => stringVisitor.Visit(value);
        action
            .ShouldThrow<ArgumentException>()
            .Message.ShouldBe("Could not parse the provided value. (Parameter 'size')");
    }

    [Theory]
    [InlineData("1EB")]
    public void GivenUnknownSizeUnit_WhenCallVisit_ThenArgumentOutOfRangeExceptionThrown(string value)
    {
        var stringVisitor = new StringVisitor();
        var action = () => stringVisitor.Visit(value);
        action
            .ShouldThrow<ArgumentOutOfRangeException>()
            .Message.ShouldBe("Unknown size unit. (Parameter 'size')");
    }
}
