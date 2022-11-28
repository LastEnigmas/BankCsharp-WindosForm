using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCsharp.models.ViewModels
{
    public class SendMoneyViewModel
    {
        public int CardNumber { get; set; }
        public SqlMoney Money { get; set; }
    }
}
