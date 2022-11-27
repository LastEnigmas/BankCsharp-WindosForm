using BankCsharp.Core.Servises;
using BankCsharp.models;
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
    }
}
