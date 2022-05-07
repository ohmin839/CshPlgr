﻿using static CshPlgr.Lib.API;
using System.Management.Automation;

namespace CshPlgr.Cli.Collector
{
    [Cmdlet("Collect", "PolytonicWords")]
    public class Cmdlet : System.Management.Automation.Cmdlet
    {
        private List<string> allWords = new();

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
                    allWords.AddRange(words);
                }
            }

            foreach (var word in allWords)
            {
                WriteObject(word);
            }
        }
    }
}
