
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Fold_and_Sum
{
    class foldAndSum
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int. Parse)
                .ToArray();
            int k = nums.Length / 4;
            var firstRowlLeft = nums
                .Take(k)
                .Reverse()
                .ToList();
            var firstRowRight = nums
                .Reverse()
                .Take(k)
                .ToArray();
            var firstRow = firstRowlLeft
                .Concat(firstRowRight)
                .ToArray();
            var secondRow = nums
                .Skip(k)
                .Take(2 * k)
                .ToArray();

            var result = firstRow
                .Zip(secondRow, (x, y) => x + y)
                .ToList();
            Console.WriteLine(string.Join(" ", result));

         //   var res = firstRow.Select((n, index) => n + secondRow[index]).ToList();
         //   res.ForEach(Console.WriteLine);

        }
    }
}
