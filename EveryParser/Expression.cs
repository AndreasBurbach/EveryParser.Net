using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;

namespace EveryParser
{
    public class Expression
    {
        private string _formular;
        private List<BaseArgument> _baseArguments;

        public Expression()
        { }

        public Expression(string formular, bool checkSyntax = true)
        {
            SetFormular(formular, checkSyntax);
        }

        public void AddArgument(params BaseArgument[] arguments)
        {
            _baseArguments.AddRange(arguments);
        }

        public object Calculate()
        {
            if (string.IsNullOrWhiteSpace(_formular))
                throw new ArgumentNullException();

            return Calculate(_formular, false);
        }

        public object Calculate(string formular, bool checkSyntax = true)
        {
            SetFormular(formular, checkSyntax);

            var listener = new EveryGrammarCalculatorListener();
            ParseTreeWalker.Default.Walk(listener, GetParser(formular));

            return null;
        }

        public bool CalculateBoolean()
        {
            if (string.IsNullOrWhiteSpace(_formular))
                throw new ArgumentNullException();

            return CalculateBoolean(_formular, false);
        }

        public bool CalculateBoolean(string formular, bool checkSyntax = true)
        {
            SetFormular(formular, checkSyntax);

            var listener = new EveryGrammarCalculatorListener();
            ParseTreeWalker.Default.Walk(listener, GetParser(formular));

            return false;
        }

        public string CalculateString()
        {
            if (string.IsNullOrWhiteSpace(_formular))
                throw new ArgumentNullException();

            return CalculateString(_formular, false);
        }

        public string CalculateString(string formular, bool checkSyntax = true)
        {
            SetFormular(formular, checkSyntax);

            var listener = new EveryGrammarCalculatorListener();
            ParseTreeWalker.Default.Walk(listener, GetParser(formular));

            return null;
        }

        public decimal CalculateDecimal()
        {
            if (string.IsNullOrWhiteSpace(_formular))
                throw new ArgumentNullException();

            return CalculateDecimal(_formular, false);
        }

        public decimal CalculateDecimal(string formular, bool checkSyntax = true)
        {
            SetFormular(formular, checkSyntax);

            var listener = new EveryGrammarCalculatorListener();
            ParseTreeWalker.Default.Walk(listener, GetParser(formular));

            return 0.0m;
        }

        public void SetFormular(string formular, bool checkSyntax = true)
        {
            if (string.IsNullOrWhiteSpace(formular))
                throw new ArgumentNullException();

            if (checkSyntax)
                ParseTreeWalker.Default.Walk(new EveryGrammarValidatorListener(), GetParser(formular));

            _formular = formular;
        }

        private static EveryGrammarParser.StartRuleContext GetParser(string formular)
        {
            var stream = CharStreams.fromString(formular);
            var upper = new CaseChangingCharStream(stream, true); https://github.com/antlr/antlr4/blob/master/doc/case-insensitive-lexing.md
            var lexer = new EveryGrammarLexer(upper);
            var tokens = new CommonTokenStream(lexer);
            var parser = new EveryGrammarParser(tokens)
            {
                BuildParseTree = true
            };

            return parser.startRule();
        }
    }
}
