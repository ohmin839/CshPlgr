using Antlr4.Runtime.Misc;
using CshPlgr.Lib.Collector.Generated;

namespace CshPlgr.Lib.Collector
{
    internal class Listener: CollectionGrammarBaseListener
    {
        private SortedSet<string> words = new SortedSet<string>();

        public override void ExitWord([NotNull] CollectionGrammarParser.WordContext context)
        {
            var text = context.GetText();
            words.Add(text);
        }

        public SortedSet<string> PolytonicWords
        {
            get { return words; }
        }
    }
}
