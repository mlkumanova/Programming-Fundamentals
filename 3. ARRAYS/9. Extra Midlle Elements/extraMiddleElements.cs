using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  class extraMiddleElements
    {
        static void Main(string[] args)
        {
        var n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        if (n.Length == 1)
        {
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine( "{" + $@" {n[i]} " + "}");

            }
        }
        else
        {
            if (n.Length % 2 == 0)
            {
                int midd = 0;
                int midd2 = 0;

                for (int i = 0; i < n.Length; i++)
                {
                    midd = n[n.Length / 2];
                    midd2 = n[n.Length / 2 - 1];


                }
                Console.WriteLine("{" + string.Join(", ", midd2, midd) + "}");



            }
            else if (n.Length % 2 == 1)
            {
                int midd = 0;
                int midd2 = 0;
                int midd3 = 0;
                for (int i = 0; i < n.Length; i++)
                {
                    midd = n[n.Length / 2 - 1];
                    midd2 = n[n.Length / 2];
                    midd3 = n[n.Length / 2 + 1];

                }

                Console.WriteLine("{" + string.Join(", ", midd, midd2, midd3) + "}");


            }
        }
        }
    }

