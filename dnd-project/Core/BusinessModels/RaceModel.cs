using System.Text;
using Newtonsoft.Json;
using dnd_project.Core.Data;

namespace dnd_project.Core.BusinessModels
{
    public class RaceModel
    {
        #region Instance Variables and Properties
        public string Name { get; set; }
        public int[] Age { get; set; }
        public string Size { get; set; }
        public string Alignment { get; set; }
        public int Speed { get; set; }
        public RaceAttribute[] AttributeMods { get; set; }
        public string[] Feats { get; set; }
        public string[] Proficiencies { get; set; }
        #endregion

        #region Constructor(s)
        public RaceModel(string raceName)
        {
            JsonRaceData raceData = JsonConvert.DeserializeObject<JsonRaceData>(Properties.Resources.RaceData);
            if (raceData.Races[raceName] != null)
            {
                Name = raceName;
                Age = raceData.Races[raceName].Ages;
                Size = raceData.Races[raceName].Size;
                Alignment = raceData.Races[raceName].CommonAlignment;
                Speed = raceData.Races[raceName].Movement;
                AttributeMods = raceData.Races[raceName].AttributeScores;
                Feats = raceData.Races[raceName].Feats;
                Proficiencies = raceData.Races[raceName].Proficiencies;
            }
        }
        #endregion

        #region Class Methods
        /// <summary>
        /// Overriden ToString method to print nicely for debugging
        /// </summary>
        /// <returns>string raceString The information pertaining to the race. </returns>
        public override string ToString()
        {
            StringBuilder raceString = new StringBuilder();
            raceString.Append("\n------RACE------\n");

            raceString.AppendLine("Race: " + Name);
            raceString.AppendLine("Age: Typically aged between " + Age[0] + " and " + Age[1] + " years old");
            raceString.AppendLine("Size: " + Size);
            raceString.AppendLine("Alignment: " + Alignment);
            raceString.AppendLine("Speed: " + Speed);

            raceString.Append("Ability Modifiers:\n");
            foreach (RaceAttribute att in AttributeMods)
            {
                raceString.Append("\t" + att.Attribute + ": " + att.Change + "\n");
            }

            return raceString.ToString();
        }
        #endregion
    }
}