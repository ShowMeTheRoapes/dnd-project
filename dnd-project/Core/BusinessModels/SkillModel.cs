public class SkillModel
{
    #region Instance Variables and Properties
    public string Name { get; set; }
    public string Description { get; set; }
    public string Attribute { get; set; }
    public int Modifier { get; set; }
    public bool IsProficient { get; set; }
    #endregion

    #region Constructor(s)
    public SkillModel()
	{
        Name = "";
        Description = "";
        Attribute = "";
        Modifier = 0;
        IsProficient = false;
	}

    public SkillModel(string name, string attribute, string description, int rank, bool isProficient)
    {
        Name = name;
        Description = description;
        Attribute = attribute;
        Modifier = rank;
        IsProficient = isProficient;
    }
    #endregion

    #region Class Methods
    public override string ToString()
    {
        return Name + ": " + Modifier + "\n";
    }
    #endregion
}
