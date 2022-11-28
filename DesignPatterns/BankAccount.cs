using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class BankAccount
    {
        public string Name { get; set; } 
        public float Balance { get; protected set; } = 600;

        public void MakeDeposit(int ammount)
        {
            Balance += ammount;
        }

        public virtual void MakeWithdraw(int ammount)
        {
            if (Balance - ammount < 0)
            {
                throw new Exception("Balance need to be positive");
            }
            Balance -= ammount;
        }
    }
}
