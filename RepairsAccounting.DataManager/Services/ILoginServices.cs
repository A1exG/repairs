using RepairsAccounting.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RepairsAccounting.DataManager.Services
{
   
    [ServiceContract]
    public interface ILoginServices
    {
        [OperationContract]
        UserModel LogIn(string login, string password);
    }
}
