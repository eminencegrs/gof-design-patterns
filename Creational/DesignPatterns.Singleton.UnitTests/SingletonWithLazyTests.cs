using Shouldly;
using Xunit;

namespace DesignPatterns.Singleton.UnitTests;

public class SingletonWithLazyTests
{
    [Fact]
    public void Given_WhenCreateSingletonWithLazy_ThenSameInstancesReturned()
    {
        var firstInstance = SingletonWithLazy.Instance;
        var secondInstance = SingletonWithLazy.Instance;

        firstInstance.ShouldBe(secondInstance);
    }
}
