using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
        var num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        int k = num.Count / 4;              
       
        var firstRowLeft = num.Take(k).Reverse().ToList();
            num.Reverse();
        var firstRowRight = num.Take(k).ToList();

        var firstRow = firstRowLeft.Concat(firstRowRight).ToList();
        var secondRow = num.Skip(k).Take(2 * k).Reverse().ToList();
        for (int i = 0; i < firstRow.Count; i++)
        {
        
        }

       



    }
}

