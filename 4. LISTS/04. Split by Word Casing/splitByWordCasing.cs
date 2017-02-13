using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class splitByWordCasing
{
    static void Main(string[] args)
    {
        char[] characters = { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' };
        List<string> text = Console.ReadLine().Split(characters, StringSplitOptions.RemoveEmptyEntries).ToList();
       
        List<string> lowerCase = new List<string>();
        List<string> upperCase = new List<string>();
        List<string> mixedCase = new List<string>();

        foreach (var word in text)
        {
            var countLower = false;
            var countUpper = false;
            var countMixed = false;
            foreach (var letter in word)
            {
                if (char.IsLower(letter))
                {
                    countLower = true;
                }
                else if (char.IsUpper(letter))
                {
                    countUpper = true;
                }
                else if (!char.IsLetter(letter))
                {
                    countMixed = true;
                }

             
                }

            if (countMixed)
            {
                mixedCase.Add(word);
            }
            else if (!countUpper)
            {
                lowerCase.Add(word);
            }

            else if (!countLower)
            {
                upperCase.Add(word);
            }
            else
            {
                mixedCase.Add(word);
            }
        }

            Console.WriteLine($@"Lower-case: {string.Join(", ",lowerCase)}");
        Console.WriteLine($@"Mixed-case: {string.Join(", ", mixedCase)}");
        Console.WriteLine($@"Upper-case: {string.Join(", ", upperCase)}");
            
        }




    }

    



