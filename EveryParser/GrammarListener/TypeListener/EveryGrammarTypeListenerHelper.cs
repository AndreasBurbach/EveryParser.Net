using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using EveryParser.LinQReplaces;
using System.Collections.Generic;

namespace EveryParser.GrammarListener.TypeListener
{
    public partial class EveryGrammarTypeListener
    {
        private void CheckNumberOrArrayOfNumbersUnary([NotNull] ParserRuleContext context, EveryParserType resultType = EveryParserType.Number, EveryParserType resultArrayType = EveryParserType.ArrayOfNumber, EveryParserType resultEmptyArray = EveryParserType.EmptyArray)
        {
            if (!ErrorCollector.CheckParamsCount(context, 1, Node.Children))
            {
                Node = Node.Parent;
                return;
            }

            var parameterType = Node.Children[0].ValueType;

            if (parameterType.IsNumber())
                Node.ValueType = resultType;
            if (parameterType.IsNumberArray())
                Node.ValueType = resultArrayType;
            if (parameterType.IsNumberOrArrayOfNumbers())
                Node.ValueType = resultType | resultArrayType;
            if (parameterType.IsEmptyArray())
                Node.ValueType = resultEmptyArray;

            if (Node.ValueType == EveryParserType.None)
                ErrorCollector.AddError(context, ErrorCode.IsNotNumberOrArrayOfNumbers, "Parameter is not a Number or an Array of Numbers");

            Node = Node.Parent;
        }

        private void CheckNumberOrArrayOfNumbersBinary([NotNull] ParserRuleContext context)
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
            if ((parameterType1.IsNumber() && parameterType2.IsNumberArray()) ||
                parameterType1.IsNumberArray() && parameterType2.IsNumber() ||
                parameterType1.IsNumberArray() && parameterType2.IsNumberArray())
                Node.ValueType = EveryParserType.ArrayOfNumber;
            if (parameterType1.IsNumberOrArrayOfNumbers() && parameterType2.IsNumberOrArrayOfNumbers())
                Node.ValueType = EveryParserType.Number | EveryParserType.ArrayOfNumber;
            if (parameterType1.IsEmptyArray() && parameterType2.IsEmptyArray())
                Node.ValueType = EveryParserType.EmptyArray;

            if (Node.ValueType == EveryParserType.None)
                ErrorCollector.AddError(context, ErrorCode.IsNotNumberOrArrayOfNumbers, "Parameters are not Numbers or Arrays of Numbers");

            Node = Node.Parent;
        }

        private void CheckListOfNumbersUnary([NotNull] ParserRuleContext context)
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

        private void CheckListOfNumbersBinary([NotNull] ParserRuleContext context, EveryParserType resultType)
        {
            if (ErrorCollector.CheckParamsCount(context, 2, Node.Children))
            {
                if (!Node.Children[0].ValueType.IsNumberArray() || !Node.Children[1].ValueType.IsNumberArray())
                    ErrorCollector.AddError(context, ErrorCode.IsNotNumberArray, "One or all Parameters are not Array of Numbers!");
                else
                    Node.ValueType = resultType;
            }

            Node = Node.Parent;
        }

        private void CheckNumericUnary([NotNull] ParserRuleContext context, EveryParserType resultType)
        {
            if (ErrorCollector.CheckParamsCount(context, 1, Node.Children))
            {
                if (!Node.Children[0].ValueType.IsNumber())
                    ErrorCollector.AddError(context, ErrorCode.IsNotNumber, "Parameter is not a Number!");
                else
                    Node.ValueType = resultType;
            }

            Node = Node.Parent;
        }

        private void CheckNumericBinary([NotNull] ParserRuleContext context, EveryParserType resultType)
        {
            if (ErrorCollector.CheckParamsCount(context, 2, Node.Children))
            {
                if (!Node.Children[0].ValueType.IsNumber() || !Node.Children[1].ValueType.IsNumber())
                    ErrorCollector.AddError(context, ErrorCode.IsNotNumber, "One or all Parameters are not Numbers!");
                else
                    Node.ValueType = resultType;
            }

            Node = Node.Parent;
        }

        private void CheckNumericTri([NotNull] ParserRuleContext context, EveryParserType resultType)
        {
            if (ErrorCollector.CheckParamsCount(context, 3, Node.Children))
            {
                if (!Node.Children[0].ValueType.IsNumber() || !Node.Children[1].ValueType.IsNumber() || !Node.Children[2].ValueType.IsNumber())
                    ErrorCollector.AddError(context, ErrorCode.IsNotNumber, "One or all Parameters are not Numbers!");
                else
                    Node.ValueType = resultType;
            }

            Node = Node.Parent;
        }

        private void CheckBoolBinary([NotNull] ParserRuleContext context, EveryParserType resultType)
        {
            if (ErrorCollector.CheckParamsCount(context, 2, Node.Children))
            {
                if (!Node.Children[0].ValueType.IsBoolean() || !Node.Children[1].ValueType.IsBoolean())
                    ErrorCollector.AddError(context, ErrorCode.IsNotNumber, "One or all Parameters are not Boolean!");
                else
                    Node.ValueType = resultType;
            }

            Node = Node.Parent;
        }

