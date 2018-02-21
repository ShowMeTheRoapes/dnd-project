using System.Collections.Generic;
using System.Text;

public class AttributesListModel
{
    #region Instance Variables and Properties
    private const int DEF_VALUE = 10;

    public List<AttributeModel> Attributes { get; set; }
    #endregion

    #region Constructor(s)
    public AttributesListModel()
    {
        Attributes = new List<AttributeModel>();

        foreach (string[] attr in AttributesData.attributes)
        {
            Attributes.Add(new AttributeModel(attr[0], attr[1], DEF_VALUE));
        }
    }
    #endregion

    #region Class Methods
    public override string ToString()
    {
        StringBuilder output = new StringBuilder();

        output.Append("\n-----ATTRIBUTES-----\n");
        foreach (AttributeModel attr in Attributes)
        {
            output.Append(attr.ToString());
        }

        return output.ToString();
    }
    #endregion
}
