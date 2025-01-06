using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Training_Assignment_1
{
    internal class Account
    {
        protected string accountHolderName;
        protected double Balance;
        protected int accountNumber;

        public Account(int accNo,string Name)
        {
            this.accountHolderName = Name;
            this.accountNumber = accNo;
            this.Balance = 0;
        }

        public virtual void showAccountDetails()
        {
            Console.WriteLine($"Account Number : {this.accountNumber}");
            Console.WriteLine($"Account Holder Name : {this.accountHolderName}");
            Console.WriteLine($"Balance : {this.Balance}");
        }

        public void depositAmount()
        {
            Console.WriteLine("Enter amount to be deposited : ");
            double amt = Convert.ToDouble(Console.ReadLine());
            this.Balance += amt;

            Console.WriteLine("Amount Deposited");
        }

        public virtual void withdraw()
        {
            try
            {
                Console.Write("\nEnter the amount to be withdrawn : ");
                double amt = Convert.ToDouble(Console.ReadLine());
                if (amt > this.Balance)
                {
                    throw new Exception("Account Balance is Low!!");
                }
                else
                {
                    this.Balance -= amt;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception message : {e.Message}");
            }
        }

        public void showBalance()
        {
            Console.WriteLine($"\nAccount balance : {this.Balance}");
        }
    }
}
