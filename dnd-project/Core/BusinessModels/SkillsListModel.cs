using System.Collections.Generic;
using System.Text;

public class SkillsListModel
{
    #region Instance Variables and Properties
    private const int DEF_RANK = 0;
    private const bool DEF_PROFICIENCY = false;
    
    public List<SkillModel> Skills { get; set; }
    #endregion

    #region Constructor(s)
    public SkillsListModel()
	{
        Skills = new List<SkillModel>();

        foreach (string[] skill in SkillsData.skills)
        {
            Skills.Add(new SkillModel(skill[0], skill[1], skill[2], DEF_RANK, DEF_PROFICIENCY));
        }
	}
    #endregion

    #region Class Methods
    public override string ToString()
    {
        StringBuilder output = new StringBuilder();
        output.Append("\n-----SKILLS-----\n");
        foreach (SkillModel skill in Skills)
        {
            output.Append(skill.ToString());
        }

        return output.ToString();
    }
    #endregion
}
