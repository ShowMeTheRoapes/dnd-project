using System.Collections.Generic;
using System.Text;
using dnd_project.Core.Data;
using System.Reflection;
using dnd_project.Core.BusinessModels.Builders;
using System.Linq;
using Newtonsoft.Json;

namespace dnd_project.Core.BusinessModels
{
    class Character
    {
        #region Instance Variables and Properties
        private AttributesListModel attributesList;
        private Class characterClass;
        private HashSet<Feat> featsList;
        private Race characterRace;
        private SkillsListModel skillsList;
        private SortedSet<string> proficienciesList;

        public string Alignment { get; set; }
        public string Bonds { get; set; }
        public string Background { get; set; }
        public string Eyes { get; set; }
        public string Faction { get; set; }
        public string Flaws { get; set; }
        public string Hair { get; set; }
        public string Height { get; set; }
        public string HitDie { get; set; }
        public string Ideals { get; set; }
        public string Name { get; set; }
        public string PersonalityTraits { get; set; }
        public string Size { get; set; }
        public string Skin { get; set; }
        public int Age { get; set; }
        public int ArmorClass { get; set; }
        public int CurrentHitPoints { get; set; }
        public int ExperiencePoints { get; set; }
        public int Initiative { get; set; }
        public int Inspiration { get; set; }
        public int Level { get; set; }
        public int MaxHitPoints { get; set; }
        public int ProficiencyBonus { get; set; }
        public int Speed { get; set; }
        public int Weight { get; set; }
        #endregion

        #region Constructor(s)
        public Character()
        {
            attributesList = new AttributesListModel();
            skillsList = new SkillsListModel();
            featsList = new HashSet<Feat>();
            proficienciesList = new SortedSet<string>();

            Name = "";
            PersonalityTraits = "";
            Ideals = "";
            Bonds = "";
            Flaws = "";
            Alignment = "";
            Height = "";
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
            Weight = 0;
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
        public void SetClass(Class aClass)
        {
            characterClass = aClass;

            //Only aggregate feats when both class and race are initialized
            if (characterRace != null)
                AggregateData();
        }

        /// <summary>
        /// Method to get the character's race info based on a provided name.
        /// </summary>
        /// <param name="raceName">The name of the race</param>
        public void SetRace(Race race)
        {
            if (characterRace != null)
            {
                foreach (RaceAttribute attribute in characterRace.AttributeMods)
                {
                    attributesList.Clear(attribute.Attribute, attribute.Change);
                }
            }

            characterRace = race;

            //Updating Ability List Values from RaceModel
            foreach (RaceAttribute attribute in characterRace.AttributeMods)
            {
                attributesList.AddValue(attribute.Attribute, attribute.Change);
            }

            Size = characterRace.Size;
            Speed = characterRace.Speed;

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

            //Pull the feat information
            List<string> newFeats = characterClass.StartingFeats.ToList<string>();
            newFeats.AddRange(characterRace.Feats.ToList<string>());
            AddFeats(newFeats.Distinct().ToList());

            //Pull the proficiency information
            foreach (string prof in characterClass.Proficiencies)
                proficienciesList.Add(prof);

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
        /// Adds a list of feats to the character's set of feats. Only adds them if the feats can be found in FeatsData.json
        /// </summary>
        /// <param name="possibleFeats">A list of possible feats to add</param>
        private void AddFeats(List<string> possibleFeats)
        {
            FeatBuilder builder = new FeatBuilder();
            JsonFeatData featData = JsonConvert.DeserializeObject<JsonFeatData>(Properties.Resources.FeatData);
            foreach(string feat in possibleFeats)
            {
                if (featData.Feats.Keys.Contains(feat))
                {
                    builder.SetName(feat).SetDescription(featData.Feats[feat].Description);
                    featsList.Add(builder.Build());
                }
            }
        }

        /// <summary>
        /// Overridden ToString for debugging
        /// </summary>
        /// <returns>Returns information about a Character</returns>
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine("############################");
            output.AppendLine("### Character Properties ###");
            output.AppendLine("############################");
            foreach (PropertyInfo pi in this.GetType().GetProperties())
            {
                if (pi.GetType().IsSubclassOf(typeof(System.Collections.ICollection)))
                {
                    output.Append(pi.GetType().ToString());
                    if (pi.GetValue(this) != null)
                    {
                        dynamic prop = pi.GetValue(this);

                        foreach (dynamic item in prop)
                        {
                            output.AppendLine(item.toString());
                        }
                    }
                }
                else
                {
                    output.Append(pi.Name + ": ");
                    dynamic value = pi.GetValue(this);
                    if (!object.Equals(value, null) && !object.Equals(value, ""))
                    {
                        output.AppendLine(value.ToString());
                    }
                    else
                    {
                        output.AppendLine();
                    }
                }
            }

            output.Append(characterClass == null ? "No Class" : characterClass.ToString());
            output.Append(characterRace == null ? "No Race" : characterRace.ToString());
            output.Append(attributesList == null ? "No Attributes" : attributesList.ToString());
            output.Append(skillsList == null ? "No Skills" : skillsList.ToString());

            output.Append("\n-----FEATS-----\n");

            if (!(featsList == null))
            {
                foreach (Feat feat in featsList)
                    output.Append(feat.ToString());
            }
            output.Append("\n-----PROFICIENCIES-----\n");

            if (!(proficienciesList == null))
            {
                foreach (string prof in proficienciesList)
                    output.Append(prof + "\n");
            }
            return output.ToString();
        }
        #endregion
    }
}