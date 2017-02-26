using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class RageQuit
{
    static void Main()
    {
        var pattern = @"(\D+)(\d+)";

        var regex = new Regex(pattern);

        var input = Console.ReadLine().ToUpper();

        var matches = regex.Matches(input);

        StringBuilder outputResult = new StringBuilder();

        foreach (Match match in matches)
        {

            var message = match.Groups[1].Value;
            int repeat = int.Parse(match.Groups[2].Value);


            for (int i = 0; i < repeat; i++)
            {
                outputResult.Append(message);
            }


        }
        Console.WriteLine($@"Unique symbols used: {outputResult.ToString().Distinct().Count()}");
        Console.WriteLine(outputResult);

    }
} 


    
    

