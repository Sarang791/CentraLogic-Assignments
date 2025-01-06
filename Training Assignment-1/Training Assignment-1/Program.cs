using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Comment added to check push operation

//new comment to test agian

namespace Training_Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainAccount m = null;
            while (true)
            {
                Console.WriteLine("\n-----------MENU-----------");
                Console.WriteLine("1. Create Account\n2. Show Details\n3. Deposit to Savings Account\n4. Deposit to Current Account\n5. Withdraw from Saving Account\n6. Withdraw from Current Account\n7. Show Earned Interest\n8. Exit\n");
                Console.Write("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: m = new MainAccount(); break;

                    case 2: if (m == null) Console.WriteLine("Create account first");
                        else m.showDetails();
                        break;

                    case 3:
                        if (m == null) Console.WriteLine("Create account first");
                        else m.savings.depositAmount();
                        break;

                    case 4:
                        if (m == null) Console.WriteLine("Create account first");
                        else m.current.depositAmount();
                        break;

                    case 5:
                        if (m == null) Console.WriteLine("Create account first");
                        else m.savings.withdraw();
                        break;

                    case 6:
                        if (m == null) Console.WriteLine("Create account first");
                        else m.current.withdraw();
                        break;

                    case 7:
                        if (m == null) Console.WriteLine("Create account first");
                        else m.savings.calculateInterest();
                        break;


                    case 8:
                        Console.WriteLine("Thank You !!");
                        return;
                }
            }
        }
    }
}
