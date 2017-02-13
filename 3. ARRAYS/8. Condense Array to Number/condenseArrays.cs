using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {

          var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
      
        while (input.Length > 1)
        {
            var condensed = new int[input.Length-1];
    
            for (int i = 0; i < condensed.Length; i++)
            {
      
                condensed[i] = input[i] + input[i + 1];
    
           }
            input = condensed;


        }
            Console.WriteLine(string.Join(" ", input));




    }
}

