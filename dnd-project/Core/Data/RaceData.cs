using System;
using System.Collections.Generic;

public static class RaceData
{
    //Name, Age Range, Size, Alignment, Speed, Ability Scores(Bonus), Feats, Proficiencies
    public static readonly Dictionary<string, string[]> races = new Dictionary<string, string[]>
    {
        {
            "Hill Dwarf",
            new String[]
            {
                "Hill Dwarf",
                "50-350 years",
                "Medium",
                "Lawful",
                "25 feet",
                "Constitution 2;Wisdom 1",
                "Darkvision;Dwarven Resilience;Dwarven Combat Training;Stonecunning;Dwarven Toughness",
                "Common Language;Dwarvish Language;Smith's Tools~Brewer's Supplies~Mason's Tools"
            }
        },
        {
            "Mountain Dwarf",
            new String[]
            {
                "Mountain Dwarf",
                "50-350 years",
                "Medium",
                "Lawful",
                "25 feet",
                "Constitution 2;Strength 2",
                "Darkvision;Dwarven Resilience;Dwarven Combat Training;Stonecunning",
                "Common Language;Dwarvish Language;Light Armor;Medium Armor;Smith's Tools~Brewer's Supplies~Mason's Tools"
            }
        },
        {
            "High Elf",
            new String[]
            {
                "High Elf",
                "100-750 years",
                "Medium",
                "Chaotic Good",
                "30 feet",
                "Dexterity 2;Intelligence 1",
                "Darkvision;Keen Senses;Fey Ancestry;Trance;Cantrip;Extra Language",
                "Common Language;Elvish Language;Longsword;Shortsword;Shortbow;Longbow"
            }
        },
        {
            "Wood Elf",
            new String[]
            {
                "Wood Elf",
                "100-750 years",
                "Medium",
                "Chaotic Good",
                "35 feet",
                "Dexterity 2;Wisdom 1",
                "Darkvision;Keen Senses;Fey Ancestry;Trance;Mask of the Wild",
                "Common Language;Elvish Language;Longsword;Shortsword;Shortbow;Longbow"
            }
        },
        {
            "Dark Elf (Drow)",
            new String[]
            {
                "Dark Elf (Drow)",
                "100-750 years",
                "Medium",
                "Chaotic Evil",
                "30 feet",
                "Dexterity 2;Charisma 1",
                "Superior Darkvision;Keen Senses;Fey Ancestry;Trance;Sunlight Sensitivity;Drow Magic",
                "Common Language;Elvish Language;Rapier;Shortsword;Hand Crossbow",
            }
        },
        {
            "Lightfoot Halfling",
            new String[]
            {
                "Lightfoot Halfling",
                "20-150 years",
                "Small",
                "Lawful Good",
                "25 feet",
                "Dexterity 2;Charisma 1",
                "Lucky;Brave;Halfling Nimbleness;Naturally Stealthy",
                "Common Language;Halfling Language"
            }
        },
        {
            "Stout Halfling",
            new String[]
            {
                "Stout Halfling",
                "20-150 years",
                "Small",
                "Lawful Good",
                "25 feet",
                "Dexterity 2;Constitution 1",
                "Lucky;Brave;Halfling Nimbleness;Stout Resilience",
                "Common Language;Halfling Language"
            }
        },
        {
            "Human",
            new String[]
            {
                "Human",
                "18-100 years",
                "Medium",
                "True Neutral",
                "30 feet",
                "Strength 1;Dexterity 1;Charisma 1;Constitution 1;Wisdom 1;Intelligence 1",
                "Extra Language",
                "Common Language"
            }
        },
        {
            "Dragonborn",
            new String[]
            {
                "Dragonborn",
                "15-80 years",
                "Medium",
                "Neutral Good",
                "30 feet",
                "Strength 2;Charisma 1",
                "Draconic Ancestry;Breath Weapon;Damage Resistance",
                "Common Language;Draconic Language"
            }
        },
        {
            "Forest Gnome",
            new String[]
            {
                "Forest Gnome",
                "40-500 years",
                "Small",
                "Neutral Good",
                "25 feet",
                "Intelligence 2;Dexterity 1",
                "Darkvision;Gnome Cunning;Natural Illusionist;Speak with Small Beasts",
                "Common Language;Gnomish Language"
            }
        },
        {
            "Rock Gnome",
            new String[]
            {
                "Rock Gnome",
                "40-500 years",
                "Small",
                "Neutral Good",
                "25 feet",
                "Intelligence 2;Constitution 1",
                "Darkvision;Gnome Cunning;Artificer's Lore;Tinker",
                "Common Language;Gnomish Language"
            }
        },
        {
            "Half-Elf",
            new String[]
            {
                "Half-Elf",
                "18-180 years",
                "Medium",
                "Chaotic Neutral",
                "30 feet",
                "Charisma 2;Other 1;Other 1",
                "Darkvision;Fey Ancestry;Skill Versatility;Extra Language",
                "Common Language;Elvish Language"
            }
        },
        {
            "Half-Orc",
            new String[]
            {
                "Half-Orc",
                "14-75 years",
                "Medium",
                "Chaotic Neutral",
                "30 feet",
                "Strength 2;Constitution 1",
                "Darkvision;Relentless Endurance;Savage Attacks",
                "Common Language;Orc Language;Intimidation"
            }
        },
        {
            "Tiefling",
            new String[]
            {
                "Tiefling",
                "18-110 years",
                "Medium",
                "Chaotic Neutral",
                "30 feet",
                "Charisma 2;Intelligence 1",
                "Darkvision;Hellish Resistance;Infernal Legacy",
                "Common Language;Infernal Language"
            }
        }
    };
}
