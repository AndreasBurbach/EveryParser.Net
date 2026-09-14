using BenchmarkDotNet.Attributes;
using System.Text;

namespace EveryParser.Benchmarks.Benchmarks;

[MemoryDiagnoser]
public class ParsingBenchmarks
{
    private const string ShortFormula = "1 + 2 * 3";

    private const string MediumBusinessFormula = "Round((124.50 * 1.19 + 45.20 * 0.07) * (1 - 0.15) / (3 + 1), 2)";

    private const string LargeScientificFormula =
        "Sqrt(Pow(15.5 - 3.2, 2) + Pow(24.8 - 6.1, 2) + Pow(8.4 - 1.2, 2)) * Sin(45) + Exp(-0.05 * 10) * Cos(0.25 * 10 + 0.1) - (1000 * Pow(1 + 0.05, 12))";

    private const string HugeStressFormula =
        "Sqrt(Pow(12.5, 2) + Pow(8.4, 2) + Pow(3.1, 2)) * Sin(45 * pi / 180) + Exp(-0.05 * 10) * Cos(0.25 * 10 + 0.1) - (1500 * Pow(1 + 0.05, 12) / (1 - Pow(1 + 0.05, -12))) + (Max(120, 85) * Min(45, 90) / (Abs(-5.4) + 0.001)) + Round(Clamp(75, 0, 100) * 1.19, 2) - (Pow(4, 3) - 3 * Pow(4, 2) + 5 * 4 - 7) / (Pow(2, 2) + 1) + Log(10 * 10 + 1, 10)";

    private static readonly string ChainedMath50TermsFormula = BuildChainedMathFormula(50);

    private const string MediumVariablesFormula = "Round((a * 1.19 + b * 0.07) * (1 - discount) / (quantity + 1), 2)";

    private const string HugeVariablesFormula =
        "Sqrt(Pow(x, 2) + Pow(y, 2) + Pow(z, 2)) * Sin(45 * pi / 180) + Exp(-0.05 * t) * Cos(0.25 * t + 0.1) - (baseVal * Pow(1 + rate, periods) / (1 - Pow(1 + rate, -periods))) + (Max(val1, val2) * Min(val3, val4) / (Abs(delta) + 0.001)) + Round(Clamp(a, 0, 100) * 1.19, 2) - (Pow(k, 3) - 3 * Pow(k, 2) + 5 * k - 7) / (Pow(m, 2) + 1) + Log(scale * 10 + 1, 10)";

    private static string BuildChainedMathFormula(int termCount)
    {
        var sb = new StringBuilder("1");
        for (int i = 1; i <= termCount; i++)
        {
            sb.Append($" + {i * 2} * {i * 2 + 1}");
        }
        return sb.ToString();
    }

    [Benchmark(Baseline = true)]
    public object ParseAndCalculate_Short()
    {
        return Expression.Calculate(ShortFormula);
    }

    [Benchmark]
    public object ParseAndCalculate_Medium_Business()
    {
        return Expression.Calculate(MediumBusinessFormula);
    }

    [Benchmark]
    public object ParseAndCalculate_Large_Scientific()
    {
        return Expression.Calculate(LargeScientificFormula);
    }

    [Benchmark]
    public object ParseAndCalculate_Huge_StressTest()
    {
        return Expression.Calculate(HugeStressFormula);
    }

    [Benchmark]
    public object ParseAndCalculate_ChainedMath_50Terms()
    {
        return Expression.Calculate(ChainedMath50TermsFormula);
    }

    [Benchmark]
    public object ParseAndCalculate_Variables_Medium()
    {
        var expr = new Expression(MediumVariablesFormula);
        expr.AddArgument("a", 124.50);
        expr.AddArgument("b", 45.20);
        expr.AddArgument("discount", 0.15);
        expr.AddArgument("quantity", 3);
        return expr.Calculate();
    }

    [Benchmark]
    public object ParseAndCalculate_Variables_Huge()
    {
        var expr = new Expression(HugeVariablesFormula);
        expr.AddArgument("x", 12.5);
        expr.AddArgument("y", 8.4);
        expr.AddArgument("z", 3.1);
        expr.AddArgument("t", 10.0);
        expr.AddArgument("baseVal", 1500.0);
        expr.AddArgument("rate", 0.05);
        expr.AddArgument("periods", 12);
        expr.AddArgument("val1", 120);
        expr.AddArgument("val2", 85);
        expr.AddArgument("val3", 45);
        expr.AddArgument("val4", 90);
        expr.AddArgument("delta", -5.4);
        expr.AddArgument("a", 75);
        expr.AddArgument("k", 4);
        expr.AddArgument("m", 2);
        expr.AddArgument("scale", 10.0);
        return expr.Calculate();
    }
}
