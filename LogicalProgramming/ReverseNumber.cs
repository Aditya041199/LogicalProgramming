using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class ReverseNumber
    {
        public void Reverse()
        {
            Console.WriteLine("Enter The Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;
            while (num > 0)
            {
                int reminder = num % 10;
                reverse = reverse * 10 + reminder;
                num /= 10;
            }
            Console.WriteLine(reverse);
        }
    }
}
