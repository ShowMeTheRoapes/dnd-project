using System.Collections.Generic;
using System.Text;

public class SkillsListModel
{
    #region Instance Variables and Properties
    private const int DEF_RANK = 0;
    private const bool DEF_PROFICIENCY = false;
    private const int NAME_POS = 0;
    private const int ATTR_POS = 1;
    private const int DESC_POS = 2;
    
    public Dictionary<string, SkillModel> Skills { get; set; }
    #endregion

    #region Constructor(s)
    public SkillsListModel()
	{
        Skills = new Dictionary<string, SkillModel>();

        foreach (string[] skill in SkillsData.skills)
        {
            Skills[skill[NAME_POS]] = new SkillModel(skill[NAME_POS], skill[ATTR_POS], skill[DESC_POS], DEF_RANK, DEF_PROFICIENCY);
        }
	}
    #endregion

    #region Class Methods
    /// <summary>
    /// Clears all of the skill proficiency from when a class is changed
    /// </summary>
    public void Clear()
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
    /// <param name="mods">a dictionary of Attribute:Modifier pairs</param>
    /// <param name="proficiencyBonus">the proficiency bonus</param>
    public void CalculateSkillMods(Dictionary<string, int> mods, int proficiencyBonus)
    {
        foreach (string name in Skills.Keys)
        {
            if(Skills[name].IsProficient)
            {
                Skills[name].Modifier += proficiencyBonus;
            }
            foreach (string attr in mods.Keys)
            {
                if(Skills[name].Attribute == attr)
                {
                    Skills[name].Modifier += mods[attr];
                }
            }
        }
    }

    public void ClearSkillMods()
    {
        foreach (string name in Skills.Keys) 
        {
            Skills[name].Modifier = 0;
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
