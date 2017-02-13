using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class graterofTwoValues
    {
        static void Main(string[] args)
        {
        var type = Console.ReadLine();
        if (type == "int")
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMaxInt(first, second));
        }
        else if (type == "char")
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            int result = GetMaxChar(first, second);
            var bigger = result == -1 ? $"{second}" : $"{first}";
            Console.WriteLine(bigger);


        }
        else if (type == "string")
        {
            var first = Console.ReadLine();
            var second = Console.ReadLine();
            GetMaXstring(first, second);


        }


    }

    private static void GetMaXstring(string first, string second)
    {

        if (first.CompareTo(second) == -1)
        {
            Console.WriteLine($@"{second}");
            return;
        }
        else if (first.CompareTo(second) == 1)
        {
            Console.WriteLine($@"{first}");
            return;
        }

    }

    public static int GetMaxChar(char first, char second)
    {
        int firstChar = first;
        int secondChar = second;
        var res = firstChar.CompareTo(secondChar);

        return res;

    }

    static int GetMaxInt(int first, int second)
    {
        return Math.Max(first, second);
    }
}
    

