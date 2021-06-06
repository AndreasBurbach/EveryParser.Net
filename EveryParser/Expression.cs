﻿using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EveryParser
{
    public class Expression
    {
        private string _formular;
        private SortedList<string, object> _baseArguments;
        private List<string> _missingArguments;
        private (ErrorCode, string)[] _errorsOfLastCalculation;

        public bool HasErrors => !(_errorsOfLastCalculation is null) && _errorsOfLastCalculation.Any();

        public Expression()
        {
            _baseArguments = new SortedList<string, object>();
            _missingArguments = new List<string>();
            _errorsOfLastCalculation = null;
        }

        public Expression(string formular, bool checkSyntax = true) : this()
        {
            SetFormular(formular, checkSyntax);
        }

        public static object Calculate(string formular)
        {
            return new Expression(formular).Calculate();
        }

        public static bool? CalculateBoolean(string formular)
        {
            return new Expression(formular).CalculateBoolean();
        }

        public static string CalculateString(string formular)
        {
            return new Expression(formular).CalculateString();
        }

        public static decimal? CalculateDecimal(string formular)
        {
            return new Expression(formular).CalculateDecimal();
        }

        public static DateTime? CalculateDateTime(string formular)
        {
            return new Expression(formular).CalculateDateTime();
        }

        public static object[] CalculateArray(string formular)
        {
            return new Expression(formular).CalculateArray();
        }

        #region arguments

        public void AddArgument(string name, string value)
        {
            AddArgument(name, (object)value);
        }

        public void AddArgument(string name, double value)
        {
            AddArgument(name, (object)value);
        }

        public void AddArgument(string name, int value)
        {
            AddArgument(name, (object)value);
        }

        public void AddArgument(string name, decimal value)
        {
            AddArgument(name, (object)value);
        }

        public void AddArgument(string name, float value)
        {
            AddArgument(name, (object)value);
        }

        public void AddArgument(string name, string[] value)
        {
            AddArgument(name, (object)value);
        }

        public void AddArgument(string name, double[] value)
        {
            AddArgument(name, (object)value);
        }

        public void AddArgument(string name, int[] value)
        {
            AddArgument(name, (object)value);
        }

        public void AddArgument(string name, decimal[] value)
        {
            AddArgument(name, (object)value);
        }

        public void AddArgument(string name, float[] value)
        {
            AddArgument(name, (object)value);
        }

        private void AddArgument(string name, object value)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));

            if (_baseArguments.ContainsKey(name))
                _baseArguments[name] = value;
            else
                _baseArguments.Add(name, value);
        }

        public List<string> GetMissingUserDefinedArguments()
        {
            return _missingArguments ?? new List<string>();
        }

        #endregion arguments

        #region Caluclator

        public object Calculate()
        {
            if (string.IsNullOrWhiteSpace(_formular))
                throw new ArgumentNullException();

            return Calculate(_formular, false);
        }

        public object Calculate(string formular, bool checkSyntax = true)
        {
            _errorsOfLastCalculation = null;

            SetFormular(formular, checkSyntax);

            var listener = new EveryGrammarCalculatorListener();
            ParseTreeWalker.Default.Walk(listener, GetParser(formular));

            _errorsOfLastCalculation = listener.ErrorCollector.GetErrors();

            if (listener.ErrorCollector.HasErrors)
                return null;

            return listener.Result;
        }

        public bool? CalculateBoolean()
        {
            if (string.IsNullOrWhiteSpace(_formular))
                throw new ArgumentNullException();

            return CalculateBoolean(_formular, false);
        }

        public bool? CalculateBoolean(string formular, bool checkSyntax = true)
        {
            _errorsOfLastCalculation = null;

            SetFormular(formular, checkSyntax);

            var listener = new EveryGrammarCalculatorListener();
            ParseTreeWalker.Default.Walk(listener, GetParser(formular));

            _errorsOfLastCalculation = listener.ErrorCollector.GetErrors();

            if (listener.ErrorCollector.HasErrors)
                return null;

            return Convert.ToBoolean(listener.Result);
        }

        public string CalculateString()
        {
            if (string.IsNullOrWhiteSpace(_formular))
                throw new ArgumentNullException();

            return CalculateString(_formular, false);
        }

        public string CalculateString(string formular, bool checkSyntax = true)
        {
            _errorsOfLastCalculation = null;

            SetFormular(formular, checkSyntax);

            var listener = new EveryGrammarCalculatorListener();
            ParseTreeWalker.Default.Walk(listener, GetParser(formular));

            _errorsOfLastCalculation = listener.ErrorCollector.GetErrors();

            if (listener.ErrorCollector.HasErrors)
                return null;

            return listener.Result.ToString();
        }

        public decimal? CalculateDecimal()
        {
            if (string.IsNullOrWhiteSpace(_formular))
                throw new ArgumentNullException();

            return CalculateDecimal(_formular, false);
        }

        public decimal? CalculateDecimal(string formular, bool checkSyntax = true)
        {
            _errorsOfLastCalculation = null;

            SetFormular(formular, checkSyntax);

            var listener = new EveryGrammarCalculatorListener();
            ParseTreeWalker.Default.Walk(listener, GetParser(formular));

            _errorsOfLastCalculation = listener.ErrorCollector.GetErrors();

            if (listener.ErrorCollector.HasErrors)
                return null;

            return Convert.ToDecimal(listener.Result);
        }

        public DateTime? CalculateDateTime()
        {
            if (string.IsNullOrWhiteSpace(_formular))
                throw new ArgumentNullException();

            return CalculateDateTime(_formular, false);
        }

        public DateTime? CalculateDateTime(string formular, bool checkSyntax = true)
        {
            _errorsOfLastCalculation = null;

            SetFormular(formular, checkSyntax);

            var listener = new EveryGrammarCalculatorListener();
            ParseTreeWalker.Default.Walk(listener, GetParser(formular));

            _errorsOfLastCalculation = listener.ErrorCollector.GetErrors();

            if (listener.ErrorCollector.HasErrors)
                return null;

            return Convert.ToDateTime(listener.Result);
        }

        public object[] CalculateArray()
        {
            if (string.IsNullOrWhiteSpace(_formular))
                throw new ArgumentNullException();

            return CalculateArray(_formular, false);
        }

        public object[] CalculateArray(string formular, bool checkSyntax = true)
        {
            _errorsOfLastCalculation = null;

            SetFormular(formular, checkSyntax);

            var listener = new EveryGrammarCalculatorListener();
            ParseTreeWalker.Default.Walk(listener, GetParser(formular));

            _errorsOfLastCalculation = listener.ErrorCollector.GetErrors();

            if (listener.ErrorCollector.HasErrors)
                return null;

            return (listener.Result as List<object>)?.ToArray();
        }

        #endregion Caluclator

        public void SetFormular(string formular, bool checkSyntax = true)
        {
            if (string.IsNullOrWhiteSpace(formular))
                throw new ArgumentNullException();

            if (_formular == formular)
                return;

            //if (checkSyntax)
            //    ParseTreeWalker.Default.Walk(new EveryGrammarValidatorListener(), GetParser(formular));

            _formular = formular;
        }

        public (ErrorCode, string)[] GetErrors()
        {
            return _errorsOfLastCalculation.ToArray();//Create new instace with ToArray()
        }

        private static EveryGrammarParser.StartRuleContext GetParser(string formular)
        {
            var stream = CharStreams.fromString(formular);
            //var upper = new CaseChangingCharStream(stream, true); //https://github.com/antlr/antlr4/blob/master/doc/case-insensitive-lexing.md
            var lexer = new EveryGrammarLexer(stream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new EveryGrammarParser(tokens)
            {
                BuildParseTree = true
            };

            return parser.startRule();
        }
    }
}