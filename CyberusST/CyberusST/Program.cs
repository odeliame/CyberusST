using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using LogicsLayer;

namespace CyberusST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            Console.ReadLine();

            DataLayer.DataLayer dt = new DataLayer.DataLayer();
            User odelia = new User("Odelia", "123456abcd");
            Console.WriteLine(dt.CheckValidate(odelia));
            Console.ReadLine();

            

        }
    }
}
