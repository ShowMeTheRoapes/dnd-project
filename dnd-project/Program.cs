using dnd_project.Core;
using dnd_project.Core.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using dnd_project.Core.ViewModels;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new MainMenu().Show();
            Application.Run();

            //CharacterController controller = new CharacterController();
            //controller.SetRace("Wood Elf");
            //controller.SetClass("Wizard");
            //controller.SetCharacterProperty(CharacterValues.Name, "Steve The Wizard");
            //Console.WriteLine("\n*********FIRST WRITE********\n\n");
            //controller.PrintCharacterToConsole();
            //controller.SaveCharacter(Properties.Settings.Default.SaveDirectory);
            //controller.LoadCharacter(Properties.Settings.Default.SaveDirectory + @"\" + "Steve The Wizard");
            //Console.WriteLine("\n*********FIRST WRITE********\n\n");
            //controller.PrintCharacterToConsole();
        }
    }
}
