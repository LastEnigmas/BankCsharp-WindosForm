﻿using BankCsharp.Core.Servises;
using BankCsharp.models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCsharp.Core.Repository
{
    public class UserRepository : UserService
    {
        SqlConnection con = null;

        public bool Login(UserViewModel user)
        {
            con = new SqlConnection("Server=.; database=MyBank_WindowsForm; Trusted_Connection=True; ");
            string myQuery = "Select * from MyUsers " + 
                $" where Username = '{user.Username}' and Password = '{user.Password}' ";
            SqlCommand cmd = new SqlCommand(myQuery, con);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            if (result != -1 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}