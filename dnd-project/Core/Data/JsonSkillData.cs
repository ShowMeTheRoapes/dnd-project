using System.Text;
using System.Collections.Generic;

namespace dnd_project.Core.Data
{
    class JsonSkillData
    {
        public Dictionary<string,JsonSkillInfo> Skills { get; set; }
        
        public class JsonSkillInfo
        {
            public string ParentAttribute { get; set; }
            public string Description { get; set; }

            public override string ToString()
            {
                StringBuilder output = new StringBuilder();

                output.AppendLine("\t--Parent Attribute: " + ParentAttribute);
                output.Append("\t\t--Description: " + Description);

                return output.ToString();
            }
        }
    }
}
