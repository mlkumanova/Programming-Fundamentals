using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class hello
    {
        static void Main(string[] args)
    {
        /* 1. Hello
          string name = Console.ReadLine();

          PrintName(name);
      */

        /* 2. Get Max
         var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
         Console.WriteLine(GetMax(arr));
        */



        /* 3. LastDigit int num = int.Parse(Console.ReadLine()) % 10;
          Console.WriteLine(PrintNumberToText(num));
        */


        /*4. Appearance count
        int sizeOfArray = int.Parse(Console.ReadLine());
        var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(HowManyTimesAppears(ref arr,number)); 
        */

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

    private static string PrintNumberToText(int num)
    {
        string chislo = string.Empty;
        switch (num)
        {
            case 1: chislo = "one"; break;
            case 2: chislo = "two"; break;
            case 3: chislo = "three"; break;
            case 4: chislo = "four"; break;
            case 5: chislo = "five"; break;
            case 6: chislo = "six"; break;
            case 7: chislo = "seven"; break;
            case 8: chislo = "eight"; break;
            case 9: chislo = "nine"; break;
            default: chislo = "zero"; break;
        }
        return chislo;

    }

    private static int GetMax(int[] arr)
     {

         int biggest = int.MinValue;

         foreach (var item in arr)
         {
             if (biggest < item)
             {
                 biggest = item;
             }
         }
         return biggest;
     }


    static void PrintName(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
  
}

