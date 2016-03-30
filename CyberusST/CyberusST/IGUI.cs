using LogicsLayer;
//using SharedLibrarys;

namespace CyberusST
{
    interface IGUI
    {
        void ChangePassword(User u, string changingMethod);
        bool CheckIfUserExist(string username);
        bool CheckValidate(string username, string password);
    }
}