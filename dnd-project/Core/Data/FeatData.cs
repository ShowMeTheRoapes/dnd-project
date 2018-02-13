using System;
using System.Collections.Generic;

public static class FeatData
{
    public static readonly Dictionary<string, string[]> feats = new Dictionary<string, string[]> 
    {
        {
            "Arcane Recovery",
            new string[]
            {
                "Arcane Recovery",
                "You have learned to regain some of your magical energ by studying your spellbook. Once per day when you finish a short rest, you can choose expended spell slots to recover. The spell slots can have a combined level that is equal to or less than half your wizard level (rounded up), and none o f the slots can be 6th level or higher. For example, if you’re a 4th-level wizard, you can recover up to two levels worth of spell slots. You can recover either a 2nd-level spell slot or two 1st-level spell slots."
            }
        },
        {
            "Artificer's Lore",
            new string[]
            {
                "Artificer's Lore",
                "Whenever you make an Intelligence (History) check related to magic items, alchemical objects, or technological devices, you can add twice your proficiency bonus, instead of any proficiency bonus you normally apply."
            }
        },
        {
            "Bardic Inspiration",
            new string[]
            {
                "Bardic Inspiration",
                @"You can inspire others through stirring w ords or music. To do so, you use a bonus action on your turn to choose one creature other than yourself within 60 feet of you who can hear you. That creature gains one Bardic Inspiration die, a d6. 
                Once within the next 10 minutes, the creature can roll the die and add the number rolled to one ability check, attack roll, or saving throw it makes. The creature can wait until after it rolls the d20 before deciding to use the Bardic Inspiration die, but must decide before the DM says whether the roll succeeds or fails. Once the Bardic Inspiration die is rolled, it is lost. A creature can have only one Bardic Inspiration die at a time.
                You can use this feature a number of times equal to your Charisma modifier (a minimum of once). You regain any expended uses when you finish a long rest. Your Bardic Inspiration die changes when you reach certain levels in this class. The die becomes a d8 at 5th level, a d 10 at 10th level, and a d12 at 15th level."
            }
        },
        {
            "Brave",
            new string[]
            {
                "Brave",
                "You have advantage on saving throws against being frightened."
            }
        },
        {
            "Breath Weapon",
            new string[]
            {
                "Breath Weapon",
                @"You can use your action to exhale destructive energy. Your draconic ancestry determines the size, shape, and damage type of the exhalation. When you use your breath weapon, each creature in the area of the exhalation must make a saving throw, the type of which is determined by your draconic ancestry. The DC for this saving throw equals 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increases to 3d6 at 6th level, 4d6 at 11th level, and 5d6 at 16th level. After you use your breath weapon, you can’t use it again until you complete a short or long rest."
            }
        },
        {
            "Cantrip",
            new string[]
            {
                "Cantrip",
                "A spell that can be cast at will, without using a spell slot and without being prepared in advance. Repeated practice has fixed the spell in the caster’s mind and infused the caster with the magic needed to produce the effect over and over. A cantrip’s spell level is 0."
            }
        },
        {
            "Damage Resistance",
            new string[]
            {
                "Damage Resistance",
                "You have resistance to the damage type associated with your draconic ancestry."
            }
        },
        {
            "Darkvision",
            new string[]
            {
                "Darkvision",
                "Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray."
            }
        },
        {
            "Divine Domain",
            new string[]
            {
                "Divine Domain",
                @"Choose one domain related to your deity: Knowledge, Life, Light, Nature, Tempest, Trickery, or War. Each domain is detailed at the end o f the class description, and each one provides examples o f gods associated with it. Your choice grants you domain  pells and other features when you choose it at 1st level. It also grants you additional ways to use Channel Divinity when you gain that feature at 2nd level, and additional benefits at 6th, 8th, and 17th levels.
                Each domain has a list of spells — its domain spells — that you gain at the cleric levels noted in the domain description. Once you gain a domain spell, you always have it prepared, and it doesn’t count against the number o f spells you can prepare each day. If you have a domain spell that doesn’t appear on the cleric spell list, the spell is nonetheless a cleric spell for you."
            }
        },
        {
            "Divine Sense",
            new string[]
            {
                "Divine Sense",
                "The presence of strong evil registers on your senses like a noxious odor, and powerful good rings like heavenly music in your ears. As an action, you can open your awareness to detect such forces. Until the end of your next turn, you know the location of any celestial, fiend, or undead within 60 feet of you that is not behind total cover. You know the type (celestial, fiend, or undead) of any being whose presence you sense, but not its identity (the vampire Count Strahd von Zarovich, for instance). Within the same radius, you also detect the presence of any place or object that has been consecrated or desecrated, as with the hallow spell. You can use this feature a number of times equal to 1 + your Charisma modifier. When you finish a long rest, you regain all expended uses."
            }
        },
        {
            "Draconic Ancestry",
            new string[]
            {
                "Draconic Ancestry",
                "You have draconic ancestry. Choose one type of dragon from the Draconic Ancestry table on page 34 of the Player's Handbook. Your breath weapon and damage resistance are determined by the dragon type, as shown in the table."
            }
        },
        {
            "Drow Magic",
            new string[]
            {
                "Drow Magic",
                "You know the dancing lights cantrip. When you reach 3rd level, you can cast the faerie fire spell once per day. When you reach 5th level, you can also cast the darkness spell once per day. Charisma is your spellcasting ability for these spells."
            }
        },
        {
            "Druidic",
            new string[]
            {
                "Druidic",
                "You know Druidic, the secret language o f druids. You can speak the language and use it to leave hidden messages. You and others who know this language automatically spot such a message. Others spot the message’s presence with a successful DC 15 Wisdom (Perception) check but can’t decipher it without magic."
            }
        },
        {
            "Dwarven Resilience",
            new string[]
            {
                "Dwarven Resilience",
                "You have advantage on saving throws against poison, and you have resistance against poison damage (explained in chapter 9)."
            }
        },
        {
            "Dwarven Toughness",
            new string[]
            {
                "Dwarven Toughness",
                "Your hit point maximum increases by 1, and it increases by 1 every time you gain a level."
            }
        },
        {
            "Expertise",
            new string[]
            {
                "Expertise",
                "Two of your skill proficiencies, or one of your skill proficiencies and your proficiency with thieves’ tools. Your proficiency bonus is doubled for anyability check you make that uses either of the chosen proficiencies. At 6th level, you can choose two more of your proficiencies (in skills or with thieves’ tools) to gain this benefit."
            }
        },
        {
            "Extra Language",
            new string[]
            {
                "Extra Language",
                "You can speak, read, and write one extra language of your choice."
            }
        },
        {
            "Favored Enemy",
            new string[]
            {
                "Favored Enemy",
                @"You have significant experience studying, tracking, hunting, and even talking to a certain type of enemy. 
                Choose a type of favored enemy: aberrations, beasts, celestials, constructs, dragons, elementals, fey,
                fiends, giants, monstrosities, oozes, plants, or undead. Alternatively, you can select two races of humanoid
                (such as gnolls and orcs) as favored enemies.
                You have advantage on Wisdom (Survival) checks to track your favored enemies, as well as on Intelligence checks to recall information about them.
                When you gain this feature, you also learn one language of your choice that is spoken by your favored enemies, if they speak one at all.
                You choose one additional favored enemy, as well as an associated language, at 6th and 14th level. As you gain levels, your choices should reflect the types of monsters you have encountered on your adventures."
            }
        },
        {
            "Fey Ancestry",
            new string[]
            {
                "Fey Ancestry",
                "You have advantage on saving throws against being charmed, and magic can’t put you to sleep."
            }
        },
        {
            "Fighting Style",
            new string[]
            {
                "Fighting Style",
                @"You adopt a particular style of fighting as your specialty. Choose one of the following options. You can’t take a Fighting Style option more than once, even if you later get to choose again. 

                Archery (Fighter And Ranger) - You gain a +2 bonus to attack rolls you make with ranged weapons.

                Defense (All) - While you are wearing armor, you gain a +1 bonus to AC.

                Dueling (All) - When you are wielding a melee weapon in one hand and no other weapons, you gain a +2 bonus to damage rolls with that weapon.

                Great Weapon Fighting (Fighter And Paladin) - When you roll a 1 or 2 on a damage die for an attack you make with a melee weapon that you are wielding with two hands, you can reroll the die and must use the new roll, even if the new roll is a 1 or a 2. The weapon must have the two-handed or versatile property for you to gain this benefit.

                Protection (Fighter And Paladin) - When a creature you can see attacks a target other than you that is within 5 feet of you, you can use your reaction to impose disadvantage on the attack roll. You must be wielding a shield.

                Two-Weapon Fighting (Fighter And Ranger) - When you engage in two-weapon fighting, you can add your ability modifier to the damage of the second attack."
            }
        },
        {
            "Gnome Cunning",
            new string[]
            {
                "Gnome Cunning",
                "definition"
            }
        },
        {
            "Halfling Nimbleness",
            new string[]
            {
                "Halfling Nimbleness",
                "definition"
            }
        },
        {
            "Hellish Resistance",
            new string[]
            {
                "Hellish Resistance",
                "definition"
            }
        },
        {
            "Infernal Legacy",
            new string[]
            {
                "Infernal Legacy",
                "definition"
            }
        },
        {
            "Lay on Hands",
            new string[]
            {
                "Lay on Hands",
                "definition"
            }
        },
        {
            "Lucky",
            new string[]
            {
                "Lucky",
                "definition"
            }
        },
        {
            "Martial Arts",
            new string[]
            {
                "Martial Arts",
                "definition"
            }
        },
        {
            "Mask of the Wild",
            new string[]
            {
                "Mask of the Wild",
                "definition"
            }
        },
        {
            "Natural Explorer",
            new string[]
            {
                "Natural Explorer",
                "definition"
            }
        },
        {
            "Natural Illusionist",
            new string[]
            {
                "Natural Illusionist",
                "definition"
            }
        },
        {
            "Naturally Stealthy",
            new string[]
            {
                "Naturally Stealthy",
                "definition"
            }
        },
        {
            "Other Worldly Patron",
            new string[]
            {
                "Other Worldly Patron",
                "definition"
            }
        },
        {
            "Pact Magic",
            new string[]
            {
                "Pact Magic",
                "definition"
            }
        },
        {
            "Rage",
            new string[]
            {
                "Rage",
                "definition"
            }
        },
        {
            "Relentless Endurance",
            new string[]
            {
                "Relentless Endurance",
                "definition"
            }
        },
        {
            "Savage Attacks",
            new string[]
            {
                "Savage Attacks",
                "definition"
            }
        },
        {
            "Second Wind",
            new string[]
            {
                "Second Wind",
                "definition"
            }
        },
        {
            "Skill Versatility",
            new string[]
            {
                "Skill Versatility",
                "definition"
            }
        },
        {
            "Sneak Attack",
            new string[]
            {
                "Sneak Attack",
                "definition"
            }
        },
        {
            "Sorcerous Origin",
            new string[]
            {
                "Sorcerous Origin",
                "definition"
            }
        },
        {
            "Speak with Small Beasts",
            new string[]
            {
                "Speak with Small Beasts",
                "definition"
            }
        },
        {
            "Spellcasting",
            new string[]
            {
                "Spellcasting",
                "definition"
            }
        },
        {
            "Stonecunning",
            new string[]
            {
                "Stonecunning",
                "definition"
            }
        },
        {
            "Stout Resilience",
            new string[]
            {
                "Stout Resilience",
                "definition"
            }
        },
        {
            "Sunlight Sensitivity",
            new string[]
            {
                "Sunlight Sensitivity",
                "definition"
            }
        },
        {
            "Superior Darkvision",
            new string[]
            {
                "Superior Darkvision",
                "definition"
            }
        },
        {
            "Thieves' Cant",
            new string[]
            {
                "Thieves' Cant",
                "definition"
            }
        },
        {
            "Tinker",
            new string[]
            {
                "Tinker",
                "definition"
            }
        },
        {
            "Trance",
            new string[]
            {
                "Trance",
                "definition"
            }
        },
        {
            "Unarmored Defense",
            new string[]
            {
                "Unarmored Defense",
                "definition"
            }
        }
    };
}
