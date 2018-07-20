using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using dnd_project.Core.Data;

namespace dnd_project.Core.BusinessModels
{
    public class SkillsListModel
    {
        #region Instance Variables and Properties
        private const int DEF_RANK = 0;
        private const bool DEF_PROFICIENCY = false;

        public Dictionary<string, SkillModel> Skills { get; set; }
        #endregion

        #region Constructor(s)
        public SkillsListModel()
        {
            Skills = new Dictionary<string, SkillModel>();
            JsonSkillData skillsData = JsonConvert.DeserializeObject<JsonSkillData>(Properties.Resources.SkillsData);

            foreach (string skillName in skillsData.Skills.Keys)
            {
                Skills[skillName] = new SkillModel(skillName, skillsData.Skills[skillName].ParentAttribute, skillsData.Skills[skillName].Description, DEF_RANK, DEF_PROFICIENCY);
            }
        }
        #endregion

        #region Class Methods
        /// <summary>
        /// Clears all of the skill proficiency from when a class is changed
        /// </summary>
        public void ClearProficiencies()
        {
            foreach (string item in Skills.Keys)
            {
                Skills[item].IsProficient = DEF_PROFICIENCY;
            }
        }

        /// <summary>
        /// Adds proficiency to a chosen skill
        /// </summary>
        /// <param name="skill">Name of a skill to be changed</param>
        public void SetProficiency(string skill)
        {
            Skills[skill].IsProficient = true;
        }

        /// <summary>
        /// Calculates all skill modifiers based on attribute modifier and proficiency bonus
        /// </summary>
        /// <param name="mods">a dictionary of Attribute:Rank pairs</param>
        /// <param name="proficiencyBonus">the proficiency bonus</param>
        public void CalculateSkillMods(Dictionary<string, int> mods, int proficiencyBonus)
        {
            foreach (string name in Skills.Keys)
            {
                if (Skills[name].IsProficient)
                {
                    Skills[name].Rank += proficiencyBonus;
                }
                foreach (string attr in mods.Keys)
                {
                    if (Skills[name].Attribute == attr)
                    {
                        Skills[name].Rank += mods[attr];
                    }
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void ClearSkillRanks()
        {
            foreach (string name in Skills.Keys)
            {
                Skills[name].Rank = 0;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append("\n-----SKILLS-----\n");
            foreach (string skill_name in Skills.Keys)
            {
                output.Append(Skills[skill_name].ToString());
            }

            return output.ToString();
        }
        #endregion
    }
}