using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
        IsPrime(number);
        if (IsPrime(number))
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }

    }

    public static bool IsPrime(double number)
    {
        if (number == 1 || number == 0)
        {
            return false;
        }
        if (number == 2)
        {
            return true;
        }

        double half = number / 2;
        for (int i = 2; i <= half; ++i)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
}
