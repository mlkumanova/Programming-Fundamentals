using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.reverse_array_of_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isFound = false;
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    int x = input[i];
                    int y = input[j];
                    int res = x + y;
                    foreach (var item in input)
                    {
                        if (res == item)
                        {
                            Console.WriteLine($"{input[i]} + {input[j]} == {res}");
                            isFound = true;

                        }
                    }
                }
            }
            if (!isFound)
            {
                Console.WriteLine("No");
            }

        }
       
    }
}
