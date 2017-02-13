using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class countNumbers
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse).ToList();

        
        foreach (var item in numbers.Distinct().OrderBy(x => x))
        {
            Console.WriteLine(string.Join(" -> ", item, numbers.Count(x => x == item)));

        }

        //Distinct input {1 2 1 3 } -> return{1 2 3}



        }
    }
    

