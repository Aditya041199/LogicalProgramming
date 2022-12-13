using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class StopWatch
    {
        public void Watch()
        {
            Stopwatch stopwatch = new Stopwatch();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press any key to start stopwatch");
            Console.ResetColor();
            Console.ReadKey();//screen holding
            stopwatch.Start();//start

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press any key to stop stopwatch");
            Console.ResetColor();
            Console.ReadKey();
            stopwatch.Stop();//stop
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}:{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);//0,1,2,3 display placed
            Console.WriteLine(elapsedTime);
        }
    }
}
