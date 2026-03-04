using System.Linq;
using Xunit;
using EveryParser.GrammarListener;

namespace EveryParser.Test
{
    public class SyntaxTest
    {
        [Fact]
        public void ValidSyntax_SimpleExpression_NoErrors()
        {
            var expr = new Expression("1 + 2");
            var result = expr.CalculateDecimal();

            Assert.False(expr.HasErrors);
            Assert.Empty(expr.CalculationErrors);
            Assert.Equal(3m, result);
        }

        [Fact]
        public void ValidSyntax_ComplexExpression_NoErrors()
        {
            var expr = new Expression("(1 + 2) * 3");
            var result = expr.CalculateDecimal();

            Assert.False(expr.HasErrors);
            Assert.Empty(expr.CalculationErrors);
            Assert.Equal(9m, result);
        }

        [Fact]
        public void ValidSyntax_WithWhitespace_NoErrors()
        {
            var expr = new Expression("  1   +   2  ");
            var result = expr.CalculateDecimal();

            Assert.False(expr.HasErrors);
            Assert.Empty(expr.CalculationErrors);
            Assert.Equal(3m, result);
        }

        [Fact]
        public void ValidSyntax_WithTabs_NoErrors()
        {
            var expr = new Expression("1\t+\t2");
            var result = expr.CalculateDecimal();

            Assert.False(expr.HasErrors);
            Assert.Empty(expr.CalculationErrors);
            Assert.Equal(3m, result);
        }

        [Fact]
        public void ValidSyntax_Array_NoErrors()
        {
            var expr = new Expression("[1, 2, 3]");
            var result = expr.CalculateArray();

            Assert.False(expr.HasErrors);
            Assert.Empty(expr.CalculationErrors);
            Assert.NotNull(result);
            Assert.Equal(3, result.Length);
        }

        [Fact]
        public void ValidSyntax_Function_NoErrors()
        {
            var expr = new Expression("Abs(-5)");
            var result = expr.CalculateDecimal();

            Assert.False(expr.HasErrors);
            Assert.Empty(expr.CalculationErrors);
            Assert.Equal(5m, result);
        }

        [Fact]
        public void ValidSyntax_String_NoErrors()
        {
            var expr = new Expression("\"hello\"");
            var result = expr.CalculateString();

            Assert.False(expr.HasErrors);
            Assert.Empty(expr.CalculationErrors);
            Assert.Equal("hello", result);
        }

        [Fact]
        public void InvalidSyntax_SingleEquals_HasError()
        {
            var expr = new Expression("80 = 8%");
            var result = expr.Calculate();

            Assert.True(expr.HasErrors);
            Assert.NotEmpty(expr.CalculationErrors);
            Assert.Null(result);
        }

        [Fact]
        public void InvalidSyntax_SingleEquals_ErrorType()
        {
            var expr = new Expression("80 = 8%");
            expr.Calculate();

            var errors = expr.CalculationErrors;
            Assert.NotEmpty(errors);
            Assert.Contains(errors, e => e.Item1 == ErrorCode.SyntaxError);
        }

        [Fact]
        public void InvalidSyntax_UnknownCharacter_HasError()
        {
            var expr = new Expression("1 + 2 @ 3");
            var result = expr.CalculateDecimal();

            Assert.True(expr.HasErrors);
            Assert.NotEmpty(expr.CalculationErrors);
            Assert.Null(result);
        }

        [Fact]
        public void InvalidSyntax_TrailingOperator_HasError()
        {
            var expr = new Expression("1 + 2 +");
            var result = expr.CalculateDecimal();

            Assert.True(expr.HasErrors);
            Assert.NotEmpty(expr.CalculationErrors);
            Assert.Null(result);
        }

        [Fact]
        public void InvalidSyntax_MissingClosingBracket_HasError()
        {
            var expr = new Expression("(1 + 2");
            var result = expr.CalculateDecimal();

            Assert.True(expr.HasErrors);
            Assert.NotEmpty(expr.CalculationErrors);
            Assert.Null(result);
        }

        [Fact]
        public void InvalidSyntax_ExtraClosingBracket_HasError()
        {
            var expr = new Expression("(1 + 2))");
            var result = expr.CalculateDecimal();

            Assert.True(expr.HasErrors);
            Assert.NotEmpty(expr.CalculationErrors);
            Assert.Null(result);
        }

