using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using EveryParser.LinQReplaces;
using System;
using System.Collections.Generic;

namespace EveryParser.GrammarListener.CalculatorListener
{
    public partial class EveryGrammarCalculatorListener
    {
        private ArraySlicingType _lastArraySlicingType;

        /// <summary>
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
            ArraySlicing(context, _lastArraySlicingType);
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_Indexing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_Indexing([NotNull] EveryGrammarParser.ArraySlicing_IndexingContext context)
        {
            _lastArraySlicingType = ArraySlicingType.Indexing;
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_Slicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_Slicing([NotNull] EveryGrammarParser.ArraySlicing_SlicingContext context)
        {
            _lastArraySlicingType = ArraySlicingType.Slicing;
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_StepSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_StepSlicing([NotNull] EveryGrammarParser.ArraySlicing_StepSlicingContext context)
        {
            _lastArraySlicingType = ArraySlicingType.StepSlicing;
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_StartSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_StartSlicing([NotNull] EveryGrammarParser.ArraySlicing_StartSlicingContext context)
        {
            _lastArraySlicingType = ArraySlicingType.StartSlicing;
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_StartStepSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_StartStepSlicing([NotNull] EveryGrammarParser.ArraySlicing_StartStepSlicingContext context)
        {
            _lastArraySlicingType = ArraySlicingType.StartStepSlicing;
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_EndSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_EndSlicing([NotNull] EveryGrammarParser.ArraySlicing_EndSlicingContext context)
        {
            _lastArraySlicingType = ArraySlicingType.EndSlicing;
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_EndStepSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_EndStepSlicing([NotNull] EveryGrammarParser.ArraySlicing_EndStepSlicingContext context)
        {
            _lastArraySlicingType = ArraySlicingType.EndStepSlicing;
        }

        /// <summary>
        /// Exit a parse tree produced by the <c>ArraySlicing_AllStepSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void ExitArraySlicing_AllStepSlicing([NotNull] EveryGrammarParser.ArraySlicing_AllStepSlicingContext context)
        {
            _lastArraySlicingType = ArraySlicingType.AllStepSlicing;
        }

        private void ArraySlicing([NotNull] ParserRuleContext context, ArraySlicingType arraySlicingType)
        {
            if (!ErrorCollector.CheckHasParams(context, Node.Children))
            {
                Node.Value = null;
                Node = Node.Parent;
                return;
            }

            int parametersCount = arraySlicingType.GetParameterCount();

            var childValues = Node.Children.GetRange(1, parametersCount - 1).Select(child => child.Value).ToArray();

            if (!ErrorCollector.CheckParamsCount(context, parametersCount - 1, childValues) ||
                ErrorCollector.CheckIsNull(context, childValues) ||
                !ErrorCollector.CheckIsNumberOrArrayOfNumbers(context, childValues))
            {
                Node.Value = null;
                Node = Node.Parent;
                return;
            }

            var array = Node.Children[0].Value as List<object>;
            if (array is null)
            {
                string text = Node.Children[0].Value as string;
                if (string.IsNullOrWhiteSpace(text))
                {
                    ErrorCollector.AddError(context, ErrorCode.FirstIsNotArray, "The first parameter musst be an array or string!");
                    Node.Value = null;
                    Node = Node.Parent;
                    return;
                }

                array = new List<object>(Array.ConvertAll(text.ToCharArray(), x => (object)x));
            }

            switch (arraySlicingType)
            {
                case ArraySlicingType.Indexing:
                    Node.Value = SliceArray(context, array, childValues[0]);
                    break;

                case ArraySlicingType.Slicing:
                    Node.Value = SliceArrayFromTo(context, array, childValues[0], childValues[1]);
                    break;

                case ArraySlicingType.StepSlicing:

                    Node.Value = SliceArrayFromToStep(context, array, childValues[0], childValues[1], childValues[2]);
                    break;

                case ArraySlicingType.StartSlicing:
                    Node.Value = SliceArrayFromTo(context, array, childValues[0], array.Count);
                    break;

                case ArraySlicingType.StartStepSlicing:
                    Node.Value = SliceArrayFromToStep(context, array, childValues[0], array.Count, childValues[1]);
                    break;

                case ArraySlicingType.EndSlicing:
                    Node.Value = SliceArrayFromTo(context, array, 0, childValues[0]);
                    break;

                case ArraySlicingType.EndStepSlicing:
                    Node.Value = SliceArrayFromToStep(context, array, 0, childValues[0], childValues[1]);
                    break;

                case ArraySlicingType.AllStepSlicing:
                    Node.Value = SliceArrayFromToStep(context, array, 0, array.Count, childValues[0]);
                    break;

                default:
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
                if (index < 0)
                    index = array.Count + index;

                if (index >= array.Count)
                {
                    ErrorCollector.AddError(context, ErrorCode.IndexNotCorrect, "The index can't be higher or equal to the length of the array!");
                    return null;
                }
                else if (index < 0)
                {
                    ErrorCollector.AddError(context, ErrorCode.IndexNotCorrect, "The index can't be less than 0!");
                    return null;
                }

                return array[index];
            }

            return indexList.Select(x =>
            {
                int index = Convert.ToInt32(x);
                if (index < 0)
                    index = array.Count + index;

                if (index >= array.Count)
                {
                    ErrorCollector.AddError(context, ErrorCode.IndexNotCorrect, "The index can't be higher or equal to the length of the array!");
                    return null;
                }
                else if (index < 0)
                {
                    ErrorCollector.AddError(context, ErrorCode.IndexNotCorrect, "The index can't be less than 0!");
                    return null;
                }

                return array[index];
            });
        }

        private object SliceArrayFromTo(ParserRuleContext context, List<object> array, object indexStartObj, object indexEndObj)
        {
            var indexStartList = indexStartObj as List<object>;
            var indexEndList = indexEndObj as List<object>;

            if (indexStartList is null && indexEndList is null)
            {
                int indexStart = Convert.ToInt32(indexStartObj);
                int indexEnd = Convert.ToInt32(indexEndObj);
                return GetFromTo(context, array, indexStart, indexEnd);
            }
            else if (indexStartList is null)
            {
                int indexStart = Convert.ToInt32(indexStartObj);
                return indexEndList.Select(indexEndX => (object)GetFromTo(context, array, indexStart, Convert.ToInt32(indexEndX)));
            }
            else if (indexEndList is null)
            {
                int indexEnd = Convert.ToInt32(indexEndObj);
                return indexStartList.Select(indexStartX => (object)GetFromTo(context, array, Convert.ToInt32(indexStartX), indexEnd));
            }
            else if (indexStartList.Count == indexEndList.Count)
            {
                var result = new List<object>(indexEndList.Count);
                for (int i = 0; i < indexEndList.Count; i += 1)
                {
                    int indexStart = Convert.ToInt32(indexStartList[i]);
                    int indexEnd = Convert.ToInt32(indexEndList[i]);
                    result.Add(GetFromTo(context, array, indexStart, indexEnd));
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
                int step = Convert.ToInt32(stepObj);
                return GetFromTo(context, array, indexStart, indexEnd, step);
            }
            else if (indexStartList is null && indexEndList is null)
            {
                int indexStart = Convert.ToInt32(indexStartObj);
                int indexEnd = Convert.ToInt32(indexEndObj);
                return stepList.Select(stepX => (object)GetFromTo(context, array, indexStart, indexEnd, Convert.ToInt32(stepX)));
            }
            else if (indexStartList is null && stepList is null)
            {
                int indexStart = Convert.ToInt32(indexStartObj);
                int step = Convert.ToInt32(stepObj);
                return indexEndList.Select(indexEndX => (object)GetFromTo(context, array, indexStart, Convert.ToInt32(indexEndX), step));
            }
            else if (indexEndList is null && stepList is null)
            {
                int indexEnd = Convert.ToInt32(indexEndObj);
                int step = Convert.ToInt32(stepObj);
                return indexStartList.Select(indexStartX => (object)GetFromTo(context, array, Convert.ToInt32(indexStartX), indexEnd, step));
            }
            else if (indexStartList is null)
            {
                if (indexEndList.Count == stepList.Count)
                {
                    int indexStart = Convert.ToInt32(indexStartObj);
                    var result = new List<object>(indexEndList.Count);
                    for (int i = 0; i < indexEndList.Count; i += 1)
                    {
                        int indexEnd = Convert.ToInt32(indexEndList[i]);
                        int step = Convert.ToInt32(stepList[i]);
                        result.Add((object)GetFromTo(context, array, indexStart, indexEnd, step));
                    }
                    return result;
                }

                ErrorCollector.AddError(context, ErrorCode.NotEqualArayCount, $"Array count must be equal: IndexEnd Array Count {indexEndList.Count} Step Array Count {stepList.Count}");
            }
            else if (indexEndList is null)
            {
                if (indexStartList.Count == stepList.Count)
                {
                    int indexEnd = Convert.ToInt32(indexEndObj);
                    var result = new List<object>(indexStartList.Count);
                    for (int i = 0; i < indexStartList.Count; i += 1)
                    {
                        int indexStart = Convert.ToInt32(indexStartList[i]);
                        int step = Convert.ToInt32(stepList[i]);
                        result.Add((object)GetFromTo(context, array, indexStart, indexEnd, step));
                    }
                    return result;
                }

                ErrorCollector.AddError(context, ErrorCode.NotEqualArayCount, $"Array count must be equal: IndexStart Array Count {indexStartList.Count} Step Array Count {stepList.Count}");
            }
            else if (stepList is null)
            {
                if (indexStartList.Count == indexEndList.Count)
                {
                    int step = Convert.ToInt32(stepObj);
                    var result = new List<object>(indexStartList.Count);
                    for (int i = 0; i < indexStartList.Count; i += 1)
                    {
                        int indexStart = Convert.ToInt32(indexStartList[i]);
                        int indexEnd = Convert.ToInt32(indexEndList[i]);
                        result.Add((object)GetFromTo(context, array, indexStart, indexEnd, step));
                    }
                    return result;
                }

                ErrorCollector.AddError(context, ErrorCode.NotEqualArayCount, $"Array count must be equal: IndexStart Array Count {indexStartList.Count} IndexEnd Array Count {indexEndList.Count}");
            }
            else if (indexStartList.Count == indexEndList.Count && indexStartList.Count == stepList.Count)
            {
                var result = new List<object>(indexStartList.Count);
                for (int i = 0; i < indexStartList.Count; i += 1)
                {
                    int indexStart = Convert.ToInt32(indexStartList[i]);
                    int indexEnd = Convert.ToInt32(indexEndList[i]);
                    int step = Convert.ToInt32(stepList[i]);
                    result.Add((object)GetFromTo(context, array, indexStart, indexEnd, step));
                }
                return result;
            }
            else
                ErrorCollector.AddError(context, ErrorCode.NotEqualArayCount, $"Array count must be equal: IndexStart Array Count {indexStartList.Count} IndexEnd Array Count {indexEndList.Count} Step Array Count {stepList.Count}");

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

            if (startIndex >= list.Count || endIndex > list.Count)
            {
                ErrorCollector.AddError(context, ErrorCode.StartEndIndexNotCorrect, "The startIndex/endIndex can't be higher to the length of the array!");
                return null;
            }
            else if (startIndex < 0 || endIndex < 0)
            {
                ErrorCollector.AddError(context, ErrorCode.StartEndIndexNotCorrect, "The startIndex/endIndex can't be less than 0!");
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