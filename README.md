# EveryParser.Net


[![Codacy Badge](https://app.codacy.com/project/badge/Grade/bf62aef3d51d4d56aaa4b4b28ee0b88e)](https://www.codacy.com/gh/AndreasBurbach/EveryParser.Net/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=AndreasBurbach/EveryParser.Net&amp;utm_campaign=Badge_Grade)

[![NuGet Badge](https://buildstats.info/nuget/EveryParser.Net)](https://www.nuget.org/packages/EveryParser.Net/)

## Description

This parser is for "everything in your life!" as you need inside your projects.
This parser is an easy to use expression parser library. It can not like the most parsers only calculate math, it can also calculate logical boolean expressions, working with strings calculation and date/time expressions.

This project repository is only for .Net-Core we are currently working on an integration for many other programming languages. It's planed for Java, Python, Typescript and Ruby.

## Installation Instructions

The recommended way to get **EveryParser.Net** is to use NuGet. The following packages are provided and maintained in the public .

## Usage

The know how to use, look at our [Wiki](https://github.com/AndreasBurbach/EveryParser.Net/wiki) of this project or the quick start below.
You can also check out the [tests](https://github.com/AndreasBurbach/EveryParser.Net/tree/main/EveryParser.Test/ExpressionTest) written for this project.

To create the C# classes from AntLR use the following command:
java -jar antlr-4.10.1-complete.jar -Dlanguage=CSharp EveryGrammar.g4 -o ".antlr" -package "EveryParser"

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
>```

Returns all errors you receive from the evaluation

## Contributing

We call it EveryParser and we mean it in all ways. If you think there is something missing or you need some more functions, let us know with an Issue or feel free to create a pull request.

## Thanks

Thanks to all contributors for this project. Also thanks to the team behind [ANTLR](https://github.com/antlr/antlr4), [Math.Net](https://github.com/mathnet/mathnet-numerics), [XUnit](https://github.com/xunit/xunit) and also [Microsoft .Net](https://github.com/dotnet/core).

## License

The project runs under the MIT License.
