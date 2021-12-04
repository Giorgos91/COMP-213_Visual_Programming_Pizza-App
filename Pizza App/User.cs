using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Pizza_App
{
    public class User
    {
        
        public enum accessible { any, some, all };


        [JsonProperty("Username")]
        public string username { get; set; }

        [JsonProperty("Password")]
        public string password { get; set; }

        [JsonProperty("Access")]
        public accessible access { get; set; }

        public User()
        {

        }
        public User(string Username, string Password, accessible Access)
        {
            this.username = Username;
            this.password = Password;
            this.access = Access;
        }

        public void Copy(User user)
        {
            this.username = user.username;
            this.password = user.password;
            this.access = user.access;
        }
    }
}
