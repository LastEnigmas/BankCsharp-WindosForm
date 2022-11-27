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
    public partial class CheckAccountFm : Form
    {
        private User user = new User();
        public CheckAccountFm(User user)
        {
            InitializeComponent();
            this.user = user;
            UserMoneyLabel.Text = Convert.ToString(user.Money);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainPageBtn_Click(object sender, EventArgs e)
        {
            UserProfile frm = new UserProfile( new UserProfileRepository() , this.user.Username );
            this.Close();
            frm.Show();
        }
    }
}
