using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class pairsByDifference
    {
        static void Main(string[] args)
        {
          var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
          int difference = int.Parse(Console.ReadLine());
      
          int counter = 0;
          for (int i = 0; i < input.Length; i++)
          {
              for (int j = input.Length - 1; j > i; j--)
              {
                  if (input[i] - input[j] == difference || input[j] - input[i] == difference)
                  {
                      counter++;
                  }
              }
               
          }
          Console.WriteLine(counter);

//----------
     //   var list = Console.ReadLine().Split().Select(int.Parse).ToList();
     //   var diff = int.Parse(Console.ReadLine());
     //   var count = 0;
     //
     //   foreach (var num in list)
     //   {
     //       foreach (var nums in list)
     //       {
     //           if (num - nums == diff)
     //           {
     //               count++;
     //           }
     //       }
     //   }
     //   Console.WriteLine(count);

    }
}

