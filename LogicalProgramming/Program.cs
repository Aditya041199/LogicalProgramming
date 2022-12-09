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
                Console.WriteLine("1. Fibonacci Series" + "\n" + "2. Perfect Number" + "\n" + "3. Prime Number" + "\n" + "4. Reverse Number" + "\n" + "5. Coupon Number" + "\n" + "6. Exit");
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        FibonacciSeries fibo = new FibonacciSeries();
                        fibo.Fibonacci();
                        break;
                    case 2:
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.Perfect();
                        break;
                    case 3:
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.Prime();
                        break;
                    case 4:
                        ReverseNumber reverseNumber = new ReverseNumber();
                        reverseNumber.Reverse();
                        break;
                    case 5:
                        CouponNumber couponNumber = new CouponNumber();
                        couponNumber.Coupon();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}