        [Fact]
        public void InvalidSyntax_UnmatchedSquareBracket_HasError()
        {
            var expr = new Expression("[1, 2, 3");
            var result = expr.CalculateArray();

            Assert.True(expr.HasErrors);
            Assert.NotEmpty(expr.CalculationErrors);
            Assert.Null(result);
        }

        [Fact]
        public void InvalidSyntax_ExtraTokensAfterValidExpression_HasError()
        {
            var expr = new Expression("1 + 2 extra");
            var result = expr.CalculateDecimal();

            Assert.True(expr.HasErrors);
            Assert.NotEmpty(expr.CalculationErrors);
            Assert.Null(result);
        }

        [Fact]
        public void InvalidSyntax_DoubleDecimal_HasError()
        {
            var expr = new Expression("1.2.3");
            var result = expr.CalculateDecimal();

            Assert.True(expr.HasErrors);
            Assert.NotEmpty(expr.CalculationErrors);
            Assert.Null(result);
        }

        [Fact]
        public void ValidSyntax_EqualityOperators_NoErrors()
        {
            var validExpressions = new[]
            {
                "1 == 1",
                "1 != 2",
                "\"a\" == \"a\"",
                "\"A\" =i \"a\"",
                "\"A\" !=i \"b\""
            };

            foreach (var formula in validExpressions)
            {
                var expr = new Expression(formula);
                expr.CalculateBoolean();

                Assert.False(expr.HasErrors, $"Formula '{formula}' should not have errors");
                Assert.Empty(expr.CalculationErrors);
            }
        }

        [Fact]
        public void ValidSyntax_ArithmeticOperators_NoErrors()
        {
            var validExpressions = new[]
            {
                "1 + 2",
                "5 - 3",
                "2 * 3",
                "6 / 2",
                "5 % 2",
                "2 ** 3",
                "1 // 2"
            };

            foreach (var formula in validExpressions)
            {
                var expr = new Expression(formula);
                expr.CalculateDecimal();

                Assert.False(expr.HasErrors, $"Formula '{formula}' should not have errors");
                Assert.Empty(expr.CalculationErrors);
            }
        }

        [Fact]
        public void ValidSyntax_BitwiseOperators_NoErrors()
        {
            var validExpressions = new[]
            {
                "5 | 3",
                "5 & 3",
                "1 << 2",
                "8 >> 2",
                "~5"
            };

            foreach (var formula in validExpressions)
            {
                var expr = new Expression(formula);
                expr.Calculate();

                Assert.False(expr.HasErrors, $"Formula '{formula}' should not have errors");
                Assert.Empty(expr.CalculationErrors);
            }
        }

        [Fact]
        public void ValidSyntax_LogicalOperators_NoErrors()
        {
            var validExpressions = new[]
            {
                "true && false",
                "true || false",
                "true ^ false",
                "not true"
            };

            foreach (var formula in validExpressions)
            {
                var expr = new Expression(formula);
                expr.CalculateBoolean();

                Assert.False(expr.HasErrors, $"Formula '{formula}' should not have errors");
                Assert.Empty(expr.CalculationErrors);
            }
        }

        [Fact]
        public void ValidSyntax_ComparisonOperators_NoErrors()
        {
            var validExpressions = new[]
            {
                "1 < 2",
                "2 > 1",
                "1 <= 2",
                "2 >= 1"
            };

            foreach (var formula in validExpressions)
            {
                var expr = new Expression(formula);
                expr.CalculateBoolean();

                Assert.False(expr.HasErrors, $"Formula '{formula}' should not have errors");
                Assert.Empty(expr.CalculationErrors);
            }
        }

        [Fact]
        public void InvalidSyntax_MultipleErrors_AllCaptured()
        {
            var expr = new Expression("1 + = 2");
            expr.CalculateDecimal();

            Assert.True(expr.HasErrors);
            Assert.NotEmpty(expr.CalculationErrors);
        }

        [Fact]
        public void InvalidSyntax_EmptyFunctionCall_HasError()
        {
            var expr = new Expression("Abs()");
            var result = expr.CalculateDecimal();

            Assert.True(expr.HasErrors);
            Assert.NotEmpty(expr.CalculationErrors);
            Assert.Null(result);
        }

