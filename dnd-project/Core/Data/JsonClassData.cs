using System.Collections.Generic;
using System.Text;

namespace dnd_project.Core.Data
{
    class JsonClassData
    {
        public Dictionary<string, JsonClassInfo> Classes { get; set; }

        public class JsonClassInfo
        {
            public string Description { get; set; }
            public string HitDie { get; set; }
            public string[] PrimaryAttributes { get; set; }
            public string[] SavingThrows { get; set; }
            public string[] Proficiencies { get; set; }
            public string[] StartingFeats { get; set; }
            public int NumberOfSkills { get; set; }
            public string[] SkillOptions { get; set; }
        }
    }
}
