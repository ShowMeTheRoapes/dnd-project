public class SkillModel
{
    #region Instance Variables and Properties
    public string Name { get; set; }
    public string Description { get; set; }
    public string Attribute { get; set; }
    public int Rank { get; set; }
    public bool IsProficient { get; set; }
    #endregion

    #region Constructor(s)
    /// <summary>
    /// Default constructor for the SkillModel class
    /// </summary>
    /// <param name="name">string The name of the skill</param>
    /// <param name="attribute">string The parent attribute of the skill</param>
    /// <param name="description">string A description of the skill</param>
    /// <param name="rank">int The value of the skill</param>
    /// <param name="isProficient">bool Is the skill a proficient skill</param>
    public SkillModel(string name, string attribute, string description, int rank, bool isProficient)
    {
        Name = name;
        Description = description;
        Attribute = attribute;
        Rank = rank;
        IsProficient = isProficient;
    }
    #endregion

    #region Class Methods
    /// <summary>
    /// Overriden ToString method that is used in debugging.
    /// </summary>
    /// <returns>string Some of the values associated with a skill</returns>
    public override string ToString()
    {
        return Name + ": " + Rank + "\n";
    }
    #endregion
}
