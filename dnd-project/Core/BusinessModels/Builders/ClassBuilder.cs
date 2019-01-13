namespace dnd_project.Core.BusinessModels.Builders
{
    class ClassBuilder
    {
        #region Variables

        private string name;
        private string description;
        private string hitDie;
        private string[] primaryAttributes;
        private string[] savingThrows;
        private string[] proficiencies;
        private string[] startingFeats;
        private int numberOfSkills;
        private string[] skillOptions;

        #endregion

        #region Constructors

        public ClassBuilder()
        {
        }

        #endregion

        #region Methods

        public ClassBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public ClassBuilder SetDescription(string description)
        {
            this.description = description;
            return this;
        }

        public ClassBuilder SetHitDie(string hitDie)
        {
            this.hitDie = hitDie;
            return this;
        }

        public ClassBuilder SetPrimaryAttributes(string[] primaryAttributes)
        {
            this.primaryAttributes = primaryAttributes;
            return this;
        }

        public ClassBuilder SetSavingThrows(string[] savingThrows)
        {
            this.savingThrows = savingThrows;
            return this;
        }

        public ClassBuilder SetProficiencies(string[] proficiencies)
        {
            this.proficiencies = proficiencies;
            return this;
        }

        public ClassBuilder SetStartingFeats(string[] startingFeats)
        {
            this.startingFeats = startingFeats;
            return this;
        }

        public ClassBuilder SetNumberOfSkills(int numberOfSkills)
        {
            this.numberOfSkills = numberOfSkills;
            return this;
        }

        public ClassBuilder SetSkillOptions(string[] skillOptions)
        {
            this.skillOptions = skillOptions;
            return this;
        }
        
        public Class Build()
        {
            return new Class(name, description, hitDie, primaryAttributes, savingThrows, proficiencies, startingFeats, numberOfSkills, skillOptions);
        } 
    }

    #endregion

}
