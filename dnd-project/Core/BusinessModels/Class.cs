using System;
using System.Text;

namespace dnd_project.Core.BusinessModels
{
    [Serializable]
    public class Class
    {
        #region Instance Variables and Properties
        private const int DEF_LEVEL = 1;

        public string Name { get; }
        public string Description { get; }
        public string HitDie { get; set; }
        public string[] PrimaryAttributes { get; }
        public string[] SavingThrows { get; }
        public string[] Proficiencies { get; }
        public string[] StartingFeats { get; }
        public int NumberOfSkills { get; }
        public string[] SkillOptions { get; }
        #endregion

        #region Constructor(s)
        public Class(string name, string description, string hitDie, string[] primaryAttributes, string[] savingThrows, string[] proficiencies,
            string[] startingFeats, int numberOfSkills, string[] skillOptions)
        {
            Name = name;
            Description = description;
            HitDie = hitDie;
            PrimaryAttributes = primaryAttributes;
            SavingThrows = savingThrows;
            Proficiencies = proficiencies;
            StartingFeats = startingFeats;
            NumberOfSkills = numberOfSkills;
            SkillOptions = skillOptions;
        }
        #endregion

        #region Class Methods
        /// <summary>
        /// Overriden ToString method to print a class
        /// </summary>
        /// <returns>Information about ClassModel object</returns>
        public override string ToString()
        {
            StringBuilder classString = new StringBuilder("\n----------CLASS----------\n");

            classString.Append("Class: " + Name + "\n");
            classString.Append("Description: " + Description + "\n");
            classString.Append("Hit Die: " + HitDie + "\n");

            classString.Append("Primary Attributes: \n");
            foreach (string att in PrimaryAttributes)
            {
                classString.Append("\t" + att + "\n");
            }

            classString.Append("Saving Throws: \n");
            foreach (string save in SavingThrows)
            {
                classString.Append("\t" + save + "\n");
            }

            return classString.ToString();
        }
        #endregion
    }
}