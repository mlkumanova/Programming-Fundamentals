﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   class Program
    {
        static void Main()
        {
        long centuries = long.Parse(Console.ReadLine());
        long years = centuries * 100;
        long days =(long)( years * 365.2422);
        long hours = days * 24;
        long minutes = hours * 60;

        Console.WriteLine($@"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }

