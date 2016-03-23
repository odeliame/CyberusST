using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicsLayer;

namespace DataLayer
{
    interface IDataLayer
    {
        bool CheckValidate(User u);
        bool CheckIfUserExist(User u);
        bool ChangePassword(User u);
    }
}
