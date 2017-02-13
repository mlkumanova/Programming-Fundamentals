using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class indexOfLetters
    {
        static void Main(string[] args)
        {

        var letters = Console.ReadLine().ToLower().ToCharArray();
        for (int i = 0; i < letters.Length; i++)
        {
            int counter = letters[i] - 97;
            
                Console.WriteLine($@"{letters[i]} -> {counter}");
            

        }





    }
    }

