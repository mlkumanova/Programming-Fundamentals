using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class geometryCalculator
    {
        static void Main(string[] args)
        {
        string figureType = Console.ReadLine();
        if (figureType == "triangle")
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            PrintTiangleArea(side, height);
        }
        else if (figureType == "square")
        {
            double side = double.Parse(Console.ReadLine());

            PrintSquareArea(side);
        }
        else if (figureType == "rectangle")
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            PrintRectangleArea(width, height);

        }
        else if (figureType == "circle")
        {
            double radius = double.Parse(Console.ReadLine());

            PrintCircleArea(radius);
        }
        
        }

    private static double PrintCircleArea(double radius)
    {
        double area = Math.PI * radius*radius;
        Console.WriteLine($@"{area:f2}");
        return area;
    }

    private static double PrintRectangleArea(double width, double height)
    {
        double area = width * height;
        Console.WriteLine($@"{area:f2}");
        return area;
    }

    private static double PrintSquareArea(double side)
    {
        double area = Math.Pow(side, 2);
        Console.WriteLine($@"{area:f2}");
        return area;
    }

    private static double PrintTiangleArea(double side, double height)
    {
        double area = (side * height) / 2;
        Console.WriteLine($@"{area:f2}");
        return area;
    }
}

