﻿using System.Collections.Generic;

public static class FeatData //Feat Name: {Feat Name, Feat Description}
{
    public static readonly Dictionary<string, string[]> feats = new Dictionary<string, string[]> 
    {
        {
            "Arcane Recovery",
            new string[]
            {
                "Arcane Recovery",
                "You have learned to regain some of your magical energy by studying your spellbook. Once per day when you finish a short rest, you can choose expended spell slots to recover. The spell slots can have a combined level that is equal to or less than half your wizard level (rounded up), and none o f the slots can be 6th level or higher. For example, if you’re a 4th-level wizard, you can recover up to two levels worth of spell slots. You can recover either a 2nd-level spell slot or two 1st-level spell slots."
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
                "You can inspire others through stirring words or music. To do so, you use a bonus action on your turn to choose one creature other than yourself within 60 feet of you who can hear you. That creature gains one Bardic Inspiration die, a d6.\n" + 
                "Once within the next 10 minutes, the creature can roll the die and add the number rolled to one ability check, attack roll, or saving throw it makes. The creature can wait until after it rolls the d20 before deciding to use the Bardic Inspiration die, but must decide before the DM says whether the roll succeeds or fails. Once the Bardic Inspiration die is rolled, it is lost. A creature can have only one Bardic Inspiration die at a time.\n" +
                "You can use this feature a number of times equal to your Charisma modifier (a minimum of once). You regain any expended uses when you finish a long rest. Your Bardic Inspiration die changes when you reach certain levels in this class. The die becomes a d8 at 5th level, a d 10 at 10th level, and a d12 at 15th level."
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
                "You can use your action to exhale destructive energy. Your draconic ancestry determines the size, shape, and damage type of the exhalation. When you use your breath weapon, each creature in the area of the exhalation must make a saving throw, the type of which is determined by your draconic ancestry. The DC for this saving throw equals 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increases to 3d6 at 6th level, 4d6 at 11th level, and 5d6 at 16th level. After you use your breath weapon, you can’t use it again until you complete a short or long rest."
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
                "Choose one domain related to your deity: Knowledge, Life, Light, Nature, Tempest, Trickery, or War. Each domain is detailed at the end o f the class description, and each one provides examples o f gods associated with it. Your choice grants you domain  pells and other features when you choose it at 1st level. It also grants you additional ways to use Channel Divinity when you gain that feature at 2nd level, and additional benefits at 6th, 8th, and 17th levels.\n" +
                "Each domain has a list of spells — its domain spells — that you gain at the cleric levels noted in the domain description. Once you gain a domain spell, you always have it prepared, and it doesn’t count against the number o f spells you can prepare each day. If you have a domain spell that doesn’t appear on the cleric spell list, the spell is nonetheless a cleric spell for you."
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
                "You have significant experience studying, tracking, hunting, and even talking to a certain type of enemy.\n" +
                "Choose a type of favored enemy: aberrations, beasts, celestials, constructs, dragons, elementals, fey, fiends, giants, monstrosities, oozes, plants, or undead. Alternatively, you can select two races of humanoid (such as gnolls and orcs) as favored enemies.\n" +
                "You have advantage on Wisdom (Survival) checks to track your favored enemies, as well as on Intelligence checks to recall information about them.\n" +
                "When you gain this feature, you also learn one language of your choice that is spoken by your favored enemies, if they speak one at all. You choose one additional favored enemy, as well as an associated language, at 6th and 14th level. As you gain levels, your choices should reflect the types of monsters you have encountered on your adventures."
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
                "You adopt a particular style of fighting as your specialty. Choose one of the following options. You can’t take a Fighting Style option more than once, even if you later get to choose again.\n\n" + 
                "Archery (Fighter And Ranger) - You gain a +2 bonus to attack rolls you make with ranged weapons.\n\n" +
                "Defense (All) - While you are wearing armor, you gain a +1 bonus to AC.\n\n" + 
                "Dueling (All) - When you are wielding a melee weapon in one hand and no other weapons, you gain a +2 bonus to damage rolls with that weapon.\n\n" + 
                "Great Weapon Fighting (Fighter And Paladin) - When you roll a 1 or 2 on a damage die for an attack you make with a melee weapon that you are wielding with two hands, you can reroll the die and must use the new roll, even if the new roll is a 1 or a 2. The weapon must have the two-handed or versatile property for you to gain this benefit.\n\n" +
                "Protection (Fighter And Paladin) - When a creature you can see attacks a target other than you that is within 5 feet of you, you can use your reaction to impose disadvantage on the attack roll. You must be wielding a shield.\n\n" +
                "Two-Weapon Fighting (Fighter And Ranger) - When you engage in two-weapon fighting, you can add your ability modifier to the damage of the second attack."
            }
        },
        {
            "Gnome Cunning",
            new string[]
            {
                "Gnome Cunning",
                "You have advantage on all Intelligence, Wisdom, and Charisma saving throws against magic."
            }
        },
        {
            "Halfling Nimbleness",
            new string[]
            {
                "Halfling Nimbleness",
                "You can move through the space of any creature that is of a size larger than yours."
            }
        },
        {
            "Hellish Resistance",
            new string[]
            {
                "Hellish Resistance",
                "You have resistance to fire damage."
            }
        },
        {
            "Infernal Legacy",
            new string[]
            {
                "Infernal Legacy",
                "You know the thaumaturgy cantrip. Once you reach 3rd level, you can cast the hellish rebuke spell once per day as a 2nd-level spell. Once you reach 5th level, you can also cast the darkness spell once per day. Charisma is your spellcasting ability for these spells."
            }
        },
        {
            "Keen Senses",
            new string[]
            {
                "Keen Senses",
                "You gain proficiency in the Perception skill."
            }
        },
        {
            "Lay on Hands",
            new string[]
            {
                "Lay on Hands",
                "Your blessed touch can heal wounds. You have a pool of healing power that replenishes when you take a long rest. With that pool, you can restore a total number of hit points equal to your paladin level x 5.\n" +
                "As an action, you can touch a creature and draw power from the pool to restore a number of hit points to that creature, up to the maximum amount remaining in your pool.\n" + 
                "Alternatively, you can expend 5 hit points from your pool of healing to cure the target of one disease or neutralize one poison affecting it. You can cure multiple diseases and neutralize multiple poisons with a single use of Lay on Hands, expending hit points separately for each one. This feature has no effect on undead and constructs."
            }
        },
        {
            "Lucky",
            new string[]
            {
                "Lucky",
                "When you roll a 1 on an attack roll, ability check, or saving throw, you can reroll the die and must use the new roll."
            }
        },
        {
            "Martial Arts",
            new string[]
            {
                "Martial Arts",
                "Your practice of martial arts gives you mastery of combat styles that use unarmed strikes and monk weapons, which are shortswords and any simple melee weapons that don’t have the two-handed or heavy property. You gain the following benefits while you are unarmed or wielding only monk weapons and you aren’t wearing armor or wielding a shield:\n" +
                "You can use Dexterity instead of Strength for the attack and damage rolls of your unarmed strikes and monk weapons. You can roll a d4 in place of the normal damage of your unarmed strike or monk weapon. This die changes as you gain monk levels, as shown in the Martial Arts column of the Monk table.\n" +
                "When you use the Attack action with an unarmed strike or a monk weapon on your turn, you can make one unarmed strike as a bonus action. For example, if you take the Attack action and attack with a quarterstaff, you can also make an unarmed strike as a bonus action, assuming you haven't already taken a bonus action this turn.\n" + 
                "Certain monasteries use specialized forms of the monk weapons. For example, you might use a club that is two lengths of wood connected by a short chain (called a nunchaku) or a sickle with a shorter, straighter blade (called a kama). Whatever name you use for a monk weapon, you can use the game statistics provided for the weapon in chapter 5."
            }
        },
        {
            "Mask of the Wild",
            new string[]
            {
                "Mask of the Wild",
                "You can attempt to hide even when you are only lightly obscured by foliage, heavy rain, falling snow, mist, and other natural phenomena."
            }
        },
        {
            "Menacing",
            new string[]
            {
                "Menacing",
                "You gain proficiency in the Intimidation skill."
            }
        },
        {
            "Natural Explorer",
            new string[]
            {
                "Natural Explorer",
                "You are particularly familiar with one type of natural environment and are adept at traveling and surviving in such regions. Choose one type of favored terrain: arctic, coast, desert, forest, grassland, mountain, swamp, or the Underdark. When you make an Intelligence or Wisdom check related to your favored terrain, your proficiency bonus is doubled if you are using a skill that you’re proficient in.\n" +
                "While traveling for an hour or more in your favored, you gain the following benefits:\n" + 
                "Difficult terrain doesn’t slow your group’s travel.\n" +
                "Your group can’t become lost except by magical means.\n" +
                "Even when you are engaged in another activity while traveling (such as foraging, navigating, or tracking), you remain alert to danger.\n" +
                "If you are traveling alone, you can move stealthily at a normal pace.\n" +
                "When you forage, you find twice as much food as you normally would.\n" +
                "While tracking other creatures, you also learn their exact number, their sizes, and how long ago they passed through the area.\n" +
                "You choose additional favored terrain types at 6th and 10th level."
            }
        },
        {
            "Natural Illusionist",
            new string[]
            {
                "Natural Illusionist",
                "You know the minor illusion cantrip. Intelligence is your spellcasting ability for it."
            }
        },
        {
            "Naturally Stealthy",
            new string[]
            {
                "Naturally Stealthy",
                "You can attempt to hide even when you are obscured only by a creature that is at least one size larger than you."
            }
        },
        {
            "Other Worldly Patron",
            new string[]
            {
                "Other Worldly Patron",
                "You have struck a bargain with an otherworldly being of your choice: the Archfey, the Fiend, or the Great Old One, each of which is detailed at the end of the class description on page 108. Your choice grants you features at 1st level and again at 6th, 10th, and 14th level."
            }
        },
        {
            "Pact Magic",
            new string[]
            {
                "Pact Magic",
                "Your arcane research and the magic bestowed on you by your patron have given you facility with spells. See chapter 10 for the general rules of spellcasting and chapter 11 for the warlock spell list."
            }
        },
        {
            "Rage",
            new string[]
            {
                "Rage",
                "In battle, you fight with primal ferocity. On your turn, you can enter a rage as a bonus action. While raging, you gain the following benefits if you aren’t wearing heavy armor:\n" +
                "You have advantage on Strength checks and Strength saving throws.\n" +
                "When you make a melee weapon attack using Strength, you gain a bonus to the damage roll that increases as you gain levels as a barbarian, as shown in the Rage Damage column of the Barbarian table.\n" +
                "You have resistance to bludgeoning, piercing, and slashing damage.\n" +
                "If you are able to cast spells, you can’t cast them or concentrate on them while raging. Your rage lasts for 1 minute. It ends early if you are knocked unconscious or if your turn ends and you haven’t attacked a hostile creature since your last turn or taken damage since then. You can also end your rage on your turn as a bonus action.\n" +
                "Once you have raged the number of times shown for your barbarian level in the Rages column of the Barbarian table, you must finish a long rest before you can rage again."
            }
        },
        {
            "Relentless Endurance",
            new string[]
            {
                "Relentless Endurance",
                "When you are reduced to 0 hit points but not killed outright, you can drop to 1 hit point instead. You can’t use this feature again until you finish a long rest."
            }
        },
        {
            "Savage Attacks",
            new string[]
            {
                "Savage Attacks",
                "When you score a critical hit with a melee weapon attack, you can roll one of the weapon’s damage dice one additional time and add it to the extra damage of the critical hit."
            }
        },
        {
            "Second Wind",
            new string[]
            {
                "Second Wind",
                "You have a limited well of stamina that you can draw on to protect yourself from harm. On your turn, you can use a bonus action to regain hit points equal to 1d 10 + your fighter level. Once you use this feature, you must finish a short or long rest before you can use it again."
            }
        },
        {
            "Skill Versatility",
            new string[]
            {
                "Skill Versatility",
                "You gain proficiency in two skills of your choice."
            }
        },
        {
            "Sneak Attack",
            new string[]
            {
                "Sneak Attack",
                "You know how to strike subtly and exploit a foe’s distraction. Once per turn, you can deal an extra 1d6 damage to one creature you hit with an attack if you have advantage on the attack roll. The attack must use a finesse or a ranged weapon.\n" +
                "You don’t need advantage on the attack roll if another enemy of the target is within 5 feet o f it, that enemy isn’t incapacitated, and you don’t have disadvantage on the attack roll.\n" +
                "The amount of the extra damage increases as you gain levels in this class, as shown in the Sneak Attack column of the Rogue table."
            }
        },
        {
            "Sorcerous Origin",
            new string[]
            {
                "Sorcerous Origin",
                "Choose a sorcerous origin, which describes the source of your innate magical power: Draconic Bloodline or Wild Magic, both detailed at the end of the class description on page 101 of the player handbook . Your choice grants you features when you choose it at 1st level and again at 6th, 14th, and 18th level."
            }
        },
        {
            "Speak with Small Beasts",
            new string[]
            {
                "Speak with Small Beasts",
                "Through sounds and gestures, you can communicate simple ideas with Small or smaller beasts. Forest gnomes love animals and often keep squirrels, badgers, rabbits, moles, woodpeckers, and other creatures as beloved pets."
            }
        },
        {
            "Spellcasting",
            new string[]
            {
                "Spellcasting",
                "You have learned to untangle and reshape the fabric of reality in harmony with your wishes and music. Your spells are part of your vast repertoire, magic that you can tune to different situations. See chapter 10 for the general rules of spellcasting and chapter 11 for the bard spell list."
            }
        },
        {
            "Stonecunning",
            new string[]
            {
                "Stonecunning",
                "Whenever you make an Intelligence (History) check related to the origin of stonework, you are considered proficient in the History skill and add double your proficiency bonus to the check, instead of your normal proficiency bonus."
            }
        },
        {
            "Stout Resilience",
            new string[]
            {
                "Stout Resilience",
                "You have advantage on saving throws against poison, and you have resistance against poison damage."
            }
        },
        {
            "Sunlight Sensitivity",
            new string[]
            {
                "Sunlight Sensitivity",
                "You have disadvantage on attack rolls and on Wisdom (Perception) checks that rely on sight when you, the target of your attack, or whatever you are trying to perceive is in direct sunlight."
            }
        },
        {
            "Superior Darkvision",
            new string[]
            {
                "Superior Darkvision",
                "Your darkvision has a radius of 120 feet."
            }
        },
        {
            "Thieves' Cant",
            new string[]
            {
                "Thieves' Cant",
                "During your rogue training you learned thieves’ cant, a secret mix of dialect, jargon, and code that allows you to hide messages in seemingly normal conversation. Only another creature that knows thieves’ cant understands such messages. It takes four times longer to convey such a message than it does to speak the same idea plainly.\n" +
                "In addition, you understand a set of secret signs and symbols used to convey short, simple messages, such as whether an area is dangerous or the territory of a thieves’ guild, whether loot is nearby, or whether the people in an area are easy marks or will provide a safe house for thieves on the run."
            }
        },
        {
            "Tinker",
            new string[]
            {
                "Tinker",
                "Using tinker's tools, you can spend 1 hour and 10 gp worth of materials to construct a Tiny clockwork device (AC 5, 1 hp). The device ceases to function after 24 hours (unless you spend 1 hour repairing it to keep the device functioning), or when you use your action to dismantle it; at that time, you can reclaim the materials used to create it. You can have up to three such devices active at a time. When you create a device, choose one of the following options:\n\n" +
                "Clockwork Toy - This toy is a clockwork animal, monster, or person, such as a frog, mouse, bird, dragon, or soldier. When placed on the ground, the toy moves 5 feet across the ground on each of your turns in a random direction. It makes noises as appropriate to the creature it represents.\n\n" +
                "Fire Starter - The device produces a miniature flame, which you can use to light a candle, torch, or campfire. Using the device requires your action.\n\n" +
                "Music Box - When opened, this music box plays a single song at a moderate volume. The box stops playing when it reaches the song’s end or when it is closed."
            }
        },
        {
            "Trance",
            new string[]
            {
                "Trance",
                "Elves don’t need to sleep. Instead, they meditate deeply, remaining semiconscious, for 4 hours a day. (The Common word for such meditation is “trance.”) While meditating, you can dream after a fashion; such dreams are actually mental exercises that have become reflexive through years of practice. After resting in this way, you gain the same benefit that a human does from 8 hours of sleep."
            }
        },
        {
            "Unarmored Defense",
            new string[]
            {
                "Unarmored Defense",
                "(Barbarian)While you are not wearing any armor, your Armor Class equals 10 + your Dexterity modifier + your Constitution modifier. You can use a shield and still gain this benefit.\n" +
                "(Monk) While you are wearing no armor and not wielding a shield, your AC equals 10 + your Dexterity modifier + your Wisdom modifier."
            }
        }
    };
}
