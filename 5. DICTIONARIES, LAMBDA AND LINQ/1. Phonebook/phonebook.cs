using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Program
    {
        public static void Main()
        {
        /*Write a program that receives some info from the console about people and their phone numbers. Each entry should have just one name and one number (both of them strings). */
        /*INPUT: 
            A Nakov 0888080808
            S Mariika
            S Nakov

            OUTPUT:
            END	Contact Mariika does not exist.
            Nakov -> 0888080808
        */

        var input = Console.ReadLine().Split().ToList();
            var phonebook = new Dictionary<string, string>();

            while (input[0] != "END")
            {
            if (input[0] == "A")
            {
                phonebook[input[1]] = input[2];
                if (phonebook[input[1]].Equals(input[1]))
                {
                    phonebook[input[1]] = (input[1]);
                }
            }

                if (input[0] == "S")
                {
                    if (phonebook.ContainsKey(input[1]))
                    {
                    Console.WriteLine($"{input[1]} -> {phonebook[input[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }
                input = Console.ReadLine()
                   .Split(' ')
                    .ToList();
            }        
        }
    }
