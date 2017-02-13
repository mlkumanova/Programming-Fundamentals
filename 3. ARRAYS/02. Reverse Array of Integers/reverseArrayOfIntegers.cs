using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class reverseArrayOfIntegers
    {
        static void Main(string[] args)
        {
        var n = int.Parse(Console.ReadLine());
        var arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write($@"{arr[i]} ");
        }
        Console.WriteLine();

        }

    //*4. Revers arrays
    //  int[] numbers = Console.ReadLine().Split(new char[] { ' ' },
    //      StringSplitOptions.RemoveEmptyEntries).
    //      Select(int.Parse).ToArray();
    //
    //  for (int i = 0; i < numbers.Length / 2; i++)
    //  {
    //      int temp = numbers[numbers.Length - 1 - i];
    //      numbers[numbers.Length - 1 - i] = numbers[i];
    //      numbers[i] = temp;
    //
    //
    //  }
    // Console.WriteLine(string.Join(" ", numbers));
}

