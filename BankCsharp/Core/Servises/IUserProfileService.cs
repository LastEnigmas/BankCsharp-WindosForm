using BankCsharp.models;
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
    }
}
