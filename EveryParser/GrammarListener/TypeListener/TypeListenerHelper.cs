using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using EveryParser.LinQReplaces;
using System.Collections.Generic;

namespace EveryParser.GrammarListener.TypeListener
{
    internal static class TypeListenerHelper
    {
        internal static object CheckNumberOrArrayOfNumbersUnary([NotNull] ParserRuleContext context, [NotNull] ErrorCollector errorCollector, [NotNull] TypeNode node, EveryParserType resultType = EveryParserType.Number, EveryParserType resultArrayType = EveryParserType.ArrayOfNumber, EveryParserType resultEmptyArray = EveryParserType.EmptyArray)
        {
            if (!errorCollector.CheckParamsCount(context, 1, node.Children))
                return node.Parent;

            var parameterType = node.Children[0].ValueType;

            if (parameterType.IsNumber())
                node.ValueType = resultType;
            if (parameterType.IsNumberArray())
                node.ValueType = resultArrayType;
            if (parameterType.IsNumberOrArrayOfNumbers())
                node.ValueType = resultType | resultArrayType;
            if (parameterType.IsEmptyArray())
                node.ValueType = resultEmptyArray;

            if (node.ValueType == EveryParserType.None)
                errorCollector.AddError(context, ErrorCode.IsNotNumberOrArrayOfNumbers, "Parameter is not a Number or an Array of Numbers");

            return node.Parent;
        }

        internal static object CheckNumberOrArrayOfNumbersBinary([NotNull] ParserRuleContext context, [NotNull] ErrorCollector errorCollector, [NotNull] TypeNode node, EveryParserType singleTypeResult = EveryParserType.Number, EveryParserType arrayTypeResult = EveryParserType.ArrayOfNumber)
        {
            if (!errorCollector.CheckParamsCount(context, 2, node.Children))
                return node.Parent;

            var parameterType1 = node.Children[0].ValueType;
            var parameterType2 = node.Children[1].ValueType;

            if (parameterType1.IsNumber() && parameterType2.IsNumber())
                node.ValueType = singleTypeResult;
            if ((parameterType1.IsNumber() && parameterType2.IsNumberArray()) ||
                parameterType1.IsNumberArray() && parameterType2.IsNumber() ||
                parameterType1.IsNumberArray() && parameterType2.IsNumberArray())
                node.ValueType = arrayTypeResult;
            if (parameterType1.IsNumberOrArrayOfNumbers() && parameterType2.IsNumberOrArrayOfNumbers())
                node.ValueType = singleTypeResult | arrayTypeResult;
            if (parameterType1.IsEmptyArray() && parameterType2.IsEmptyArray())
                node.ValueType = EveryParserType.EmptyArray;

            if (node.ValueType == EveryParserType.None)
                errorCollector.AddError(context, ErrorCode.IsNotNumberOrArrayOfNumbers, "Parameters are not Numbers or Arrays of Numbers");

            return node.Parent;
        }

        internal static object CheckListOfNumbersUnary([NotNull] ParserRuleContext context, [NotNull] ErrorCollector errorCollector, [NotNull] TypeNode node)
        {
            if (errorCollector.CheckParamsCount(context, 1, node.Children))
            {
                if (!node.Children[0].ValueType.IsNumberArray())
                    errorCollector.AddError(context, ErrorCode.IsNotNumberArray, "Parameter is not an Array of Numbers!");
                else
                    node.ValueType = EveryParserType.Number;
            }

            return node.Parent;
        }

        internal static object CheckListOfNumbersBinary([NotNull] ParserRuleContext context, [NotNull] ErrorCollector errorCollector, [NotNull] TypeNode node, EveryParserType resultType)
        {
            if (errorCollector.CheckParamsCount(context, 2, node.Children))
            {
                if (!node.Children[0].ValueType.IsNumberArray() || !node.Children[1].ValueType.IsNumberArray())
                    errorCollector.AddError(context, ErrorCode.IsNotNumberArray, "One or all Parameters are not Array of Numbers!");
                else
                    node.ValueType = resultType;
            }

