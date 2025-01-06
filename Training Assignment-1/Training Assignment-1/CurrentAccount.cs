using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Assignment_1
{
    internal class CurrentAccount:Account
    {
        public double overdraftLimit = 1000;
        public double overdraftRemaining = 1000;
        public CurrentAccount(int accNo, string Name) : base(accNo, Name) { overdraftRemaining = 1000; }
        public override void withdraw()
        {
            Console.Write("Enter amount to withdrawn : ");
            double amt = Convert.ToDouble(Console.ReadLine());
            try
            {
                if (amt > this.Balance)
                {
                    if(amt > this.Balance + this.overdraftRemaining)
                    {
                        throw new Exception("Can't withdraw more than overdraft limit");
                    }
                    else
                    {
                        this.overdraftRemaining = this.overdraftLimit - (amt - this.Balance);
                        this.Balance = 0;
                    }
                }
                else
                {
                    Balance-=amt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public override void showAccountDetails()
        {
            base.showAccountDetails();
            Console.WriteLine("OverDraft Limit remaining: "+this.overdraftRemaining);
        }

    }
}
