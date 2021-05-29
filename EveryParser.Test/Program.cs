namespace EveryParser.Test
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var mathTest = new ExpressionTest.ExpressionMathTest();
            mathTest.DefaultTests();
            mathTest.FactorConstTest();
            mathTest.FactorTests();
            mathTest.FunctionTests();

            var mathArrayTest = new ExpressionTest.ExpressionMathArrayTest();
            mathArrayTest.MathArrayTests();
            mathArrayTest.MathStatisticsArrayTests();
        }
    }
}