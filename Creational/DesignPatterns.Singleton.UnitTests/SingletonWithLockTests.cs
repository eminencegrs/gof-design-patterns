using Shouldly;
using Xunit;

namespace DesignPatterns.Singleton.UnitTests;

public class SingletonWithLockTests
{
    [Fact]
    public void Given_WhenCreateSingletonWithLock_ThenSameInstancesReturned()
    {
        var firstInstance = SingletonWithLock.Instance;
        var secondInstance = SingletonWithLock.Instance;

        firstInstance.ShouldBe(secondInstance);
    }
}