            return node.Parent;
        }

        internal static object CheckNumericUnary([NotNull] ParserRuleContext context, [NotNull] ErrorCollector errorCollector, [NotNull] TypeNode node, EveryParserType resultType)
        {
            if (errorCollector.CheckParamsCount(context, 1, node.Children))
            {
                if (!node.Children[0].ValueType.IsNumber())
                    errorCollector.AddError(context, ErrorCode.IsNotNumber, "Parameter is not a Number!");
                else
                    node.ValueType = resultType;
            }

            return node.Parent;
        }

        internal static object CheckNumericBinary([NotNull] ParserRuleContext context, [NotNull] ErrorCollector errorCollector, [NotNull] TypeNode node, EveryParserType resultType)
        {
            if (errorCollector.CheckParamsCount(context, 2, node.Children))
            {
                if (!node.Children[0].ValueType.IsNumber() || !node.Children[1].ValueType.IsNumber())
                    errorCollector.AddError(context, ErrorCode.IsNotNumber, "One or all Parameters are not Numbers!");
                else
                    node.ValueType = resultType;
            }

            return node.Parent;
        }

        internal static object CheckNumericTri([NotNull] ParserRuleContext context, [NotNull] ErrorCollector errorCollector, [NotNull] TypeNode node, EveryParserType resultType)
        {
            if (errorCollector.CheckParamsCount(context, 3, node.Children))
            {
                if (!node.Children[0].ValueType.IsNumber() || !node.Children[1].ValueType.IsNumber() || !node.Children[2].ValueType.IsNumber())
                    errorCollector.AddError(context, ErrorCode.IsNotNumber, "One or all Parameters are not Numbers!");
                else
                    node.ValueType = resultType;
            }

            return node.Parent;
        }

        internal static object CalcBooleanOrBooleanArrayBinary([NotNull] ParserRuleContext context, [NotNull] ErrorCollector errorCollector, [NotNull] TypeNode node, EveryParserType resultType, EveryParserType listResultType)
        {
            if (errorCollector.CheckParamsCount(context, 2, node.Children))
            {
                if (node.Children[0].ValueType.IsBoolean() && node.Children[1].ValueType.IsBoolean())
                    node.ValueType = resultType;
                else if (node.Children[0].ValueType.IsBooleanArray() && node.Children[1].ValueType.IsBooleanArray())
                    node.ValueType = listResultType;
                else
                    errorCollector.AddError(context, ErrorCode.IsNotNumber, "One or all Parameters are not Boolean!");
            }

            return node.Parent;
        }

        internal static object CheckStringOrListUnary([NotNull] ParserRuleContext context, [NotNull] ErrorCollector errorCollector, [NotNull] TypeNode node, EveryParserType stringResultType, EveryParserType listResultType)
        {
            if (errorCollector.CheckParamsCount(context, 1, node.Children))
            {
                if (!node.Children[0].ValueType.IsString() && !node.Children[0].ValueType.IsArrayType())
                    errorCollector.AddError(context, ErrorCode.IsNotNumber, "Parameter is not a string or an Array!");
                else if (node.Children[0].ValueType.IsString())
                    node.ValueType = stringResultType;
                else if (node.Children[0].ValueType.IsArrayType())
                    node.ValueType = listResultType.IsArray() ? node.Children[0].ValueType : listResultType;
            }

            return node.Parent;
        }

        internal static object CheckStringOrArrayOfStringsUnary([NotNull] ParserRuleContext context, [NotNull] ErrorCollector errorCollector, [NotNull] TypeNode node, EveryParserType stringResultType, EveryParserType listResultType)
        {
            if (errorCollector.CheckParamsCount(context, 1, node.Children))
            {
                if (!node.Children[0].ValueType.IsString() && !node.Children[0].ValueType.IsArrayType())
                    errorCollector.AddError(context, ErrorCode.IsNotNumber, "Parameter is not a string or an Array of Strings!");
                else if (node.Children[0].ValueType == EveryParserType.String)
                    node.ValueType = stringResultType;
                else if (node.Children[0].ValueType.IsStringArray())
                    node.ValueType = listResultType;
            }

