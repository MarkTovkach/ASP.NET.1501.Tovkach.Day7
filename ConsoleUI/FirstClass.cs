using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer;

namespace ConsoleUI
{
    public static class FirstClass
    {

        public static void SomeWork(object sender,TimerEventArgs args)
        {
            Console.WriteLine("FirstClass perfomed some actions");
        }
    }
}
