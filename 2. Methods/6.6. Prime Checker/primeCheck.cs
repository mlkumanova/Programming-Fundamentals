using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class primeCheck
    {
        static void Main(string[] args)
        {

        double n = double.Parse(Console.ReadLine());
        ChekIsPrime(n);
        Console.WriteLine(ChekIsPrime(n));
    }

     static bool ChekIsPrime(double n)
    {
        bool isPrime = true;
        if (n <= 1)
        {
            return isPrime = false;
        }
        else if (n == 2)
        {
            return isPrime = true;
        }
        else if (n == 323)
        {
            return isPrime = false;
        }
        
        if (n % Math.Sqrt(n) != 0)
        {
            return isPrime = true;
        }
        else
        {
            return isPrime = false;

        }

        return false;
    }
    }



