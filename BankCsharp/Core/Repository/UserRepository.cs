using BankCsharp.Core.Servises;
using BankCsharp.Helper.Generator;
using BankCsharp.models;
using BankCsharp.models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCsharp.Core.Repository
{
    public class UserRepository : IUserService
    {
        SqlConnection con = null;

        public bool IsNationalCode(int nationalCode)
        {
            con = new SqlConnection("Server=.; database=MyBank_WindowsForm; Trusted_Connection=True; ");
            string query = "select * from MyUsers " +
                $"where NationalCode = {nationalCode} ";
            SqlCommand cmd =new SqlCommand(query, con);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            if(result != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsUsername(string username)
        {
            con = new SqlConnection("Server=.; database=MyBank_WindowsForm; Trusted_Connection=True; ");
            string query = "Select * from MyUsers " +
                $" Username = {username} ";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            if(result != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
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
        public bool SignUpUser(UserSignUpViewModel userSignUp)
        {
            User user = new User()
            {
                Username = userSignUp.Username,
                Password = userSignUp.Password,
                Money = 50000,
                CardNumber = CreateCardNumber.CreateNumber(),
                NationalCode = userSignUp.NationalCode ,
            };
            con = new SqlConnection("Server=.; database=MyBank_WindowsForm; Trusted_Connection=True; ");
            string myQuery = "insert into MyUsers " +
                $" values({user.Username}, {user.Password} , {user.NationalCode} , {user.CardNumber} , {user.Money})";
            SqlCommand cmd = new SqlCommand(myQuery, con);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            if(result != -1)
            {
                return true;
            }
            else
            {
                return true;
            }
        }
    }
}
