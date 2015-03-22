using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    public class TimerEventArgs : EventArgs
    {
        public int ms;

      public  TimerEventArgs(int ms)
        {
            this.ms = ms;
        }

    }
}
