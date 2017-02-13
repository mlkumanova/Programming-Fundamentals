using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class phonebookUpgrade
    {
        static void Main()
        {
        var input = Console.ReadLine().Split().ToList();
        var phonebook = new SortedDictionary<string, string>();

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

            if (input[0] == "ListAll")
            {
                foreach (var item in phonebook)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");

                }
            }
            input = Console.ReadLine()
               .Split(' ')
                .ToList();

        }   
        }
    


}
    

