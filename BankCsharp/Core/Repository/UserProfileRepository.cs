using BankCsharp.Core.Servises;
using BankCsharp.models;
using BankCsharp.models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankCsharp.Core.Repository
{
    public class UserProfileRepository : IUserProfileService
    {
        SqlConnection con = null;

        public bool ChangePassword(ChangePasswordViewModel changePassword)
        {
            con = new SqlConnection("Server=.; database=MyBank_WindowsForm; Trusted_Connection=True; ");
            string query = "update MyUsers " +
                $" set Password = '{changePassword.NewPassword}' " +
                $" where Username = '{changePassword.Username}' ";
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
        public bool CheckMoney(SendEndMoneyViewModel sendEnd)
        {
            con = new SqlConnection("Server=.; database=MyBank_WindowsForm; Trusted_Connection=True; ");
            string query = "select * from MyUsers " +
                $" where Username = '{sendEnd.UserFirstUsername}'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                double currentMoney = (double)(rdr["Money"]);
                if(currentMoney - sendEnd.Money > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public bool DoSendMoney(SendEndMoneyViewModel sendEnd)
        {
            con = new SqlConnection("Server=.; database=MyBank_WindowsForm; Trusted_Connection=True; ");
            bool result;
            result = CheckMoney(sendEnd);
            if(result == false)
            {
                return false;
            }

            User user = new User();
            user = GetUserByUsername(user.Username);
            user.Money = (SqlMoney)(Convert.ToDouble(user.Money) - sendEnd.Money);

            result = Update(user);
            if(result == false)
            {
                return false;
            }

            result =  SecenUserMoneyTask(sendEnd.UserSecendUsername , sendEnd.Money);
            if( result == false)
            {
                return false;
            }

            return true;
        }
        public User FindUserByCardNumber(string username)
        {
            con = new SqlConnection("Server=.; database=MyBank_WindowsForm; Trusted_Connection=True; ");
            string query = "select * from MyUsers " +
                $" where Username = '{username}'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                User user = new User()
                {
                    Username = (string)(rdr["Username"]),
                    Money = (SqlMoney)(Convert.ToDouble(rdr["Money"])),
                    NationalCode = (int)(rdr["NationalNumber"]),
                    CardNumber = (int)(rdr["NumberCard"]),
                };

                return user;
            }

            return null;
        }
        public User FindUserByNationalCode(string username)
        {
            con = new SqlConnection("Server=.; database=MyBank_WindowsForm; Trusted_Connection=True; ");
            string query = "select * from MyUsers " +
                $" where Username = '{username}' ";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string checkUsername = (string)(rdr["Username"]);
                if(checkUsername != null)
                {
                    User user = new User();
                    user.Username = (string)(rdr["Username"]);
                    user.NationalCode = (int)(rdr["NationalNumber"]);
                    user.CardNumber = (int)(rdr["CardNumber"]);
                    user.Money = Convert.ToInt32(rdr["Money"]);

                    return user;
                }
                else
                {
                    return null;
                }
            }

            con.Close();
            return null;
        }
        public User GetUserByUsername(string username)
        {
            con = new SqlConnection("Server=.; database=MyBank_WindowsForm; Trusted_Connection=True; ");
            string query = "select * from MyUsers " +
                $" where Username = '{username}'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                User user = new User()
                {
                    Username = (string)(rdr["Username"]),
                    Money = (SqlMoney)(double)(rdr["Money"]),
                };

                return user;
            }


            return null;
        }
        public string IsNumberCard(int number)
        {
            con = new SqlConnection("Server=.; database=MyBank_WindowsForm; Trusted_Connection=True; ");
            string query = "select * from MyUsers " +
                $" where CardNumber = {number} ";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string username = (string)(dr["Username"]);
                if(username != null)
                {
                    return username ;
                }
                else
                {
                    return null;
                }
            }

            return null;
        }
        public bool Update(User user)
        {
            con = new SqlConnection("Server=.; database=MyBank_WindowsForm; Trusted_Connection=True; ");
            string query = "update MyUsers " +
                $"set Money = {user.Money}" +
                $" where Username = '{user.Username}'";
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


        #region SecendUser_Money
        public bool SecenUserMoneyTask(string username , double money)
        {
            User user = new User();
            user = FindUserByNationalCode(username);

            user.Money = (SqlMoney)((Convert.ToDouble(user.Money)) - money);
            Update(user);
            return true;
        }
        public SecendUserInfoViewModel FindSecendUser( int  cardnumber )
        {
            con = new SqlConnection("Server=.; database=MyBank_WindowsForm; Trusted_Connection=True; ");
            string query = "select * from MyUsers " +
                $" where  NumberCard = {cardnumber}";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SecendUserInfoViewModel secendUserInfo = new SecendUserInfoViewModel();
                secendUserInfo.CardNumber = (int)dr["NumberCard"];
                secendUserInfo.Username = (string)dr["Username"];

                return secendUserInfo;
            }

            return null;
        }

        #endregion
    }
}
