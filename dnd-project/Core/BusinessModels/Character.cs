using System.Collections.Generic;
using System.Text;
using dnd_project.Core.Data;
using System.Reflection;
using dnd_project.Core.BusinessModels.Builders;
using System.Linq;
using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace dnd_project.Core.BusinessModels
{
    [Serializable]
    public class Character : ISerializable
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
        public int AdditionalAttributePoints { get; set; }
        public int AdditionalLanguages { get; set; }
        #endregion

        #region Constructor(s)
        
        /// <summary>
        /// Default Constructor
        /// </summary>
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
            AdditionalAttributePoints = 0;
            AdditionalLanguages = 0;
        }

        /// <summary>
        /// Constructor used for deserialization
        /// </summary>
        /// <param name="info">SerializationInfo object that you add objects to to get serialized</param>
        /// <param name="context">Information about the serialization stream</param>
        protected Character(SerializationInfo info, StreamingContext context)
        {
            attributesList = (AttributesListModel)info.GetValue("attrList", typeof(AttributesListModel));
            characterClass = (Class)info.GetValue("class", typeof(Class));
            featsList = (HashSet<Feat>)info.GetValue("feats", typeof(HashSet<Feat>));
            featsList.OnDeserialization(this);
            characterRace = (Race)info.GetValue("race", typeof(Race));
            skillsList = (SkillsListModel)info.GetValue("skills", typeof(SkillsListModel));
            proficienciesList = (SortedSet<string>)info.GetValue("profs", typeof(SortedSet<string>));
            Alignment = (string)info.GetValue("Alignment", typeof(string));
            Bonds = (string)info.GetValue("Bonds", typeof(string));
            Background = (string)info.GetValue("Background", typeof(string));
            Eyes = (string)info.GetValue("Eyes", typeof(string));
            Faction = (string)info.GetValue("Faction", typeof(string));
            Flaws = (string)info.GetValue("Flaws", typeof(string));
            Hair = (string)info.GetValue("Hair", typeof(string));
            Height = (string)info.GetValue("Height", typeof(string));
            HitDie = (string)info.GetValue("HitDie", typeof(string));
            Ideals = (string)info.GetValue("Ideals", typeof(string));
            Name = (string)info.GetValue("Name", typeof(string));
            PersonalityTraits = (string)info.GetValue("PersonalityTraits", typeof(string));
            Size = (string)info.GetValue("Size", typeof(string));
            Skin = (string)info.GetValue("Skin", typeof(string));
            Age = (int)info.GetValue("Age", typeof(int));
            ArmorClass = (int)info.GetValue("ArmorClass", typeof(int));
            CurrentHitPoints = (int)info.GetValue("CurrentHitPoints", typeof(int));
            ExperiencePoints = (int)info.GetValue("ExperiencePoints", typeof(int));
            Initiative = (int)info.GetValue("Initiative", typeof(int));
            Level = (int)info.GetValue("Level", typeof(int));
            MaxHitPoints = (int)info.GetValue("MaxHitPoints", typeof(int));
            ProficiencyBonus = (int)info.GetValue("ProficiencyBonus", typeof(int));
            Speed = (int)info.GetValue("Speed", typeof(int));
            Weight = (int)info.GetValue("Weight", typeof(int));
            AdditionalAttributePoints = (int)info.GetValue("AdditionalAttributePoints", typeof(int));
            AdditionalLanguages = (int)info.GetValue("AdditionalLanguages", typeof(int));
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
                try
                {
                    attributesList.AddValue(item.Attribute, item.Change);
                }
                catch (KeyNotFoundException e)
                {
                    AdditionalAttributePoints++;
                }
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
                    if(attribute.Attribute != "Choose One")
                        attributesList.Clear(attribute.Attribute, attribute.Change);
                }
            }

            characterRace = race;

            //Updating Ability List Values from RaceModel
            foreach (RaceAttribute attribute in characterRace.AttributeMods)
            {
                try
                {
                    attributesList.AddValue(attribute.Attribute, attribute.Change);
                }
                catch (KeyNotFoundException e)
                {
                    AdditionalAttributePoints++;
                }
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

        /// <summary>
        /// Implemetation of ISerializable's GetObjectData. Used when serializing a Character
        /// </summary>
        /// <param name="info">SerializationInfo object that you add objects to to get serialized</param>
        /// <param name="context">Information about the serialization stream</param>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("attrList", attributesList, typeof(AttributesListModel));
            info.AddValue("class", characterClass, typeof(Class));
            info.AddValue("feats", featsList, typeof(HashSet<Feat>));
            info.AddValue("race", characterRace, typeof(Race));
            info.AddValue("skills", skillsList, typeof(SkillsListModel));
            info.AddValue("profs", proficienciesList, typeof(SortedSet<string>));
            info.AddValue("Alignment", Alignment);
            info.AddValue("Bonds", Bonds);
            info.AddValue("Background", Background);
            info.AddValue("Eyes", Eyes);
            info.AddValue("Faction", Faction);
            info.AddValue("Flaws", Flaws);
            info.AddValue("Hair", Hair);
            info.AddValue("Height", Height);
            info.AddValue("HitDie", HitDie);
            info.AddValue("Ideals", Ideals);
            info.AddValue("Name", Name);
            info.AddValue("PersonalityTraits", PersonalityTraits);
            info.AddValue("Size", Size);
            info.AddValue("Skin", Skin);
            info.AddValue("Age", Age);
            info.AddValue("ArmorClass", ArmorClass);
            info.AddValue("CurrentHitPoints", CurrentHitPoints);
            info.AddValue("ExperiencePoints", ExperiencePoints);
            info.AddValue("Initiative", Initiative);
            info.AddValue("Inspiration", Inspiration);
            info.AddValue("Level", Level);
            info.AddValue("MaxHitPoints", MaxHitPoints);
            info.AddValue("ProficiencyBonus", ProficiencyBonus);
            info.AddValue("Speed", Speed);
            info.AddValue("Weight", Weight);
            info.AddValue("AdditionalAttributePoints", AdditionalAttributePoints);
            info.AddValue("AdditionalLanguages", AdditionalLanguages);
        }

        /// <summary>
        /// Gets the attributes list of the character
        /// </summary>
        /// <returns>AttributesListModel containing attribute info</returns>
        public AttributesListModel GetAttributesList()
        {
            return attributesList;
        }
        
        /// <summary>
        /// Gets name of the current race
        /// </summary>
        /// <returns>Name of the race or "None" if race is null</returns>
        public string GetRace()
        {
            return characterRace == null ? "None" : characterRace.Name;
        }

        /// <summary>
        /// Gets the name of the Class
        /// </summary>
        /// <returns>Name of the class or "None" if race is null</returns>
        public string GetClass()
        {
            return characterClass == null ? "None" : characterClass.Name;
        }
        #endregion
    }
}