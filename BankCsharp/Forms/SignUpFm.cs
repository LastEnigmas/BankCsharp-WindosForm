using BankCsharp.Core.Repository;
using BankCsharp.Core.Servises;
using BankCsharp.Helper.Generator;
using BankCsharp.Helper.Security;
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
    public partial class SignUpFm : Form
    {
        private readonly IUserService _userService;

        public SignUpFm( IUserService userService)
        {   
            _userService = userService;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        private void ShoOrHide_CheckedChanged(object sender, EventArgs e)
        {
            if (ShoOrHide.Checked)
            {
                PasswordInput.UseSystemPasswordChar = true;
            }
            else
            {
                PasswordInput.UseSystemPasswordChar = false;
            }
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {

            if (_userService.IsNationalCode(Convert.ToInt32(NationalCodeInput.Text)))
            {
                // validation one (National Code)
                string message = "National code is exist ! ";
                MessageBox.Show(message);

                var time = Task.Delay(1200);
                time.Wait();

                this.Close();
                SignUpFm signUpFm = new SignUpFm(new UserRepository());
                signUpFm.Show();
            }else if (_userService.IsUsername(FixText.FixTexts(UsernameInput.Text)))
            {
                // validation two (Username)
                string message = "Username is exist ! ";
                MessageBox.Show(message);

                var time = Task.Delay(1200);
                time.Wait();

                this.Close();
                SignUpFm signUpFm = new SignUpFm(new UserRepository());
                signUpFm.Show();
            }
            else if(PasswordInput.Text != RePasswordinput.Text)
            {
                // validation tree (Password)
                string messageStr = "Password is not match";
                MessageBox.Show(messageStr);
                var time = Task.Delay(1200);
                time.Wait();

                this.Close();
                SignUpFm signUpFm = new SignUpFm( new UserRepository() );
                signUpFm.Show();
            }
            else if((System.Text.RegularExpressions.Regex.IsMatch(NationalCodeInput.Text , "[^0-9]")) || (NationalCodeInput.Text.Length > 8  ) || (NationalCodeInput.Text.Length < 8))
            {
                // validation four (natiaonal lenght)
                string messageStr = "Plese enter only numbers.[Less than 9 number]";
                MessageBox.Show(messageStr);
                var time = Task.Delay(1200);
                time.Wait();

                this.Close();
                SignUpFm signUpFm = new SignUpFm( new UserRepository() );
                signUpFm.Show();
            }
            else
            {
                UserSignUpViewModel userSignUp = new UserSignUpViewModel()
                {
                    Username = FixText.FixTexts(UsernameInput.Text),
                    Password = PasswordHashC.EncodePasswordMd5(PasswordInput.Text),
                    NationalCode = Convert.ToInt32(NationalCodeInput.Text),
                };

                bool result = _userService.SignUpUser(userSignUp);
                if(result != false )
                {
                    string message = "Your profile was created.";
                    MessageBox.Show(message);
                    var time = Task.Delay(1200);
                    time.Wait();
                    this.Close();
                    Form1 form = new Form1();
                    form.Show();
                }
                else
                {
                    string message = "Somthings Wrong.Please Try again.";
                    MessageBox.Show(message);
                    var time = Task.Delay(1200);
                    time.Wait();
                    this.Close();
                    SignUpFm signUpFm = new SignUpFm(new UserRepository());
                    signUpFm.Show();
                }

            }
        }
    }
}
