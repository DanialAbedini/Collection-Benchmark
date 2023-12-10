using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Validators;

namespace Collection;

class CustomConfig : ManualConfig
{
    public CustomConfig()
    {
        AddJob(new Job());
        AddValidator(JitOptimizationsValidator.DontFailOnError);
        AddLogger(ConsoleLogger.Default);
        AddColumnProvider(DefaultColumnProviders.Instance);
    }
}
class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<CollectionBenchmark>(new CustomConfig());

    }
}
