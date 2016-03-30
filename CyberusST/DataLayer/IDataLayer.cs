using LogicsLayer;
namespace DataLayer
{
    public interface IDataLayer
    {
        bool CheckValidate(User u);
        bool CheckIfUserExist(User u);
        bool ChangePassword(User u);
    }
}
