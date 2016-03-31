using SharedLibrarys;
namespace LogicsLayer
{
    interface ILogicsLayer
    {
        string ChangePassword(User u, string oldpswd, string newpswd1 = "", string newpswd2 = "");
        bool CheckIfUserExist(User u);
        bool CheckValidate(User u);
    }
}
