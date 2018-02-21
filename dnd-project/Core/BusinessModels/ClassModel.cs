using System;
using System.Text;

public class ClassModel
{
    private const int DEF_LEVEL = 1;

    public string Name { get; set; }
    public string Description { get; set; }
    public string HitDie { get; set; }
    public string[] PrimaryAttributes { get; set; }
    public string[] SavingThrows { get; set; }
    public string[] Proficiencies { get; set; }
    public string[] Feats { get; set; }

    public ClassModel(string className)
    {
        string[] classInfo = getClassInformation(className);

        Name = classInfo[0];
        Description = classInfo[1];
        HitDie = classInfo[2];
        PrimaryAttributes = classInfo[3].Split(';');
        SavingThrows = classInfo[4].Split(';');
        Proficiencies = classInfo[5].Split(';');
        Feats = classInfo[6].Split(';');

    }

    private string[] getClassInformation(string className)
    {
       return ClassData.classes[className];
    }

    public override string ToString()
    {
        StringBuilder classString = new StringBuilder("\n----------CLASS----------\n");

        classString.Append(Name + "\n");
        classString.Append(Description + "\n");
        classString.Append(HitDie + "\n");

        classString.Append("Primary Attributes: \n");
        foreach (string att in PrimaryAttributes)
        {
            classString.Append("\t" + att + "\n");
        }

        classString.Append("Saving Throws: \n");
        foreach (string save in SavingThrows)
        {
            classString.Append("\t" + save + "\n");
        }

        return classString.ToString();
    }
}

