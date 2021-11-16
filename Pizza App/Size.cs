using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Pizza_App
{
    public class Size
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("price")]
        public double price { get; set; }

        [JsonProperty("freeIngredientCount")]
        public int freeIng { get; set; }



        public Size(string Name,double Price,int FreeIng)
        {
            name = Name;
            price = Price;
            freeIng = FreeIng;
        }

    }

}
