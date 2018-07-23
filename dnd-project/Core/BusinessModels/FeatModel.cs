using System.Text;
using Newtonsoft.Json;
using dnd_project.Core.Data;

namespace dnd_project.Core.BusinessModels
{
    public class FeatModel
    {
        #region Instance Variables and Properties
        const int DESCRIPTION_ELEMENT = 1;
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion

        #region Constructor(s)
        public FeatModel(string name)
        {
            JsonFeatData featData = JsonConvert.DeserializeObject<JsonFeatData>(Properties.Resources.FeatData);
            if(featData.Feats[name] != null)
            {
                Name = name;
                Description = featData.Feats[name].Description;
            }
            
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
