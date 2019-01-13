using System;
using System.Text;

namespace dnd_project.Core.BusinessModels
{
    [Serializable]
    public class Feat
    {
        #region Instance Variables and Properties
        const int DESCRIPTION_ELEMENT = 1;
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion

        #region Constructor(s)
        public Feat(string name, string description)
        {
            Name = name;
            Description = description;
        }
        #endregion

        #region Class Methods
        /// <summary>
        /// Overridden ToString for debugging
        /// </summary>
        /// <returns>Information about a FeatModel object</returns>
        public override string ToString()
        {
            StringBuilder output = new StringBuilder("");
            output.AppendLine("Name: " + Name);
            output.AppendLine("Description: ");
            output.Append(Description + "\n");
            output.AppendLine();

            return output.ToString();
        }
        #endregion
    }
}