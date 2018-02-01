using System;
using System.Collections.Generic;

public class SkillsList
{
    private const int DEF_RANK = 0;
    private const bool DEF_PROFICIENCY = false;
    public readonly List<Skill> skills = new List<Skill>(); 

    public SkillsList()
	{
        foreach (string[] skill in SkillsData.skills)
        {
            skills.Add(new Skill(skill[0], skill[1], skill[2], DEF_RANK, DEF_PROFICIENCY));
        }
	}
}
