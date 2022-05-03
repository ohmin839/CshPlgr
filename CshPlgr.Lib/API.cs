using Antlr4.Runtime;
using CshPlgr.Lib.Converter;
using CshPlgr.Lib.Converter.Generated;

namespace CshPlgr.Lib
{
    public class API
    {
        public static string ToPolytonic(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return "";
            }
            var inputStream = new AntlrInputStream(text);
            var lexer = new ConversionGrammarLexer(inputStream);
            var tokenStream = new CommonTokenStream(lexer);
            var parser = new ConversionGrammarParser(tokenStream);
            var parseTree = parser.letters();
            var visitor = new Visitor();
            return visitor.VisitLetters(parseTree);
        }
    }
}