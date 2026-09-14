# EveryParser.Net

[![NuGet Badge](https://img.shields.io/nuget/v/EveryParser.Net.svg)](https://www.nuget.org/packages/EveryParser.Net/)
[![.NET](https://github.com/AndreasBurbach/EveryParser.Net/actions/workflows/dotnet.yml/badge.svg)](https://github.com/AndreasBurbach/EveryParser.Net/actions/workflows/dotnet.yml)
[![CodeQL](https://github.com/AndreasBurbach/EveryParser.Net/actions/workflows/codeql-analysis.yml/badge.svg)](https://github.com/AndreasBurbach/EveryParser.Net/actions/workflows/codeql-analysis.yml)

## Description

This parser is for "everything in your life!" as you need inside your projects.
This parser is an easy to use expression parser library. It can not like the most parsers only calculate math, it can also calculate logical boolean expressions, working with strings calculation and date/time expressions.

This project repository is only for .Net-Core we are currently working on an integration for many other programming languages. It's planed for Java, Python, Typescript and Ruby.

## Installation Instructions

The recommended way to get **EveryParser.Net** is to use NuGet. The package is provided and maintained in the public [NuGet Gallery](https://www.nuget.org/packages/EveryParser.Net/).

```bash
dotnet add package EveryParser.Net
```

or with Visual Studio's Package Manager Console:

```powershell
Install-Package EveryParser.Net
```

## Usage

The know how to use, look at our [Wiki](https://github.com/AndreasBurbach/EveryParser.Net/wiki) of this project or the quick start below.
You can also check out the [tests](https://github.com/AndreasBurbach/EveryParser.Net/tree/main/EveryParser.Test/ExpressionTest) written for this project.

To create the C# classes from AntLR use the following command:
java -jar antlr-4.13.2-complete.jar -Dlanguage=CSharp -o EveryParser EveryGrammar.g4

### Quick Start

If you just want to evaluate with no thinking of own parameters or errors:

> ```csharp
> Expression.CalculateDecimal("IndexOf([1,2,3], 1)")
> ```

Results in => 0

If you have an expression with variables from outside the formular:

> ```csharp
> var expr = new Expression("variable1 + variable2");
> var arguments = expr.GetFormularArgumentNames();
> if (arguments.Any())
> {
>   expr.AddArgument("variable1", 1);
>   expr.AddArgument("variable2", 2);
> }
> expr.CalculateDecimal();
> ```

Results in => 3

If you want to check for errors from the evaluation of an expression:

> ```csharp
> var expr = new Expression("# + ! * testfunc(1)");
> expr.Calculate();
> if (expr.HasErrors)
>   for(int i = 0; i < expr.CalculationErrors.Length; ++i)
>     Console.WriteLine(expr.CalculationErrors[i].Item2);
> ```

Returns all errors you receive from the evaluation

## Performance & Benchmarks

EveryParser.Net includes an integrated benchmark suite powered by **BenchmarkDotNet** in the `EveryParser.Benchmarks` project.

### How to Run the Benchmarks

Always execute benchmarks in **Release mode**:

```bash
# Interactive menu (choose any benchmark):
dotnet run -c Release --project EveryParser.Benchmarks/EveryParser.Benchmarks.csproj

# Run formula parsing benchmarks (from simple to stress-test):
dotnet run -c Release --project EveryParser.Benchmarks/EveryParser.Benchmarks.csproj -- --filter "*ParsingBenchmarks*"

# Run repeated evaluation benchmarks:
dotnet run -c Release --project EveryParser.Benchmarks/EveryParser.Benchmarks.csproj -- --filter "*EvaluationBenchmarks*"

# Run competitive comparison benchmarks (EveryParser vs. NCalc, Flee, DynamicExpresso):
dotnet run -c Release --project EveryParser.Benchmarks/EveryParser.Benchmarks.csproj -- --filter "*Comparison*"

# Quick run (fewer warmup/target iterations):
dotnet run -c Release --project EveryParser.Benchmarks/EveryParser.Benchmarks.csproj -- --filter "*ComparisonRepeated*" --job short
```

Reports are automatically generated and saved in:
- **HTML:** `BenchmarkDotNet.Artifacts/results/*-report.html` (visual report with formatting)
- **Markdown:** `BenchmarkDotNet.Artifacts/results/*-report-github.md` (summary tables)
- **CSV:** `BenchmarkDotNet.Artifacts/results/*-report.csv` (raw data)

---

### Current Status & Baseline (v1.2.0)

EveryParser currently utilizes an event-driven ANTLR4 `ParseTreeWalker` with an intermediate DOM tree (`NodeCalculator`). For repeated calculations, formulas are currently re-parsed on each execution.

#### 1. Internal Formula Baseline (Cold Parsing & Evaluation)

| Formula Complexity | Sample Expression | Mean Latency | Gen 0 / 1k Ops | Allocated Memory |
|---|---|---:|---:|---:|
| **Short** | `1 + 2 * 3` | **21.68 µs** | 1.068 | **13.41 KB** |
| **Huge / Stress-Test** | Multi-term math with `Pow`, `Sin`, `Clamp`, polynomials (~360 chars) | **629.93 µs** | 22.461 | **276.05 KB** |

#### 2. Competitive Comparison (100 Repeated Evaluations with Variables)
Formula: `"(a * 1.19 + b * 0.07) * (1 - 0.15) / (quantity + 1)"`

| Engine | Execution Strategy | Mean Time (100 Ops) | Allocated Memory | Speedup vs EveryParser |
|---|---|---:|---:|---:|
| **EveryParser.Net** | ANTLR4 Listener (Current) | **9.06 ms** | **4,162 KB (~4.16 MB)** | **1.0x (Baseline)** |
| **NCalc** (v7.2) | ANTLR4 + AST-Cache | **34.22 µs** | **141.6 KB** | **~265x faster** |
| **Flee** (v2.0) | IL-JIT Compiled (`Reflection.Emit`) | **3.11 µs** | **2.4 KB** | **~2,900x faster** |
| **DynamicExpresso** (v2.19) | .NET Expression Tree (`.Compile()`) | **90.85 ns** | **0 B (Zero Allocation)** | **~100,000x faster** |

## Contributing

We call it EveryParser and we mean it in all ways. If you think there is something missing or you need some more functions, let us know with an Issue or feel free to create a pull request.

## Thanks

Thanks to all contributors for this project. Also thanks to the teams behind [ANTLR](https://github.com/antlr/antlr4), [Math.Net](https://github.com/mathnet/mathnet-numerics), [XUnit](https://github.com/xunit/xunit) and also [Microsoft .Net](https://github.com/dotnet/core).

## License

The project runs under the MIT License.
