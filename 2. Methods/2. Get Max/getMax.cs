using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class Program
    {
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

       int result =  GetMAx(a, b, c);
        Console.WriteLine(result);
    }

    private static int GetMAx(int a, int b, int c)
    {
        int result = Math.Max(Math.Max(a,b), c);
        return result;
        
    }
}