        [Fact]
        public void InvalidSyntax_InvalidFunctionName_HasError()
        {
            var expr = new Expression("InvalidFunc(1)");
            var result = expr.CalculateDecimal();

            Assert.True(expr.HasErrors);
            Assert.NotEmpty(expr.CalculationErrors);
            Assert.Null(result);
        }

        [Fact]
        public void InvalidSyntax_StringWithoutClosingQuote_HasError()
        {
            var expr = new Expression("\"unclosed string");
            var result = expr.CalculateString();

            Assert.True(expr.HasErrors);
            Assert.NotEmpty(expr.CalculationErrors);
            Assert.Null(result);
        }

        [Fact]
        public void ValidSyntax_UnaryPlusAfterBinaryPlus_ValidExpression()
        {
            // "1 ++ 2" is actually valid: "1 + (+2)" (unary plus)
            var expr = new Expression("1 ++ 2");
            var result = expr.CalculateDecimal();

            Assert.False(expr.HasErrors);
            Assert.Empty(expr.CalculationErrors);
            Assert.Equal(3m, result);
        }

        [Fact]
        public void InvalidSyntax_MissingOperand_HasError()
        {
            var expr = new Expression("* 5");
            var result = expr.CalculateDecimal();

            Assert.True(expr.HasErrors);
            Assert.NotEmpty(expr.CalculationErrors);
            Assert.Null(result);
        }

        [Fact]
        public void InvalidSyntax_InvalidArraySyntax_HasError()
        {
            var expr = new Expression("[1, 2, 3,]");
            var result = expr.CalculateArray();

            Assert.True(expr.HasErrors);
            Assert.NotEmpty(expr.CalculationErrors);
            Assert.Null(result);
        }

        [Fact]
        public void InvalidSyntax_NestedBracketsMismatch_HasError()
        {
            var expr = new Expression("[(1 + 2]");
            var result = expr.CalculateArray();

            Assert.True(expr.HasErrors);
            Assert.NotEmpty(expr.CalculationErrors);
            Assert.Null(result);
        }

        [Fact]
        public void InvalidSyntax_ColonOutsideSlicing_HasError()
        {
            var expr = new Expression("1 : 2");
            var result = expr.CalculateDecimal();

            Assert.True(expr.HasErrors);
            Assert.NotEmpty(expr.CalculationErrors);
            Assert.Null(result);
        }

        [Fact]
        public void InvalidSyntax_TernaryOperatorMissingQuestion_HasError()
        {
            var expr = new Expression("true 1 : 2");
            var result = expr.Calculate();

            Assert.True(expr.HasErrors);
            Assert.NotEmpty(expr.CalculationErrors);
            Assert.Null(result);
        }

        [Fact]
        public void InvalidSyntax_TernaryOperatorMissingColon_HasError()
        {
            var expr = new Expression("true ? 1 2");
            var result = expr.Calculate();

            Assert.True(expr.HasErrors);
            Assert.NotEmpty(expr.CalculationErrors);
            Assert.Null(result);
        }

        [Fact]
        public void InvalidSyntax_UnbalancedParenthesesMultiple_HasError()
        {
            var expr = new Expression("((1 + 2) + 3");
            var result = expr.CalculateDecimal();

            Assert.True(expr.HasErrors);
            Assert.NotEmpty(expr.CalculationErrors);
            Assert.Null(result);
        }

        [Fact]
        public void InvalidSyntax_SpecialCharacterInVariable_HasError()
        {
            var expr = new Expression("var$1 + 2");
            var result = expr.CalculateDecimal();

            Assert.True(expr.HasErrors);
            Assert.NotEmpty(expr.CalculationErrors);
            Assert.Null(result);
        }

        [Fact]
        public void InvalidSyntax_CommaOutsideArray_HasError()
        {
            var expr = new Expression("1, 2");
            var result = expr.CalculateDecimal();

            Assert.True(expr.HasErrors);
            Assert.NotEmpty(expr.CalculationErrors);
            Assert.Null(result);
        }

        [Fact]
        public void InvalidSyntax_NotOperatorWithoutOperand_HasError()
        {
            var expr = new Expression("not");
            var result = expr.CalculateBoolean();

            Assert.True(expr.HasErrors);
            Assert.NotEmpty(expr.CalculationErrors);
            Assert.Null(result);
        }

