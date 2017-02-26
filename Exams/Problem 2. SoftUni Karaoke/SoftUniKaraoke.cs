using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUniKaraoke
{
    //class Singer
    //{
    //    public string Name { get; set; }
    //    public List<string> Songs { get; set; }
    //    public List<string> Awards { get; set; }

    //    public Singer()
    //    {
    //        Songs = new List<string>();
    //        Awards = new List<string>();
    //    }
    }

class SoftUniKaraoke
{
    static void Main(string[] args)
    {
        var paricipants = Console.ReadLine()
            .Split(new[] { ','}, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(p => p.Trim()).ToArray();

        var songs = Console.ReadLine()
            .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(p => p.Trim()).ToArray();

        var result = new Dictionary<string, List<string>>();

        string line = Console.ReadLine();

        while (line !="dawn")
        {

           var performance = line
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(p => p.Trim())
                .ToArray();

            var participant = performance[0];
            var song = performance[1];
            var award = performance[2];

            if (paricipants.Contains(participant) && songs.Contains(song))
            {
                if (!result.ContainsKey(participant))
                {
                    result[participant] = new List<string>();
                }

                var awards = result[participant];

                if (!awards.Contains(award))
                {
                        awards.Add(award);                    
                }
            }

            line = Console.ReadLine();
        }

        if (result.Any()) // result.Count == 0 e ekvival na result.Any()
        {
            foreach (var kvp in result.OrderByDescending(p=> p.Value.Count).ThenBy(p=>p.Key))
            {
                var participant = kvp.Key;
                var awards = kvp.Value;
                Console.WriteLine($"{participant}: {awards.Count} awards");

                foreach (var award in awards.OrderBy(a => a))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
        else
        {
            Console.WriteLine("No awards");
        }




















        //        List<Singer> singers = new List<Singer>();
        //        List<string> givenAwards = new List<string>();

        //        string[] inputSingers = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        //        string[] inputSongs = Console.ReadLine().Split(',');
        //        List<string> songs = new List<string>();

        //        foreach (string song in inputSongs)
        //        {
        //            songs.Add(song.Trim());
        //        }

        //        while (true)
        //        {
        //            string input = Console.ReadLine();
        //            if (input.ToLower() == "dawn") break;

        //            string[] inputArgs = input.Split(',');
        //            string currentSinger = inputArgs[0].Trim();
        //            string currentSong = inputArgs[1].Trim();
        //            string currentAward = inputArgs[2].Trim();

        //            if (!inputSingers.Contains(currentSinger)) continue;

        //            if (!songs.Contains(currentSong)) continue;

        //            Singer curr = new Singer();
        //            if (singers.Any(x => x.Name == currentSinger))
        //            {
        //                curr = singers.First(x => x.Name == currentSinger);
        //                if (!curr.Songs.Contains(currentSong))
        //                {
        //                    curr.Songs.Add(currentSong);
        //                }
        //                if (!curr.Awards.Contains(currentAward) && !givenAwards.Contains(currentAward))
        //                {
        //                    curr.Awards.Add(currentAward);
        //                }
        //            }
        //            else
        //            {
        //                curr = new Singer();
        //                curr.Name = currentSinger;
        //                curr.Songs.Add(currentSong);
        //                if (!givenAwards.Contains(currentAward))
        //                {
        //                    curr.Awards.Add(currentAward);
        //                }
        //                singers.Add(curr);
        //            }

        //            givenAwards.Add(currentAward);
        //        }

        //        foreach (Singer singer in singers.OrderByDescending(x => x.Awards.Count).ThenBy(x => x.Name))
        //        {
        //            Console.WriteLine("{0}: {1} awards", singer.Name, singer.Awards.Count);
        //            foreach (string award in singer.Awards.OrderBy(x => x))
        //            {
        //                Console.WriteLine("--{0}", award);
        //            }
        //        }

        //        if (singers.Count == 0)
        //        {
        //            Console.WriteLine("No awards");
        //        }
        //    }
        //}
    }
}