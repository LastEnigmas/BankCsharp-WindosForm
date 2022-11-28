using BankCsharp.Core.Repository;
using BankCsharp.Core.Servises;
using BankCsharp.Helper.Security;
using BankCsharp.models;
using BankCsharp.models.ViewModels;
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
    public partial class ChangePasswordFm : Form
    {
        private User user = new User();
        private readonly IUserProfileService _userProfile;
        public ChangePasswordFm(User user , IUserProfileService userProfile)
        {
            this.user = user;
            this._userProfile = userProfile;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserProfile profile = new UserProfile(new UserProfileRepository() , this.user.Username);
            this.Close();
            profile.Show();
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            if(rePassInput.Text !=  PassInput.Text)
            {
                string message = "Password not match!";
                MessageBox.Show(message);
                var time = Task.Delay(1200);
                time.Wait();

                this.Close();
                ChangePasswordFm fm = new ChangePasswordFm(user, new UserProfileRepository());
                fm.Show();
            }
            else
            {
                string hashPass = PasswordHashC.EncodePasswordMd5(PassInput.Text);
                ChangePasswordViewModel changePassword = new ChangePasswordViewModel()
                {
                    Username = this.user.Username,
                    NewPassword = hashPass
                };

                bool result = _userProfile.ChangePassword(changePassword);
                if(result != true)
                {
                    string message = "somthings wrong!";
                    MessageBox.Show(message);
                    var time = Task.Delay(1200);
                    time.Wait();

                    this.Close();
                    ChangePasswordFm fm = new ChangePasswordFm(user, new UserProfileRepository());
                    fm.Show();
                }
                else
                {
                    string message = "your password is chnage.";
                    MessageBox.Show(message);
                    var time = Task.Delay(1200);
                    time.Wait();

                    this.Close();
                    Application.Exit();
                }

            }
        }
    }
}
