using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
            var word = Console.ReadLine().Split(' ');

            var random = new Random();
            
            for (int i = 0; i < word.Length; i++)
            {
                var currWord = word[i];
                var randomInd = random.Next(0, word.Length);

                var tempWord = word[randomInd];
                word[i] = tempWord;
                word[randomInd] = currWord;
            }
            foreach (var item in word)
            {
                Console.WriteLine(item);
            }
        }
    }

