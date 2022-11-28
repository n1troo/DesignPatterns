using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class CompanyAccount : BankAccount
    {
        public override void MakeWithdraw(int ammount)
        {
            Balance -= ammount;
        }
    }
}
