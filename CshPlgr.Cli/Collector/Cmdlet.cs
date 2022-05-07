using static CshPlgr.Lib.API;
using System.Management.Automation;

namespace CshPlgr.Cli.Collector
{
    [Cmdlet("Collect", "PolytonicWords")]
    public class Cmdlet : System.Management.Automation.Cmdlet
    {
        private SortedSet<string> allWords = new SortedSet<string>();

        [Parameter(
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public string[]? Lines
        {
            get; set;
        }

        protected override void ProcessRecord()
        {
            if (Lines != null && Lines.Length > 0)
            {
                foreach (var line in Lines)
                {
                    var words = CollectPolytonicWords(line);
                    foreach (var word in words)
                    {
                        allWords.Add(word);
                    }
                }
            }

            foreach (var word in allWords)
            {
                WriteObject(word);
            }
        }
    }
}
