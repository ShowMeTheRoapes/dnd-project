using System;

public class Skill
{
    private string name;
    private string description;
    private string attribute;
    private int rank;
    private bool isProficient;

    public string Name { get; set; }
    public string Description { get; set; }
    public string Attribute { get; set; }
    public int Rank { get; set; }
    public bool IsProficient { get; set; }

	public Skill()
	{
        Name = "";
        Description = "";
        Attribute = "";
        Rank = 0;
        IsProficient = false;
	}

    public Skill(string name, string attribute, string description, int rank, bool isProficient)
    {
        Name = name;
        Description = description;
        Attribute = attribute;
        Rank = rank;
        IsProficient = isProficient;
    }
}
