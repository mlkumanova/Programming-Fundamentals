using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

    class FootballStandings
    {
        static void Main()
        {
        var key = Console.ReadLine();
        key = Regex.Escape(key);

        var regex = new Regex($@"{key}(.*?){key}.*?{key}(.+?){key}.+?(\d+):(\d+)");

        var score = new Dictionary<string, long>();
        var goals = new Dictionary<string, long>();


        while (true)
        {
            var line = Console.ReadLine();

            if (line == "final")
            {
                break;
            }
            var match = regex.Match(line);

            var firstTeamReverse = match.Groups[1].Value.Reverse().ToArray();
            var secondTeamReverse = match.Groups[2].Value.Reverse().ToArray();

            var firstTeam = new string(firstTeamReverse).ToUpper();
            var secondTeam = new string(secondTeamReverse).ToUpper();
            var firstTeamGoals = int.Parse(match.Groups[3].Value);
            var secondTeamGoals = int.Parse(match.Groups[4].Value);

            if (!score.ContainsKey(firstTeam))
            {
                score[firstTeam] = 0;
            }
            if (!score.ContainsKey(secondTeam))
            {
                score[secondTeam] = 0;
            }
            if (!goals.ContainsKey(firstTeam))
            {
                goals[firstTeam] = 0;
            }
            if (!goals.ContainsKey(secondTeam))
            {
                goals[secondTeam] = 0;
            }

            goals[firstTeam] += firstTeamGoals;
            goals[secondTeam] += secondTeamGoals;

            if (firstTeamGoals > secondTeamGoals)
            {
                score[firstTeam] += 3;
            }
            else if (firstTeamGoals < secondTeamGoals)
            {
                score[secondTeam] += 3;
            }
            else
            {
                score[firstTeam]++;
                score[secondTeam]++;
            }
        }

        Console.WriteLine($@"League standings:");

        int place = 1;
        foreach (var kvp in score.OrderByDescending(kvp =>kvp.Value).ThenBy(kvp => kvp.Key))
        {
            Console.WriteLine($@"{place}. {kvp.Key} {kvp.Value}");
            place++;
        }
        Console.WriteLine($@"Top 3 scored goals:");
        foreach (var kvp in goals.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key).Take(3))
        {
            Console.WriteLine($"- {kvp.Key} -> {kvp.Value}");

        }


        }
    }

