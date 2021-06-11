using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EveryParser
{
    public partial class EveryGrammarCalculatorListener
    {/// <summary>
     /// Enter a parse tree produced by the <c>ArraySlicing</c>
     /// labeled alternative in <see cref="EveryGrammarParser.if_else"/>.
     /// <para>The default implementation does nothing.</para>
     /// </summary>
     /// <param name="context">The parse tree.</param>
        public void EnterArraySlicing([NotNull] EveryGrammarParser.ArraySlicingContext context)
        {
            Node = Node.AddChildNode();
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.if_else"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing([NotNull] EveryGrammarParser.ArraySlicingContext context)
        {
            if (!ErrorCollector.CheckHasParams(context, Node.Children))
            {
                Node.Value = null;
                Node = Node.Parent;
                return;
            }

            var childValues = Node.Children.Select(child => child.Value).ToArray();

            if (ErrorCollector.CheckIsNull(context, childValues) || !ErrorCollector.CheckIsNumberOrArrayOfNumbers(context, childValues))
            {
                Node.Value = null;
                Node = Node.Parent;
                return;
            }

            if (childValues.Length < 2 || childValues.Length > 3)
            {
                ErrorCollector.AddError(context, ErrorCode.ArraySlicingNotCorrect, "The parameter count for slicing the array is not correct!");
                Node.Value = null;
                Node = Node.Parent;
                return;
            }

            var array = childValues[0] as List<object>;
            if (array is null)
            {
                string text = childValues[0] as string;
                if (string.IsNullOrWhiteSpace(text))
                {
                    ErrorCollector.AddError(context, ErrorCode.FirstIsNotArray, "The first parameter musst be an array or string!");
                    Node.Value = null;
                    Node = Node.Parent;
                    return;
                }

                array = Array.ConvertAll(text.ToArray(), x => (object)x).ToList();
            }

            switch (childValues.Length)
            {
                case 2:
                    Node.Value = SliceArray(context, array, childValues[1]);
                    break;

                case 3:
                    Node.Value = SliceArrayFromTo(context, array, childValues[1], childValues[2]);
                    break;

                case 4:
                    Node.Value = SliceArrayFromToStep(context, array, childValues[1], childValues[2], childValues[3]);
                    break;

                default:
                    ErrorCollector.AddError(context, ErrorCode.ParamsCountNotCorrect, "Count of parameters for this function is not correct!");
                    Node.Value = null;
                    break;
            }

            Node = Node.Parent;
        }

        private object SliceArray(ParserRuleContext context, List<object> array, object indexObj)
        {
            var indexList = indexObj as List<object>;

            if (indexList is null)
            {
                int index = Convert.ToInt32(indexObj);
                return array[index];
            }

            return indexList.Select(x => array[Convert.ToInt32(x.ToString())]);
        }

        private object SliceArrayFromTo(ParserRuleContext context, List<object> array, object indexStartObj, object indexEndObj)
        {
            var indexStartList = indexStartObj as List<object>;
            var indexEndList = indexEndObj as List<object>;

            if (indexStartList is null && indexEndList is null)
            {
                int indexStart = Convert.ToInt32(indexStartObj);
                int indexEnd = Convert.ToInt32(indexEndObj);
                return array.GetRange(indexStart, indexEnd - indexStart);
            }
            else if (indexStartList is null)
            {
                int indexStart = Convert.ToInt32(indexStartObj);
                return indexEndList.Select(indexEndX => array.GetRange(indexStart, Convert.ToInt32(indexEndX) - indexStart)).ToList();
            }
            else if (indexEndList is null)
            {
                int indexEnd = Convert.ToInt32(indexEndObj);
                return indexStartList.Select(indexStartX =>
                {
                    int indexStart = Convert.ToInt32(indexStartX);
                    return array.GetRange(indexStart, indexEnd - indexStart);
                }).ToList();
            }
            else if (indexStartList.Count == indexEndList.Count)
            {
                var result = new List<object>(indexEndList.Count);
                for (int i = 0; i < indexEndList.Count; i += 1)
                {
                    int indexStart = Convert.ToInt32(indexStartObj);
                    int indexEnd = Convert.ToInt32(indexEndObj);
                    result.Add(array.GetRange(indexStart, indexEnd - indexStart));
                }
                return result;
            }

            ErrorCollector.AddError(context, ErrorCode.NotEqualArayCount, $"Array count must be equal: IndexStart Array Count {indexStartList.Count} IndexEnd Array Count {indexEndList.Count}");

            return null;
        }

        private object SliceArrayFromToStep(ParserRuleContext context, List<object> array, object indexStartObj, object indexEndObj, object stepObj)
        {
            var indexStartList = indexStartObj as List<object>;
            var indexEndList = indexEndObj as List<object>;
            var stepList = stepObj as List<object>;

            if (indexStartList is null && indexEndList is null && stepList is null)
            {
                int indexStart = Convert.ToInt32(indexStartObj);
                int indexEnd = Convert.ToInt32(indexEndObj);
                return array.GetRange(indexStart, indexEnd - indexStart);
            }
            else if (indexStartList is null)
            {
                int indexStart = Convert.ToInt32(indexStartObj);
                return indexEndList.Select(indexEndX => array.GetRange(indexStart, Convert.ToInt32(indexEndX) - indexStart)).ToList();
            }
            else if (indexEndList is null)
            {
                int indexEnd = Convert.ToInt32(indexEndObj);
                return indexStartList.Select(indexStartX =>
                {
                    int indexStart = Convert.ToInt32(indexStartX);
                    return array.GetRange(indexStart, indexEnd - indexStart);
                }).ToList();
            }
            else if (indexStartList.Count == indexEndList.Count)
            {
                var result = new List<object>(indexEndList.Count);
                for (int i = 0; i < indexEndList.Count; i += 1)
                {
                    int indexStart = Convert.ToInt32(indexStartObj);
                    int indexEnd = Convert.ToInt32(indexEndObj);
                    result.Add(array.GetRange(indexStart, indexEnd - indexStart));
                }
                return result;
            }

            ErrorCollector.AddError(context, ErrorCode.NotEqualArayCount, $"Array count must be equal: IndexStart Array Count {indexStartList.Count} IndexEnd Array Count {indexEndList.Count}");

            return null;
        }

        private List<object> GetFromTo(ParserRuleContext context, List<object> list, int start, int end, int step = 1)
        {
            if (step < 1 || step >= list.Count)
            {
                ErrorCollector.AddError(context, ErrorCode.StepNotCorrect, "The step can't be less 1 and higher then length of array!");
                return null;
            }

            var startIndex = start < 0 ? list.Count + start : start;
            var endIndex = end < 0 ? list.Count + end : end;

            if (((start < 0 && end < 0) || (start >= 0 && end >= 0)))
            {
                if (start >= end)
                {
                    ErrorCollector.AddError(context, ErrorCode.StartEndIndexNotCorrect, "The startIndex can't be higher or equal to the endIndex!");
                    return null;
                }
            }
            else if (start >= 0 && end < 0)
            {
                if (start >= endIndex)
                {
                    ErrorCollector.AddError(context, ErrorCode.StartEndIndexNotCorrect, "The startIndex can't be higher or equal to the endIndex!");
                    return null;
                }
            }
            else if (start < 0 && end >= 0)
            {
                if (startIndex >= end)
                {
                    ErrorCollector.AddError(context, ErrorCode.StartEndIndexNotCorrect, "The startIndex can't be higher or equal to the endIndex!");
                    return null;
                }
            }

            if (startIndex >= list.Count || endIndex >= list.Count)
            {
                ErrorCollector.AddError(context, ErrorCode.StartEndIndexNotCorrect, "The startIndex/endIndex can't be higher or equal to the length of the array!");
                return null;
            }

            var result = new List<object>();

            for (int i = startIndex; i < endIndex; i += step)
                result.Add(list[i]);

            result.TrimExcess();
            return result;
        }
    }
}