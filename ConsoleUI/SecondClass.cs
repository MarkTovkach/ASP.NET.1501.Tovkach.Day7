using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer;

namespace ConsoleUI
{
    public static class SecondClass
    {
        public static void SomeWork(object sender, TimerEventArgs args)
        {
            Console.WriteLine("SecondClass perfomed some actions");
        }
    }
}
