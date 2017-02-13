using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class numbersInReversedOrder
    {
    static void Main(string[] args)
    {
        string number = Console.ReadLine();
        ReverseNumber(number); 
    }

    private static void ReverseNumber(string number)
    {
        Console.WriteLine(new string(number.Reverse().ToArray()));
    }


    
    //-for  int number

    //       int n = int.Parse(Console.ReadLine());
    //       ReverseNumber(n);
    //      
    //   }
    //
    //   private static void ReverseNumber(int n)
    //   {
    //       double reverse = 0;
    //       while (n > 0 || n< 0)
    //       {
    //           double lastDigit = n % 10;
    //           reverse = (reverse * 10) + //lastDigit;
    //           n = n / 10;
    //       }
    //       Console.WriteLine(reverse);


}


