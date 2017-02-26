using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EnduranceRally
{
    static void Main(string[] args)
   {

        var drivers = Console.ReadLine().Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries);

        var track = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

        var checkpoints = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        foreach (var driver in drivers)
        {
            double fuel = driver.First(); // encoding

            for (int i = 0; i < track.Length; i++)
            {
                var currentZoneFuel = track[i];

                if (checkpoints.Contains(i))
                {
                    fuel += currentZoneFuel;
                }
                else
                {
                    fuel -= currentZoneFuel;
                }
                if (fuel <= 0)
                {
                    Console.WriteLine($"{driver} - reached {i}");
                    break;
                }

            }
            if (fuel > 0)
            {
                Console.WriteLine($"{driver} - fuel left {fuel:f2}");
            }

        }







   //    var names = Console.ReadLine().Split().ToList();
   //    var trackLayout = Console.ReadLine().Split().Select(double.Parse).ToList();
   //    var chekpoints = Console.ReadLine().Split().Select(double.Parse).ToList();
   //
   //
   //    var startFuel = 0.0;
   //
   //    foreach (var name in names)
   //    {
   //    var counter = 0;
   //
   //        var encoding = Encoding.ASCII.GetBytes(name);
   //
   //        startFuel = encoding[0];
   //
   //        for (var i = 0; i < trackLayout.Count; i++)
   //        {
   //            bool isEqual = false;
   //
   //            for (var j = 0; j < chekpoints.Count; j++)
   //            {
   //                if (i == chekpoints[j])
   //                {
   //                    isEqual = true;
   //                    break;
   //
   //                }
   //            }
   //
   //            if (isEqual)
   //            {
   //                startFuel = startFuel + trackLayout[i];
   //            }
   //            else
   //            {
   //                startFuel = startFuel - trackLayout[i];
   //
   //            }
   //            if (startFuel > 0)
   //            {
   //                counter++;
   //            }
   //            
   //        
   //            else
   //            {
   //                Console.WriteLine($@"{name} - reached {counter}");
   //
   //                break;
   //            }
   //        }
   //        if (startFuel > 0)
   //        {
   //
   //            Console.WriteLine($@"{name} - fuel left {startFuel:f2}");
   //        }
   //    }
   //    
   
            
    }
}
    

