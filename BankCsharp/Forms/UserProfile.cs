using BankCsharp.Core.Servises;
using BankCsharp.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankCsharp.Forms
{
    public partial class UserProfile : Form
    {
        private readonly IUserProfileService _userProfile;
        private User user = new User();
        public UserProfile( IUserProfileService userProfile , string username)
        {
            _userProfile = userProfile;
            FillUser(username);
            InitializeComponent();
            User_Name_label.Text = user.Username ;
        }

        private void FillUser(string username)
        {
            user = _userProfile.FindUserByNationalCode(username);
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            string message = "Good Bye!";
            MessageBox.Show(message);
            var time = Task.Delay(1200);
            time.Wait();
            Application.Exit();
        }
        private void MainPageBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        private void CheckAccountBtn_Click(object sender, EventArgs e)
        {
            CheckAccountFm accountFm = new CheckAccountFm(user);
            this.Close();
            accountFm.Show();
        }

        private void AccountInfoBtn_Click(object sender, EventArgs e)
        {
            AccountInfoFm accountInfo = new AccountInfoFm(user);
            accountInfo.Show();
            this.Close();
        }

        private void SendMoneyBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
