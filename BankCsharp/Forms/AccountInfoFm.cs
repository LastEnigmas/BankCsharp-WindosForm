using BankCsharp.Core.Repository;
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
    public partial class AccountInfoFm : Form
    {
        private User user = new User();
        public AccountInfoFm(User user)
        {
            this.user = user;
            InitializeComponent();
            UsernameInput.Text = user.Username;
            CardNumebrInput.Text = Convert.ToString(user.CardNumber);
            NationalNumberInput.Text = Convert.ToString(user.NationalCode);
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
            UserProfile profile = new UserProfile(new UserProfileRepository() , this.user.Username );
            this.Close();
            profile.Show();
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            ChangePasswordFm change = new ChangePasswordFm(user ,  new UserProfileRepository() );
            this.Close();
            change.Show();
        }
    }
}
