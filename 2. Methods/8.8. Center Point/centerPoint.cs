using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class CenterPoint
    {
        static void Main(string[] args)
        {
        //40/100
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());

        ClosestToCenterPoint(x1, y1, x2, y2);
    }

    private static void ClosestToCenterPoint(int x1, int y1, int x2, int y2)
    {
        double distance1 = distanceToCenter(x1, y1);
        double distance2 = distanceToCenter(x2, y2);
        if (distance1 > distance2)
        {
            Console.WriteLine($@"({x2}, {y2})");
        }
        else
        {
            if (distance1 <= distance2)
            {
                Console.WriteLine($@"({x1}, {y2})");
            }
        }
    }

    static double distanceToCenter(double x, double y)
    {
        return Math.Sqrt(Math.Pow((0 - x), 2) + Math.Pow((0 - y), 2));
    }
}

