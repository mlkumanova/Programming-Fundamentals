using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            
                int n = int.Parse(Console.ReadLine());
                GetMultipleOfEvensAndOdds(n);
                Console.WriteLine(GetMultipleOfEvensAndOdds(n));
            
        }

            

    private static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumEvens = GetSumOfEvensDigits(n);
            int sumOdds = GetSumOfOddDigits(n);
            int sum = Math.Abs(sumEvens * sumOdds);
            return sum;

        }

        private static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            while (n > 0 || n < 0)
            {
                int lastDigit = Math.Abs(n % 10);
                if (lastDigit % 2 == 1)
                {
                    sum = Math.Abs(sum + lastDigit);
                }
                n = Math.Abs(n / 10);
            }
            return sum;
        }

        private static int GetSumOfEvensDigits(int n)
        {
            int sum = 0;
            while (n > 0 || n < 0)
            {
                int lastDigit = Math.Abs(n % 10);
                if (lastDigit % 2 == 0)
                {
                    sum = Math.Abs(sum + lastDigit);
                }
                n = Math.Abs(n / 10);

            }
            return sum;
        }
    }


    

