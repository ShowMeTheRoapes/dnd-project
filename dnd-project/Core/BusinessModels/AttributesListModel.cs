using System;
using System.Collections.Generic;

public class AttributesListModel
{
    private const int DEF_VALUE = 10;

    public List<AttributeModel> Attributes { get; set; }

    public AttributesListModel()
    {
        Attributes = new List<AttributeModel>();

        foreach (string[] attr in AttributesData.attributes)
        {
            Attributes.Add(new AttributeModel(attr[0], attr[1], DEF_VALUE));
        }
    }
}
