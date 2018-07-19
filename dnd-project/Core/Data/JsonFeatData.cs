using System.Text;
using System.Collections.Generic;

namespace dnd_project.Core.Data
{
    class JsonFeatData
    {
        public Dictionary<string,JsonFeatInfo> Feats { get; set; }

        public class JsonFeatInfo
        {
            public string Description { get; set; }

            public override string ToString()
            {
                return "\t--Description: " + Description;
            }
        }
    }
}
