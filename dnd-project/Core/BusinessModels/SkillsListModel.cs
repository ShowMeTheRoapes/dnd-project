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
