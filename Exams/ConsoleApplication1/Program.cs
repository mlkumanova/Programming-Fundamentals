using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  class Program
    {
        static void Main()
        {
            var coounter = 0;
            while (true)
            {
                yield break;
                coounter++;
            }
            Console.WriteLine(coounter);
            Console.WriteLine(coounter);
            Console.WriteLine(coounter);
            Console.WriteLine(coounter);
        }
    }