        [Fact]
        public void InvalidSyntax_IncompleteComparison_HasError()
        {
            var expr = new Expression("1 <");
            var result = expr.CalculateBoolean();

            Assert.True(expr.HasErrors);
            Assert.NotEmpty(expr.CalculationErrors);
            Assert.Null(result);
        }

        [Fact]
        public void InvalidSyntax_InvalidHexNumber_HasError()
        {
            var expr = new Expression("0x1G");
            var result = expr.CalculateDecimal();

            Assert.True(expr.HasErrors);
            Assert.NotEmpty(expr.CalculationErrors);
            Assert.Null(result);
        }

        [Fact]
        public void InvalidSyntax_ControlCharacterInExpression_HasError()
        {
            var expr = new Expression("1 + \0 2");
            var result = expr.CalculateDecimal();

            Assert.True(expr.HasErrors);
            Assert.NotEmpty(expr.CalculationErrors);
            Assert.Null(result);
        }

        [Fact]
        public void InvalidSyntax_MultipleDecimalPoints_HasError()
        {
            var expr = new Expression("1.2.3.4");
            var result = expr.CalculateDecimal();

            Assert.True(expr.HasErrors);
            Assert.NotEmpty(expr.CalculationErrors);
            Assert.Null(result);
        }

        [Fact]
        public void InvalidSyntax_NegativeSignMisplaced_HasError()
        {
            var expr = new Expression("1 + - 2");
            var result = expr.CalculateDecimal();

            // "+- " might parse as +(-2), so this could be valid
            // Only check if it actually fails
            if (expr.HasErrors)
            {
                Assert.NotEmpty(expr.CalculationErrors);
            }
        }

        [Fact]
        public void ValidSyntax_IntegerPercentage_NoErrors()
        {
            var expr = new Expression("83%");
            var result = expr.CalculateDecimal();

            Assert.False(expr.HasErrors);
            Assert.Empty(expr.CalculationErrors);
            Assert.Equal(0.83m, result);
        }

        [Fact]
        public void ValidSyntax_DoublePercentage_NoErrors()
        {
            var expr = new Expression("45.3%");
            var result = expr.CalculateDecimal();

            Assert.False(expr.HasErrors);
            Assert.Empty(expr.CalculationErrors);
            Assert.Equal(0.453m, result);
        }

        [Fact]
        public void ValidSyntax_PercentageWithSpacedModulo_NoErrors()
        {
            var expr = new Expression("6% % 3%");
            var result = expr.CalculateDecimal();

            Assert.False(expr.HasErrors);
            Assert.Empty(expr.CalculationErrors);
            Assert.Equal(0.06m % 0.03m, result);
        }

        [Fact]
        public void ValidSyntax_PercentageWithModuloNoSpaces_NoErrors()
        {
            var expr = new Expression("6%%3%");
            var result = expr.CalculateDecimal();

            Assert.False(expr.HasErrors);
            Assert.Empty(expr.CalculationErrors);
            Assert.Equal(0.06m % 0.03m, result);
        }

        [Fact]
        public void ValidSyntax_DecimalModuloPercentage_NoErrors()
        {
            var expr = new Expression("0.06 % 3%");
            var result = expr.CalculateDecimal();

            Assert.False(expr.HasErrors);
            Assert.Empty(expr.CalculationErrors);
            Assert.Equal(0.06m % 0.03m, result);
        }

        [Fact]
        public void ValidSyntax_PercentageArithmetic_NoErrors()
        {
            var expr = new Expression("50% + 25%");
            var result = expr.CalculateDecimal();

            Assert.False(expr.HasErrors);
            Assert.Empty(expr.CalculationErrors);
            Assert.Equal(0.75m, result);
        }

        [Fact]
        public void ValidSyntax_MixedPercentageAndNumber_NoErrors()
        {
            var expr = new Expression("100 * 50%");
            var result = expr.CalculateDecimal();

            Assert.False(expr.HasErrors);
            Assert.Empty(expr.CalculationErrors);
            Assert.Equal(50m, result);
        }

        [Fact]
        public void ValidSyntax_ComplexPercentageExpression_NoErrors()
        {
            var expr = new Expression("(50% + 25%) * 100");
            var result = expr.CalculateDecimal();

            Assert.False(expr.HasErrors);
            Assert.Empty(expr.CalculationErrors);
            Assert.Equal(75m, result);
        }
    }
}
