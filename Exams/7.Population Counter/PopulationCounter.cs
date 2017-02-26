using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PopulationCounter
{
    static void Main(string[] args)
    {

        var input = Console.ReadLine().Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        var dict = new SortedDictionary<string, SortedDictionary<string, long>>();

        while (input[0] != "report")
        {
            var country = input[1];
            var city = input[0];
            var population = long.Parse(input[2]);

            if (!dict.ContainsKey(country))
            {
                dict[country] = new SortedDictionary<string, long>();
            }

            if (!dict[country].ContainsKey(city))
            {
                dict[country][city] = 0;
            }

            dict[country][city] += population;


            input = Console.ReadLine().Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        foreach (var country in dict.OrderByDescending(x => x.Value.Sum(y => y.Value)))
        {
            List<long> sumOfTowns = country.Value.Select(x => x.Value).ToList();
            Console.WriteLine($"{country.Key} (total population: {sumOfTowns.Sum()})");

            Console.Write($"=>{string.Join("=>", country.Value.OrderByDescending(x => x.Value).Select(x => $"{x.Key}: {x.Value}\r\n"))}");



        }
    
        








    }
    }
