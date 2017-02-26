using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


    class Program
    {
    static void Main()
    {
        var names = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x=>x).ToList();
        double health = 0;
        decimal damage = 0;

        foreach (var name in names)
        {         

            for (int i = 0; i < name.Length; i++)
            {


                 if (char.IsDigit(name[i]))
                 {
                    
                     damage += Math.Abs(name[i] - '0');
                  
                 }

                if (char.IsLetter(name[i]))
                {
                    health += name[i];
                }
                if (name[i] == '*')
                {
                    damage = damage * 2;
                }
                if (name[i] == '/')
                {
                    damage = damage / 2;
                }

            }
            
            Console.WriteLine($@"{name} - {health} health, {damage:f2} damage");
            health = 0;
            damage = 0;



            //string input = Console.ReadLine();
            //string[] args = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            //char[] skipLetters = "0123456789+-*/.".ToCharArray();
            //List<string> result = new List<string>();

            //foreach (var dragonName in args)
            //{
            //    long lettersSum = 0;

            //    foreach (var letter in dragonName)
            //    {
            //        if (!skipLetters.Contains(letter))
            //        {
            //            lettersSum += (long)letter;
            //        }
            //    }

            //    string numbersPattern = @"(-?\d*\.?\d+)";
            //    var numbersMatches = Regex.Matches(dragonName, numbersPattern);

            //    decimal numbersSum = 0;
            //    foreach (Match numberMatch in numbersMatches)
            //    {
            //        numbersSum += decimal.Parse(numberMatch.Groups[1].Value);
            //    }

            //    foreach (var letter in dragonName)
            //    {
            //        if (letter == '*')
            //        {
            //            numbersSum *= 2;
            //        }
            //        if (letter == '/')
            //        {
            //            numbersSum /= 2;
            //        }
            //    }

            //    result.Add($"{dragonName} - {lettersSum} health, {numbersSum:f2} damage");
            //}

            //var sortedResult = result.OrderBy(x => x);

            //foreach (var dragonInfo in sortedResult)
            //{
            //    Console.WriteLine(dragonInfo);
            //}
        }

    }
    }

        
    

