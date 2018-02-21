using System.Collections.Generic;
using System.Text;

public class AttributesListModel
{
    #region Instance Variables and Properties
    private const int DEF_VALUE = 10;
    private const int NAME_POS = 0;
    private const int DESC_POS = 1;

    public Dictionary<string, AttributeModel> Attributes { get; set; }
    #endregion

    #region Constructor(s)
    public AttributesListModel()
    {
        Attributes = new Dictionary<string, AttributeModel>();

        foreach (string[] attr in AttributesData.attributes)
        {
            Attributes[attr[NAME_POS]] = new AttributeModel(attr[NAME_POS], attr[DESC_POS], DEF_VALUE);
        }
    }
    #endregion

    #region Class Methods
    public override string ToString()
    {
        StringBuilder output = new StringBuilder();

        output.Append("\n-----ATTRIBUTES-----\n");
        foreach (string attr_name in Attributes.Keys)
        {
            output.Append(Attributes[attr_name].ToString());
        }

        return output.ToString();
    }
    #endregion
}
