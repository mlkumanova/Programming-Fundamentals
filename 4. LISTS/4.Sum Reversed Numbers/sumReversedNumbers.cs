using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class sumReversedNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine(Console.ReadLine().Split().Select(x => int.Parse(string.Join("", x.Reverse()))).Sum());

        //--or--
        //    string[] inputNum = Console.ReadLine().Split();
        //    int sum = 0;
        //
        //    for (int i = 0; i < inputNum.Length; i++)
        //    {
        //        string currNum = inputNum[i];
        //        List<char> reversedNum = currNum.Reverse().ToList();
        //
        //        string reversedNumString = string.Join("", //reversedNum);
        //        int resultNum = int.Parse(reversedNumString);
        //        sum += resultNum;
        //
        //
        //    }
        //    Console.WriteLine(sum);

        //-------------or---------
        //   string[] inputNum = Console.ReadLine().Split();
        //   int sum = 0;
        //
        //   for (int i = 0; i < inputNum.Length; i++)
        //   {
        //       string currNum = inputNum[i];
        //       string reversedNum = string.Join("", currNum.Reverse());
        //       int parsedNum = int.Parse(reversedNum);
        //       sum += parsedNum;
        //   }
        //   Console.WriteLine(sum);

        //---- or--


    }
}

