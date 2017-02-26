using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class CharityMarathon
    {
        static void Main()
        {
        var days = int.Parse(Console.ReadLine());
        var participants = int.Parse(Console.ReadLine());
        var laps = decimal.Parse(Console.ReadLine());
        var length = decimal.Parse(Console.ReadLine());
        var capacity = decimal.Parse(Console.ReadLine());
        var money = decimal.Parse(Console.ReadLine());

        var maxRun = capacity * days;
        /* var totalRunners = Math.Min(participant, capacyty * days);
         * var totalKm = (final * laps * length) / 1000;
            var raised = totalKm * money;
            Console.WriteLine($@"Money raised: {raised:f2}");
         */
        var final = 0.0m;
        if (maxRun >= participants)
        {
            final = participants;
            var totalKm = (final * laps * length) / 1000;
            var raised = totalKm * money;
            Console.WriteLine($@"Money raised: {raised:f2}");
        }
        else
        {
            final = maxRun;
            var totalKm = (final * laps * length) / 1000;
            var raised = totalKm * money;
            Console.WriteLine($@"Money raised: {raised:f2}");

        }
             
        }

        }
    

