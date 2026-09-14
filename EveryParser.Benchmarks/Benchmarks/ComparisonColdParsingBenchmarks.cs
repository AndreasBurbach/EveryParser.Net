using BenchmarkDotNet.Attributes;
using DynamicExpresso;
using Flee.PublicTypes;

namespace EveryParser.Benchmarks.Benchmarks;

[MemoryDiagnoser]
public class ComparisonColdParsingBenchmarks
{
    private const string SimpleFormula = "1 + 2 * 3";

    private const string BusinessFormula = "(a * 1.19 + b * 0.07) * (1 - 0.15) / (quantity + 1)";

    // --- Simple Formula: 1 + 2 * 3 ---

    [Benchmark(Baseline = true)]
    public object EveryParser_Simple()
    {
        return EveryParser.Expression.Calculate(SimpleFormula);
    }

    [Benchmark]
    public object NCalc_Simple()
    {
        var expr = new NCalc.Expression(SimpleFormula);
        return expr.Evaluate();
    }

    [Benchmark]
    public object Flee_Simple()
    {
        var context = new ExpressionContext();
        var expr = context.CompileGeneric<double>(SimpleFormula);
        return expr.Evaluate();
    }

    [Benchmark]
    public object DynamicExpresso_Simple()
    {
        var interpreter = new Interpreter();
        return interpreter.Eval(SimpleFormula);
    }

    // --- Business Formula with Variables ---

    [Benchmark]
    public object EveryParser_BusinessWithVariables()
    {
        var expr = new EveryParser.Expression(BusinessFormula);
        expr.AddArgument("a", 124.50);
        expr.AddArgument("b", 45.20);
        expr.AddArgument("quantity", 3.0);
        return expr.Calculate();
    }

    [Benchmark]
    public object NCalc_BusinessWithVariables()
    {
        var expr = new NCalc.Expression(BusinessFormula);
        expr.Parameters["a"] = 124.50;
        expr.Parameters["b"] = 45.20;
        expr.Parameters["quantity"] = 3.0;
        return expr.Evaluate();
    }

    [Benchmark]
    public object Flee_BusinessWithVariables()
    {
        var context = new ExpressionContext();
        context.Options.ParseCulture = System.Globalization.CultureInfo.InvariantCulture;
        context.Variables["a"] = 124.50;
        context.Variables["b"] = 45.20;
        context.Variables["quantity"] = 3.0;
        var expr = context.CompileGeneric<double>(BusinessFormula);
        return expr.Evaluate();
    }

    [Benchmark]
    public object DynamicExpresso_BusinessWithVariables()
    {
        var interpreter = new Interpreter();
        return interpreter.Eval(BusinessFormula,
            new Parameter("a", 124.50),
            new Parameter("b", 45.20),
            new Parameter("quantity", 3.0));
    }
}
