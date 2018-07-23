using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using dnd_project.Core.Data;
using dnd_project.Core.BusinessModels;
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

            //JsonAttributeData attributeData = JsonConvert.DeserializeObject<JsonAttributeData>(Properties.Resources.AttributeData);
            //JsonClassData classData = JsonConvert.DeserializeObject<JsonClassData>(Properties.Resources.ClassData);
            //JsonFeatData featData = JsonConvert.DeserializeObject<JsonFeatData>(Properties.Resources.FeatData);
            //JsonRaceData raceData = JsonConvert.DeserializeObject<JsonRaceData>(Properties.Resources.RaceData);
            //JsonSkillData skillData = JsonConvert.DeserializeObject<JsonSkillData>(Properties.Resources.SkillsData);

            //string aClass = "Barbarian";
            //string race = "Half-Orc";

            //ClassModel barb = new ClassModel(aClass);

            //Console.WriteLine(barb.ToString());
            //foreach (string feat in barb.StartingFeats)
            //    Console.WriteLine(feat.ToString());

            Character character = new Character();
            character.Name = "Byrd";
            character.SetCharacterClass("Ranger");
            character.SetCharacterRace("Wood Elf");
            Console.WriteLine("\n*********FIRST WRITE********\n\n");
            Console.Write(character);

            character.SetCharacterClass("Monk");
            Console.WriteLine("\n*********SECOND WRITE********\n\n");
            Console.Write(character);

            character.SetCharacterRace("Dragonborn");
            Console.WriteLine("\n*********THIRD WRITE********\n\n");
            Console.Write(character);
        }
    }
}
