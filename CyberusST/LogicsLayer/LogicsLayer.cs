using SharedLibrarys;
using System;
using LogicsLayer.LogicExceptions;
namespace LogicsLayer
{
    public class LogicsLayer : ILogicsLayer
    {
        private DataLayer.IDataLayer dt;
        public LogicsLayer()
        {
            dt = new DataLayer.DataLayer();
        }
        //Changes user password.
        //Params: user, old password
        //Optinal Params: two new passwords
        //return the new password
        //throws Exception for bad matches, bad passwords and errors in user input
        public string ChangePassword(User u, string oldpswd, string newpswd1 = "", string newpswd2 = "")
        {
            //if user didn't enter passwords
            if ((string.IsNullOrEmpty(newpswd1)) && (string.IsNullOrEmpty(newpswd2)))
            {
                if (!oldpswd.Equals(u.password)) // check that the old password is right
                    throw new OldDoesntMatchException();
                User newUser = new User(u.name, GeneratePass());
                bool b = dt.ChangePassword(newUser);
                return newUser.password;
            }
            // if user inserted password
            else
            {
                if (!oldpswd.Equals(u.password)) // old password is wrong
                    throw new OldDoesntMatchException();
                if (!newpswd1.Equals(newpswd2)) // two new passwords doesnt match
                    throw new NewDoesntMatchException();
                if (!CheckValidPass(newpswd1)) //entered password is invalid
                    throw new BadNewPasswordException();
                User newUser = new User(u.name, newpswd1); // create a user instance with the new pass
                dt.ChangePassword(newUser);
                return newpswd1;    //return new password
            }
        }
        //Internal function
        //Checks if a given string represents a valid password
        //Params: password
        //return true if string is a valid password, false otherwise
        private bool CheckValidPass(string pass) //checks string for validity
        {
            if (pass.Length != 8) // the length must be 8
                return false;
            bool numflag = false;
            for (int i = 0; i < 10 & !numflag; i++) // check that there is at least 1 number
            {
                if (pass.Contains(i.ToString()))
                    numflag = true;
            }
            return numflag;
        }
        //Internal function
        //Generate a random password
        //Return a stirng representing a valid password
        private string GeneratePass()
        {
            string newpass = "";
            newpass = Guid.NewGuid().ToString(); //generate new guid
            newpass = newpass.Substring(0, 8);  // cut the substring to desierd length
            return newpass;
        }
        //Checks if user exists in db
        //Params: User
        //return true if user exists, false otherwise
        public bool CheckIfUserExist(User u)
        {
            return dt.CheckIfUserExist(u);
        }
        //Check if specific user match his password
        //Params: user
        //return true if username with given password exists, false otherwise
        public bool CheckValidate(User u)
        {
            return dt.CheckValidate(u);
        }
    }
}
