using System.Collections.Generic;
using System.Text;

namespace dnd_project.Core.Data
{
    class JsonAttributeData
    {
        public Dictionary<string, JsonAttributeInfo> Attributes { get; set; }
        
        public class JsonAttributeInfo
        {
            public string Description { get; set; }
        }
    }
}
