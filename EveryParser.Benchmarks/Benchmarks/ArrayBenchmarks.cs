using BenchmarkDotNet.Attributes;

namespace EveryParser.Benchmarks.Benchmarks;

[MemoryDiagnoser]
public class ArrayBenchmarks
{
    private const string ArrayScalarAddition = "[1, 2, 3, 4, 5, 6, 7, 8, 9, 10] + 5";

    private const string ArrayElementwiseMultiplication =
        "[1, 2, 3, 4, 5, 6, 7, 8, 9, 10] * [10, 9, 8, 7, 6, 5, 4, 3, 2, 1]";

    private const string ArrayConcat =
        "Concat([1, 2, 3, 4, 5], [6, 7, 8, 9, 10])";

    private const string ArrayStatisticMean =
        "Mean([10, 25, 40, 55, 70, 85, 100, 115, 130, 145])";

    [Benchmark(Baseline = true)]
    public object Array_ScalarAddition()
    {
        return Expression.Calculate(ArrayScalarAddition);
    }

    [Benchmark]
    public object Array_ElementwiseMultiplication()
    {
        return Expression.Calculate(ArrayElementwiseMultiplication);
    }

    [Benchmark]
    public object Array_Concat()
    {
        return Expression.Calculate(ArrayConcat);
    }

    [Benchmark]
    public object Array_StatisticMean()
    {
        return Expression.Calculate(ArrayStatisticMean);
    }
}