        private void CheckStringOrListUnary([NotNull] ParserRuleContext context, EveryParserType stringResultType, EveryParserType listResultType)
        {
            if (ErrorCollector.CheckParamsCount(context, 1, Node.Children))
            {
                if (!Node.Children[0].ValueType.IsString() && !Node.Children[0].ValueType.IsArrayType())
                    ErrorCollector.AddError(context, ErrorCode.IsNotNumber, "Parameter is not a string or an Array!");
                else if (Node.Children[0].ValueType.IsString())
                    Node.ValueType = stringResultType;
                else if (Node.Children[0].ValueType.IsArrayType())
                    Node.ValueType = listResultType.IsArray() ? Node.Children[0].ValueType : listResultType;
            }

            Node = Node.Parent;
        }

        private void CheckStringOrArrayOfStringsUnary([NotNull] ParserRuleContext context, EveryParserType stringResultType, EveryParserType listResultType)
        {
            if (ErrorCollector.CheckParamsCount(context, 1, Node.Children))
            {
                if (!Node.Children[0].ValueType.IsString() && !Node.Children[0].ValueType.IsArrayType())
                    ErrorCollector.AddError(context, ErrorCode.IsNotNumber, "Parameter is not a string or an Array of Strings!");
                else if (Node.Children[0].ValueType == EveryParserType.String)
                    Node.ValueType = stringResultType;
                else if (Node.Children[0].ValueType.IsStringArray())
                    Node.ValueType = listResultType;
            }

            Node = Node.Parent;
        }

        private void CheckStringOrArrayOfStringsBinary([NotNull] ParserRuleContext context, EveryParserType stringResultType, EveryParserType listResultType)
        {
            if (!ErrorCollector.CheckParamsCount(context, 2, Node.Children))
            {
                Node = Node.Parent;
                return;
            }

            var parameterType1 = Node.Children[0].ValueType;
            var parameterType2 = Node.Children[1].ValueType;

            if (parameterType1.IsString() && parameterType2.IsString())
                Node.ValueType = stringResultType;
            if ((parameterType1.IsString() && parameterType2.IsStringArray()) || parameterType1.IsStringArray() && parameterType2.IsString())
                Node.ValueType = listResultType;
            if (parameterType1.IsStringOrArrayOfStrings() && parameterType2.IsStringOrArrayOfStrings())
                Node.ValueType = stringResultType | listResultType;
            if (parameterType1.IsEmptyArray() && parameterType2.IsEmptyArray())
                Node.ValueType = stringResultType;

            if (Node.ValueType == EveryParserType.None)
                ErrorCollector.AddError(context, ErrorCode.IsNotStringOrArrayOfStrings, "Parameters are not Strings or Arrays of Strings");

            Node = Node.Parent;
        }

        private void CheckAnyUnary([NotNull] ParserRuleContext context, EveryParserType resultType)
        {
            if (ErrorCollector.CheckParamsCount(context, 1, Node.Children))
            {
                if (Node.Children[0].ValueType == EveryParserType.None)
                    ErrorCollector.AddError(context, ErrorCode.IsNotNumber, "Parameter has no type!");
                else
                    Node.ValueType = resultType;
            }

            Node = Node.Parent;
        }

        private void CheckAnyBinary([NotNull] ParserRuleContext context, EveryParserType resultType)
        {
            if (ErrorCollector.CheckParamsCount(context, 2, Node.Children))
            {
                if (Node.Children[0].ValueType == EveryParserType.None || Node.Children[1].ValueType == EveryParserType.None)
                    ErrorCollector.AddError(context, ErrorCode.IsNotNumber, "One or all Parameters has no type!");
                else
                    Node.ValueType = resultType;
            }

            Node = Node.Parent;
        }

