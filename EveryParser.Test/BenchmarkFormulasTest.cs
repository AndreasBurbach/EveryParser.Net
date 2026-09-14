using EveryParser.Benchmarks.Benchmarks;
using System.Linq;
using Xunit;

namespace EveryParser.Test
{
    public class BenchmarkFormulasTest
    {
        [Fact]
        public void TestParsingBenchmarkFormulasExecuteWithoutErrors()
        {
            var parsing = new ParsingBenchmarks();
            Assert.NotNull(parsing.ParseAndCalculate_Short());
            Assert.NotNull(parsing.ParseAndCalculate_Medium_Business());
            Assert.NotNull(parsing.ParseAndCalculate_Large_Scientific());
            
            Assert.NotNull(parsing.ParseAndCalculate_Huge_StressTest());
            Assert.NotNull(parsing.ParseAndCalculate_ChainedMath_50Terms());
            Assert.NotNull(parsing.ParseAndCalculate_Variables_Medium());
            Assert.NotNull(parsing.ParseAndCalculate_Variables_Huge());
        }

        [Fact]
        public void TestEvaluationBenchmarkFormulasExecuteWithoutErrors()
        {
            var eval = new EvaluationBenchmarks { Iterations = 2 };
            eval.Setup();
            Assert.NotNull(eval.RepeatedEvaluation_Simple());
            Assert.NotNull(eval.RepeatedEvaluation_Medium());
            Assert.NotNull(eval.RepeatedEvaluation_Huge());
        }

        [Fact]
        public void TestShortCircuitBenchmarkFormulasExecuteWithoutErrors()
        {
            var sc = new ShortCircuitBenchmarks();
            Assert.NotNull(sc.Condition_True_ExpensiveElseBranch());
            Assert.NotNull(sc.Condition_False_ExpensiveThenBranch());
            Assert.NotNull(sc.LogicAnd_FalseFirstOperand());
            Assert.NotNull(sc.LogicOr_TrueFirstOperand());
        }

        [Fact]
        public void TestArrayBenchmarkFormulasExecuteWithoutErrors()
        {
            var arr = new ArrayBenchmarks();
            Assert.NotNull(arr.Array_ScalarAddition());
            Assert.NotNull(arr.Array_ElementwiseMultiplication());
            Assert.NotNull(arr.Array_Concat());
            Assert.NotNull(arr.Array_StatisticMean());
        }

        [Fact]
        public void TestComparisonColdParsingBenchmarksExecuteWithoutErrors()
        {
            var cold = new ComparisonColdParsingBenchmarks();
            Assert.NotNull(cold.EveryParser_Simple());
            Assert.NotNull(cold.NCalc_Simple());
            Assert.NotNull(cold.Flee_Simple());
            Assert.NotNull(cold.DynamicExpresso_Simple());

            Assert.NotNull(cold.EveryParser_BusinessWithVariables());
            Assert.NotNull(cold.NCalc_BusinessWithVariables());
            Assert.NotNull(cold.Flee_BusinessWithVariables());
            Assert.NotNull(cold.DynamicExpresso_BusinessWithVariables());
        }

        [Fact]
        public void TestComparisonRepeatedEvaluationBenchmarksExecuteWithoutErrors()
        {
            var warm = new ComparisonRepeatedEvaluationBenchmarks { Iterations = 2 };
            warm.Setup();
            Assert.NotNull(warm.EveryParser_Repeated());
            Assert.NotNull(warm.NCalc_Repeated());
            Assert.True(warm.Flee_Repeated() != 0);
            Assert.True(warm.DynamicExpresso_Repeated() != 0);
        }
    }
}
