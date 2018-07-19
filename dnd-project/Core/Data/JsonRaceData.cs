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

            public override string ToString()
            {
                StringBuilder output = new StringBuilder();

                output.AppendLine("Age: " + Ages[0] + " to " + Ages[1]);
                output.AppendLine("Size: " + Size);
                output.AppendLine("Common Alignment: " + CommonAlignment);

                output.AppendLine("Attribute Score Changes:");
                foreach(RaceAttribute att in AttributeScores)
                    output.AppendLine(att.ToString());

                output.AppendLine("Starting Feats:");
                foreach (string feat in Feats)
                    output.AppendLine("\t-" + feat);

                output.AppendLine("Starting Proficiencies:");
                if (Proficiencies.Length == 0)
                    output.AppendLine("\t-None");
                foreach (string prof in Proficiencies)
                    output.AppendLine("\t-" + prof);

                output.AppendLine("Starting Languages:");
                foreach (string lang in Languages)
                    output.AppendLine("\t-" + lang);

                output.AppendLine("Starting Gear Choices:");
                if (GearChoices.Length == 0)
                    output.AppendLine("\t-None");
                foreach (string gear in GearChoices)
                    output.AppendLine("\t-" + gear);

                return output.ToString();
            }
        }

        public class RaceAttribute
        {
            public string Attribute { get; set; }
            public int Change { get; set; }

            public override string ToString()
            {
                return "\t-" + Attribute + ": +" + Change;
            }
        }

    }
}
