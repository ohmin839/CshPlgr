using static CshPlgr.Lib.API;
using System.Management.Automation;

namespace CshPlgr.Cli.Converter
{
    [Cmdlet("ConvertTo", "Polytonic")]
    public class Cmdlet : System.Management.Automation.Cmdlet
    {
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
                    WriteObject(ConvertToPolytonic(line));
                }
            }
        }
    }
}
