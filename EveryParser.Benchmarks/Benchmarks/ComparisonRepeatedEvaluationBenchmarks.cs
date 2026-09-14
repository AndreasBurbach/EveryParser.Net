using BenchmarkDotNet.Attributes;
using DynamicExpresso;
using Flee.PublicTypes;

namespace EveryParser.Benchmarks.Benchmarks;

[MemoryDiagnoser]
public class ComparisonRepeatedEvaluationBenchmarks
{
    private const string BusinessFormula = "(a * 1.19 + b * 0.07) * (1 - 0.15) / (quantity + 1)";

    [Params(100)]
    public int Iterations { get; set; }

    // EveryParser
    private EveryParser.Expression _everyParserExpr;

    // NCalc
    private NCalc.Expression _ncalcExpr;

    // Flee
    private ExpressionContext _fleeContext;
    private IGenericExpression<double> _fleeExpr;

    // DynamicExpresso
    private Func<double, double, double, double> _dynamicExpressoFunc;

    [GlobalSetup]
    public void Setup()
    {
        // Setup EveryParser
        _everyParserExpr = new EveryParser.Expression(BusinessFormula);
        _everyParserExpr.AddArgument("a", 100.0);
        _everyParserExpr.AddArgument("b", 45.20);
        _everyParserExpr.AddArgument("quantity", 3.0);

        // Setup NCalc
        _ncalcExpr = new NCalc.Expression(BusinessFormula);
        _ncalcExpr.Parameters["a"] = 100.0;
        _ncalcExpr.Parameters["b"] = 45.20;
        _ncalcExpr.Parameters["quantity"] = 3.0;

        // Setup Flee (Compiles to IL once)
        _fleeContext = new ExpressionContext();
        _fleeContext.Options.ParseCulture = System.Globalization.CultureInfo.InvariantCulture;
        _fleeContext.Variables["a"] = 100.0;
        _fleeContext.Variables["b"] = 45.20;
        _fleeContext.Variables["quantity"] = 3.0;
        _fleeExpr = _fleeContext.CompileGeneric<double>(BusinessFormula);

        // Setup DynamicExpresso (Compiles to Delegate via Expression Trees once)
        var interpreter = new Interpreter();
        _dynamicExpressoFunc = interpreter.ParseAsDelegate<Func<double, double, double, double>>(
            BusinessFormula, "a", "b", "quantity");
    }

    [Benchmark(Baseline = true)]
    public object EveryParser_Repeated()
    {
        object result = null;
        for (int i = 0; i < Iterations; i++)
        {
            _everyParserExpr.AddArgument("a", (double)i);
            result = _everyParserExpr.Calculate();
        }
        return result;
    }

    [Benchmark]
    public object NCalc_Repeated()
    {
        object result = null;
        for (int i = 0; i < Iterations; i++)
        {
            _ncalcExpr.Parameters["a"] = (double)i;
            result = _ncalcExpr.Evaluate();
        }
        return result;
    }

    [Benchmark]
    public double Flee_Repeated()
    {
        double result = 0;
        for (int i = 0; i < Iterations; i++)
        {
            _fleeContext.Variables["a"] = (double)i;
            result = _fleeExpr.Evaluate();
        }
        return result;
    }

    [Benchmark]
    public double DynamicExpresso_Repeated()
    {
        double result = 0;
        for (int i = 0; i < Iterations; i++)
        {
            result = _dynamicExpressoFunc((double)i, 45.20, 3.0);
        }
        return result;
    }
}
