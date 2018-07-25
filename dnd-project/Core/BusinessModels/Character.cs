using System.Collections.Generic;
using System.Text;
using dnd_project.Core.Data;

namespace dnd_project.Core.BusinessModels
{
    class Character
    {
        #region Instance Variables and Properties
        private ClassModel characterClass;
        private RaceModel characterRace;
        private AttributesListModel attributesList;
        private SkillsListModel skillsList;
        private HashSet<FeatModel> featsList;
        private SortedSet<string> proficienciesList;

        public string Name { get; set; }
        public string PersonalityTraits { get; set; }
        public string Ideals { get; set; }
        public string Bonds { get; set; }
        public string Flaws { get; set; }
        public string Alignment { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Eyes { get; set; }
        public string Skin { get; set; }
        public string Hair { get; set; }
        public string Size { get; set; }
        public string HitDie { get; set; }
        public int Speed { get; set; }
        public int Level { get; set; }
        public int Age { get; set; }
        public int ExperiencePoints { get; set; }
        public int ArmorClass { get; set; }
        public int Initiative { get; set; }
        public int Inspiration { get; set; }
        public int ProficiencyBonus { get; set; }
        public int MaxHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        #endregion

        #region Constructor(s)
        public Character()
        {
            attributesList = new AttributesListModel();
            skillsList = new SkillsListModel();
            featsList = new HashSet<FeatModel>();
            proficienciesList = new SortedSet<string>();

            Name = "";
            PersonalityTraits = "";
            Ideals = "";
            Bonds = "";
            Flaws = "";
            Alignment = "";
            Height = "";
            Weight = "";
            Eyes = "";
            Skin = "";
            Hair = "";
            Size = "";
            HitDie = "";
            Level = 0;
            Speed = 0;
            Age = 0;
            ExperiencePoints = 0;
            ArmorClass = 0;
            Initiative = 0;
            Inspiration = 0;
            ProficiencyBonus = 0;
            MaxHitPoints = 0;
            CurrentHitPoints = 0;
        }
        #endregion

        #region Class Methods
        /// <summary>
        /// Recalculates attributes with updated base attribute values and class modifiers
        /// </summary>
        /// <param name="attributes">List and order of the attributes to be set</param>
        /// <param name="values">List and order of the values to be set</param>
        public void SetBaseAttributes(string[] attributes, int[] values)
        {
            for (int i = 0; i < attributes.Length; i++)
            {
                attributesList.SetValue(attributes[i], values[i]);
            }

            foreach (var item in characterRace.AttributeMods)
            {
                attributesList.AddValue(item.Attribute, item.Change);
            }
        }
        /// <summary>
        /// Method to set the character's class info based on a provided name.
        /// </summary>
        /// <param name="className">The name of the class</param>
        public void SetCharacterClass(string className)
        {
            characterClass = new ClassModel(className);

            //Only aggregate feats when both class and race are initialized
            if (characterRace != null)
                AggregateData();
        }

        /// <summary>
        /// Method to get the character's race info based on a provided name.
        /// </summary>
        /// <param name="raceName">The name of the race</param>
        public void SetCharacterRace(string raceName)
        {
            if (characterRace != null)
            {
                foreach (RaceAttribute attribute in characterRace.AttributeMods)
                {
                    attributesList.Clear(attribute.Attribute, attribute.Change);
                }
            }

            characterRace = new RaceModel(raceName);

            //Updating Ability List Values from RaceModel
            foreach (RaceAttribute attribute in characterRace.AttributeMods)
            {
                attributesList.AddValue(attribute.Attribute, attribute.Change);
            }

            //Only aggregate feats when both class and race are initialized
            if (characterClass != null)
                AggregateData();
        }

        /// <summary>
        /// Method to pull the feat information from the character's class and race information.
        /// </summary>
        private void AggregateData()
        {
            featsList.Clear();
            proficienciesList.Clear();
            skillsList.ClearSkillRanks();

            //Pull the proficiency information
            foreach (string featName in characterClass.StartingFeats)
                featsList.Add(new FeatModel(featName));

            foreach (string prof in characterClass.Proficiencies)
                proficienciesList.Add(prof);

            //Pull the feat information
            foreach (string featName in characterRace.Feats)
                featsList.Add(new FeatModel(featName));

            foreach (string prof in characterRace.Proficiencies)
                proficienciesList.Add(prof);

            //Pull Speed, HitDie and Size from Race/Character Models
            HitDie = characterClass.HitDie;
            Speed = characterRace.Speed;
            Size = characterRace.Size;

            //Calculates Skill Modifiers
            skillsList.CalculateSkillMods(attributesList.GetAttributeMods(), ProficiencyBonus);

        }
        /// <summary>
        /// Overridden ToString for debugging
        /// </summary>
        /// <returns>Returns information about a Character</returns>
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append("\n=====" + Name + "=====\n");

            output.Append(characterClass.ToString());
            output.Append(characterRace.ToString());
            output.Append(attributesList.ToString());
            output.Append(skillsList.ToString());

            output.Append("\n-----FEATS-----\n");
            foreach (FeatModel feat in featsList)
                output.Append(feat.ToString());

            output.Append("\n-----PROFICIENCIES-----\n");
            foreach (string prof in proficienciesList)
                output.Append(prof + "\n");

            return output.ToString();
        }
        #endregion
    }
}