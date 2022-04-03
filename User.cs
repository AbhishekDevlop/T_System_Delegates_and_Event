using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_and_Event
{
    internal class User
    {
        public event ErrorDelegate AgeEvent;

        public int AcceptAge(int age) 
        {
            if (age < 18) 
            {
                AgeEvent(); //call event
            }
            return age;
        }
    }
}
