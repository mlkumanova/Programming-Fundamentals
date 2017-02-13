using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
        //----------
        //List < string > names = new List<string>() { "Peter", "Maria", "Katya", "Todor"};
        //     names.Add("Kumanova");
        //     names.RemoveAt(0);
        //    names.Remove("Todor");
        //    names.Insert(3, "MIMITYYY");
        //    foreach (var name in names)
        //    {
        //        Console.WriteLine(name);
        //    }

        //-----------Remove Negatives and Reverse
        //    List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        //    List<int> result = new List<int>();

        //    foreach (var num in numbers)
        //    {
        //        if (num >= 0)
        //        {
        //            result.Add(num);
        //        }
        //    }
        //    result.Reverse();
        //
        //    if (result.Count > 0)
        //    {
        //        Console.WriteLine(string.Join(" ", result));
        //    }
        //    else
        //    {
        //        Console.WriteLine("empty");
        //    }

        //------------APPEND LIST------

        // var lists = Console.ReadLine().Split('|');
        // var result = new List<string>();
        // for (int i = lists.Length - 1; i >= 0; i--)
        // {
        //     var list = lists[i].Split(' ');
        //     foreach (var item in list)
        //     {
        //         if (item != string.Empty)
        //         {
        //             result.Add(item);
        //
        //         }
        //     }
        //     
        // }
        //
        // Console.WriteLine(string.Join(" ", result));

        //-----------SUM ADJACENT EQUAL NUMBERS

        List<decimal> num = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
        List<decimal> result = new List<decimal>();
        bool areAllDifferent = false;
        while (!areAllDifferent)
        {
            areAllDifferent = true;
            for (int i = 0; i < num.Count; i++)
            {

            }
        }


    }
    }