        private void CheckOnlyStringOrOnlyArraySameResult([NotNull] ParserRuleContext context)
        {
            if (ErrorCollector.CheckParamsCount(context, 2, Node.Children))
            {
                var type1 = Node.Children[0].ValueType;
                var type2 = Node.Children[1].ValueType;

                if ((!type1.IsString() && !type2.IsString()) && (!type1.IsArrayType() && !type2.IsArrayType()))
                    ErrorCollector.AddError(context, ErrorCode.IsNotNumberOrArrayOfNumbers, "Parameters are not both string or not both Arrays!");
                else
                    Node.ValueType = type1;
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
                return EveryParserType.ArrayOfString;

            if (IsDateTimeArray(children))
                return EveryParserType.ArrayOfDateTime;

            return EveryParserType.Array;
        }

        private EveryParserType GetSingleTypeOfArrayType(EveryParserType type)
        {
            switch (type)
            {
                case EveryParserType.Number:
                    return EveryParserType.Number;

                case EveryParserType.Boolean:
                    return EveryParserType.Boolean;

                case EveryParserType.String:
                    return EveryParserType.String;

                case EveryParserType.DateTime:
                    return EveryParserType.DateTime;

                case EveryParserType.ArrayOfNumber:
                    return EveryParserType.Number;

                case EveryParserType.ArrayOfBoolean:
                    return EveryParserType.Boolean;

                case EveryParserType.ArrayOfString:
                    return EveryParserType.String;

                case EveryParserType.ArrayOfDateTime:
                    return EveryParserType.DateTime;
            }

            return EveryParserType.None;
        }

        private bool IsNumberArray(List<TypeNode> children) => !children.Any(x => x.ValueType != EveryParserType.Number);

        private bool IsStringArray(List<TypeNode> children) => !children.Any(x => x.ValueType != EveryParserType.String);

        private bool IsBooleanArray(List<TypeNode> children) => !children.Any(x => x.ValueType != EveryParserType.Boolean);

        private bool IsDateTimeArray(List<TypeNode> children) => !children.Any(x => x.ValueType != EveryParserType.DateTime);

        /// <summary>
        /// Method to use in order to create the date value.
        /// Therefore the date methods are very similar, it's everything here inside one method
        /// </summary>
        /// <param name="context"></param>
        /// <param name="expectedDateParameters"></param>
        private void SetNodeForDateTimeValue([NotNull] ParserRuleContext context, int expectedDateParameters)
        {
            if (!ErrorCollector.CheckParamsCount(context, expectedDateParameters, Node.Children))
            {
                Node.ValueType = EveryParserType.None;
                Node = Node.Parent;
                return;
            }

            if (expectedDateParameters == 1)
            {
                var childType = Node.Children[0].ValueType;
                if (childType.IsString())
                    Node.ValueType = EveryParserType.DateTime;
                else if (childType.IsStringArray())
                    Node.ValueType = EveryParserType.ArrayOfDateTime;
                else if (childType.IsStringOrArrayOfStrings())
                    Node.ValueType = EveryParserType.DateTime | EveryParserType.ArrayOfDateTime;
            }
            else
            {
                if (Node.Children.Any(v => !v.ValueType.IsNumber() && !v.ValueType.IsNumberArray() && !v.ValueType.IsNumberOrArrayOfNumbers()))
                {
                    ErrorCollector.AddError(context, ErrorCode.IsNotNumberOrArrayOfNumbers, "One or more values are not number or array of numbers");
                    Node.ValueType = EveryParserType.None;
                    Node = Node.Parent;
                    return;
                }

                if (Node.Children.Any(v => v.ValueType.IsNumberArray()))
                    Node.ValueType = EveryParserType.ArrayOfDateTime;
                else if (Node.Children.Any(v => v.ValueType.IsNumberOrArrayOfNumbers()))
                    Node.ValueType = EveryParserType.DateTime | EveryParserType.ArrayOfDateTime;
                else
                    Node.ValueType = EveryParserType.DateTime;
            }

            Node = Node.Parent;
        }

        private void ArraySlicing([NotNull] ParserRuleContext context, ArraySlicingType arraySlicingType)
        {
            if (!ErrorCollector.CheckParamsCount(context, arraySlicingType.GetParameterCount(), Node.Children))
            {
                Node = Node.Parent;
                return;
            }

            if (!Node.Children[0].ValueType.IsArrayType())
            {
                ErrorCollector.AddError(context, ErrorCode.FirstIsNotArray, "First parameter must be an array!");
                Node = Node.Parent;
                return;
            }

            var childrenTypes = Node.Children.GetRange(1, arraySlicingType.GetParameterCount() - 1).Select(x => x.ValueType);

            if (childrenTypes.Any(v => !v.IsNumber() && !v.IsNumberArray() && !v.IsNumberOrArrayOfNumbers()))
            {
                ErrorCollector.AddError(context, ErrorCode.IsNotNumberOrArrayOfNumbers, "One or more values are not number or array of numbers");
                Node = Node.Parent;
                return;
            }

            //Issue here, we can not recognize arrays in arrays
            switch (arraySlicingType)
            {
                case ArraySlicingType.Indexing:
                    if (childrenTypes.Any(v => v.IsNumberArray()))
                        Node.ValueType = Node.Children[0].ValueType;
                    else if (childrenTypes.Any(v => v.IsNumberOrArrayOfNumbers()))
                        Node.ValueType = GetSingleTypeOfArrayType(Node.Children[0].ValueType) | Node.Children[0].ValueType;
                    else
                        Node.ValueType = GetSingleTypeOfArrayType(Node.Children[0].ValueType);
                    break;
                case ArraySlicingType.Slicing:
                case ArraySlicingType.StepSlicing:
                case ArraySlicingType.StartSlicing:
                case ArraySlicingType.StartStepSlicing:
                case ArraySlicingType.EndSlicing:
                case ArraySlicingType.EndStepSlicing:
                case ArraySlicingType.AllStepSlicing:
                    Node.ValueType = Node.Children[0].ValueType;
                    break;
            }

            Node = Node.Parent;
        }
    }
}