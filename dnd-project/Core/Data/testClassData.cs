using System.Collections.Generic;
using System.Text;

namespace dnd_project.Core.Data
{
    class TestClassData
    {
        public Dictionary<string, TestClassInfo> Classes { get; set; }

        public class TestClassInfo
        {
            public string Description { get; set; }
            public string HitDie { get; set; }
            public string[] PrimaryAttributes { get; set; }
            public string[] SavingThrows { get; set; }
            public string[] Proficiencies { get; set; }
            public string[] StartingFeats { get; set; }
            public int NumberOfSkills { get; set; }
            public string[] SkillOptions { get; set; }

            public override string ToString()
            {
                StringBuilder output = new StringBuilder();
                output.AppendLine("Description: " + Description);
                output.AppendLine("Hit Die: " + HitDie);

                output.AppendLine("Primary Attributes:");
                foreach (string att in PrimaryAttributes)
                    output.AppendLine("\t-" + att);

                output.AppendLine("Saving Throws:");
                foreach (string st in SavingThrows)
                    output.AppendLine("\t-" + st);

                output.AppendLine("Profencies");
                foreach (string p in Proficiencies)
                    output.AppendLine("\t-" + p);

                output.AppendLine("Starting Feats:");
                foreach (string feat in StartingFeats)
                    output.AppendLine("\t-" + feat);

                output.AppendLine("Number of skills to select: " + NumberOfSkills);

                output.AppendLine("Skill Options:");
                foreach (string skill in SkillOptions)
                    output.AppendLine("\t-" + skill);

                return output.ToString();
            }
        }
    }
}
