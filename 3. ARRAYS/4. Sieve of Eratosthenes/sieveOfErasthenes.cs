using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

        Fast(n);
       // Slow(n);
        }

    static void Slow(int n)
    {
        for (int i = 2; i < n; i++)
        {
            if (isPrime(i))
            {
                Console.WriteLine(i);
            }
        }
    }

     static bool isPrime(int i)
    {
        for (int j = 2; j < i; j++)
        {
            if (i % j == 0)
            {
                return false;
            }

        }
        return true;
    }

    static void Fast(int n)
    {
        bool[] primes = new bool[n + 1];
        for (int i = 0; i <= n; i++)
        {
            primes[i] = true;
        }
        primes[0] = primes[1] = false;

        for (int p = 2; p <= n; p++)
        {
            if (primes[p] == true)
            {
                Console.WriteLine(p);

                for (int j = 2; j <= n; j++)
                {
                    if (j*p <= n && j*p >= 0)
                    {
                        primes[j * p] = false;
                    }

                }

            }
        }
     }
}




