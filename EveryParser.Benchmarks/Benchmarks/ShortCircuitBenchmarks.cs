using BenchmarkDotNet.Attributes;

namespace EveryParser.Benchmarks.Benchmarks;

[MemoryDiagnoser]
public class ShortCircuitBenchmarks
{
    private const string TernaryTrueExpensiveElse =
        "true ? 42 : (Sqrt(Pow(15.5, 2) + Pow(24.8, 2)) * Sin(45) + Exp(2) * Cos(5))";

    private const string TernaryFalseExpensiveThen =
        "false ? (Sqrt(Pow(15.5, 2) + Pow(24.8, 2)) * Sin(45) + Exp(2) * Cos(5)) : 42";

    private const string LogicAndFalseFirst =
        "false && (Sqrt(Pow(15.5, 2)) > 10)";

    private const string LogicOrTrueFirst =
        "true || (Sqrt(Pow(15.5, 2)) > 10)";

    [Benchmark(Baseline = true)]
    public object Condition_True_ExpensiveElseBranch()
    {
        return Expression.Calculate(TernaryTrueExpensiveElse);
    }

    [Benchmark]
    public object Condition_False_ExpensiveThenBranch()
    {
        return Expression.Calculate(TernaryFalseExpensiveThen);
    }

    [Benchmark]
    public object LogicAnd_FalseFirstOperand()
    {
        return Expression.Calculate(LogicAndFalseFirst);
    }

    [Benchmark]
    public object LogicOr_TrueFirstOperand()
    {
        return Expression.Calculate(LogicOrTrueFirst);
    }
}
