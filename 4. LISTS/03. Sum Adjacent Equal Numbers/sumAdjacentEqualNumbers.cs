﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class sumAdjacentEqualNumbers
    {
    static void Main()
     {
        List<decimal> input = Console.ReadLine()
            .Split()
            .Select(decimal.Parse)
            .ToList();

        for (int i = 1; i < input.Count; i++)
        {
            if (input[i] == input[i - 1])
            {
                input[i] = input[i] + input[i - 1];
                input.Remove(input[i - 1]);
                i = 0;
            }
        }
        Console.WriteLine(string.Join(" ", input));

    }
}


    

