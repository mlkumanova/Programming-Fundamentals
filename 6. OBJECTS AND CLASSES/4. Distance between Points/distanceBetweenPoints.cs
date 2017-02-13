using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Point
{
    public double X { get; set; }
    public double Y { get; set; }
}
class distanceBetweenPoints
{
    static void Main()
    {
        var firstPoint = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

        var first = new Point
        {
            X = firstPoint[0],
            Y = firstPoint[1]
        };

        var secondPoint = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToList();

        var second = new Point
        {
            X = secondPoint[0],
            Y = secondPoint[1]
        };

        var result = CalculateDIstance(first, second);
        Console.WriteLine($"{result:f3}");

    }
    public static double CalculateDIstance(Point firstPoint, Point secondPoint)
    {
        var diffX = firstPoint.X - secondPoint.X;
        var diffY = firstPoint.Y - secondPoint.Y;

        var powX = Math.Pow(diffX, 2);
        var powY = Math.Pow(diffY, 2);

        return Math.Sqrt(powX + powY);
    }
}
    

