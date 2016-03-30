using System;
using LogicsLayer;
//using SharedLibrarys;
//using LogicsLayer.LogicExceptions;

namespace CyberusST
{
    class GUI : IGUI
    {
        //*****private LogicsLayer.LogicsLayer ll = new LogicsLayer.LogicsLayer();
        private DataLayer.DataLayer dt = new DataLayer.DataLayer();

        //changes the password
        //gets User and the changing password method
        //returns the new password
        public void ChangePassword(User u, string changingMethod)
        {
            Console.WriteLine("Enter your old password:");
            string old = Console.ReadLine();
            if (!CheckValidate(u.name, old))
            {
                //****throw new OldDoesntMatchException();
            }

            string new1 = "";
            string new2 = "";
            if (changingMethod == "1")
            {
                Console.WriteLine("New password must contain 8 characters and at least one digit.");
                Console.WriteLine("Enter your new password:");
                new1 = Console.ReadLine();
                Console.WriteLine("Enter your new password again:");
                new2 = Console.ReadLine();

            }
            //***string pass = ll.ChangePassword(u, old, new1, new2);
            //***Console.WriteLine("Your new password is: " + pass);
        }
        //checks if user exist in the db or not
        //gets string username
        //returns if the user exist in the db or not
        public bool CheckIfUserExist(string username)
        {
            User newUser = new User(username);
            //***return ll.CheckIfUserExist(newUser);
            return true;

        }
        //checks if the username matches to the password
        //gets strings username and password
        //returns if the username matches to the password
        public bool CheckValidate(string username, string password)
        {
            User newUser = new User(username, password);
            //***return ll.CheckValidate(newUser);
            return true;
        }
    }
}