            return node.Parent;
        }

        internal static object CheckStringOrArrayOfStringsBinary([NotNull] ParserRuleContext context, [NotNull] ErrorCollector errorCollector, [NotNull] TypeNode node, EveryParserType stringResultType, EveryParserType listResultType)
        {
            if (!errorCollector.CheckParamsCount(context, 2, node.Children))
                return node.Parent;

            var parameterType1 = node.Children[0].ValueType;
            var parameterType2 = node.Children[1].ValueType;

            if (parameterType1.IsString() && parameterType2.IsString())
                node.ValueType = stringResultType;
            if ((parameterType1.IsString() && parameterType2.IsStringArray()) || parameterType1.IsStringArray() && parameterType2.IsString())
                node.ValueType = listResultType;
            if (parameterType1.IsStringOrArrayOfStrings() && parameterType2.IsStringOrArrayOfStrings())
                node.ValueType = stringResultType | listResultType;
            if (parameterType1.IsEmptyArray() && parameterType2.IsEmptyArray())
                node.ValueType = stringResultType;

            if (node.ValueType == EveryParserType.None)
                errorCollector.AddError(context, ErrorCode.IsNotStringOrArrayOfStrings, "Parameters are not Strings or Arrays of Strings");

            return node.Parent;
        }

        internal static object CheckAnyUnary([NotNull] ParserRuleContext context, [NotNull] ErrorCollector errorCollector, [NotNull] TypeNode node, EveryParserType resultType)
        {
            if (errorCollector.CheckParamsCount(context, 1, node.Children))
            {
                if (node.Children[0].ValueType == EveryParserType.None)
                    errorCollector.AddError(context, ErrorCode.IsNotNumber, "Parameter has no type!");
                else
                    node.ValueType = resultType;
            }

            return node.Parent;
        }

        internal static object CheckAnyBinary([NotNull] ParserRuleContext context, [NotNull] ErrorCollector errorCollector, [NotNull] TypeNode node, EveryParserType resultType)
        {
            if (errorCollector.CheckParamsCount(context, 2, node.Children))
            {
                if (node.Children[0].ValueType == EveryParserType.None || node.Children[1].ValueType == EveryParserType.None)
                    errorCollector.AddError(context, ErrorCode.IsNotNumber, "One or all Parameters has no type!");
                else
                    node.ValueType = resultType;
            }

            return node.Parent;
        }

        internal static object CheckOnlyStringOrOnlyArraySameResult([NotNull] ParserRuleContext context, [NotNull] ErrorCollector errorCollector, [NotNull] TypeNode node)
        {
            if (errorCollector.CheckParamsCount(context, 2, node.Children))
            {
                var type1 = node.Children[0].ValueType;
                var type2 = node.Children[1].ValueType;

                if ((!type1.IsString() && !type2.IsString()) && (!type1.IsArrayType() && !type2.IsArrayType()))
                    errorCollector.AddError(context, ErrorCode.IsNotNumberOrArrayOfNumbers, "Parameters are not both string or not both Arrays!");
                else
                    node.ValueType = type1;
            }

            return node.Parent;
        }

        private static EveryParserType GetArrayType(List<TypeNode> children)
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

        private static EveryParserType GetSingleTypeOfArrayType(EveryParserType type)
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

        private static bool IsNumberArray(List<TypeNode> children) => !children.Any(x => x.ValueType != EveryParserType.Number);

        private static bool IsStringArray(List<TypeNode> children) => !children.Any(x => x.ValueType != EveryParserType.String);

        private static bool IsBooleanArray(List<TypeNode> children) => !children.Any(x => x.ValueType != EveryParserType.Boolean);

        private static bool IsDateTimeArray(List<TypeNode> children) => !children.Any(x => x.ValueType != EveryParserType.DateTime);

