using System.Text;
using System.Collections.Generic;

namespace dnd_project.Core.Data
{
    class JsonRaceData
    {

        public Dictionary<string, JsonRaceInfo> Races { get; set; }

        public class JsonRaceInfo
        {
            public int[] Ages { get; set; }
            public string Size { get; set; }
            public string CommonAlignment { get; set; }
            public int Movement { get; set; }
            public RaceAttribute[] AttributeScores { get; set; }
            public string[] Feats { get; set; }
            public string[] Proficiencies { get; set; }
            public string[] Languages { get; set; }
            public string[] GearChoices { get; set; }
        }

        public class RaceAttribute
        {
            public string Attribute { get; set; }
            public int Change { get; set; }
        }

    }
}
