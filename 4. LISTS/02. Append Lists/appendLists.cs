using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class appendLists
    {
        static void Main(string[] args)
        {

        

      List<string> input = Console.ReadLine().Split(new char[] {'|' } , StringSplitOptions.RemoveEmptyEntries).ToList();
        List<string> result = new List<string>();

        for (int i = input.Count - 1; i >= 0; i--)
        {
            input[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            result.Add(input[i]);
            
        }
        Console.WriteLine(string.Join(" ", result),StringSplitOptions.RemoveEmptyEntries);

    }
}

