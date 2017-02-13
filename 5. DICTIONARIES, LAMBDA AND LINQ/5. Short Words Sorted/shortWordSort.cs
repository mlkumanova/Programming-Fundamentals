using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Short_Words_Sorted
{
    class shortWordSort
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split(new char[] { ' ' , '.' , ',', ':', ';' , '(', ')', '[' , ']', '\"' , '\'', '\\', '/', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length < 5)
                .Distinct()
                .OrderBy(x=>x)
                .ToList();

            Console.WriteLine(string.Join(", ", words));

      

        }
    }
}
