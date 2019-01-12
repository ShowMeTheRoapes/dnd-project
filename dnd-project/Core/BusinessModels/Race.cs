using System.Text;
using dnd_project.Core.Data;

namespace dnd_project.Core.BusinessModels
{
    public class Race
    {
        
        #region Instance Variables and Properties
        public string Name { get; }
        public int[] Ages { get; }
        public string Size { get; }
        public string Alignment { get; }
        public int Speed { get; }
        public RaceAttribute[] AttributeMods { get; }
        public string[] Feats { get; }
        public string[] Proficiencies { get; }
        public string[] Languages { get; }
        public string[] GearChoices { get; }
        #endregion

        #region Constructor(s)
        public Race(string name, int[] age, string size, string alignment, int speed, RaceAttribute[] attributeMods, string[] feats,
            string[] proficiencies, string[] languages, string[] gearChoices)
        {
            Name = name;
            Ages = age;
            Size = size;
            Alignment = alignment;
            Speed = speed;
            AttributeMods = attributeMods;
            Feats = feats;
            Proficiencies = proficiencies;
            Languages = languages;
            GearChoices = gearChoices;
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
            raceString.AppendLine("Age: Typically aged between " + Ages[0] + " and " + Ages[1] + " years old");
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