using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_and_Event
{
    public class Bank
    {
        public event  BalanceDelegate  LowBalance;
        public event BalanceDelegate InsufficentBal;
        public event BalanceDelegate ZeroBal;
        float bal;
        public Bank()
        {
            bal = 10000;
        }

        public float Deposit(float amt) 
        {
            bal += amt;
            return bal;
        }
        public float withdraw(float amt) 
        {
            float able = (float) bal - amt; // to check //is he eligible for to withdraw amt;
           if(able <0) 
            {
                InsufficentBal();
                return bal;
            }
            else  
            {
                bal -= amt;

                if (bal == 0)
                { 
                    ZeroBal();
                    return bal;
                }
                else if (bal < 3000) 
                {
                    LowBalance();
                    return bal;
                }
                else 
                {
                    return bal;
                }
            }
        }
    }
}
