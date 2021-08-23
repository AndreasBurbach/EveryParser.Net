using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using EveryParser.GrammarListener;
using EveryParser.GrammarListener.ArgumentsListener;
using EveryParser.GrammarListener.CalculatorListener;
using EveryParser.GrammarListener.TypeListener;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EveryParser
{
    public class Expression
    {
        private string _formular;

        private readonly SortedList<string, object> _arguments;
        private (ErrorCode, string)[] _errorsOfLastCalculation;
        private readonly SyntaxErrorListener _syntaxErrorListener;

        public bool HasErrors => !(_errorsOfLastCalculation is null) && _errorsOfLastCalculation.Any();

        /// <summary>
        /// Creates the Expression without a formular
        /// </summary>
        public Expression()
        {
            _arguments = new SortedList<string, object>();
            _errorsOfLastCalculation = null;
            _syntaxErrorListener = new SyntaxErrorListener();
        }

        /// <summary>
        /// Creates the Expression with a formular
        /// </summary>
        /// <param name="formular">Text of the formular</param>
        public Expression(string formular) : this()
        {
            SetFormular(formular);
        }

        #region Static Methods

        /// <summary>
        /// Calculates the formular
        /// </summary>
        /// <returns>object</returns>
        public static object Calculate(string formular) => new Expression(formular).Calculate();

        /// <summary>
        /// Calculates the formular
        /// </summary>
        /// <returns>boolean</returns>
        public static bool? CalculateBoolean(string formular) => new Expression(formular).CalculateBoolean();

        /// <summary>
        /// Calculates the formular
        /// </summary>
        /// <returns>string</returns>
        public static string CalculateString(string formular) => new Expression(formular).CalculateString();

        /// <summary>
        /// Calculates the formular
        /// </summary>
        /// <returns>decimal</returns>
        public static decimal? CalculateDecimal(string formular) => new Expression(formular).CalculateDecimal();

        /// <summary>
        /// Calculates the formular
        /// </summary>
        /// <returns>dateTime</returns>
        public static DateTime? CalculateDateTime(string formular) => new Expression(formular).CalculateDateTime();

        /// <summary>
        /// Calculates the formular
        /// </summary>
        /// <returns>object array</returns>
        public static object[] CalculateArray(string formular) => new Expression(formular).CalculateArray();

        /// <summary>
        /// Returns the names of the variables inside of the formular for the calculation
        /// </summary>
        /// <returns>string array</returns>
        public static string[] GetFormularArgumentNames(string formular) => new Expression(formular).GetFormularArgumentNames();

        /// <summary>
        /// Returns the possible type of the result of the formular, e.g. string, number, etc.
        /// </summary>
        /// <returns>Type of result</returns>
        public static EveryParserType GetPossibleResultingType(string formular) => new Expression(formular).GetPossibleResultingType();

        #endregion Static Methods

        #region arguments

        /// <summary>
        /// Adds a string as an argument for the calculation
        /// </summary>
        /// <param name="name">Name of the argument</param>
        /// <param name="value">Value of the Argument</param>
        public void AddArgument(string name, string value)
        {
            AddArgument(name, (object)value);
        }

        /// <summary>
        /// Adds a double as an argument for the calculation
        /// </summary>
        /// <param name="name">Name of the argument</param>
        /// <param name="value">Value of the Argument</param>
        public void AddArgument(string name, double value)
        {
            AddArgument(name, (object)value);
        }

        /// <summary>
        /// Adds a int as an argument for the calculation
        /// </summary>
        /// <param name="name">Name of the argument</param>
        /// <param name="value">Value of the Argument</param>
        public void AddArgument(string name, int value)
        {
            AddArgument(name, (object)value);
        }

        /// <summary>
        /// Adds a decimal as an argument for the calculation
        /// </summary>
        /// <param name="name">Name of the argument</param>
        /// <param name="value">Value of the Argument</param>
        public void AddArgument(string name, decimal value)
        {
            AddArgument(name, (object)value);
        }

        /// <summary>
        /// Adds a float as an argument for the calculation
        /// </summary>
        /// <param name="name">Name of the argument</param>
        /// <param name="value">Value of the Argument</param>
        public void AddArgument(string name, float value)
        {
            AddArgument(name, (object)value);
        }

        /// <summary>
        /// Adds a string array as an argument for the calculation
        /// </summary>
        /// <param name="name">Name of the argument</param>
        /// <param name="value">Value of the Argument</param>
        public void AddArgument(string name, string[] value)
        {
            AddArgument(name, (object)value);
        }

        /// <summary>
        /// Adds a double array as an argument for the calculation
        /// </summary>
        /// <param name="name">Name of the argument</param>
        /// <param name="value">Value of the Argument</param>
        public void AddArgument(string name, double[] value)
        {
            AddArgument(name, (object)value);
        }

        /// <summary>
        /// Adds a int array as an argument for the calculation
        /// </summary>
        /// <param name="name">Name of the argument</param>
        /// <param name="value">Value of the Argument</param>
        public void AddArgument(string name, int[] value)
        {
            AddArgument(name, (object)value);
        }

        /// <summary>
        /// Adds a decimal array as an argument for the calculation
        /// </summary>
        /// <param name="name">Name of the argument</param>
        /// <param name="value">Value of the Argument</param>
        public void AddArgument(string name, decimal[] value)
        {
            AddArgument(name, (object)value);
        }

        /// <summary>
        /// Adds a float array as an argument for the calculation
        /// </summary>
        /// <param name="name">Name of the argument</param>
        /// <param name="value">Value of the Argument</param>
        public void AddArgument(string name, float[] value)
        {
            AddArgument(name, (object)value);
        }

        /// <summary>
        /// Add an array of arguments for the calculation
        /// </summary>
        /// <param name="names">Names of the arguments</param>
        /// <param name="values">Values of the arguments</param>
        public void AddArgumentRange(string[] names, object[] values)
        {
            if (names.Length != values.Length)
                throw new ArgumentException("Arrays must have the same size!");

            for (int i = 0; i < names.Length; i += 1)
                AddArgument(names[i], values[i]);
        }

        /// <summary>
        /// Adds a object as an argument for the calculation
        /// </summary>
        /// <param name="name">Name of the argument</param>
        /// <param name="value">Value of the Argument</param>
        public void AddArgument(string name, object value)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));

            if (value is null)
                throw new ArgumentNullException(nameof(value));

            if (_arguments.ContainsKey(name))
                _arguments[name] = value;
            else
                _arguments.Add(name, value);
        }

        /// <summary>
        /// Removes a specific argument for the calculation
        /// </summary>
        /// <param name="name">Name of Argument</param>
        public void RemoveArgument(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));

            if (_arguments.ContainsKey(name))
                _arguments.Remove(name);
        }

        /// <summary>
        /// Removed everythin inside the Arguments for the calculation
        /// </summary>
        public void ClearArguments() => _arguments.Clear();

        /// <summary>
        /// Returns all names of the added Arguments
        /// </summary>
        /// <returns>Array of strings</returns>
        public string[] GetAddedArguments() => _arguments.Keys.ToArray();

        /// <summary>
        /// Returns the names of the variables inside of the formular for the calculation
        /// </summary>
        /// <returns>string array</returns>
        public string[] GetFormularArgumentNames()
        {
            var listener = new EveryGrammarArgumentsListener();
            ParseTreeWalker.Default.Walk(listener, GetParser(_formular));

            return listener.Arguments;
        }

        #endregion arguments

        #region Caluclator

        /// <summary>
        /// Calculates the setted formular
        /// </summary>
        /// <returns>object</returns>
        public object Calculate()
        {
            var result = CalculateFormular();

            if (HasErrors)
                return null;

            return result;
        }

        /// <summary>
        /// Calculates the setted formular
        /// </summary>
        /// <returns>boolean</returns>
        public bool? CalculateBoolean()
        {
            var result = CalculateFormular();

            if (HasErrors)
                return null;

            return Convert.ToBoolean(result);
        }

        /// <summary>
        /// Calculates the setted formular
        /// </summary>
        /// <returns>string</returns>
        public string CalculateString()
        {
            var result = CalculateFormular();

            if (HasErrors)
                return null;

            return result.ToString();
        }

        /// <summary>
        /// Calculates the setted formular
        /// </summary>
        /// <returns>decimal</returns>
        public decimal? CalculateDecimal()
        {
            var result = CalculateFormular();

            if (HasErrors)
                return null;

            return Convert.ToDecimal(result);
        }

        /// <summary>
        /// Calculates the setted formular
        /// </summary>
        /// <returns>dateTime</returns>
        public DateTime? CalculateDateTime()
        {
            var result = CalculateFormular();

            if (HasErrors)
                return null;

            return Convert.ToDateTime(result);
        }

        /// <summary>
        /// Calculates the setted formular
        /// </summary>
        /// <returns>object array</returns>
        public object[] CalculateArray()
        {
            var result = CalculateFormular();

            if (HasErrors)
                return null;

            return (result as List<object>)?.ToArray();
        }

        /// <summary>
        /// Calculate
        /// </summary>
        /// <returns>object</returns>
        private object CalculateFormular()
        {
            CheckFormular();

            _errorsOfLastCalculation = null;

            var listener = new EveryGrammarCalculatorListener(_arguments);
            ParseTreeWalker.Default.Walk(listener, GetParser(_formular));

            var errors = new List<(ErrorCode, string)>(_syntaxErrorListener.GetErrors());
            errors.AddRange(listener.ErrorCollector.GetErrors());
            _errorsOfLastCalculation = errors.ToArray();

            return listener.Result;
        }

        #endregion Caluclator

        /// <summary>
        /// Returns the possible type of the result of the formular, e.g. string, number, etc.
        /// </summary>
        /// <returns>Type of result</returns>
        public EveryParserType GetPossibleResultingType()
        {
            CheckFormular();

            _errorsOfLastCalculation = null;

            var listener = new EveryGrammarTypeListener(_arguments);
            ParseTreeWalker.Default.Walk(listener, GetParser(_formular));

            _errorsOfLastCalculation = listener.ErrorCollector.GetErrors();

            return listener.Result;
        }

        /// <summary>
        /// Set the formular for the expression
        /// </summary>
        /// <param name="formular">Text of the formular</param>
        public void SetFormular(string formular)
        {
            if (string.IsNullOrWhiteSpace(formular))
                throw new ArgumentNullException(nameof(formular));

            if (_formular == formular)
                return;

            _formular = formular;
        }

        /// <summary>
        /// Errors from the last calculation
        /// </summary>
        public (ErrorCode, string)[] CalculationErrors => _errorsOfLastCalculation.ToArray();

        /// <summary>
        /// Is the formular already set?
        /// </summary>
        /// <returns>True if the formular was set</returns>
        public bool HasFormular() => !string.IsNullOrWhiteSpace(_formular);

        private EveryGrammarParser.StartRuleContext GetParser(string formular)
        {
            _syntaxErrorListener.ClearErrors();

            var stream = CharStreams.fromString(formular);
            //var upper = new CaseChangingCharStream(stream, true); //https://github.com/antlr/antlr4/blob/master/doc/case-insensitive-lexing.md

            var lexer = new EveryGrammarLexer(stream);
            lexer.RemoveErrorListeners();

            var tokens = new CommonTokenStream(lexer);

            var parser = new EveryGrammarParser(tokens)
            {
                BuildParseTree = true
            };

            parser.RemoveErrorListeners();
            parser.AddErrorListener(_syntaxErrorListener);

            return parser.startRule();
        }

        private void CheckFormular()
        {
            if (!HasFormular())
                throw new ArgumentNullException(nameof(_formular));
        }
    }
}