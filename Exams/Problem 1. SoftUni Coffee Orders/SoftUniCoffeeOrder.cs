using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class SoftUniCoffeeOrder
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        decimal totalPrice = 0m;
        for (int i = 0; i < n; i++)
        {
            var pricePerCapsule = decimal.Parse(Console.ReadLine());

            DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
            long capsuleCount = long.Parse(Console.ReadLine());

            var daysInMouth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

            decimal currPrice = (daysInMouth * capsuleCount) * pricePerCapsule;
            totalPrice += currPrice;



            Console.WriteLine($@"The price for the coffee is: ${currPrice:f2}");

        }

        Console.WriteLine($@"Tota;: ${totalPrice:f2}");










        //-----------------------------------------------
        //var orders = long.Parse(Console.ReadLine());
        //decimal total = 0m;
        //decimal priceCoffe = 0m;
        //var result = new List<decimal>();


        //for (int i = 0; i < orders; i++)
        //{
        //    decimal price = decimal.Parse(Console.ReadLine());
        //    var inputDate = Console.ReadLine();
        //    var date = DateTime.ParseExact(inputDate, "d/M/yyyy", CultureInfo.InvariantCulture);
        //    var capsules = decimal.Parse(Console.ReadLine());

        //    decimal days = System.DateTime.DaysInMonth(date.Year, date.Month);

        //    priceCoffe = days * capsules * price;
        //    total += priceCoffe;

        //    result.Add(priceCoffe);

        //}
        //foreach (var item in result)
        //{
        //    Console.WriteLine($@"The price for the coffee is: ${item:f2}");

        //}

        //Console.WriteLine($@"Total: ${total}");
        //-----------------------------------------------------------------------------

        //    long numberOfOrders = long.Parse(Console.ReadLine());
        //    decimal pricePerCapsule = 0m;
        //    DateTime date = new DateTime();
        //    long capsulesCount = 0;
        //    decimal orderPrice = 0;
        //    decimal totalPrice = 0;

        //    for (int i = 0; i < numberOfOrders; i++)
        //    {
        //        pricePerCapsule = decimal.Parse(Console.ReadLine());
        //        date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy",
        //        CultureInfo.InvariantCulture);

        //        capsulesCount = long.Parse(Console.ReadLine());

        //        orderPrice = DateTime.DaysInMonth(date.Year, date.Month) * capsulesCount * pricePerCapsule;

        //        Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
        //        totalPrice += orderPrice;
        //    }
        //    Console.WriteLine($"Total: ${totalPrice:f2}");
        //}
    }
}

