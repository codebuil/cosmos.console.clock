using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Sys = Cosmos.System;
using System.Threading;
namespace clocks
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("time");
        }

        protected override void Run()
        {
            DateTime dt = DateTime.Now;

            Console.SetCursorPosition(1, 10);
            Console.WriteLine(dt.ToString()+"                         ");
            
            Thread.Sleep(1000);


        }
    }
}
