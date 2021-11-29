using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;

namespace EveryParser.GrammarListener.ArgumentsListener
{
    /// <summary>
    /// This interface defines a complete listener for a parse tree produced by
    /// <see cref="EveryGrammarParser"/>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
    public partial class EveryGrammarArgumentsListener : IEveryGrammarListener
    {
        private List<string> _variables = new List<string>();

        public string[] Arguments => _variables.ToArray();

        public void Clear()
        {
            _variables = new List<string>();
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_Variable</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_Variable([NotNull] EveryGrammarParser.Factor_VariableContext context)
        {
            string text = context.GetText();

            if (!text.Equals("e", StringComparison.InvariantCultureIgnoreCase) && !text.Equals("pi", StringComparison.InvariantCultureIgnoreCase))
                _variables.Add(text);
        }

        /// <summary>
        /// Enter a parse tree produced by the <c>Factor_ObjectVariables</c>
        /// labeled alternative in <see cref="EveryGrammarParser.factor"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public void EnterFactor_ObjectVariables([NotNull] EveryGrammarParser.Factor_ObjectVariablesContext context)
        {
            string text = context.GetText();

            if (!text.Equals("DateTime.Now", StringComparison.InvariantCultureIgnoreCase))
                _variables.Add(text);
        }
    }
}