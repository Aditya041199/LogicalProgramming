using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class FibonacciSeries
    {
        public void Fibonacci()
        {
            Console.WriteLine("Enter The Length Of Series:");
            int num = Convert.ToInt32(Console.ReadLine());
            int firstNum = 0, secondNum = 1, thirdNum = 0;
            Console.WriteLine("First no. - " + firstNum + "\n" + "Second no. - " + secondNum);
            for (int i = 0; i < num; i++)
            {
                thirdNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = thirdNum;
                Console.WriteLine(thirdNum);
            }
        }
    }
}
