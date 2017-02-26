using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class SweetDessert
    {
        static void Main()
        {
        var cash = decimal.Parse(Console.ReadLine());
        var guest = decimal.Parse(Console.ReadLine());
        var bannanas = decimal.Parse(Console.ReadLine());
        var eggs = decimal.Parse(Console.ReadLine());
        var beriiesKg = decimal.Parse(Console.ReadLine());
        
        var calculatedPrice = (Math.Ceiling(guest / 6))*((2*bannanas) + (4*eggs) + (0.2m * beriiesKg));

        var diff = Math.Abs(cash - calculatedPrice);
        if (calculatedPrice<= cash)
        {
            Console.WriteLine($@"Ivancho has enough money - it would cost {calculatedPrice:f2}lv.");
        }
        else
        {
            Console.WriteLine($@"Ivancho will have to withdraw money - he will need {diff:f2}lv more.");
        }
    }

    }
    

