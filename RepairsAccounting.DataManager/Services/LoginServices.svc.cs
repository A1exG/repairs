using RepairsAccounting.DataManager.DataAccess;
using RepairsAccounting.Library.Models;

namespace RepairsAccounting.DataManager.Services
{
    public class LoginServices : ILoginServices
    {
        public UserModel LogIn(string login, string password)
        {
            UserData data = new UserData();
            var user = data.LogInUser(login, password);
            
            return user[0];
        }
    }
}
