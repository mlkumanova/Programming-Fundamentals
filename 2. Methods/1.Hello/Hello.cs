﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Hello
    {
        static void Main(string[] args)
        {
        string name = Console.ReadLine();
        PrintName(name);

        }

    private static void PrintName(string name)
    {
        Console.WriteLine($@"Hello, {name}!");
    }
}

