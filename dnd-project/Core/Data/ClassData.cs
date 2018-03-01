using System.Collections.Generic;

public static class ClassData //Class Name : {Name, Description, Hit Die, Primary Attribute, Saving Throws, Proficiencies, Starting Feats, Skill Choices}
{
    public static readonly Dictionary<string, string[]> classes = new Dictionary<string, string[]>()
    {
        {
            "Barbarian",
            new string[]
            {
                "Barbarian",
                "A fierce warrior of primitive background who can enter a battle rage.",
                "d12",
                "Strength",
                "Strength;Constitution",
                "Light Armor;Medium Armor;Shields;Simple Weapons;Martial Weapons",
                "Rage;Unarmored Defense",
                "2;Animal Handling;Athletics;Intimidation;Nature;Perception;Survival"
            }
        },
        {
            "Bard",
            new string[]
            {
                "Bard",
                "An inspiring magician whose power echoes the music of creation.",
                "d8",
                "Charisma",
                "Dexterity;Charisma",
                "Light Armor;Simple Weapons;Hand Crossbows;Longswords;Rapiers;Shortswords",
                "Spellcasting;Bardic Inspiration",
                "3;Acrobatics;Animal Handling;Arcana;Athletics;Deception;History;Insight;Intimidation;Investigation;Medicine;Nature;Perception;Performance;Persuasion;Religion;Sleight of Hand;Stealth;Survival"
            }
        },
        {
            "Cleric",
            new string[]
            {
                "Cleric",
                "A priestly champion who wields divine magic in service of a higher power.",
                "d8",
                "Wisdom",
                "Wisdom;Charisma",
                "Light Armor;Medium Armor;Shields;Simple Weapons",
                "Spellcasting;Divine Domain",
                "2;History;Insight;Medicine;Persuasion;Religion"
            }
        },
        {
            "Druid",
            new string[]
            {
                "Druid",
                "A priest of the Old Faith, wielding the powers of nature— moonlight and plant growth, fire and lightning— and adopting animal forms.",
                "d8",
                "Wisdom",
                "Intelligence;Wisdom",
                "Light Armor;Medium Armor;Shields;Clubs;Daggers;Darts;Javelins;Maces;Quarterstaffs;Scimitars;Sickles;Slings;Spears",
                "Druidic;Spellcasting",
                "2;Arcana;Animal Handling;Insight;Medicine;Nature;Perception;Religion;Survival"
            }
        },
        {
            "Fighter",
            new string[]
            {
                "Fighter",
                "A master of martial combat, skilled with a variety of weapons and armor.",
                "d10",
                "Strength/Dexterity",
                "Strength;Constitution",
                "All Armor;Shields;Simple Weapons;Martial Weapons",
                "Fighting Style; Second Wind",
                "2;Acrobatics;Animal Handling;Athletics;History;Insight;Intimidation;Perception;Survival"
            }
        },
        {
            "Monk",
            new string[]
            {
                "Monk",
                "A master of martial arts, harnessing the power of the body in pursuit of physical and spiritual perfection.",
                "d8",
                "Dexterity/Wisdom",
                "Strength;Constitution",
                "Simple Weapons;Shortswords",
                "Unarmored Defense;Martial Arts",
                "2;Acrobatics;Athletics;History;Insight;Religion;Stealth"
            }
        },
        {
            "Paladin",
            new string[]
            {
                "Paladin",
                "A holy warrior bound to a sacred oath.",
                "d10",
                "Strength/Charisma",
                "Wisdom;Chraisma",
                "All Armor;Shields;Simple Weapons;Martial Weapons",
                "Divine Sense;Lay on Hands",
                "2;Athletics;Insight;Intimidation;Medicine;Persuasion;Religion"
            }
        },
        {
            "Ranger",
            new string[]
            {
                "Ranger",
                "A warrior who uses martial prowess and nature magic to combat threats on the edges of civilization.",
                "d10",
                "Dexterity/Wisdom",
                "Strength;Dexterity",
                "Light Armor;Medium Armor;Shields;Simple Weapons;Martial Weapons",
                "Favored Enemy;Natural Explorer",
                "3;Animal Handling;Athletics;Insight;Investigation;Nature;Perception;Stealth;Survival"
            }
        },
        {
            "Rogue",
            new string[]
            {
                "Rogue",
                "A soundrel who uses stealth and trickery to overcome obstacles and enemies.",
                "d8",
                "Dexterity",
                "Dexterity;Intelligence",
                "Light Armor;Simple Weapons;Hand Crossbows;Longswords;Rapiers;Shortswords",
                "Expertise;Sneak Attack;Thieves' Cant",
                "4;Acrobatics;Athletics;Deception;Insight;Intimidation;Investigation;Perception;Performance;Persuasion;Slight of Hand;Stealth"
            }
        },
        {
            "Sorcerer",
            new string[]
            {
                "Sorcerer",
                "A spellcaster who draws on inherent magic from a gift or bloodline.",
                "d6",
                "Charisma",
                "Constitution;Charisma",
                "Daggers;Darts;Slings;Quarterstaffs;Light Crossbow",
                "Spellcasting;Sorcerous Origin",
                "2;Arcana;Deception;Insight;Intimidation;Persuasion;Religion"
            }
        },
        {
            "Warlock",
            new string[]
            {
                "Warlock",
                "A wielder of magic that is derived from a bargain with an extraplanar entity.",
                "d8",
                "Charisma",
                "Wisdom;Charisma",
                "Light Armor;Simple Weapons",
                "Otherworldly Patron;Pact Magic",
                "2;Arcana;Deception;History;Intimidation;Investigation;Nature;Religion"
            }
        },
        {
            "Wizard",
            new string[]
            {
                "Wizard",
                "A scholarly magic-user capable of manipulating the structures of reality.",
                "d6",
                "Intelligence",
                "Intelligence;Wisdom",
                "Daggers;Darts;Slings;Quarterstaffs;Light Crossbows",
                "Spellcasting;Arcane Recovery",
                "2;Arcana;History;Insight;Investigation;Medicine;Religion"
            }
        }
    };

}
