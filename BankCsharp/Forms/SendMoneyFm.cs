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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankCsharp.Forms
{
    public partial class SendMoneyFm : Form
    {
        private User user = new User();
        private readonly IUserProfileService _userProfileService;
        public SendMoneyFm(User user , IUserProfileService userProfile )
        {
            _userProfileService = userProfile;
            this.user = user;
            InitializeComponent();
        }

        private void MainPageBtn_Click(object sender, EventArgs e)
        {
            UserProfile profile = new UserProfile(new UserProfileRepository(), this.user.Username);
            this.Close();
            profile.Show();
        }

        private string CheckNumberCard(int numbercard)
        {
            return _userProfileService.IsNumberCard(numbercard);
        }
        private void NextBtn_Click(object sender, EventArgs e)
        {
            if((SecendCardNumber.Text.Length < 8 ) || (SecendCardNumber.Text.Length > 8))
            {
                string message = "Error Card number";
                MessageBox.Show(message);
                var time = Task.Delay(1200);
                time.Wait();
                SendMoneyFm moneyFm = new SendMoneyFm(this.user , new UserProfileRepository() );
                this.Close();
                moneyFm.Show();
            }else if (System.Text.RegularExpressions.Regex.IsMatch(MoneyInput.Text, "[^0-9]"))
            {
                string message = "Please enter only numbers.";
                MessageBox.Show(message);
                var time = Task.Delay(1200);
                time.Wait();
                SendMoneyFm moneyFm = new SendMoneyFm(this.user , new UserProfileRepository() );
                this.Close();
                moneyFm.Show();
            }

            try
            {
                SqlMoney money = Convert.ToDecimal(MoneyInput.Text);
                int cardNumber = Convert.ToInt32(SecendCardNumber.Text);
                SendMoneyViewModel sendMoney = new SendMoneyViewModel()
                {
                    Money = money,
                    CardNumber = cardNumber,
                };

                string secendUsername = CheckNumberCard(cardNumber);
                if(secendUsername != null)
                {
                    // next 
                }
                else
                {
                    string message = "Invalid NumberCard !";
                    MessageBox.Show(message);
                    SendMoneyFm moneyFm = new SendMoneyFm(this.user, new UserProfileRepository());
                    this.Close();
                    moneyFm.Show();
                }
            }catch(Exception ex)
            {
                string message = "Invalid Data type!";
                MessageBox.Show(message);
            }
        }
    }
}
