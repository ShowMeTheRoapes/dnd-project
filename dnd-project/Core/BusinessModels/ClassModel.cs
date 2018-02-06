using System;

public class ClassModel
{
    private const int DEF_LEVEL = 1;

    public string Name { get; set; }
    public string Description { get; set; }
    public string HitDie { get; set; }
    public string PrimaryAttributes { get; set; }
    public string[] SavingThrows { get; set; }
    public string[] Proficiencies { get; set; }
    public string[] Feats { get; set; }

    public ClassModel(string className)
    {
        String[] theClass = getClassInformation(className);

        Name = theClass[0];
        Description = theClass[1];
        HitDie = theClass[2];
        PrimaryAttributes = theClass[3];
        SavingThrows = theClass[4].Split(';');
        Proficiencies = theClass[5].Split(';');
        Feats = theClass[6].Split(';');

    }

    private string[] getClassInformation(string className)
    {
        string[] theClass = { };
        for (int i = 0; i < ClassData.classes.Length; i++)
        {
            if (ClassData.classes[i][0] == className)
            {
               theClass = ClassData.classes[i];
            }
        }

        return theClass;
    }
}

