using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Assignment_1
{
    internal class MainAccount
    {
        static int counter = 0;
        public SavingsAccount savings;
        public CurrentAccount current;
        public static void incrementCounter()
        {
            counter++;
        }

        public static int getCounter() { return counter; }

        public MainAccount()
        {
            incrementCounter();
            Console.WriteLine("\nEnter Your Name : ");
            string name = Console.ReadLine();
            int accNo = getCounter();
            savings = new SavingsAccount(accNo, name);
            current = new CurrentAccount(accNo,name);

            Console.WriteLine("Your Account is created successfully!");
        }

        public void showDetails()
        {
            Console.WriteLine("\nSavings Account Details : ");
            this.savings.showAccountDetails();
            Console.WriteLine("\nCurrent Account Details : ");
            this.current.showAccountDetails();
        }
    }
}
