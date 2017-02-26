using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


    class blqks2
    {
        static void Main()
        {

        //80/100
            var names = Console.ReadLine().Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x);
            var health = 0m;
            var damage = 0m;
           

            foreach (var name in names)
            {
                var pattern = @"[+-]?\d+(?:\.?\d+)?";
                var regex = new Regex(pattern);
                var matches = regex.Matches(name);

                for (int i = 0; i < name.Length; i++)
                { 
                    if (char.IsLetter(name[i]))
                    {
                        health += name[i];
                    }

                }
                foreach (Match match in matches)
                {
                    damage += decimal.Parse(match.Value);

                }

                var modifiers = name.Where(a => a == '*' || a == '/');
                foreach (var modifier in modifiers)
                {
                    switch (modifier)
                    {
                        case '*': damage *= 2; break;
                        case '/': damage /= 2; break;
                    }

                }
                Console.WriteLine($@"{name} - {health} health, {damage:f2} damage");
                health = 0m;
                damage = 0m;

            }   
        }
    }

