using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Timer
{
    public class TimerEvent
    {
        public event EventHandler<TimerEventArgs> TimeOut;

        public int span;

        public TimerEvent(int ms)
        {
            span = ms;
        }
        public void OnTimeOut(int span)
        {
            TimerEventArgs e = new TimerEventArgs(span);
            TimeOut(this, e);
        }

        public void Start()
        {
            Thread.Sleep(span);
            OnTimeOut(span);
        }


    }
}
