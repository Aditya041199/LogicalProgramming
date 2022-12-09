using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class CouponNumber
    {
        public void Coupon()
        {
            Console.WriteLine("How Many Coupon You Have To Generate?");
            int num = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[] arr = new int[num];
            for (int i = 0; i < arr.Length; i++)
            {

                int randomNum = random.Next(0, 100);
                arr[i] = randomNum;
            }
            foreach (var data in arr)
            {
                if (data != 0)
                {
                    Console.WriteLine(data);
                }
            }
        }
    }
}
