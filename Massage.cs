using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_and_Event
{

    public delegate void BalanceDelegate();
    internal class Massage
    {
        public static void NotSuffientBal() 
        {
            Console.WriteLine("Insufficient balance. can not process transaction");
        }
        public static void LowBalance() 
        {
            Console.WriteLine("Transaction completed. Low Balance. Your Balance is less than 3000. Please add money.");
        }
        public static void ZeroBalance() 
        {
            Console.WriteLine("Transaction Completed. Now Your Balance is Zero. Please add money. ");
        }
    }
}
