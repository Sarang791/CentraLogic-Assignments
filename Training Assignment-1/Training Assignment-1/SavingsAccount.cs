using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Assignment_1
{
    internal class SavingsAccount: Account
    {
        const double interestRate = 6.5;

        public void calculateInterest()
        {
            double interest = (this.Balance * interestRate * 2) / 100;
            Console.WriteLine($"Your interest amount is : {interest}");
        }

        public SavingsAccount(int accNo, string Name): base( accNo, Name) { }
    }
}
