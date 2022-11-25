using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCsharp.Helper.Generator
{
    public class FixText
    {
        public static string FixTexts(string text)
        {
            return text.Trim().ToLower();
        }
    }
}
