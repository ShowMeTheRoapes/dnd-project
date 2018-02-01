using System;

public class Skill
{
    private string name;
    private string description;
    private int rank;
    private Boolean isProficient;

    public string Name { get; set; }
    public string Desc { get; set; }
    public int Rank { get; set; }
    public Boolean IsProficient { get; set; }

	public Skill()
	{
        Name = "";
        Desc = "";
        Rank = 0;
        IsProficient = false;
	}

    public Skill(String name, String description, int rank, Boolean isProficient)
    {
        Name = name;
        Desc = description;
        Rank = rank;
        IsProficient = isProficient;
    }
}
