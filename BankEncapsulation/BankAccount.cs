using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    { 

                public BankAccount()
                { 
                }

    private double balance = 0;

   
      
        public void Deposit(double amount)
        {
            Console.WriteLine($"Simulating a deposit of {amount, 0:c} to your account!!");
            balance = amount;
        }
        public double GetBalance() 
        { 
                return balance;
        }
   
     }
}
