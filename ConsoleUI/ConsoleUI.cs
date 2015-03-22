using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer;

namespace ConsoleUI
{
    class ConsoleUI
    {
        static void Main(string[] args)
        {
            TimerEvent timer = new TimerEvent(5000);
            timer.TimeOut += FirstClass.SomeWork;
            timer.TimeOut += SecondClass.SomeWork;
            timer.Start();
            Console.ReadKey();
        }
    }
}
