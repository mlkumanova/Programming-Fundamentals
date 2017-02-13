using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class squareNumbers
    {
        static void Main(string[] args)
        {
        List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
        var sortedList = new List<double>();
        foreach (var num in numbers)
        {
            var isInt = FindRoot(num);
            if (isInt)
            {
                sortedList.Add(num);
            }
        }
       // sortedList.Sort();
       // sortedList.Reverse();
        var sort = sortedList.OrderByDescending(x => x);
        Console.WriteLine(string.Join(" ", sort));          

        }

    private static bool FindRoot(double num)
    {
        if (Math.Sqrt(num) == (int)Math.Sqrt(num))
        {
            return true;
        }
        return false;
    }
}

