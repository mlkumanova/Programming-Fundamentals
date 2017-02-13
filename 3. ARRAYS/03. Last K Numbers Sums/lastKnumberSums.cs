using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Last_K_Numbers_Sums
{
    class lastKnumberSums
    {
        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());
            long k = int.Parse(Console.ReadLine());

            var number = new long[n];
            number[0] = 1;

            for (long i = 1; i < number.Length; i++)
            {
                number[i] = SumOfPrevKElement(number, i, k);

            }
            for (long i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);

            }
        }
        static long SumOfPrevKElement(long[] number, long index, long k)
        {
            long sum = 0;
            for (long i = Math.Max(index - k, 0); i < index; i++)
            {
                sum += number[i];
            }
            return sum;
        }
    
}
}
