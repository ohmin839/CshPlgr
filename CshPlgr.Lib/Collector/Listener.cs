using Antlr4.Runtime.Misc;
using CshPlgr.Lib.Collector.Generated;

namespace CshPlgr.Lib.Collector
{
    internal class Listener: CollectionGrammarBaseListener
    {
        private List<string> wordList = new();

        public override void ExitWord([NotNull] CollectionGrammarParser.WordContext context)
        {
            var word = context.GetText();
            wordList.Add(word);
        }

        public List<string> PolytonicWords
        {
            get { return wordList; }
        }
    }
}
