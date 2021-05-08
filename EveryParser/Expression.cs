using Antlr4.Runtime;
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

        public Expression(string formular)
        {
            _formular = formular;
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

            GetParser(formular).startRule();

            return null;
        }

        public void SetFormular(string formular, bool checkSyntax = true)
        {
            if (string.IsNullOrWhiteSpace(_formular))
                throw new ArgumentNullException();

            if (checkSyntax)
                GetParser(formular).startRule();

            _formular = formular;
        }

        private static EveryGrammarParser GetParser(string formular)
        {
            var stream = CharStreams.fromString(formular);
            var lexer = new EveryGrammarLexer(stream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new EveryGrammarParser(tokens)
            {
                BuildParseTree = true
            };

            return parser;
        }
    }
}