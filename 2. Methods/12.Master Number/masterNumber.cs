using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class masterNumber
    {
        static void Main(string[] args)
        {
        //0/100
        double n = double.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            if (IsPalindromCheck(i) == true && SumOfLastDigitis(i) == true && ContainsEvenDigit(i) == true)
            {
                Console.WriteLine(i);
            }
        }
       
        IsPalindromCheck(n);
        SumOfLastDigitis(n);
        ContainsEvenDigit(n);
    }

    private static bool ContainsEvenDigit(double n)
    {
        for (int i = 0; i < n; i++)
        {
            if (i% 2 == 0)
            {
                return true;
            }
        }
        return false;

    }

    private static bool SumOfLastDigitis(double n)
    {
        double sum = 0;
        double lasDigits = 0;
        while (n > 0)
        {
            lasDigits = n % 10;
            sum = sum + lasDigits;
            n = n / 10;

        }
        if (sum % 7 != 0)
        {
            return false;
        }
        return true;
    }

    private static bool IsPalindromCheck(double n)
    {
        double reverse = 0;
        double temp = 0;
        double lastDigit = 0;
        temp = n;
        while (n > 0)
        {
            lastDigit = n % 10;
            reverse = reverse * 10 + lastDigit;
            n = n / 10;   
        }
        if (reverse != temp)
        {
            return false;
        }
        return true;
    }
}
    

