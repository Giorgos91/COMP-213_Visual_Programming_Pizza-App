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

        [JsonProperty("price")]
        public double price { get; set; }

        public Toppings(string Name, double Price)
        {
            name = Name;
            price = Price;
        }
        public Toppings()
        {

        }
    }
}
