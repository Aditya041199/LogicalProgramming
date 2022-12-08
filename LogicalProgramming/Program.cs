using System;
namespace LogicalProgramming

{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Logical Programming Problems");
                Console.WriteLine("1. Fibonaccis Series" + "\n" + "2. Exit");
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        FibonacciSeries fibo = new FibonacciSeries();
                        fibo.Fibonacci();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}