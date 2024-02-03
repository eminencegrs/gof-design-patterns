using DesignPatterns.AbstractFactory.Local;
using FluentAssertions;
using FluentAssertions.Execution;
using Moq;
using Xunit;

namespace DesignPatterns.AbstractFactory.UnitTests.Local;

public class StorageFactoryTests
{
    [Fact]
    public void Given_WhenCallCreate_ThenResultAsExpected()
    {
        var mockSettings = new Mock<StorageSettings>();
        var storageFactory = new StorageFactory(mockSettings.Object);

        IStorage? result = null;
        var action = () => result = storageFactory.Create();
        using (new AssertionScope())
        {
            action.Should().NotThrow();
            result.Should().NotBeNull();
            result.Should().BeOfType<Storage>();
        }
    }
}
