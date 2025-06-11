using Antlr4.Runtime;
using EveryParser.GrammarListener;
using EveryParser.LinQReplaces;
using System.Collections.Generic;
using System.IO;

namespace EveryParser
{
    internal class SyntaxErrorListener : IAntlrErrorListener<IToken>
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
    }
}