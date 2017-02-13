
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class aMinerTask
{
    static void Main()
    {

        var resources = new Dictionary<string, decimal>();
        var line = Console.ReadLine();
        while (line != "stop")
        {
            var resource = line; ;
            var quantity = decimal.Parse(Console.ReadLine());
            if (!resources.ContainsKey(resource))
            {
                resources[resource] = 0;
            }
            resources[resource] += quantity;
            line = Console.ReadLine();
        }

        foreach (var item in resources)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}

