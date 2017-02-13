using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Reverse_Arrays_Of_Strings
{
    class reverseArray
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').ToArray();

            Console.WriteLine(string.Join(" ", arr.Reverse()));

           // string[] input = Console.ReadLine().Split(' ').ToArray();
           // var reversed = Reverse(input);
           // Console.WriteLine(reversed);

        }
        private static string Reverse(string[] input)
        {
            var sb = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
                sb.Append(' ');
            }
            return sb.ToString();

        }

    }
    }

