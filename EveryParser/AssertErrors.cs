using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EveryParser
{
    /// <summary>
    /// ErrorCodes for the EveryParser
    /// </summary>
    public enum ErrorCode
    {
        IsNull,
        IsNotNumber,
        IsNotBoolean,
        IsTypeDifferent,
        ParamsCountNotCorrect,
        NoParameter,
        TypeConversion
    }

    public class AssertErrors
    {
        private readonly List<(ErrorCode, string)> _errors;

        /// <summary>
        /// Count of Errors
        /// </summary>
        public int ErrorCount => _errors.Count;

        /// <summary>
        /// Are there any errors collected?
        /// </summary>
        public bool HasErrors => _errors.Count > 0;

        public AssertErrors()
        {
            _errors = new List<(ErrorCode, string)>();
        }

        /// <summary>
        /// Get all errors
        /// </summary>
        /// <returns>Array of errocodes and the error messages</returns>
        public (ErrorCode, string)[] GetErrors() => _errors.ToArray();

        /// <summary>
        /// Check if one of the parameters is null
        /// </summary>
        /// <param name="context">Context for line recognition</param>
        /// <param name="childs">All childs which are commited to the calculation</param>
        /// <returns>true if one parameters is null</returns>
        public bool CheckIsNull(ParserRuleContext context, params object[] childs)
        {
            foreach (var child in childs)
                if (child is null)
                {
                    _errors.Add((ErrorCode.IsNull, $"One or more values are null {context.Start.Line}:{context.Start.StartIndex}, {context.Stop.Line}:{context.Stop.StartIndex}"));
                    return true;
                }

            return false;
        }

        /// <summary>
        /// Check if all parameters are type of numbers (int, long, double, decimal)
        /// </summary>
        /// <param name="context">Context for line recognition</param>
        /// <param name="childs">All childs which are commited to the calculation</param>
        /// <returns>true if types are numbers (int, long, double, decimal)</returns>
        public bool CheckIsNumber(ParserRuleContext context, params object[] childs)
        {
            foreach (var child in childs)
                if (!(child is int || child is long || child is double || child is decimal))
                {
                    _errors.Add((ErrorCode.IsNotNumber, $"One or more values are not numbers {context.Start.Line}:{context.Start.StartIndex}, {context.Stop.Line}:{context.Stop.StartIndex}"));
                    return false;
                }

            return true;
        }

        /// <summary>
        /// Check if all parameters are type of boolean
        /// </summary>
        /// <param name="context">Context for line recognition</param>
        /// <param name="childs">All childs which are commited to the calculation</param>
        /// <returns>true if types are boolean</returns>
        public bool CheckIsBoolean(ParserRuleContext context, params object[] childs)
        {
            foreach (var child in childs)
                if (bool.TryParse(child.ToString(), out _))
                {
                    _errors.Add((ErrorCode.IsNotBoolean, $"One or more values are not boolean {context.Start.Line}:{context.Start.StartIndex}, {context.Stop.Line}:{context.Stop.StartIndex}"));
                    return false;
                }

            return true;
        }

        /// <summary>
        /// Check if a pair of params has not the same type for the calculation
        /// </summary>
        /// <param name="context">Context for line recognition</param>
        /// <param name="childs">All childs which are commited to the calculation</param>
        /// <returns>true if types differ</returns>
        public bool CheckIsTypeDifferent(ParserRuleContext context, params object[] childs)
        {
            for (int i = 0; i < childs.Length; i += 1)
            {
                var child1Value = childs[i];

                for (int k = 0; k < childs.Length; k += 1)
                {
                    var child2Value = childs[k];

                    if (!CheckIsNumber(context, child1Value, child2Value) || !CheckIsBoolean(context, child1Value, child2Value))
                        return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if the count of child params it same as the params count which is need for a calculation
        /// </summary>
        /// <param name="context">Context for line recognition</param>
        /// <param name="paramsCount">The count of parameters the calculation needs </param>
        /// <param name="childs">All childs which are commited to the calculation</param>
        /// <returns>true if count is correct</returns>
        public bool CheckParamsCount(ParserRuleContext context, int paramsCount, params object[] childs)
        {
            if (childs.Length != paramsCount)
            {
                _errors.Add((ErrorCode.ParamsCountNotCorrect, $"No {paramsCount} {(paramsCount == 1 ? "value" : "values")} {context.Start.Line}:{context.Start.StartIndex}, {context.Stop.Line}:{context.Stop.StartIndex}"));
                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks if the calculation got parameters to calculate
        /// </summary>
        /// <param name="context">Context for line recognition</param>
        /// <param name="childs">All childs which are commited to the calculation</param>
        /// <returns>true if there is a parameter</returns>
        public bool CheckHasParams(ParserRuleContext context, params object[] childs)
        {
            if (childs is null || !childs.Any())
            {
                _errors.Add((ErrorCode.NoParameter, $"No Parameter was commited to the calculation {context.Start.Line}:{context.Start.StartIndex}, {context.Stop.Line}:{context.Stop.StartIndex}"));
                return false;
            }

            return true;
        }

        public void AddTypeConversionError(ParserRuleContext context, string text, Type targetedType)
        {
            _errors.Add((ErrorCode.TypeConversion, $"Could not convert { text}  to type of {targetedType.Name}  {context.Start.Line}:{context.Start.StartIndex}, {context.Stop.Line}:{context.Stop.StartIndex}"));
        }
    }
}