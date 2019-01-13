namespace dnd_project.Core.BusinessModels.Builders
{
    class FeatBuilder
    {
        private string name;
        private string description;

        public FeatBuilder()
        {
        }

        public FeatBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public FeatBuilder SetDescription(string description)
        {
            this.description = description;
            return this;
        }

        public Feat Build()
        {
            return new Feat(name, description);
        }
    }
}
