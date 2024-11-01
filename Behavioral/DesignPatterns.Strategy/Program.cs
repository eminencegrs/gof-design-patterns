using System.Diagnostics.CodeAnalysis;
using BenchmarkDotNet.Running;
using DesignPatterns.Strategy;

var summary = BenchmarkRunner.Run<SortingBenchmark>();

[ExcludeFromCodeCoverage]
public partial class Program { }
