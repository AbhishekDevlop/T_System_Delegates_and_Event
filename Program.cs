using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_and_Event
{
    public delegate void DisplayMsg(); //hold method reference of failmsg anf passmsg
    public delegate void ErrorDelegate();
    public class Program
    {
        static void ErrorMsg()
        {
            Console.WriteLine("You are not Eligible for Vote.");
        }

        static void FailMsg()
        {
            Console.WriteLine("You are Fail");
        }
        static void PassMsg()
        {
            Console.WriteLine("Congragulation you are pass");
        }
        static void Main(string[] args)
        {
            Calculation cal = new Calculation();
            CalDelegate calculateAdd = new CalDelegate(cal.Addition);
            int result = calculateAdd.Invoke(20, 10);
            Console.WriteLine("Addition = "+result);

            CalDelegate calculateSub = new CalDelegate(cal.Substraction);
            result = calculateSub.Invoke(20, 10);
            Console.WriteLine("Substraction"+result);
            Console.WriteLine("===========================");

            //TO UPPERCASE DELEGATE
            Test t =  new Test();
            NameDelegate namDel = new NameDelegate(t.ToUpperCase);
            string name = namDel.Invoke("Abhishek");
            Console.WriteLine("Name  = "+name);
            Console.WriteLine("=================================");

            Console.WriteLine("=========Multicast Delegate======");
            //Multicast Delegate

            Calculation cal1 = new Calculation();
            CalDelegate calculate = new CalDelegate(cal1.Addition);
            calculate += new CalDelegate(cal1.Substraction);
            calculate += new CalDelegate(cal1.multiplication); // adding in Invocation list

            Delegate[] list = calculate.GetInvocationList();

            foreach (Delegate item in list)
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke(20, 10));
            }
            Console.WriteLine("========================================");

            //Multicaste Delegate
            
            Test t1 = new Test();
            NameDelegate nameDelegate = new NameDelegate(t1.ToUpperCase);
            nameDelegate += new NameDelegate(t1.ToLowerCase);

            Delegate[] names = nameDelegate.GetInvocationList();
            
            foreach(Delegate item in names) 
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke("Abhishek"));

            }

            Console.WriteLine("===========Event==========");
            //event 

            User user = new User();
            user.AgeEvent += new ErrorDelegate(ErrorMsg);
            int age = user.AcceptAge(12);
            Console.WriteLine($"Candidate age is {age} yrs.");


            //Result Event 

            Result rsult = new Result();
            rsult.PassEvent += new DisplayMsg(PassMsg);
            rsult.FailEvent += new DisplayMsg(FailMsg);
            rsult.AccepMark(35);
            Console.WriteLine("==========================================");

            //Bank Event 
            Massage msg = new Massage();
            Bank b = new Bank();
            b.LowBalance += new BalanceDelegate(Massage.LowBalance);
            b.ZeroBal += new BalanceDelegate(Massage.ZeroBalance);
            b.InsufficentBal += new BalanceDelegate(Massage.NotSuffientBal);
            //float bal = (float)b.withdraw(5000);
            //Console.WriteLine("Your Current balance is " + bal);
            //bal = (float)b.withdraw(3000);
            //Console.WriteLine("Your Current balance is " + bal);
            //bal = (float)b.withdraw(2000);
            //Console.WriteLine("Your Current balance is " + bal);
            //var ba = (float)b.withdraw(11100);
            //Console.WriteLine("Your Current balance is " + ba);

            string s1,s2 = "yes";
            float bal;
            do
            {
                Console.WriteLine("Enter a amount ");
                float amount = Convert.ToSingle(Console.ReadLine());
                bal = (float)b.withdraw(amount);
                Console.WriteLine("Your current balance is " + bal);
                Console.WriteLine("Do you want to withdraw money again");
                s1 = Console.ReadLine();
            } while (s1 == s2);
            Console.WriteLine("Thank you For Banking Please visit Again");
        }
    }
}
