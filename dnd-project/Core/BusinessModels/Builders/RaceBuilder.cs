using dnd_project.Core.Data;

namespace dnd_project.Core.BusinessModels.Builders
{
    public class RaceBuilder
    {
        #region Variables
        private string name;
        private int[] age;
        private string size;
        private string alignment;
        private int speed;
        private RaceAttribute[] attributeMods;
        private string[] feats;
        private string[] proficiencies;
        private string[] languages;
        private string[] gearChoices;
        #endregion

        #region Constructor(s)
        public RaceBuilder()
        {
        }
        #endregion

        #region Methods
        public RaceBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public RaceBuilder SetAges(int[] age)
        {
            this.age = age;
            return this;
        }

        public RaceBuilder SetSize(string size)
        {
            this.size = size;
            return this;
        }

        public RaceBuilder SetAlignment(string alignment)
        {
            this.alignment = alignment;
            return this;
        }

        public RaceBuilder SetSpeed(int speed)
        {
            this.speed = speed;
            return this;
        }

        public RaceBuilder SetAttributeMods(RaceAttribute[] attributeMods)
        {
            this.attributeMods = attributeMods;
            return this;
        }

        public RaceBuilder SetFeats(string[] feats)
        {
            this.feats = feats;
            return this;
        }

        public RaceBuilder SetProficiencies(string[] proficiencies)
        {
            this.proficiencies = proficiencies;
            return this;
        }

        public RaceBuilder SetLanguages(string[] languages)
        {
            this.languages = languages;
            return this;
        }

        public RaceBuilder SetGearChoices(string[] gearChoices)
        {
            this.gearChoices = gearChoices;
            return this;
        }

        public Race Build()
        {
            return new Race(name, age, size, alignment, speed, attributeMods, feats, proficiencies, languages, gearChoices);
        }
        #endregion
    }
}
