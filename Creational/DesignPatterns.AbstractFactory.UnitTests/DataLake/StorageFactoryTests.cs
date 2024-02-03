using Azure.Storage.Files.DataLake;
using DesignPatterns.AbstractFactory.DataLake;
using FluentAssertions;
using FluentAssertions.Execution;
using Moq;
using Xunit;

namespace DesignPatterns.AbstractFactory.UnitTests.DataLake;

public class StorageFactoryTests
{
    [Fact]
    public void Given_WhenCallCreate_ThenResultAsExpected()
    {
        var mockSettings = new Mock<StorageSettings>();
        var mockServiceClient = new Mock<DataLakeServiceClient>();
        var storageFactory = new StorageFactory(mockSettings.Object, mockServiceClient.Object);

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
