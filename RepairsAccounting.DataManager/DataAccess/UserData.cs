using RepairsAccounting.DataManager.DataAccess.Internal;
using RepairsAccounting.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepairsAccounting.DataManager.DataAccess
{
    public class UserData
    {
        public List<UserModel> LogInUser(string userLogin, string userPassword)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new { userLogin, userPassword };

            var output = sql.LoadData<UserModel, dynamic>("dbo.spUserLogIn", p, "RepairsAccounting");

            return output;
        }
    }
}