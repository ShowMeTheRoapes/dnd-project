using System.Text;
using dnd_project.Core.Data;
using Newtonsoft.Json;
namespace dnd_project.Core.BusinessModels
{
    public class ClassModel
    {
        #region Instance Variables and Properties
        private const int DEF_LEVEL = 1;

        public string Name { get; set; }
        public string Description { get; set; }
        public string HitDie { get; set; }
        public string[] PrimaryAttributes { get; set; }
        public string[] SavingThrows { get; set; }
        public string[] Proficiencies { get; set; }
        public string[] StartingFeats { get; set; }
        public int NumberOfSkills { get; set; }
        public string[] SkillOptions { get; set; }
        #endregion

        #region Constructor(s)
        public ClassModel(string className)
        {
            JsonClassData classData = JsonConvert.DeserializeObject<JsonClassData>(Properties.Resources.ClassData);
            if (classData.Classes[className] != null)
            {
                Name = className;
                Description = classData.Classes[className].Description;
                HitDie = classData.Classes[className].HitDie;
                PrimaryAttributes = classData.Classes[className].PrimaryAttributes;
                SavingThrows = classData.Classes[className].SavingThrows;
                Proficiencies = classData.Classes[className].Proficiencies;
                StartingFeats = classData.Classes[className].StartingFeats;
                NumberOfSkills = classData.Classes[className].NumberOfSkills;
                SkillOptions = classData.Classes[className].SkillOptions;
            }

        }
        #endregion

        #region Class Methods

        /// <summary>
        /// Overriden ToString method to print a class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder classString = new StringBuilder("\n----------CLASS----------\n");

            classString.Append(Name + "\n");
            classString.Append(Description + "\n");
            classString.Append(HitDie + "\n");

            classString.Append("Primary Attributes: \n");
            foreach (string att in PrimaryAttributes)
            {
                classString.Append("\t" + att + "\n");
            }

            classString.Append("Saving Throws: \n");
            foreach (string save in SavingThrows)
            {
                classString.Append("\t" + save + "\n");
            }

            return classString.ToString();
        }
        #endregion
    }
}

