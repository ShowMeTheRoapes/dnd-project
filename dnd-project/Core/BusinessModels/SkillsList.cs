using System;
using System.Collections.Generic;

public class SkillsList
{
    private const int DEF_RANK = 0;
    private const bool DEF_PROFICIENCY = false;
    
    public List<Skill> Skills { get; set; }

    public SkillsList()
	{
        Skills = new List<Skill>();

        foreach (string[] skill in SkillsData.skills)
        {
            Skills.Add(new Skill(skill[0], skill[1], skill[2], DEF_RANK, DEF_PROFICIENCY));
        }
	}
}
