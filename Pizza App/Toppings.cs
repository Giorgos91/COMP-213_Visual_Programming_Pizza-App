using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Pizza_App
{
    public class Toppings
    {
        [JsonProperty("name")]
        public string name { get; set; }

        public Toppings(string Name)
        {
            name = Name;           
        }
        public Toppings()
        {

        }
    }
}
