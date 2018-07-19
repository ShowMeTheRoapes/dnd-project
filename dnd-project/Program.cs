using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using dnd_project.Core.Data;
using Newtonsoft.Json;

namespace dnd_project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //new MainMenu().Show();
            //Application.Run();

            JsonAttributeData attributeData = JsonConvert.DeserializeObject<JsonAttributeData>(Properties.Resources.AttributeData);
            JsonClassData classData = JsonConvert.DeserializeObject<JsonClassData>(Properties.Resources.ClassData);
            JsonFeatData featData = JsonConvert.DeserializeObject<JsonFeatData>(Properties.Resources.FeatData);
            JsonRaceData raceData = JsonConvert.DeserializeObject<JsonRaceData>(Properties.Resources.RaceData);
            JsonSkillData skillData = JsonConvert.DeserializeObject<JsonSkillData>(Properties.Resources.SkillsData);

            string aClass = "Barbarian";
            string race = "Half-Orc";

            Console.WriteLine("================================OUTPUT START====================================");
            Console.WriteLine("+++Class: " + aClass + "+++");
            Console.WriteLine(classData.Classes[aClass]);
            Console.WriteLine("+++Race: " + race + "+++");
            Console.WriteLine(raceData.Races[race]);
            Console.WriteLine("+++Feats+++");
            foreach (string feat in raceData.Races[race].Feats)
            {
                Console.WriteLine("\t-" + feat);
                Console.WriteLine("\t" + featData.Feats[feat]);
            }
            foreach (string feat in classData.Classes[aClass].StartingFeats)
            {
                Console.WriteLine("\t-" + feat);
                Console.WriteLine("\t" + featData.Feats[feat]);
            }

            Console.WriteLine("+++Skills+++");
            foreach (string skill in classData.Classes[aClass].SkillOptions)
            {
                Console.WriteLine("\t-" + skill);
                Console.WriteLine("\t" + skillData.Skills[skill]);
            }

            //Character character = new Character();
            //character.Name = "Byrd";
            //character.SetCharacterClass("Ranger");
            //character.SetCharacterRace("Wood Elf");
            //Console.WriteLine("\n*********FIRST WRITE********\n\n");
            //Console.Write(character);

            //character.SetCharacterClass("Monk");
            //Console.WriteLine("\n*********SECOND WRITE********\n\n");
            //Console.Write(character);

            //character.SetCharacterRace("Dragonborn");
            //Console.WriteLine("\n*********THIRD WRITE********\n\n");
            //Console.Write(character);
        }
    }
}
