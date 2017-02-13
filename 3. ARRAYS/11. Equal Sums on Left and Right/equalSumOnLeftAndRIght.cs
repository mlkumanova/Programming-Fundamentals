using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class equalSumOnLeftAndRIght
    {
        static void Main(string[] args)
        {
        var num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        

     if (num.Length == 1)
     {
         Console.WriteLine("0");
         return;
     }
     var leftSum = 0;
     var rightSum = 0;
     bool isFound = false;
     for (int i = 0; i < num.Length; i++)
     {
         for (int j = 0; j < i; j++)
         {
             leftSum = leftSum + num[j];
         }
         for (int k = i + 1; k < num.Length; k++)
         {
             rightSum = rightSum + num[k];
  
         }
         if (leftSum == rightSum)
         {
             Console.WriteLine(i);
             isFound = true;
         }
         else
         {
             leftSum = 0;
             rightSum = 0;
         }
            
        }


        if (isFound == false)
        {
            Console.WriteLine("no");
        }




        // var reversedNum = num.Reverse().ToArray();
        // var leftSum = 0;
        // var rightSum = 0;
        // for (int i = 0; i < num.Length; i++)
        // {
        //     var position = num[i];
        //
        //     leftSum = num[i] + num[i + 1];
        //     rightSum = reversedNum[i] + reversedNum[i + 1];
        //     position = Math.Abs(num[i] - leftSum);
        //
        //     Console.WriteLine(position);
        //
        // }




    }
}

