using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class cubeProperties
    {
        static void Main(string[] args)
        {
        double side = double.Parse(Console.ReadLine());
        string parameter = Console.ReadLine();
        if (parameter == "face")
        {
            PrintFace(side) ; 
        }
        else if (parameter == "space")
        {
            PrintSpace(side);
            
        }
        else if (parameter == "volume")
        {
            PrintVolume(side);
            
        }
        else if (parameter == "area" )
        {
            PrintArea(side); 

        }

             
        }

    private static double PrintArea(double side)
    {
        double result = Math.Pow(side, 2) * 6;
        Console.WriteLine($@"{result:f2}");
        return result;
    }

    private static double PrintVolume(double side)
    {
        double result =  Math.Pow(side, 3);
        Console.WriteLine($@"{result:f2}");
        return result;
    }

    private static double PrintSpace(double side)
    {
        double result =  Math.Sqrt(3 * Math.Pow(side, 2));
        Console.WriteLine($@"{result:f2}");
        return result;
    }

    private static double PrintFace(double side)
    {
        double result =  Math.Sqrt(2 * Math.Pow(side, 2));
        Console.WriteLine($@"{result:f2}");
        return result;
    }
}

