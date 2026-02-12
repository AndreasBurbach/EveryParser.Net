using System;
using Xunit;

namespace EveryParser.Test.ExpressionTest
{
    public class ExpressionApiTest
    {
        #region SetFormular

        [Fact]
        public void TestSetFormularNull()
        {
            var expr = new Expression();
            Assert.Throws<ArgumentNullException>(() => expr.SetFormular(null));
        }

        [Fact]
        public void TestSetFormularEmpty()
        {
            var expr = new Expression();
            Assert.Throws<ArgumentNullException>(() => expr.SetFormular(""));
        }

        [Fact]
        public void TestSetFormularWhitespace()
        {
            var expr = new Expression();
            Assert.Throws<ArgumentNullException>(() => expr.SetFormular("   "));
        }

        [Fact]
        public void TestSetFormularSameIgnored()
        {
            var expr = new Expression("1 + 1");
            expr.SetFormular("1 + 1"); // should not throw
            Assert.Equal(2, expr.CalculateDecimal());
        }

        [Fact]
        public void TestSetFormularChange()
        {
            var expr = new Expression("1 + 1");
            Assert.Equal(2, expr.CalculateDecimal());

            expr.SetFormular("2 + 2");
            Assert.Equal(4, expr.CalculateDecimal());
        }

        #endregion

        #region HasFormular

        [Fact]
        public void TestHasFormularFalse()
        {
            var expr = new Expression();
            Assert.False(expr.HasFormular());
        }

        [Fact]
        public void TestHasFormularTrue()
        {
            var expr = new Expression("1 + 1");
            Assert.True(expr.HasFormular());
        }

        #endregion

        #region CalculateWithoutFormular

        [Fact]
        public void TestCalculateWithoutFormular()
        {
            var expr = new Expression();
            Assert.Throws<ArgumentNullException>(() => expr.Calculate());
        }

        [Fact]
        public void TestCalculateBooleanWithoutFormular()
        {
            var expr = new Expression();
            Assert.Throws<ArgumentNullException>(() => expr.CalculateBoolean());
        }

        [Fact]
        public void TestCalculateDecimalWithoutFormular()
        {
            var expr = new Expression();
            Assert.Throws<ArgumentNullException>(() => expr.CalculateDecimal());
        }

        [Fact]
        public void TestCalculateStringWithoutFormular()
        {
            var expr = new Expression();
            Assert.Throws<ArgumentNullException>(() => expr.CalculateString());
        }

        [Fact]
        public void TestCalculateDateTimeWithoutFormular()
        {
            var expr = new Expression();
            Assert.Throws<ArgumentNullException>(() => expr.CalculateDateTime());
        }

        [Fact]
        public void TestCalculateArrayWithoutFormular()
        {
            var expr = new Expression();
            Assert.Throws<ArgumentNullException>(() => expr.CalculateArray());
        }

        #endregion

        #region Argument Management

        [Fact]
        public void TestRemoveArgument()
        {
            var expr = new Expression("variable1 + variable2");
            expr.AddArgument("variable1", 1);
            expr.AddArgument("variable2", 2);

            Assert.Equal(3, expr.CalculateDecimal());

            expr.RemoveArgument("variable1");

            expr.CalculateDecimal();
            Assert.True(expr.HasErrors);
        }

        [Fact]
        public void TestRemoveArgumentNull()
        {
            var expr = new Expression("1 + 1");
            Assert.Throws<ArgumentNullException>(() => expr.RemoveArgument(null));
        }

        [Fact]
        public void TestRemoveArgumentEmpty()
        {
            var expr = new Expression("1 + 1");
            Assert.Throws<ArgumentNullException>(() => expr.RemoveArgument(""));
        }

        [Fact]
        public void TestRemoveNonExistingArgument()
        {
            var expr = new Expression("1 + 1");
            expr.RemoveArgument("nonexist"); // should not throw
        }

        [Fact]
        public void TestClearArguments()
        {
            var expr = new Expression("variable1 + variable2");
            expr.AddArgument("variable1", 1);
            expr.AddArgument("variable2", 2);

            Assert.Equal(3, expr.CalculateDecimal());

            expr.ClearArguments();
            Assert.Empty(expr.GetAddedArguments());

            expr.CalculateDecimal();
            Assert.True(expr.HasErrors);
        }

        [Fact]
        public void TestGetAddedArguments()
        {
            var expr = new Expression("variable1 + variable2");
            expr.AddArgument("variable1", 1);
            expr.AddArgument("variable2", 2);

            var args = expr.GetAddedArguments();
            Assert.Equal(2, args.Length);
            Assert.Contains("variable1", args);
            Assert.Contains("variable2", args);
        }

        [Fact]
        public void TestGetAddedArgumentsEmpty()
        {
            var expr = new Expression("1 + 1");
            var args = expr.GetAddedArguments();
            Assert.Empty(args);
        }

        [Fact]
        public void TestAddArgumentOverwrite()
        {
            var expr = new Expression("variable1");
            expr.AddArgument("variable1", 1);
            Assert.Equal(1, expr.CalculateDecimal());

            expr.AddArgument("variable1", 42);
            Assert.Equal(42, expr.CalculateDecimal());
        }

