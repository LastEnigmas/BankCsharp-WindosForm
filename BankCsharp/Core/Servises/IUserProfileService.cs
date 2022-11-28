using BankCsharp.models;
using BankCsharp.models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCsharp.Core.Servises
{
    public interface IUserProfileService
    {
        User FindUserByNationalCode(string username);
        string IsNumberCard(int number);
        bool ChangePassword(ChangePasswordViewModel changePassword);
        SecendUserInfoViewModel FindSecendUser(int cardNumber);
        bool DoSendMoney(SendEndMoneyViewModel sendEnd);
        bool CheckMoney(SendEndMoneyViewModel sendEnd);
        User GetUserByUsername(string username);
        bool SecenUserMoneyTask(string username , double money);
        User FindUserByCardNumber(string username);
        bool Update(User user);  
    }
}
