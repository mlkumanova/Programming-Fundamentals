using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
        var emails = new Dictionary<string, string>();
        var line = Console.ReadLine();
        while (line != "stop")
        {
            var us = ".us";
            var uk = ".uk";
            var name = line;
            var email = Console.ReadLine();

            bool contains = email.Contains(us);
            bool contains2 = email.Contains(uk);

            if (!emails.ContainsKey(name))
            {
                if (contains != true && contains2 != true)
                {
                    emails[name] = email;
                }
            }
            line = Console.ReadLine();
        }
        foreach (var item in emails)
        {

            Console.WriteLine($"{item.Key} -> {item.Value}");
        }

        //---or
    //  var fixedEmails = emails.Where(a => !a.Value.ToLower().EndsWith("us") && !a.Value.ToLower().EndsWith("uk")).ToDictionary(p => p.Key, p => p.Value);
    //  foreach (var item in fixedEmails)
    //  {
    //      Console.WriteLine($@"{item.Key} -> {item.Value}");
     //   }
        

        }
    }

