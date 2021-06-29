using Antlr4.Runtime;
using System.Collections.Generic;
using System.Linq;

namespace EveryParser.GrammarListener.TypeListener
{
    public partial class EveryGrammarTypeListener
    {
        private void CheckNumberOrArrayOfNumbersUnary(ParserRuleContext context)
        {
            if (!ErrorCollector.CheckParamsCount(context, 1, Node.Children))
            {
                Node = Node.Parent;
                return;
            }

            var parameterType = Node.Children[0].ValueType;

            if (parameterType.IsNumber())
                Node.ValueType = EveryParserType.Number;
            if (parameterType.IsNumberArray())
                Node.ValueType = EveryParserType.ArrayOfNumber;
            if (parameterType.IsNumberOrArrayOfNumbers())
                Node.ValueType = EveryParserType.Number | EveryParserType.ArrayOfNumber;
            if (parameterType.IsEmptyArray())
                Node.ValueType = EveryParserType.EmptyArray;

            if (Node.ValueType == EveryParserType.None)
                ErrorCollector.AddError(context, ErrorCode.IsNotNumberOrArrayOfNumbers, "Parameter is not a Number or an Array of Numbers");

            Node = Node.Parent;
        }

        private void CheckNumberOrArrayOfNumbersBinary(ParserRuleContext context)
        {
            if (!ErrorCollector.CheckParamsCount(context, 2, Node.Children))
            {
                Node = Node.Parent;
                return;
            }

            var parameterType1 = Node.Children[0].ValueType;
            var parameterType2 = Node.Children[1].ValueType;

            if (parameterType1.IsNumber() && parameterType2.IsNumber())
                Node.ValueType = EveryParserType.Number;
            if ((parameterType1.IsNumber() && parameterType2.IsNumberArray()) || parameterType1.IsNumberArray() && parameterType2.IsNumber())
                Node.ValueType = EveryParserType.ArrayOfNumber;
            if (parameterType1.IsNumberOrArrayOfNumbers() && parameterType2.IsNumberOrArrayOfNumbers())
                Node.ValueType = EveryParserType.Number | EveryParserType.ArrayOfNumber;
            if (parameterType1.IsEmptyArray() && parameterType2.IsEmptyArray())
                Node.ValueType = EveryParserType.EmptyArray;

            if (Node.ValueType == EveryParserType.None)
                ErrorCollector.AddError(context, ErrorCode.IsNotNumberOrArrayOfNumbers, "Parameters are not Numbers or Arrays of Numbers");

            Node = Node.Parent;
        }

        private void CheckListOfNumbersUnary(ParserRuleContext context)
        {
            if (ErrorCollector.CheckParamsCount(context, 1, Node.Children))
            {
                if (Node.Children[0].ValueType != EveryParserType.ArrayOfNumber)
                    ErrorCollector.AddError(context, ErrorCode.IsNotNumberArray, "Parameter is not an Array of Numbers!");
                else
                    Node.ValueType = EveryParserType.Number;
            }

            Node = Node.Parent;
        }


        private void CheckListOfNumbersBinary(ParserRuleContext context, EveryParserType resultType)
        {
            if (ErrorCollector.CheckParamsCount(context, 2, Node.Children))
            {
                if (Node.Children[0].ValueType != EveryParserType.ArrayOfNumber || Node.Children[1].ValueType != EveryParserType.ArrayOfNumber)
                    ErrorCollector.AddError(context, ErrorCode.IsNotNumberArray, "One or all Parameters are not Array of Numbers!");
                else
                    Node.ValueType = resultType;
            }

            Node = Node.Parent;
        }

        private void CheckNumericUnary(ParserRuleContext context,  EveryParserType resultType)
        {

            if (ErrorCollector.CheckParamsCount(context, 1, Node.Children))
            {
                if (Node.Children[0].ValueType != EveryParserType.Number)
                    ErrorCollector.AddError(context, ErrorCode.IsNotNumber, "Parameter is not a Numbers!");
                else
                    Node.ValueType = resultType;
            }

            Node = Node.Parent;
        }

        private void CheckNumericBinary(ParserRuleContext context, EveryParserType resultType)
        {
            if (ErrorCollector.CheckParamsCount(context, 2, Node.Children))
            {
                if (Node.Children[0].ValueType != EveryParserType.Number || Node.Children[1].ValueType != EveryParserType.Number)
                    ErrorCollector.AddError(context, ErrorCode.IsNotNumber, "One or all Parameters are not Numbers!");
                else
                    Node.ValueType = resultType;
            }

            Node = Node.Parent;
        }

        private void CheckNumericTri(ParserRuleContext context, EveryParserType resultType)
        {
            if (ErrorCollector.CheckParamsCount(context, 3, Node.Children))
            {
                if (Node.Children[0].ValueType != EveryParserType.Number || Node.Children[1].ValueType != EveryParserType.Number || Node.Children[2].ValueType != EveryParserType.Number)
                    ErrorCollector.AddError(context, ErrorCode.IsNotNumber, "One or all Parameters are not Numbers!");
                else
                    Node.ValueType = resultType;
            }

            Node = Node.Parent;
        }

        private void CheckBoolBinary(ParserRuleContext context, EveryParserType resultType)
        {
            if (ErrorCollector.CheckParamsCount(context, 2, Node.Children))
            {
                if (Node.Children[0].ValueType != EveryParserType.Boolean || Node.Children[1].ValueType != EveryParserType.Boolean)
                    ErrorCollector.AddError(context, ErrorCode.IsNotNumber, "One or all Parameters are not Boolean!");
                else
                    Node.ValueType = resultType;
            }

            Node = Node.Parent;
        }


        private EveryParserType GetArrayType(List<TypeNode> children)
        {
            if (children is null || !children.Any())
                return EveryParserType.EmptyArray;

            if (IsNumberArray(children))
                return EveryParserType.ArrayOfNumber;

            if (IsBooleanArray(children))
                return EveryParserType.ArrayOfBoolean;

            if (IsStringArray(children))
                return EveryParserType.ArrayOfBoolean;

            if (IsDateTimeArray(children))
                return EveryParserType.ArrayOfDateTime;

            return EveryParserType.Array;
        }

        private bool IsNumberArray(List<TypeNode> children) => !children.Any(x => x.ValueType != EveryParserType.Number);

        private bool IsStringArray(List<TypeNode> children) => !children.Any(x => x.ValueType != EveryParserType.String);

        private bool IsBooleanArray(List<TypeNode> children) => !children.Any(x => x.ValueType != EveryParserType.Boolean);

        private bool IsDateTimeArray(List<TypeNode> children) => !children.Any(x => x.ValueType != EveryParserType.DateTime);
    }
}