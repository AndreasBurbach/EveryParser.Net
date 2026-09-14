using BenchmarkDotNet.Attributes;

namespace EveryParser.Benchmarks.Benchmarks;

[MemoryDiagnoser]
public class EvaluationBenchmarks
{
    private Expression _simpleExpr;
    private Expression _mediumExpr;
    private Expression _hugeExpr;

    [Params(10, 100)]
    public int Iterations { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        _simpleExpr = new Expression("a * b + c");
        _simpleExpr.AddArgument("a", 10);
        _simpleExpr.AddArgument("b", 20);
        _simpleExpr.AddArgument("c", 30);

        _mediumExpr = new Expression("Round((a * 1.19 + b * 0.07) * (1 - discount) / (quantity + 1), 2)");
        _mediumExpr.AddArgument("a", 100.0);
        _mediumExpr.AddArgument("b", 50.0);
        _mediumExpr.AddArgument("discount", 0.1);
        _mediumExpr.AddArgument("quantity", 2);

        _hugeExpr = new Expression(
            "Sqrt(Pow(x, 2) + Pow(y, 2) + Pow(z, 2)) * Sin(45 * pi / 180) + Exp(-0.05 * t) * Cos(0.25 * t + 0.1) - (baseVal * Pow(1 + rate, periods) / (1 - Pow(1 + rate, -periods))) + (Max(val1, val2) * Min(val3, val4) / (Abs(delta) + 0.001)) + Round(Clamp(a, 0, 100) * 1.19, 2) - (Pow(k, 3) - 3 * Pow(k, 2) + 5 * k - 7) / (Pow(m, 2) + 1) + Log(scale * 10 + 1, 10)"
        );
        _hugeExpr.AddArgument("x", 12.5);
        _hugeExpr.AddArgument("y", 8.4);
        _hugeExpr.AddArgument("z", 3.1);
        _hugeExpr.AddArgument("t", 10.0);
        _hugeExpr.AddArgument("baseVal", 1500.0);
        _hugeExpr.AddArgument("rate", 0.05);
        _hugeExpr.AddArgument("periods", 12);
        _hugeExpr.AddArgument("val1", 120);
        _hugeExpr.AddArgument("val2", 85);
        _hugeExpr.AddArgument("val3", 45);
        _hugeExpr.AddArgument("val4", 90);
        _hugeExpr.AddArgument("delta", -5.4);
        _hugeExpr.AddArgument("a", 75);
        _hugeExpr.AddArgument("k", 4);
        _hugeExpr.AddArgument("m", 2);
        _hugeExpr.AddArgument("scale", 10.0);
    }

    [Benchmark(Baseline = true)]
    public object RepeatedEvaluation_Simple()
    {
        object result = null;
        for (int i = 0; i < Iterations; i++)
        {
            _simpleExpr.AddArgument("a", i);
            result = _simpleExpr.Calculate();
        }
        return result;
    }

    [Benchmark]
    public object RepeatedEvaluation_Medium()
    {
        object result = null;
        for (int i = 0; i < Iterations; i++)
        {
            _mediumExpr.AddArgument("a", (double)i);
            result = _mediumExpr.Calculate();
        }
        return result;
    }

    [Benchmark]
    public object RepeatedEvaluation_Huge()
    {
        object result = null;
        for (int i = 0; i < Iterations; i++)
        {
            _hugeExpr.AddArgument("a", i % 100);
            result = _hugeExpr.Calculate();
        }
        return result;
    }
}
