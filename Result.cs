using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_and_Event
{
    public class Result
    {
        public event DisplayMsg PassEvent;
        public event DisplayMsg FailEvent;
        public void AccepMark(float percent) 
        {
            if (percent < 40) 
            
                FailEvent(); 
            
            else
                PassEvent();

        }
    }
}
