using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class removeNegativesAndReverse
    {
        static void Main()
        {
        List<int> nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();


       nums.RemoveAll(x => x < 0);

     if (nums.Count == 0)
     {
         Console.WriteLine("empty");
     }
        nums.Reverse();
     Console.WriteLine(string.Join(" ",nums));
  
    
     



    }
    }

