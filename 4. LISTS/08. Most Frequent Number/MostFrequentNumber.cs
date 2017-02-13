using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
        //   var list = Console.ReadLine()
        //        .Split()
        //
        //        .Select(int.Parse)
        //        .GroupBy(l => l)
        //        .OrderByDescending(l => l.Count())
        //        .First() 
        //        .Distinct()           
        //        .ToList();
        //
        //    foreach (var item in list)
        //    {
        //        Console.WriteLine(item);
        //    }

        var list = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        var maxCount = 0;
        var maxFrequentNum = 0;

        for (int i = 0; i < list.Count; i++)
        {
            int counter = 0;
            for (int j = i; j < list.Count; j++)
            {
                if (list[i] == list[j])
                {
                    counter++;
                    if (counter > maxCount)
                    {
                        maxCount = counter;
                        maxFrequentNum = list[i];

                    }
                }
            }
        }
        Console.WriteLine(maxFrequentNum);
        

        
       



    }
}


