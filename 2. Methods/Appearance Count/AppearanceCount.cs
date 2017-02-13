using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class AppearanceCount
    {
        static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(HowManyTimesAppears(ref arr, number));


        }

        private static int HowManyTimesAppears(ref int[] arr, int number)
        {
            int counter = 0;

            foreach (var item in arr)
            {
                if (item == number)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
    

