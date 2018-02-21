using System.Text;

public class FeatModel
{
    const int DESCRIPTION_ELEMENT = 1;
    public string Name { get; set; }
    public string Description { get; set; }

    public FeatModel(string name)
    {
        Name = name;
        Description = getFeatDescription(name);
    }

    private string getFeatDescription(string name)
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
}
