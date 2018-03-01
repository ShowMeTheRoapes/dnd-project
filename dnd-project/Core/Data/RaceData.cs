using System.Collections.Generic;

public static class RaceData //Name, Age Range, Size, Alignment, Speed, Ability Scores(Bonus), Feats, Proficiencies
{
    public static readonly Dictionary<string, string[]> races = new Dictionary<string, string[]>
    {
        {
            "Hill Dwarf",
            new string[]
            {
                "Hill Dwarf",
                "50-350 years",
                "Medium",
                "Lawful",
                "25 feet",
                "Constitution 2;Wisdom 1",
                "Darkvision;Dwarven Resilience;Stonecunning;Dwarven Toughness",
                "Common Language;Dwarvish Language;Battleaxes;Handaxes;Throwing Hammers;Warhammers;Smith's Tools~Brewer's Supplies~Mason's Tools"
            }
        },
        {
            "Mountain Dwarf",
            new string[]
            {
                "Mountain Dwarf",
                "50-350 years",
                "Medium",
                "Lawful",
                "25 feet",
                "Constitution 2;Strength 2",
                "Darkvision;Dwarven Resilience;Stonecunning",
                "Common Language;Dwarvish Language;Battleaxes;Handaxes;Throwing Hammers;Warhammers;Light Armor;Medium Armor;Smith's Tools~Brewer's Supplies~Mason's Tools"
            }
        },
        {
            "High Elf",
            new string[]
            {
                "High Elf",
                "100-750 years",
                "Medium",
                "Chaotic Good",
                "30 feet",
                "Dexterity 2;Intelligence 1",
                "Darkvision;Fey Ancestry;Trance;Cantrip;Extra Language;Keen Senses",
                "Common Language;Elvish Language;Longswords;Shortswords;Shortbows;Longbows"
            }
        },
        {
            "Wood Elf",
            new string[]
            {
                "Wood Elf",
                "100-750 years",
                "Medium",
                "Chaotic Good",
                "35 feet",
                "Dexterity 2;Wisdom 1",
                "Darkvision;Fey Ancestry;Trance;Mask of the Wild;Keen Senses",
                "Common Language;Elvish Language;Longswords;Shortswords;Shortbows;Longbows"
            }
        },
        {
            "Dark Elf",
            new string[]
            {
                "Dark Elf (Drow)",
                "100-750 years",
                "Medium",
                "Chaotic Evil",
                "30 feet",
                "Dexterity 2;Charisma 1",
                "Superior Darkvision;Fey Ancestry;Trance;Sunlight Sensitivity;Drow Magic;Keen Senses",
                "Common Language;Elvish Language;Rapiers;Shortswords;Hand Crossbows",
            }
        },
        {
            "Lightfoot Halfling",
            new string[]
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
            new string[]
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
            new string[]
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
            new string[]
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
            new string[]
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
            new string[]
            {
                "Rock Gnome",
                "40-500 years",
                "Small",
                "Neutral Good",
                "25 feet",
                "Intelligence 2;Constitution 1",
                "Darkvision;Gnome Cunning;Artificer's Lore;Tinker",
                "Common Language;Gnomish Language;Artisan's Tools (Tinker's Tools)"
            }
        },
        {
            "Half-Elf",
            new string[]
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
            new string[]
            {
                "Half-Orc",
                "14-75 years",
                "Medium",
                "Chaotic Neutral",
                "30 feet",
                "Strength 2;Constitution 1",
                "Darkvision;Relentless Endurance;Savage Attacks;Menacing",
                "Common Language;Orc Language"
            }
        },
        {
            "Tiefling",
            new string[]
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
