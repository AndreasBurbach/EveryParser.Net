using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using EveryParser.LinQReplaces;
using System;
using System.Collections.Generic;

namespace EveryParser.CalculatorListener
{
    public partial class EveryGrammarCalculatorListener
    {
        /// <summary>
        /// Enter a parse tree produced by the <c>ArraySlicing_Indexing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArraySlicing_Indexing([NotNull] EveryGrammarParser.ArraySlicing_IndexingContext context)
        {
            Node.ChildCaluclationName = "ArraySlicing_Indexing";
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>ArraySlicing_Slicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArraySlicing_Slicing([NotNull] EveryGrammarParser.ArraySlicing_SlicingContext context)
        {
            Node.ChildCaluclationName = "ArraySlicing_Slicing";
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>ArraySlicing_StepSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArraySlicing_StepSlicing([NotNull] EveryGrammarParser.ArraySlicing_StepSlicingContext context)
        {
            Node.ChildCaluclationName = "ArraySlicing_StepSlicing";
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>ArraySlicing_StartSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArraySlicing_StartSlicing([NotNull] EveryGrammarParser.ArraySlicing_StartSlicingContext context)
        {
            Node.ChildCaluclationName = "ArraySlicing_StartSlicing";
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>ArraySlicing_StartStepSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArraySlicing_StartStepSlicing([NotNull] EveryGrammarParser.ArraySlicing_StartStepSlicingContext context)
        {
            Node.ChildCaluclationName = "ArraySlicing_StartStepSlicing";
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>ArraySlicing_EndSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArraySlicing_EndSlicing([NotNull] EveryGrammarParser.ArraySlicing_EndSlicingContext context)
        {
            Node.ChildCaluclationName = "ArraySlicing_EndSlicing";
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>ArraySlicing_EndStepSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArraySlicing_EndStepSlicing([NotNull] EveryGrammarParser.ArraySlicing_EndStepSlicingContext context)
        {
            Node.ChildCaluclationName = "ArraySlicing_EndStepSlicing";
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>ArraySlicing_AllStepSlicing</c>
        /// labeled alternative in <see cref="EveryGrammarParser.array_slicing_term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterArraySlicing_AllStepSlicing([NotNull] EveryGrammarParser.ArraySlicing_AllStepSlicingContext context)
        {
            Node.ChildCaluclationName = "ArraySlicing_AllStepSlicing";
        }

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

            if (childValues.Length < 2 || childValues.Length > 4)
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

                array = new List<object>(Array.ConvertAll(text.ToCharArray(), x => (object)x));
            }

            switch (Node.ChildCaluclationName)
            {
                case "ArraySlicing_Indexing":
                    if (childValues.Length < 2 || childValues.Length > 2)
                    {
                        ErrorCollector.AddError(context, ErrorCode.ArraySlicingNotCorrect, "The parameter count for slicing the array (ArraySlicing_Indexing) is not correct!");
                        Node.Value = null;
                        Node = Node.Parent;
                        return;
                    }

                    Node.Value = SliceArray(context, array, childValues[1]);
                    break;

                case "ArraySlicing_Slicing":
                    if (childValues.Length != 3)
                    {
                        ErrorCollector.AddError(context, ErrorCode.ArraySlicingNotCorrect, "The parameter count for slicing the array (ArraySlicing_Slicing) is not correct!");
                        Node.Value = null;
                        Node = Node.Parent;
                        return;
                    }

                    Node.Value = SliceArrayFromTo(context, array, childValues[1], childValues[2]);
                    break;

                case "ArraySlicing_StepSlicing":
                    if (childValues.Length != 4)
                    {
                        ErrorCollector.AddError(context, ErrorCode.ArraySlicingNotCorrect, "The parameter count for slicing the array (ArraySlicing_StepSlicing) is not correct!");
                        Node.Value = null;
                        Node = Node.Parent;
                        return;
                    }

                    Node.Value = SliceArrayFromToStep(context, array, childValues[1], childValues[2], childValues[3]);
                    break;

                case "ArraySlicing_StartSlicing":
                    if (childValues.Length != 2)
                    {
                        ErrorCollector.AddError(context, ErrorCode.ArraySlicingNotCorrect, "The parameter count for slicing the array (ArraySlicing_StartSlicing) is not correct!");
                        Node.Value = null;
                        Node = Node.Parent;
                        return;
                    }
                    Node.Value = SliceArrayFromTo(context, array, childValues[1], array.Count);
                    break;

                case "ArraySlicing_StartStepSlicing":
                    if (childValues.Length != 3)
                    {
                        ErrorCollector.AddError(context, ErrorCode.ArraySlicingNotCorrect, "The parameter count for slicing the array (ArraySlicing_StartStepSlicing) is not correct!");
                        Node.Value = null;
                        Node = Node.Parent;
                        return;
                    }
                    Node.Value = SliceArrayFromToStep(context, array, childValues[1], array.Count, childValues[2]);
                    break;

                case "ArraySlicing_EndSlicing":
                    if (childValues.Length != 2)
                    {
                        ErrorCollector.AddError(context, ErrorCode.ArraySlicingNotCorrect, "The parameter count for slicing the array (ArraySlicing_EndSlicing) is not correct!");
                        Node.Value = null;
                        Node = Node.Parent;
                        return;
                    }

                    Node.Value = SliceArrayFromTo(context, array, 0, childValues[1]);
                    break;

                case "ArraySlicing_EndStepSlicing":
                    if (childValues.Length != 3)
                    {
                        ErrorCollector.AddError(context, ErrorCode.ArraySlicingNotCorrect, "The parameter count for slicing the array (ArraySlicing_EndStepSlicing) is not correct!");
                        Node.Value = null;
                        Node = Node.Parent;
                        return;
                    }

                    Node.Value = SliceArrayFromToStep(context, array, 0, childValues[1], childValues[2]);
                    break;

                case "ArraySlicing_AllStepSlicing":
                    if (childValues.Length != 2)
                    {
                        ErrorCollector.AddError(context, ErrorCode.ArraySlicingNotCorrect, "The parameter count for slicing the array (ArraySlicing_AllStepSlicing) is not correct!");
                        Node.Value = null;
                        Node = Node.Parent;
                        return;
                    }

                    Node.Value = SliceArrayFromToStep(context, array, 0, array.Count, childValues[1]);
                    break;

                default:
                    break;
            }

            switch (childValues.Length)
            {
                case 2:
                    break;

                case 3:
                    break;

                case 4:
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