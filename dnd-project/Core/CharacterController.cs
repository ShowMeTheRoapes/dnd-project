using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using dnd_project.Core.Data;
using Newtonsoft.Json;
using dnd_project.Core.BusinessModels;


namespace dnd_project.Core
{
    class CharacterController
    {
        private Character character = new Character();

        public JsonRaceData GetRaceData()
        {
            return JsonConvert.DeserializeObject<JsonRaceData>(Properties.Resources.RaceData);
        }

        public JsonFeatData GetFeatData()
        {
            return JsonConvert.DeserializeObject<JsonFeatData>(Properties.Resources.FeatData);
        }

        public void SetCharacterProperty(string property, dynamic value)
        {
            if(property.Substring(0,3).Equals("met"))
            {
                character.GetType().GetMethod(property.Substring(3)).Invoke(character, new Object[] { value });
            }
            else
            {
                character.GetType().GetProperty(property).SetValue(character, value);
            }
        }

        public void PrintCharacterToConsole()
        {
            Console.Out.Write(character.ToString());
        }
    }
}
