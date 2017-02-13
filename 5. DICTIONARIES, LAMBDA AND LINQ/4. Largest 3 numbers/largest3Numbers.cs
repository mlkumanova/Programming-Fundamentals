using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class largest3Numbers
    {
        static void Main()
        {
        List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        var sortedNums = nums
            .OrderByDescending(x => x)
            .Take(3);
        Console.WriteLine(string.Join(" ", sortedNums));


    }
    }

