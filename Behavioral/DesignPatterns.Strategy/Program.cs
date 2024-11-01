using BenchmarkDotNet.Running;
using DesignPatterns.Strategy;

var summary = BenchmarkRunner.Run<SortingBenchmark>();
