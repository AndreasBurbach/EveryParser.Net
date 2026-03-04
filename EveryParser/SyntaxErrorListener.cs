using Antlr4.Runtime;
using EveryParser.GrammarListener;
using EveryParser.LinQReplaces;
using System.Collections.Generic;
using System.IO;

namespace EveryParser
{
    internal class SyntaxErrorListener : IAntlrErrorListener<IToken>, IAntlrErrorListener<int>
    {
        private readonly List<(ErrorCode, string message)> _errors = new List<(ErrorCode, string message)>();

        internal bool HasErrors => _errors.Any();

        internal (ErrorCode, string message)[] GetErrors()
        {
            return _errors.ToArray();
        }

        internal void ClearErrors()
        {
            _errors.Clear();
        }

        public void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            _errors.Add((ErrorCode.SyntaxError, $"{msg} {line}:{charPositionInLine}"));
        }

        public void SyntaxError(TextWriter output, IRecognizer recognizer, int offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            if (offendingSymbol >= 0 && char.IsWhiteSpace((char)offendingSymbol))
                return;

            if (!string.IsNullOrWhiteSpace(msg) && msg.StartsWith("token recognition error at:"))
            {
                if (msg.Contains("'\\t'") || msg.Contains("'\\r'") || msg.Contains("'\\n'"))
                    return;

                int firstQuote = msg.IndexOf('\'');
                int lastQuote = msg.LastIndexOf('\'');

                if (firstQuote >= 0 && lastQuote > firstQuote)
                {
                    string invalidText = msg.Substring(firstQuote + 1, lastQuote - firstQuote - 1);
                    if (string.IsNullOrWhiteSpace(invalidText))
                        return;
                }
            }

            _errors.Add((ErrorCode.SyntaxError, $"{msg} {line}:{charPositionInLine}"));
        }

        internal void AddError(string message)
        {
            _errors.Add((ErrorCode.SyntaxError, message));
        }
    }
}