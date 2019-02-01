using System;
using System.Linq;
using dnd_project.Core.Data;
using Newtonsoft.Json;
using dnd_project.Core.BusinessModels;
using dnd_project.Core.BusinessModels.Builders;
using System.Collections.Generic;

namespace dnd_project.Core
{
    class CharacterController
    {
        #region Class Variables

        private Character character = new Character();
        private JsonRaceData raceData = JsonConvert.DeserializeObject<JsonRaceData>(Properties.Resources.RaceData);
        private JsonClassData classData = JsonConvert.DeserializeObject<JsonClassData>(Properties.Resources.ClassData);
        private JsonFeatData featData = JsonConvert.DeserializeObject<JsonFeatData>(Properties.Resources.FeatData);

        #endregion

        #region Methods

        #region GetAlls

        public List<string> GetAllRaces()
        {
            List<string> races = new List<string>();
            races = raceData.Races.Keys.ToArray().ToList();
            return races;
        }
        public List<string> GetAllClasses()
        {
            List<string> classes = new List<string>();
            raceData.Races.Keys.ToArray().ToList();
            return classes;
        }
        public List<string> GetAllFeats()
        {
            List<string> feats = new List<string>();
            raceData.Races.Keys.ToArray().ToList();
            return feats;
        }

        #endregion

        #region Getters

        public Race GetRace(string raceName)
        {
            return raceData.Races.ContainsKey(raceName) ? GatherRaceData(raceName).Build() : null;
        }
        public string GetRaceCurrent()
        {
            return character.GetRace();
        }
        public Class GetClass(string className)
        {
            return classData.Classes.ContainsKey(className) ? GatherClassData(className).Build() : null;
        }
        public string GetClassCurrent()
        {
            return character.GetClass();
        }
        public Feat GetFeat(string featName)
        {
            return featData.Feats.ContainsKey(featName) ? GatherFeatData(featName).Build() : null;
        }
        /// <summary>
        /// Dictionary where the first index is the attribute name and the second index is "Value" (attribute value)
        /// or "Mod" (modifier value) 
        /// </summary>
        /// <returns>Get values and mods for attributes</returns>
        public Dictionary<string, Dictionary<string, int>> GetAttributeValuesAndMods()
        {
            AttributesListModel attributesList = character.GetAttributesList();
            Dictionary<string, Dictionary<string, int>> attrsAndMods = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> modValues = attributesList.GetAttributeMods();
            Dictionary<string, int> attrValues = attributesList.GetAttributeValues();
            foreach (string att in attrValues.Keys)
            {
                attrsAndMods[att] = new Dictionary<string, int>();
                attrsAndMods[att]["Value"] = attrValues[att];
                attrsAndMods[att]["Mod"] = modValues[att];
            }

            return attrsAndMods;
        }
        /// <summary>
        /// Use the CharacterValues enum to see the possible values
        /// </summary>
        /// <param name="property">Character property name from CharacterValues</param>
        /// <returns>Stringified value of the property</returns>
        public string GetBasicCharacterProperty(string property)
        {
            return (string) character.GetType().GetProperty(property).GetValue(character);
        }

        #endregion

        #region Setters

        public void SetRace(string raceName)
        {
            if (raceData.Races.ContainsKey(raceName))
            {
                character.SetRace(GatherRaceData(raceName).Build());
            }
        }
        public void SetClass(string className)
        {
            if (classData.Classes.ContainsKey(className))
            {
                character.SetClass(GatherClassData(className).Build());
            }
        }
        public void SetCharacterProperty(string property, dynamic value)
        {
            character.GetType().GetProperty(property).SetValue(character, value);
        }

        #endregion

        #region Private

        private ClassBuilder GatherClassData(string className)
        {
            JsonClassInfo aClass = classData.Classes[className];
            ClassBuilder builder = new ClassBuilder();
            builder.SetName(className).SetDescription(aClass.Description).SetHitDie(aClass.HitDie)
                .SetNumberOfSkills(aClass.NumberOfSkills).SetPrimaryAttributes(aClass.PrimaryAttributes)
                .SetProficiencies(aClass.Proficiencies).SetSavingThrows(aClass.SavingThrows)
                .SetSkillOptions(aClass.SkillOptions).SetStartingFeats(aClass.StartingFeats);

            return builder;
        }
        private RaceBuilder GatherRaceData(string raceName)
        {
            JsonRaceInfo aRace = raceData.Races[raceName];
            RaceBuilder builder = new RaceBuilder();
            builder.SetName(raceName).SetAges(aRace.Ages).SetAlignment(aRace.CommonAlignment)
                .SetAttributeMods(aRace.AttributeScores).SetFeats(aRace.Feats)
                .SetProficiencies(aRace.Proficiencies).SetSize(aRace.Size)
                .SetSpeed(aRace.Movement).SetLanguages(aRace.Languages)
                .SetGearChoices(aRace.GearChoices);
            return builder;
        }



        private FeatBuilder GatherFeatData(string featName)
        {
            JsonFeatInfo aFeat = featData.Feats[featName];
            FeatBuilder builder = new FeatBuilder();
            builder.SetName(featName).SetDescription(aFeat.Description);

            return builder;
        }

        #endregion

        #region Misc

        public void PrintCharacterToConsole()
        {
            Console.Out.Write(character.ToString());
        }

        public void SaveCharacter(string saveDirectory)
        {
            SaverLoader.WriteToBinaryFile<Character>(saveDirectory, character.Name, character);
        }

        public void LoadCharacter(string filePath)
        {
            character = SaverLoader.ReadFromBinaryFile<Character>(filePath);
        }
        #endregion

        #endregion
    }
}
