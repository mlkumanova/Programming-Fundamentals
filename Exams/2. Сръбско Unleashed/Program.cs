using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10.Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {//70/100
            
            var listSinger = new Dictionary<string, Dictionary<string,  decimal>>();
            var line = Console.ReadLine();

            while (!line.Equals("End"))
            {
                var data = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var pattern = @"(?<singer>\w.+)@(?<venue>\w.+)\s(?<price>\d+)\s(?<count>\d+)";
                var regex = new Regex(pattern);

                var matches = regex.Matches(line);

                foreach (Match match in matches)
                {
                    if (match.Success)
                    {
                        var singer = match.Groups[1].Value;
                        var venue = match.Groups[2].Value;
                        var price = decimal.Parse(match.Groups[3].Value);
                        var count = decimal.Parse(match.Groups[4].Value);
                        var totalMoney = price * count;

                        if (!listSinger.ContainsKey(venue))
                        {
                            listSinger[venue] = new Dictionary<string, decimal>();
                            
                        }
                        if (!listSinger[venue].ContainsKey(singer))
                        {
                            listSinger[venue][singer] = 0m;
                            
                        }
                        
                            listSinger[venue][singer] += totalMoney;
                    }
                }
                line = Console.ReadLine();                
            }
         
            foreach (var singer in listSinger)
            {
                Console.WriteLine(singer.Key);
                var sorted = singer.Value.OrderByDescending(x => x.Value).ThenBy(x=>x.Key);
                foreach (var song in sorted)
                {
                    Console.WriteLine($@"#  {song.Key}-> {song.Value}");
                }
            }



            }
    }
}
