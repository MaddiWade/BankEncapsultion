using System;

namespace BankEncapsultion
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAccounts = new BankAccount(1000);
            Console.WriteLine("please enter how much you want to deposit!");
            var myDeposit = double.Parse(Console.ReadLine());
            myAccounts.Deposit(myDeposit);

            var bal = myAccounts.GetBalance();
                Console.WriteLine($"this is your new balance! {bal}");
            
            Console.WriteLine("How much do you want to withdraw?");  
            var myWithdraw = double.Parse(Console.ReadLine());
            double newbal = bal - myWithdraw;
            if (myWithdraw <= 0)
                Console.WriteLine("Transaction Complete, Have a good day!"); 
            else
                Console.WriteLine($"This is your balance after withdraw! {newbal}");
        }
    }
}
