using System;
using System.Collections.Generic;

public class AttributesList
{
    private const int DEF_VALUE = 10;

    public List<Attribute> Attributes { get; set; }

    public AttributesList()
    {
        Attributes = new List<Attribute>();

        foreach (string[] attr in AttributesData.attributes)
        {
            Attributes.Add(new Attribute(attr[0], attr[1], DEF_VALUE));
        }
    }
}
