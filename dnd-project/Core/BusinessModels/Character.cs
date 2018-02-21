using System.Collections.Generic;
using System.Text;

class Character
{
    #region Variable Declarations
    private ClassModel characterClass;
    private RaceModel characterRace;
    private AttributesListModel attributesList;
    private SkillsListModel skillsList;
    private HashSet<FeatModel> featsList;
    private SortedSet<string> proficienciesList;

    public string Name { get; set; }
    public string PersonalityTraits { get; set; }
    public string Ideals { get; set; }
    public string Bonds { get; set; }
    public string Flaws { get; set; }
    public string Alignment { get; set; }
    public string Speed { get; set; }
    public string Height { get; set; }
    public string Weight { get; set; }
    public string Eyes { get; set; }
    public string Skin { get; set; }
    public string Hair { get; set; }
    public int Level { get; set; }
    public int Age { get; set; }
    public int ExperiencePoints { get; set; }
    public int ArmorClass { get; set; }
    public int Initiative { get; set; }
    public int Inspiration { get; set; }
    public int ProficiencyBonus { get; set; }
    public int MaxHitPoints { get; set; }
    public int CurrentHitPoints { get; set; }
    #endregion

    #region Constructor
    public Character()
    {
        attributesList = new AttributesListModel();
        skillsList = new SkillsListModel();
        featsList = new HashSet<FeatModel>();
        proficienciesList = new SortedSet<string>();

        Name = "";
        PersonalityTraits = "";
        Ideals = "";
        Bonds = "";
        Flaws = "";
        Alignment = "";
        Speed = "";
        Height = "";
        Weight = "";
        Eyes = "";
        Skin = "";
        Hair = "";
        Level = 0;
        Age = 0;
        ExperiencePoints = 0;
        ArmorClass = 0;
        Initiative = 0;
        Inspiration = 0;
        ProficiencyBonus = 0;
        MaxHitPoints = 0;
        CurrentHitPoints = 0;
    }
    #endregion

    #region Methods
    /// <summary>
    /// Method to set the character's class info based on a provided name.
    /// </summary>
    /// <param name="className">The name of the class</param>
    public void setCharacterClass(string className)
    {
        characterClass = new ClassModel(className);

        //Only aggregate feats when both class and race are initialized
        if (characterRace != null)
            aggregateData();
    }

    /// <summary>
    /// Method to get the character's race info based on a provided name.
    /// </summary>
    /// <param name="raceName">The name of the race</param>
    public void setCharacterRace(string raceName)
    {
        characterRace = new RaceModel(raceName);

        //Only aggregate feats when both class and race are initialized
        if (characterClass != null)
            aggregateData();
    }

    /// <summary>
    /// Method to pull the feat information from the character's class and race information.
    /// </summary>
    private void aggregateData()
    {
        featsList.Clear();
        proficienciesList.Clear();

        foreach (string featName in characterClass.Feats)
            featsList.Add(new FeatModel(featName));

        foreach (string prof in characterClass.Proficiencies)
            proficienciesList.Add(prof);
        

        foreach (string featName in characterRace.Feats)
            featsList.Add(new FeatModel(featName));

        foreach (string prof in characterRace.Proficiencies)
            proficienciesList.Add(prof);
    }

    public override string ToString()
    {
        StringBuilder output = new StringBuilder();
        output.Append("\n=====" + Name + "=====\n");

        output.Append(characterClass.ToString());
        output.Append(characterRace.ToString());
        output.Append(attributesList.ToString());
        output.Append(skillsList.ToString());

        output.Append("\n-----FEATS-----\n");
        foreach (FeatModel feat in featsList)
            output.Append(feat.ToString());

        output.Append("\n-----PROFICIENCIES-----\n");
        foreach (string prof in proficienciesList)
            output.Append(prof + "\n");

        return output.ToString();
    }
    #endregion
}

