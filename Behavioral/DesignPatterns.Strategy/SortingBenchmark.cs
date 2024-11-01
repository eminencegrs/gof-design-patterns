using System.Diagnostics.CodeAnalysis;
using BenchmarkDotNet.Attributes;

namespace DesignPatterns.Strategy;

[ExcludeFromCodeCoverage]
public class SortingBenchmark
{
    private readonly ISortingStrategy quickSortingStrategy = new QuickSortingStrategy();
    private readonly ISortingStrategy mergeSortingStrategy = new MergeSortingStrategy();

    private List<int>? unsortedList;
    private List<int>? sortedList;
    private List<int>? reverseSortedList;

    [GlobalSetup]
    public void Setup()
    {
        this.unsortedList = [34, 7, 23, 32, 5, 62, 12, 19, 4, 47];
        this.sortedList = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        this.reverseSortedList = [10, 9, 8, 7, 6, 5, 4, 3, 2, 1];
    }

    [Benchmark]
    public void QuickSortUnsortedBenchmark()
    {
        var list = new List<int>(this.unsortedList!);
        this.quickSortingStrategy.Sort(list);
    }

    [Benchmark]
    public void MergeSortUnsortedBenchmark()
    {
        var list = new List<int>(this.unsortedList!);
        this.mergeSortingStrategy.Sort(list);
    }

    [Benchmark]
    public void QuickSortSortedBenchmark()
    {
        var list = new List<int>(this.sortedList!);
        this.quickSortingStrategy.Sort(list);
    }

    [Benchmark]
    public void MergeSortSortedBenchmark()
    {
        var list = new List<int>(this.sortedList!);
        this.mergeSortingStrategy.Sort(list);
    }

    [Benchmark]
    public void QuickSortReverseSortedBenchmark()
    {
        var list = new List<int>(this.reverseSortedList!);
        this.quickSortingStrategy.Sort(list);
    }

    [Benchmark]
    public void MergeSortReverseSortedBenchmark()
    {
        var list = new List<int>(this.reverseSortedList!);
        this.mergeSortingStrategy.Sort(list);
    }
}
