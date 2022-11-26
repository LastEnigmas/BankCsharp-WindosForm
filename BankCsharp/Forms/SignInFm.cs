﻿using BankCsharp.Core.Servises;
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
    public partial class SignInFm : Form
    {
        private readonly UserService _userService;
        public SignInFm(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void SetCancelButton(Button myCancelBtn)
        {
            this.CancelButton = myCancelBtn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SigninBtn_Click(object sender, EventArgs e)
        {
            UserViewModel userVm = new UserViewModel()
            {
                Username = FixText.FixTexts(UsernameInput.Text),
                Password = PasswordHashC.EncodePasswordMd5(PasswordInput.Text),
            };
            bool result = _userService.Login(userVm);
            if(result == true)
            {
                // Go to User pannel
            }
            else
            {
                // Go to error page and alert
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

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
    }
}
