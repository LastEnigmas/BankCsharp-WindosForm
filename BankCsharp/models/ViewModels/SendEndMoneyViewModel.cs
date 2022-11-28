using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCsharp.models.ViewModels
{
    public class SendEndMoneyViewModel
    {
        public int UserFirstNationalCode { get; set; }
        public string UserFirstUsername { get; set; }
        public string UserSecendUsername { get; set; }
        public double Money { get; set; }
    }
}
