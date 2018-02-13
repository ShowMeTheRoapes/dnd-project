﻿using System;
using System.Text;

public class RaceModel
{
    public string Name { get; set; }
    public string Age { get; set; }
    public string Size { get; set; }
    public string Alignment { get; set; }
    public string Speed { get; set; }
    public string[] AbilityMods { get; set; }
    public string[] Feats { get; set; }
    public string[] Proficiencies { get; set; }

    public RaceModel(string raceName)
    {
        string[] raceInfo = getRaceInformation(raceName);

        Name = raceInfo[0];
        Age = raceInfo[1];
        Size = raceInfo[2];
        Alignment = raceInfo[3];
        Speed = raceInfo[4];
        AbilityMods = raceInfo[5].Split(';');
        Feats = raceInfo[6].Split(';');
        Proficiencies = raceInfo[7].Split(';');
    }

    private string[] getRaceInformation(string raceName)
    {
        return RaceData.races[raceName];
    }

    public override string ToString()
    {
        StringBuilder raceString = new StringBuilder();
        raceString.Append("\nRACE\n");
        
        raceString.Append(Name + "\n");
        raceString.Append("Typically aged between " + Age + " old\n");
        raceString.Append("Size: " + Size + "\n");
        raceString.Append("Alignment: " + Alignment + "\n");
        raceString.Append("Speed: " + Speed + "\n");

        raceString.Append("Ability Modifiers:\n");
        foreach (string mod in AbilityMods)
        {
            raceString.Append("\t" + mod + "\n");
        }

        raceString.Append("Feats:\n");
        foreach  (string feat in Feats)
        {
            raceString.Append("\t" + feat + "\n");
        }

        raceString.Append("Proficiencies:\n");
        foreach  (string prof in Proficiencies)
        {
            raceString.Append("\t" + prof + "\n");
        }

        return raceString.ToString();
    }
}