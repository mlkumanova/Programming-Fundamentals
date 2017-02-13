using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class specialNumbers
{
    static void Main(string[] args)
    {
  
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 1; i < arr.Length + 1; i++)
        {
            int sumOfDigits = 0;
            int digits = i;
            while (digits != 0)
            {
                sumOfDigits += digits % 10;
                digits = digits / 10;
            }
            bool special = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
            
            Console.WriteLine($@"{i} -> {special}");

        }
    }
}
    

