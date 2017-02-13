
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{

    static void Main()
    {
        var cardPowers = GetCardPower();
        var cardTypes = GetCardTypes();

        var cards = new Dictionary<string, HashSet<int>>();
        var line = Console.ReadLine();
       

        while (line != "JOKER")
        {
            var tokens = line.Split(':');

            var name = tokens[0];

            var playerCards = tokens[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in playerCards)
            {
                var cardPower = item.Substring(0, item.Length-1);
                var cardType = item.Substring(item.Length-1);

                var sum = cardPowers[cardPower] * cardTypes[cardType];

                if (!cards.ContainsKey(name))
                {
                    cards[name] = new HashSet<int>();
                }
                cards[name].Add(sum);
            }
            line = Console.ReadLine();
        }
        foreach (var item in cards)
        {
            Console.WriteLine($"{item.Key}: {item.Value.Sum()}");
        }
        
        
    }

    private static Dictionary<string, int> GetCardPower()
    {
        var powers = new Dictionary<string, int>();

        for (int i = 2; i <= 10; i++)
        {
            powers[i.ToString()] = i;
        }
        powers["J"] = 11;
        powers["Q"] = 12;
        powers["K"] = 13;
        powers["A"] = 14;
        return powers;
    }


    private static Dictionary<string, int> GetCardTypes()
    {
        var types = new Dictionary<string, int>();
        types["S"] = 4;
        types["H"] = 3;
        types["D"] = 2;
        types["C"] = 1;
        return types;
    }
}