using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicsLayer;
using System.IO;
using Newtonsoft.Json;


namespace DataLayer
{
    public class DataLayer : IDataLayer
    {

        //internal function
        //reads the data file
        //Params: None, hardcoded path
        //return true if everything went well, false otherwise
        //throws IOException for read/write to data file problems
        private Dictionary<string, string> ReadFile()
        {
            Dictionary<string, string> usersList;
            try
            {
                using (StreamReader r = new StreamReader(Directory.GetCurrentDirectory() + @"\users.json"))
                {



                    string jsonDB = r.ReadToEnd();
                    usersList = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonDB);
                }
            }
            catch (IOException e)
            {
                throw new IOException();
            }
            return usersList;
        }


        //internal function
        //writes the data file
        //Params: None, hardcoded path
        //return true if everything went well
        //throws IOException for read/write to data file problems
        private bool WriteFile(Dictionary<string, string> usersList)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + @"\users.json"))
                {
                    string jsonDB = Newtonsoft.Json.JsonConvert.SerializeObject(usersList);
                    sw.Write(jsonDB);
                    return true;

                }
            }
            catch (IOException e)
            {
                throw new IOException();
            }

        }



        //check if specific user match his password
        //Params: user: username, password - the match password
        //return true if everything went well, false otherwise
        //throws IOException for read/write to data file problems
        public bool CheckValidate(User u)
        {
            Dictionary<string, string> usersList = ReadFile();
            try
            {
                if (usersList.ContainsKey(u.name))
                {
                    if (usersList[u.name] == u.password)
                    {
                        return true;
                    }
                }
            }
            catch (IOException e)
            {
                throw new IOException();
            }



            return false;
        }


        //check if specific user exist
        //Params: user: username to check, password - not needed.
        //return true if everything went well, false otherwise
        //throws IOException for read/write to data file problems

        public bool CheckIfUserExist(User u)
        {
            Dictionary<string, string> usersList = ReadFile();
            try
            {
                if (usersList.ContainsKey(u.name))
                {

                    return true;
                }
            }

            catch (IOException e)
            {
                throw new IOException();
            }
            return false;
        }


        //changes the password of a specific user
        //Params: user: username, password - the desired new password
        //return true if everything went well, false otherwise
        //throws IOException for read/write to data file problems
        public bool ChangePassword(User u)
        {
            Dictionary<string, string> usersList = ReadFile();

            try
            {
                if (CheckIfUserExist(u))
                {
                    usersList[u.name] = u.password;
                    return WriteFile(usersList);
                }
            }
            catch (IOException e)
            {
                throw new IOException();
            }

            return false;
        }
    }
}
