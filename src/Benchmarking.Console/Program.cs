using Banchmarking;
using Banchmarking.List;
using BenchmarkDotNet.Running;
using System;

namespace Benchmarking
{
    class Program
    {
        static void Main(string[] args)
        {
            //var summary = BenchmarkRunner.Run<NameParserBenchmarks>();
            var summary = BenchmarkRunner.Run<ListBenchMarkingCreating>();
        }
    }
}
