using BankCsharp.models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCsharp.Core.Servises
{
    public interface IUserService
    {
        bool Login(UserViewModel user);
        bool IsUsername(string username);
        bool IsNationalCode(int nationalCode);
        bool SignUpUser(UserSignUpViewModel userSignUp);
    }
}
