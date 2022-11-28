using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace DesignPatterns
{
    public class PersonalBankAccount : BankAccount
    {
        public void RequestPersonalAcc()
        {
            Console.WriteLine("Here is only in personal acc");
        }
    }
}
