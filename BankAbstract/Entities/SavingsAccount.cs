using System;
using System.Collections.Generic;
using System.Text;

namespace BankAbstract.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)
        {
            //metodo sobrescrito, recebe o profixo OVERRIDE
            base.Withdraw(amount);//base reaproveita o funcionamento do metodo original
            Balance -= 2.0;
        }
    }
}
