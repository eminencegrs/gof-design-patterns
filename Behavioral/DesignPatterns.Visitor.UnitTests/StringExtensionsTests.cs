using DesignPatterns.Visitor.Models;
using FluentAssertions;
using FluentAssertions.Execution;
using Moq;
using Shouldly;
using Xunit;

namespace DesignPatterns.Visitor.UnitTests;

public class StringExtensionsTests
{
    [Theory]
    [MemberData(nameof(TestCases))]
    public void GivenSize_WhenCallVisit_ThenResultAsExpected(
        string value, ISize expectedSizeInKiloBytes, ISize expectedSizeInBytes)
    {
        var visitorMock = new Mock<IVisitor<string, ISize>>();
        visitorMock.Setup(x => x.Visit(It.IsNotNull<string>())).Returns(expectedSizeInKiloBytes).Verifiable();

        ISize? actualResult = null;
        var action = () => actualResult = value.Accept(visitorMock.Object);

        using (new AssertionScope())
        {
            action.ShouldNotThrow();
            actualResult.ShouldBeEquivalentTo(expectedSizeInKiloBytes);
            visitorMock.Verify(x => x.Visit(value), Times.Once);
        }
    }

    public static IEnumerable<object[]> TestCases()
    {
        yield return [ "1KB", new SizeInKiloBytes { Value = 1 }, new SizeInBytes { Value = 102400 }];
    }
}
