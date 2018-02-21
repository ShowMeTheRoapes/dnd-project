using System;

public class SkillModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Attribute { get; set; }
    public int Rank { get; set; }
    public bool IsProficient { get; set; }

	public SkillModel()
	{
        Name = "";
        Description = "";
        Attribute = "";
        Rank = 0;
        IsProficient = false;
	}

    public SkillModel(string name, string attribute, string description, int rank, bool isProficient)
    {
        Name = name;
        Description = description;
        Attribute = attribute;
        Rank = rank;
        IsProficient = isProficient;
    }

    public override string ToString()
    {
        return Name + ": " + Rank + "\n";
    }
}
