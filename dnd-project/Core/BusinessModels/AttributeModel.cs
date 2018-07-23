
public class AttributeModel
{
    #region Instance Variables and Properties
    private const int MAX_MOD_LEVEL = 20;
    private const int MIN_MOD_LEVEL = 2;
    private const int MAX_MOD = 10;
    private const int MIN_MOD = -5;
    private int value;

    public string Name { get; set; }
    public string Description { get; set; }
    public int Value{ get { return value; } set { this.value = value; Modifier = CalculateModifier(); } }
    public int Modifier { get; set; }
    #endregion

    #region Constructor(s)
    /// <summary>
    /// Default constructor for an AttribureModel object
    /// </summary>
    /// <param name="name">string Then name of the attribute</param>
    /// <param name="description">string A description of the attribute</param>
    /// <param name="value">int The value of the attribute</param>
    public AttributeModel(string name, string description, int value)
    {
        Name = name;
        Description = description;
        Value = value;
    }
    #endregion

    #region Class Methods
    /// <summary>
    /// Calculates the modifier based on the current value of the attribute.
    /// </summary>
    /// <returns>The calculated modifier</returns>
    private int CalculateModifier()
    {
       if (Value > MAX_MOD_LEVEL)
            return MAX_MOD;
       else if (Value < MIN_MOD_LEVEL)
            return MIN_MOD;
       else
            return (Value - 10) / 2;
    }

    /// <summary>
    /// Overriden ToString method for debugging
    /// </summary>
    /// <returns>ToString</returns>
    public override string ToString()
    {
        return Name + ": " + Value + " (" + Modifier + ")\n";
    }
    #endregion
}