        [Fact]
        public void TestAddArgumentNullName()
        {
            var expr = new Expression("1 + 1");
            Assert.Throws<ArgumentNullException>(() => expr.AddArgument(null, (object)1));
        }

        [Fact]
        public void TestAddArgumentEmptyName()
        {
            var expr = new Expression("1 + 1");
            Assert.Throws<ArgumentNullException>(() => expr.AddArgument("", (object)1));
        }

        [Fact]
        public void TestAddArgumentNullValue()
        {
            var expr = new Expression("1 + 1");
            Assert.Throws<ArgumentNullException>(() => expr.AddArgument("variable1", (object)null));
        }

        #endregion

        #region AddArgumentRange

        [Fact]
        public void TestAddArgumentRange()
        {
            var expr = new Expression("variable1 + variable2");
            expr.AddArgumentRange(new[] { "variable1", "variable2" }, new object[] { 1, 2 });
            Assert.Equal(3, expr.CalculateDecimal());
        }

        [Fact]
        public void TestAddArgumentRangeNullNames()
        {
            var expr = new Expression("1 + 1");
            Assert.Throws<ArgumentNullException>(() => expr.AddArgumentRange(null, new object[] { 1 }));
        }

        [Fact]
        public void TestAddArgumentRangeNullValues()
        {
            var expr = new Expression("1 + 1");
            Assert.Throws<ArgumentNullException>(() => expr.AddArgumentRange(new[] { "a" }, null));
        }

        [Fact]
        public void TestAddArgumentRangeDifferentLengths()
        {
            var expr = new Expression("1 + 1");
            Assert.Throws<ArgumentException>(() => expr.AddArgumentRange(new[] { "a", "b" }, new object[] { 1 }));
        }

        #endregion

        #region GetFormularArgumentNames

        [Fact]
        public void TestGetFormularArgumentNamesNoVariables()
        {
            var names = Expression.GetFormularArgumentNames("1 + 2");
            Assert.Empty(names);
        }

        [Fact]
        public void TestGetFormularArgumentNamesDuplicateVariables()
        {
            // Parser returns each occurrence, not deduplicated
            var names = Expression.GetFormularArgumentNames("x + x + x");
            Assert.Equal(3, names.Length);
            Assert.All(names, n => Assert.Equal("x", n));
        }

        [Fact]
        public void TestGetFormularArgumentNamesObjectVariable()
        {
            var names = Expression.GetFormularArgumentNames("obj.prop + obj.prop2");
            Assert.Equal(2, names.Length);
        }

        #endregion

        #region HasErrors & CalculationErrors

        [Fact]
        public void TestHasErrorsFalseAfterSuccess()
        {
            var expr = new Expression("1 + 1");
            expr.Calculate();
            Assert.False(expr.HasErrors);
        }

        [Fact]
        public void TestCalculationErrorsAfterSuccess()
        {
            var expr = new Expression("1 + 1");
            expr.Calculate();
            Assert.Empty(expr.CalculationErrors);
        }

        #endregion

        #region Static Methods

        [Fact]
        public void TestStaticCalculate()
        {
            var result = Expression.Calculate("1 + 2");
            Assert.NotNull(result);
        }

        [Fact]
        public void TestStaticCalculateString()
        {
            Assert.Equal("hello", Expression.CalculateString("\"hello\""));
        }

        [Fact]
        public void TestStaticCalculateBoolean()
        {
            Assert.Equal(true, Expression.CalculateBoolean("true"));
            Assert.Equal(false, Expression.CalculateBoolean("false"));
        }

        [Fact]
        public void TestStaticCalculateDateTime()
        {
            var result = Expression.CalculateDateTime("DateTime(2021,1,1)");
            Assert.NotNull(result);
            Assert.Equal(2021, result.Value.Year);
            Assert.Equal(1, result.Value.Month);
            Assert.Equal(1, result.Value.Day);
        }

        [Fact]
        public void TestStaticCalculateArray()
        {
            var result = Expression.CalculateArray("[1,2,3]");
            Assert.NotNull(result);
            Assert.Equal(3, result.Length);
        }

        #endregion

        #region Multiple Calculations Reuse

        [Fact]
        public void TestMultipleCalculationsOnSameExpression()
        {
            var expr = new Expression("variable1 + 1");
            expr.AddArgument("variable1", 1);
            Assert.Equal(2, expr.CalculateDecimal());

            expr.AddArgument("variable1", 10);
            Assert.Equal(11, expr.CalculateDecimal());

            expr.AddArgument("variable1", 100);
            Assert.Equal(101, expr.CalculateDecimal());
        }

        [Fact]
        public void TestCalculateAfterErrorAndRecovery()
        {
            var expr = new Expression("variable1 + 1");

            // Without argument → error
            expr.CalculateDecimal();
            Assert.True(expr.HasErrors);

            // Add argument → should work now
            expr.AddArgument("variable1", 5);
            Assert.Equal(6, expr.CalculateDecimal());
            Assert.False(expr.HasErrors);
        }

        #endregion

        #region GetPossibleResultingType

        [Fact]
        public void TestGetPossibleResultingTypeWithArguments()
        {
            var expr = new Expression("variable1 + variable2");
            expr.AddArgument("variable1", 1);
            expr.AddArgument("variable2", 2);

            var type = expr.GetPossibleResultingType();
            Assert.True(type >= 0);
        }

        #endregion
    }
}
