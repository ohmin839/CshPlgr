using Antlr4.Runtime;
using CshPlgr.Lib.Collector;
using CshPlgr.Lib.Collector.Generated;
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

        public static SortedSet<string> CollectPolytonicWords(TextReader reader)
        {
            var inputStream = new AntlrInputStream(reader);
            var lexer = new CollectionGrammarLexer(inputStream);
            var tokenStream = new CommonTokenStream(lexer);
            var parser = new CollectionGrammarParser(tokenStream);
            var listener = new Listener();
            parser.AddParseListener(listener);
            parser.text();
            return listener.PolytonicWords;
        }
        public static SortedSet<string> CollectPolytonicWords(string text)
        {
            var reader = new StringReader(text);
            return CollectPolytonicWords(reader);
        }
    }
}