using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsLayer
{
    public class User
    {
        public string name { get; set; }
        public string password { get; set; }

        public User()
        {

        }

        
        //creates user with username and password
        //if password not entered, set to "".
        public User(string thename, string pswd= "")
        {
            this.name = thename;
            this.password = pswd;
        }
    }
}
