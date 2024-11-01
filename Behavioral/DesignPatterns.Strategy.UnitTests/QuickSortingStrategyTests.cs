using Shouldly;
using Xunit;

namespace DesignPatterns.Strategy.UnitTests;

public class QuickSortingStrategyTests
{
    [Fact]
    public void GivenUnsortedNumbers_WhenSort_ThenResultAsExpected()
    {
        var unsortedList = new List<int> { 34, 7, 23, 32, 5, 62, 12, 19, 4, 47 };
        var strategy = new QuickSortingStrategy();
        strategy.Sort(unsortedList);
        unsortedList.ShouldBe([4, 5, 7, 12, 19, 23, 32, 34, 47, 62]);
    }

    [Fact]
    public void GivenSortedNumbers_WhenSort_ThenResultAsExpected()
    {
        var sortedList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var strategy = new QuickSortingStrategy();
        strategy.Sort(sortedList);
        sortedList.ShouldBe([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
    }

    [Fact]
    public void GivenReverseSortedNumbers_WhenSort_ThenResultAsExpected()
    {
        var reverseSortedList = new List<int> { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        var strategy = new QuickSortingStrategy();
        strategy.Sort(reverseSortedList);
        reverseSortedList.ShouldBe([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
    }

    [Fact]
    public void GivenNoNumbers_WhenSort_ThenResultAsExpected()
    {
        var emptyList = new List<int>();
        var strategy = new QuickSortingStrategy();
        strategy.Sort(emptyList);
        emptyList.ShouldBe(new List<int>());
    }
}
