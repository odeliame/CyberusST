using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsLayer
{
    interface ILogicsLayer
    {
        bool ChangePassword(User u, string oldpswd, string newpswd1, string newpswd2);
        bool CheckIfUserExist(User u);
        bool CheckValidate(User u);
    }
}