        /// <summary>
        /// Method to use in order to create the date value.
        /// Therefore the date methods are very similar, it's everything here inside one method
        /// </summary>
        /// <param name="context"></param>
        /// <param name="expectedDateParameters"></param>
        internal static object SetNodeForDateTimeValue([NotNull] ParserRuleContext context, [NotNull] ErrorCollector errorCollector, [NotNull] TypeNode node, int expectedDateParameters)
        {
            if (!errorCollector.CheckParamsCount(context, expectedDateParameters, node.Children))
            {
                node.ValueType = EveryParserType.None;
                return node.Parent;
            }

            if (expectedDateParameters == 1)
            {
                var childType = node.Children[0].ValueType;
                if (childType.IsString())
                    node.ValueType = EveryParserType.DateTime;
                else if (childType.IsStringArray())
                    node.ValueType = EveryParserType.ArrayOfDateTime;
                else if (childType.IsStringOrArrayOfStrings())
                    node.ValueType = EveryParserType.DateTime | EveryParserType.ArrayOfDateTime;
            }
            else
            {
                if (node.Children.Any(v => !v.ValueType.IsNumber() && !v.ValueType.IsNumberArray() && !v.ValueType.IsNumberOrArrayOfNumbers()))
                {
                    errorCollector.AddError(context, ErrorCode.IsNotNumberOrArrayOfNumbers, "One or more values are not number or array of numbers");
                    node.ValueType = EveryParserType.None;
                    return node.Parent;
                }

                if (node.Children.Any(v => v.ValueType.IsNumberArray()))
                    node.ValueType = EveryParserType.ArrayOfDateTime;
                else if (node.Children.Any(v => v.ValueType.IsNumberOrArrayOfNumbers()))
                    node.ValueType = EveryParserType.DateTime | EveryParserType.ArrayOfDateTime;
                else
                    node.ValueType = EveryParserType.DateTime;
            }

            return node.Parent;
        }

        internal static object ArraySlicing([NotNull] ParserRuleContext context, [NotNull] ErrorCollector errorCollector, [NotNull] TypeNode node, ArraySlicingType arraySlicingType)
        {
            if (!errorCollector.CheckParamsCount(context, arraySlicingType.GetParameterCount(), node.Children))
                return node.Parent;

            if (!node.Children[0].ValueType.IsArrayType())
            {
                errorCollector.AddError(context, ErrorCode.FirstIsNotArray, "First parameter must be an array!");
                return node.Parent;
            }

            var childrenTypes = node.Children.GetRange(1, arraySlicingType.GetParameterCount() - 1).Select(x => x.ValueType);

            if (childrenTypes.Any(v => !v.IsNumber() && !v.IsNumberArray() && !v.IsNumberOrArrayOfNumbers()))
            {
                errorCollector.AddError(context, ErrorCode.IsNotNumberOrArrayOfNumbers, "One or more values are not number or array of numbers");
                return node.Parent;
            }

            //Issue here, we can not recognize arrays in arrays
            switch (arraySlicingType)
            {
                case ArraySlicingType.Indexing:
                    if (childrenTypes.Any(v => v.IsNumberArray()))
                        node.ValueType = node.Children[0].ValueType;
                    else if (childrenTypes.Any(v => v.IsNumberOrArrayOfNumbers()))
                        node.ValueType = GetSingleTypeOfArrayType(node.Children[0].ValueType) | node.Children[0].ValueType;
                    else
                        node.ValueType = GetSingleTypeOfArrayType(node.Children[0].ValueType);
                    break;

                case ArraySlicingType.Slicing:
                case ArraySlicingType.StepSlicing:
                case ArraySlicingType.StartSlicing:
                case ArraySlicingType.StartStepSlicing:
                case ArraySlicingType.EndSlicing:
                case ArraySlicingType.EndStepSlicing:
                case ArraySlicingType.AllStepSlicing:
                    node.ValueType = node.Children[0].ValueType;
                    break;
            }

            return node.Parent;
        }
    }
}