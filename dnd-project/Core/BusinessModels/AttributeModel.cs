
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
    public AttributeModel()
    {
        Name = "";
        Description = "";
        Value = 0;
        Modifier = 0;
    }

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
    /// <returns></returns>
    private int CalculateModifier()
    {
       if (Value > MAX_MOD_LEVEL)
            return MAX_MOD;
       else if (Value < MIN_MOD_LEVEL)
            return MIN_MOD;
       else
            return (Value - 10) / 2;
    }

    public override string ToString()
    {
        return Name + ": " + Value + " (" + Modifier + ")\n";
    }
    #endregion
}
