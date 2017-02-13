using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class daysOfWeek
    {
        static void Main(string[] args)
        {
          
         string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
         int day = int.Parse(Console.ReadLine());
         if (day <=7 && day >= 1)
         {
             Console.WriteLine(days[day-1]);
         }
         else
         {
             Console.WriteLine("Invalid day!");
         }
        }
    }

