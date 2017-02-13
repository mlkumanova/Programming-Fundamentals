using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Rounding_Numbers
{
    class roundingNumbers
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] + "=>" + Math.Round(numbers[i], MidpointRounding.AwayFromZero));
            }
        }
    }
}
