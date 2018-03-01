using System.Text;

public class FeatModel
{
    #region Instance Variables and Properties
    const int DESCRIPTION_ELEMENT = 1;
    public string Name { get; set; }
    public string Description { get; set; }
    #endregion

    #region Constructor(s)
    public FeatModel(string name)
    {
        Name = name;
        Description = GetFeatDescription(name);
    }
    #endregion

    #region Class Methods
    private string GetFeatDescription(string name)
    {
        return FeatData.feats[name][DESCRIPTION_ELEMENT];
    }

    public override string ToString()
    {
        StringBuilder output = new StringBuilder("");
        output.AppendLine("Name: " + Name);
        output.AppendLine("Description: ");
        output.Append(Description + "\n");
        output.AppendLine();

        return output.ToString();
    }
    #endregion
}
