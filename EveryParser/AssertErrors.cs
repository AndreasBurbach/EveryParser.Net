﻿using Antlr4.Runtime;
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
        IsNotNumberOrArrayOfNumbers,
        IsNotBoolean,
        IsTypeDifferent,
        IsNotString,
        ParamsCountNotCorrect,
        NoParameter,
        TypeConversion,
        NoArguments,
        VariableNotInArguments,
        NotEqualArayCount,
        SecondParamIsNotArray,
        IsNotArray,
        IsNotDateTime,
        IsNotNumberArray,
        FirstNotNumberArray,
        SecondNotNumber,
        IsNotStringOrArray,
        CanBeEitherStringOrList,
        ThridNotNumber,
        ForthNotNumber,
        ArraySlicingNotCorrect,
        FirstIsNotArray,
        FirstIsNotNumberOrNumberArray,
        SecondIsNotNumberOrNumberArray,
        StepNotCorrect,
        StartEndIndexNotCorrect
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
        /// <param name="childs">All childs which are comitted to the calculation</param>
        /// <returns>true if one parameters is null</returns>
        public bool CheckIsNull(ParserRuleContext context, params object[] childs)
        {
            if (TypeCheckHelper.IsOneOfNull(childs))
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
        /// <param name="childs">All childs which are comitted to the calculation</param>
        /// <returns>true if types are numbers (int, long, double, decimal)</returns>
        public bool CheckIsNumber(ParserRuleContext context, params object[] childs)
        {
            if (!TypeCheckHelper.IsArrayOfNumber(childs))
            {
                _errors.Add((ErrorCode.IsNotNumber, $"One or more values are not numbers {context.Start.Line}:{context.Start.StartIndex}, {context.Stop.Line}:{context.Stop.StartIndex}"));
                return false;
            }

            return true;
        }

        /// <summary>
        /// Check if all parameters are type of numbers (int, long, double, decimal) or an array of numbers
        /// </summary>
        /// <param name="context">Context for line recognition</param>
        /// <param name="childs">All childs which are comitted to the calculation</param>
        /// <returns>true if types are numbers (int, long, double, decimal)</returns>
        public bool CheckIsNumberOrArrayOfNumbers(ParserRuleContext context, params object[] childs)
        {
            if (!TypeCheckHelper.IsArrayOfNumberOrNumberList(childs))
            {
                _errors.Add((ErrorCode.IsNotNumber, $"One or more values are not numbers or array of numbers {context.Start.Line}:{context.Start.StartIndex}, {context.Stop.Line}:{context.Stop.StartIndex}"));
                return false;
            }

            return true;
        }

        /// <summary>
        /// Check if all parameters are type of  array with numbers (int, long, double, decimal)
        /// </summary>
        /// <param name="context">Context for line recognition</param>
        /// <param name="childs">All childs which are comitted to the calculation</param>
        /// <returns>true if types are array pf numbers (int, long, double, decimal)</returns>
        public bool CheckIsListOfNumbers(ParserRuleContext context, params object[] childs)
        {
            if (!TypeCheckHelper.IsArrayOfNumberList(childs))
            {
                _errors.Add((ErrorCode.IsNotNumberArray, $"One or more values are not array of numbers {context.Start.Line}:{context.Start.StartIndex}, {context.Stop.Line}:{context.Stop.StartIndex}"));
                return false;
            }

            return true;
        }

        /// <summary>
        /// Check if all parameters are type of string or an array of string
        /// </summary>
        /// <param name="context">Context for line recognition</param>
        /// <param name="childs">All childs which are comitted to the calculation</param>
        /// <returns>true if types are numbers (int, long, double, decimal)</returns>
        public bool CheckIsStringOrListOfStrings(ParserRuleContext context, params object[] childs)
        {
            if (!TypeCheckHelper.IsStringOrStringList(childs))
            {
                _errors.Add((ErrorCode.IsNotString, $"One or more values are not string or array of strings {context.Start.Line}:{context.Start.StartIndex}, {context.Stop.Line}:{context.Stop.StartIndex}"));
                return false;
            }

            return true;
        }

        /// <summary>
        /// Check if all parameters are type of boolean
        /// </summary>
        /// <param name="context">Context for line recognition</param>
        /// <param name="childs">All childs which are comitted to the calculation</param>
        /// <returns>true if types are boolean</returns>
        public bool CheckIsBoolean(ParserRuleContext context, params object[] childs)
        {
            if (!TypeCheckHelper.IsArrayOfBoolean(childs))
            {
                _errors.Add((ErrorCode.IsNotBoolean, $"One or more values are not boolean {context.Start.Line}:{context.Start.StartIndex}, {context.Stop.Line}:{context.Stop.StartIndex}"));
                return false;
            }

            return true;
        }

        /// <summary>
        /// Check if all parameters are type of List(object)
        /// </summary>
        /// <param name="context">Context for line recognition</param>
        /// <param name="childs">All childs which are comitted to the calculation</param>
        /// <returns>true if types are boolean</returns>
        public bool CheckIsList(ParserRuleContext context, params object[] childs)
        {
            if (!TypeCheckHelper.IsArrayOfObjectList(childs))
            {
                _errors.Add((ErrorCode.IsNotArray, $"One or more values are not an array {context.Start.Line}:{context.Start.StartIndex}, {context.Stop.Line}:{context.Stop.StartIndex}"));
                return false;
            }

            return true;
        }

        /// <summary>
        /// Check if all parameters are type of string or List(obect)
        /// </summary>
        /// <param name="context"></param>
        /// <param name="childs"></param>
        /// <returns></returns>
        public bool CheckIsStringOrList(ParserRuleContext context, params object[] childs)
        {
            if (!TypeCheckHelper.IsStringOrList(childs))
            {
                _errors.Add((ErrorCode.IsNotStringOrArray, $"One or more values are not a string or array {context.Start.Line}:{context.Start.StartIndex}, {context.Stop.Line}:{context.Stop.StartIndex}"));
                return false;
            }

            return true;
        }

        /// <summary>
        /// Check if a pair of params has not the same type for the calculation
        /// </summary>
        /// <param name="context">Context for line recognition</param>
        /// <param name="childs">All childs which are comitted to the calculation</param>
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
        /// Check if all parameters are type of DateTime
        /// </summary>
        /// <param name="context">Context for line recognition</param>
        /// <param name="childs">All childs which are comitted to the calculation</param>
        /// <returns>true if types are numbers (int, long, double, decimal)</returns>
        public bool CheckIsDateTime(ParserRuleContext context, params object[] childs)
        {
            foreach (var child in childs)
                if (!(child is DateTime))
                {
                    _errors.Add((ErrorCode.IsNotDateTime, $"One or more values are not numbers {context.Start.Line}:{context.Start.StartIndex}, {context.Stop.Line}:{context.Stop.StartIndex}"));
                    return false;
                }

            return true;
        }

        /// <summary>
        /// Checks if the count of child params is same as the params count which is need for a calculation
        /// </summary>
        /// <param name="context">Context for line recognition</param>
        /// <param name="paramsCount">The count of parameters the calculation needs </param>
        /// <param name="childs">All childs which are comitted to the calculation</param>
        /// <returns>true if count is correct</returns>
        public bool CheckParamsCount(ParserRuleContext context, int paramsCount, params object[] childs)
        {
            if ((childs?.Length ?? 0) != paramsCount)
            {
                _errors.Add((ErrorCode.ParamsCountNotCorrect, $"No {paramsCount} {(paramsCount == 1 ? "value" : "values")} {context.Start.Line}:{context.Start.StartIndex}, {context.Stop.Line}:{context.Stop.StartIndex}"));
                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks if the count of child params is greater or equal the params count which is need for a calculation
        /// </summary>
        /// <param name="context">Context for line recognition</param>
        /// <param name="paramsCount">The minimal count of parameters the calculation needs </param>
        /// <param name="childs">All childs which are comitted to the calculation</param>
        /// <returns>true if count is correct</returns>
        public bool CheckParamsCountGreaterEqual(ParserRuleContext context, int paramsCount, params object[] childs)
        {
            if ((childs?.Length ?? 0) < paramsCount)
            {
                _errors.Add((ErrorCode.ParamsCountNotCorrect, $"No {paramsCount} {(paramsCount == 1 ? "value" : "values")} or greater {context.Start.Line}:{context.Start.StartIndex}, {context.Stop.Line}:{context.Stop.StartIndex}"));
                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks if the count of child params is lower or equal the params count which is need for a calculation
        /// </summary>
        /// <param name="context">Context for line recognition</param>
        /// <param name="paramsCount">The maximal count of parameters the calculation needs </param>
        /// <param name="childs">All childs which are comitted to the calculation</param>
        /// <returns>true if count is correct</returns>
        public bool CheckParamsCountLowerEqual(ParserRuleContext context, int paramsCount, params object[] childs)
        {
            var childsCount = childs?.Length ?? 0;
            if (childsCount > paramsCount)
            {
                _errors.Add((ErrorCode.ParamsCountNotCorrect, $"Too many values. Accepted {paramsCount}, but has {childsCount} {context.Start.Line}:{context.Start.StartIndex}, {context.Stop.Line}:{context.Stop.StartIndex}"));
                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks if the calculation got parameters to calculate
        /// </summary>
        /// <param name="context">Context for line recognition</param>
        /// <param name="childs">All childs which are comitted to the calculation</param>
        /// <returns>true if there is a parameter</returns>
        public bool CheckHasParams(ParserRuleContext context, params object[] childs)
        {
            if (childs is null || !childs.Any() || childs[0] is null)
            {
                _errors.Add((ErrorCode.NoParameter, $"No Parameter was comitted to the calculation {context.Start.Line}:{context.Start.StartIndex}, {context.Stop.Line}:{context.Stop.StartIndex}"));
                return false;
            }

            return true;
        }

        /// <summary>
        /// Check if the user has add some arguments which are now needed!
        /// </summary>
        /// <param name="context">Context for line recognition</param>
        /// <param name="arguments">All arguments which are given</param>
        /// <returns>true if there are arguments</returns>
        public bool CheckHasArguments(ParserRuleContext context, SortedList<string, object> arguments)
        {
            if (arguments is null || !arguments.Any())
            {
                _errors.Add((ErrorCode.NoArguments, $"No Arguments was given for the calculation {context.Start.Line}:{context.Start.StartIndex}, {context.Stop.Line}:{context.Stop.StartIndex}"));
                return false;
            }

            return true;
        }

        /// <summary>
        /// Get the argument object of the variable if the arguments has it inside
        /// </summary>
        /// <param name="context">Context for line recognition</param>
        /// <param name="arguments">All arguments which are given</param>
        /// <param name="variable">Variable which is searched</param>
        /// <returns>returns the object for the variable if found otherwise null</returns>
        public object GetCheckedArgument(ParserRuleContext context, SortedList<string, object> arguments, string variable)
        {
            if (!CheckHasArguments(context, arguments))
                return null;

            if (!arguments.TryGetValue(variable, out var value))
            {
                _errors.Add((ErrorCode.VariableNotInArguments, $"Variable {variable} was not committed for the calculation {context.Start.Line}:{context.Start.StartIndex}, {context.Stop.Line}:{context.Stop.StartIndex}"));
                return null;
            }

            return value;
        }

        /// <summary>
        /// Get the argument object with the internal object of the variable if the arguments has it inside
        /// </summary>
        /// <param name="context">Context for line recognition</param>
        /// <param name="arguments">All arguments which are given</param>
        /// <param name="variable">Variable which is searched</param>
        /// <returns>returns the object for the variable if found otherwise null</returns>
        public object GetCheckedObjectArgument(ParserRuleContext context, SortedList<string, object> arguments, string variable)
        {
            if (!CheckHasArguments(context, arguments))
                return null;

            var variableNames = variable.Split('.');

            if (!arguments.TryGetValue(variableNames[0], out var value))
            {
                _errors.Add((ErrorCode.VariableNotInArguments, $"Variable {variable} was not committed for the calculation {context.Start.Line}:{context.Start.StartIndex}, {context.Stop.Line}:{context.Stop.StartIndex}"));
                return null;
            }

            try
            {
                for (int i = 0; i < variableNames.Length; i += 1)
                {
                    string variableName = variableNames[i];

                    var property = value.GetType().GetProperty(variableName);

                    if (property is null)
                    {
                        _errors.Add((ErrorCode.VariableNotInArguments, $"Variable {variable} was not found inside the base object {variableNames[0]} {context.Start.Line}:{context.Start.StartIndex}, {context.Stop.Line}:{context.Stop.StartIndex}"));
                        return null;
                    }

                    value = property.GetValue(value);
                }
            }
            catch
            {
                _errors.Add((ErrorCode.VariableNotInArguments, $"Variable {variable} was not found inside the base object {variableNames[0]} {context.Start.Line}:{context.Start.StartIndex}, {context.Stop.Line}:{context.Stop.StartIndex}"));
                return null;
            }

            return value;
        }

        /// <summary>
        /// Adds an error text for a failed conversation to a specific type
        /// </summary>
        /// <param name="context">Context for line recognition</param>
        /// <param name="text">Text to convert to a type</param>
        /// <param name="targetedType">Type the text should be converted to</param>
        public void AddTypeConversionError(ParserRuleContext context, string text, Type targetedType)
        {
            _errors.Add((ErrorCode.TypeConversion, $"Could not convert { text}  to type of {targetedType.Name}  {context.Start.Line}:{context.Start.StartIndex}, {context.Stop.Line}:{context.Stop.StartIndex}"));
        }

        /// <summary>
        /// Adds an error text
        /// </summary>
        /// <param name="context">Context for line recognition</param>
        /// <param name="errorCode">ErrorCode of error</param>
        /// <param name="text">Text to convert to a type</param>
        public void AddError(ParserRuleContext context, ErrorCode errorCode, string text)
        {
            _errors.Add((errorCode, $"{text} {context.Start.Line}:{context.Start.StartIndex}, {context.Stop.Line}:{context.Stop.StartIndex}"));
        }
    }
}