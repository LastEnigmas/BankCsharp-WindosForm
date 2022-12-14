using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCsharp.models
{
    public class User
    {
        public string Username { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public int NationalCode { get; set; }
        public SqlMoney Money { get; set; }
        public int CardNumber { get; set; }
    }
}
