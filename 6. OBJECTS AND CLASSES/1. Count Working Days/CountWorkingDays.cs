using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


    class CountWorkingDays
    {
        static void Main()
        {
        var startDate = Console.ReadLine();
        var endDate = Console.ReadLine();

        var dateStart = DateTime.ParseExact(startDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);

        var dateEnd = DateTime.ParseExact(endDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);

        List<DateTime> holidays = new List<DateTime>()
        {
            DateTime.ParseExact("01-01-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),  
            DateTime.ParseExact("03-03-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),  
            DateTime.ParseExact("01-05-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),  
            DateTime.ParseExact("24-05-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),  
            DateTime.ParseExact("06-09-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),  
            DateTime.ParseExact("22-09-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),  
            DateTime.ParseExact("01-11-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),  
            DateTime.ParseExact("24-12-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),  
            DateTime.ParseExact("25-12-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),  
            DateTime.ParseExact("06-05-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),  
            DateTime.ParseExact("26-12-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture)
        };

        var workingDays = 0;
        

        for (DateTime currDate = dateStart; currDate <= dateEnd; currDate = currDate.AddDays(1))
        {
            DateTime checkDate = new DateTime(2016, currDate.Month, currDate.Day);

            if (currDate.DayOfWeek != DayOfWeek.Saturday && currDate.DayOfWeek != DayOfWeek.Sunday && !holidays.Contains(checkDate))
            {
                workingDays++;
            }

        }
        Console.WriteLine(workingDays);
    }
    }

