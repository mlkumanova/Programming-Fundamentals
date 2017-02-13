using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class foldAndSum
    {
        static void Main(string[] args)
        {

           var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
       
           var reverseFirstLeft = new int[arr.Length / 4];
           var reverseSecondRight = new int[arr.Length / 4];
           var reverseResult = new int[arr.Length / 2];
       
           //reverse
           for (int i = 0; i < arr. Length / 4; i++)
           {
               reverseFirstLeft[i] = arr[(arr.Length/4) -1 -i];
               reverseSecondRight[i] = arr[arr.Length -1 -i];
           }
           //sum
           for (int i = 0; i < arr.Length/4; i++)
           {
               reverseResult[i] = reverseFirstLeft[i] + arr[arr.Length / 4 + i];
               reverseResult[arr.Length / 4 + i] = reverseSecondRight[i] + arr[arr.Length / 2 + i];
       
           }
           Console.WriteLine(string.Join(" ",reverseResult));


        /////------------------

        //      var arr = Console.ReadLine().Split/(' /').Select(int.Parse).ToArray();
        //      int half = arr.Length / 2;
        //      int part = half / 2;
        //
        //      var sum = new int[half];
        //
        //      for (int i = 0; i <= 1; i++)
        //      {
        //          for (int j = 0; j < part; j++)
        //          {
        //              int firstIndex = ((part - 1) + /(-/j) + (i * (half + part)));
        //              int secondIndex = part + j + (i /*/ part);
        //              sum[j + (i * part)] = arr//[firstIndex] + arr[secondIndex];
        //          }
        //      }
        //      Console.WriteLine(string.Join(" ", sum));


        /////-------------or

   //    var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
   //    int k = arr.Length / 4;
   //    var rowLeft = arr.Take(k).Reverse();
   //    var rowRight = arr.Reverse().Take(k);
   //    var row1 = rowLeft.Concat(rowRight).ToArray();
   //    var row2 = arr.Skip(k).Take(2 * k).ToArray();
   //    var sumArr = row1.Select((x, index) => x + row2[index]);
   //    Console.WriteLine(string.Join(" ", sumArr));

    }
    }

