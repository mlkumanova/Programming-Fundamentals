using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
        var text = "My name is PokoLoko and i am 99 years old".ToLower().Replace(" ", string.Empty);
        var result = new SortedDictionary<char, int>();
        foreach (var symbol in text)
        {
            if (!result.ContainsKey(symbol))
            {
                result[symbol] = 0;
            }
            result[symbol]++;
        }
        foreach (var item in result)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
        }
    }

