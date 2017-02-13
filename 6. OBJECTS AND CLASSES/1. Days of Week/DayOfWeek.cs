using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class DayOfWeek

    {
        static void Main()
        {
        var dateAsString = Console.ReadLine();

        var date = DateTime.ParseExact(dateAsString, "dd-MM-yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine(date.DayOfWeek);


        }
    }

