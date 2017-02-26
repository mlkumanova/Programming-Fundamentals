using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Numerics;

class SinoTheWalker
    {
        static void Main()
        {
        //   var leaveTime = Console.ReadLine();
        //   var parse = DateTime.ParseExact(leaveTime, "HH:mm:ss", CultureInfo.InvariantCulture);
        //   var numberOfSteps = int.Parse(Console.ReadLine())% 86400;
        //   var timeInSeconds = int.Parse(Console.ReadLine())% 86400;
        //
        //   var totalSeconds = numberOfSteps * timeInSeconds;
        //
        //   var time = parse.AddSeconds(totalSeconds);
        //   var result = time.TimeOfDay;
        //   Console.WriteLine($@"Time Arrival: {result}");


        var startingTIme = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);

        //var numOfSteps = int.Parse(Console.ReadLine());
        //var secondsPerStep = int.Parse(Console.ReadLine());

        //long initialSec = startingTIme.Hour * 60 * 60
        //    + startingTIme.Minute*60 
        //    + startingTIme.Second;

        //ulong sec = (ulong)numOfSteps * (ulong)secondsPerStep;
        //var totalSec = (ulong)initialSec + sec;
        //var seconds = totalSec % 60;
        //var totalMinutes = totalSec / 60;
        //var minutes = totalMinutes % 60;
        //var totalHours = totalMinutes / 60;
        //var hours = totalHours % 24;

        //Console.WriteLine($"Time Arrival: {hours:00}:{minutes:00}:{seconds:00}");

        var numOfSteps = int.Parse(Console.ReadLine());
        var secondsPerStep = int.Parse(Console.ReadLine());

        long initialSec = startingTIme.Hour * 60 * 60
            + startingTIme.Minute * 60
            + startingTIme.Second;

        ulong sec = (ulong)numOfSteps * (ulong)secondsPerStep;
        var secondsToAddPerDay = sec % (24 * 60 * 60);
        var finalDate = startingTIme.AddSeconds(secondsToAddPerDay);
        Console.WriteLine($"Time Arrival: {finalDate.ToString("HH:mm:ss")}");


    }
    }

