using BankCsharp.Core.Repository;
using BankCsharp.Core.Servises;
using BankCsharp.models;
using BankCsharp.models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankCsharp.Forms
{
    public partial class SendMoneyEnd : Form
    {
        private readonly IUserProfileService _userProfile;
        private User user = new User();
        private SecendUserInfoViewModel secendUser = new SecendUserInfoViewModel();
        private readonly double MONEY;
        public SendMoneyEnd(User user , IUserProfileService userProfile , int secendUserCardNumber , double money)
        {
            this.user = user;
            _userProfile = userProfile;
            InitializeComponent();
            FillSecendUserInfo(secendUserCardNumber);
            FillDataForm(secendUser , money);
            MONEY = money; 
        }

        private void FillDataForm(SecendUserInfoViewModel secendUser , double money )
        {
            SecendCardNumber.Text = secendUser.CardNumber.ToString();
            MoneyInput.Text = money.ToString();
            UserInput.Text = secendUser.Username.ToString();
        }
        private void FillSecendUserInfo(int secendusercardnumber)
        {
            secendUser = _userProfile.FindSecendUser(secendusercardnumber);
        }
        private void MainPageBtn_Click(object sender, EventArgs e)
        {
            UserProfile profile = new UserProfile( new UserProfileRepository()  , this.user.Username );
            this.Close();
            profile.Show();
        }
        private void SendBtn_Click(object sender, EventArgs e)
        {
            SendEndMoneyViewModel sendEnd = new SendEndMoneyViewModel()
            {
                UserFirstNationalCode = this.user.CardNumber,
                UserFirstUsername = this.user.Username,
                UserSecendUsername = secendUser.Username,
                Money = MONEY,
            };


        }
    }
}
