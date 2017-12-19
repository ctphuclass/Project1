using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class UserBUS
    {
        public ResultMessage_DTO SaveUserregisrationBL(UserDTO user) // passing Bussiness object Here
        {
            try
            {
                UserDAO login = new UserDAO(); // Creating object of Dataccess
                return login.AddUserDetails(user); // calling Method of DataAccess
            }
            catch
            {
                throw;
            }
        }
        public ResultMessage_DTO CheckUserLoginBUS(UserDTO user)
        {

            UserDAO login = new UserDAO(); // Creating object of Dataccess
            return login.CheckUserLogin(user); // calling Method of DataAcces  
        }
            public static bool CheckPermission(UserDTO user)
        {
            return UserDAO.CheckPermission(user);
        }
    }

}
