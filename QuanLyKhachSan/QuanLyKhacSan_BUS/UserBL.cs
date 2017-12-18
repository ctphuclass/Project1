﻿using QuanLyKhachSan_DTO;
using QuanLyKhacSan_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhacSan_BUS
{
    public class UserBL
    {
        public ResultMessageBO SaveUserregisrationBL(UserBO objUserBL) // passing Bussiness object Here
        {
            try
            {
                UserDA objUserda = new UserDA(); // Creating object of Dataccess
                return objUserda.AddUserDetails(objUserBL); // calling Method of DataAccess
            }
            catch
            {
                throw;
            }
        }

        public ResultMessageBO CheckUserLoginBL(UserBO objUserBL)
        {
            try
            {
                UserDA objUserda = new UserDA(); // Creating object of Dataccess
                return objUserda.CheckUserLogin(objUserBL); // calling Method of DataAccess
            }
            catch
            {
                throw;
            }
        }
        public List<UserBO> GetUserList()
        {
            try
            {
                UserDA objUserda = new UserDA(); // Creating object of Dataccess
                return objUserda.GetUserList(); // calling Method of DataAccess
            }
            catch
            {
                throw;
            }
        }
        public List<UserPermissionBO> GetPermission(int piUserID, string psModule)
        {
            try
            {
                UserDA objUserda = new UserDA(); // Creating object of Dataccess
                return objUserda.GetPermission(piUserID, psModule); // calling Method of DataAccess
            }
            catch
            {
                throw;
            }
        }
    }
}

