using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_and_Event
{
    public delegate int CalDelegate(int n1, int n2);
    public delegate string NameDelegate(string name);

    internal class Calculation
    {
        public int Addition (int a, int b) 
        {
            return a + b;
        }
        public int Substraction (int a , int b) 
        {
            return a - b;
        }

        public int multiplication(int a, int b) 
        {
            return a * b;
        }

    }

    public class Test 
    {

         public string ToUpperCase(string name) 
        {
            return name.ToUpper();
        }

        public string ToLowerCase(string name ) { return name.ToLower(); }
    }
}
