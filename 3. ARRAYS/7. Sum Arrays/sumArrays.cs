using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class sumArrays
    {
        static void Main(string[] args)
        {
        var first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var second = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var result = Math.Max(first.Length, second.Length);
        for (int i = 0; i < result; i++)
        {
            var sum = first[i % first.Length] + second[i % second.Length];
            Console.Write(sum + " ");
        }
        Console.WriteLine();

        }
    }
    

