using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class circleArea
    {
    static void Main(string[] args)
    {
        double r = double.Parse(Console.ReadLine());

        double result = Math.PI * r * r;
        Console.WriteLine($@"{result:f12}");

        }

    }

