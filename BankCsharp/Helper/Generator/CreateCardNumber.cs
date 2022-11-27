using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCsharp.Helper.Generator
{
    public class CreateCardNumber
    {
        public static int CreateNumber()
        {
            Random random = new Random();
            int CardNumber = random.Next(10000000, 99999999);
            return CardNumber;
        }
    }
}
