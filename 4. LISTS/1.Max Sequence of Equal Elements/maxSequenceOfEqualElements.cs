using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class maxSequenceOfEqualElements
{
    static void Main(string[] args)
    {
        List<int> seq = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        List<int> longestSubSeq = new List<int>();
        List<int> currentSubSeq = new List<int>();

        currentSubSeq.Add(seq[0]);

        for (int i = 1; i < seq.Count; i++)
        {
            if (seq[i] == currentSubSeq[0])
            {
                currentSubSeq.Add(seq[i]);
            }
            else
            {
                if (currentSubSeq.Count > longestSubSeq.Count)
                {
                    longestSubSeq = new List<int>();

                    for (int j = 0; j < currentSubSeq.Count; j++)
                    {
                        longestSubSeq.Add(currentSubSeq[j]);
                    }
                }
                currentSubSeq = new List<int>();
                currentSubSeq.Add(seq[i]);
            }
        }
        if (currentSubSeq.Count > longestSubSeq.Count)
        {
            longestSubSeq = new List<int>();
            for (int j = 0; j < currentSubSeq.Count; j++)
            {
                longestSubSeq.Add(currentSubSeq[j]);
            }

        }
        Console.WriteLine(string.Join(" ", longestSubSeq));

        /*
      3 4 4 5 5 5 2 2 
      7 7 4 4 5 5 3 3
      1 2 3 3
      */

     //  var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
     //  int startIndex = 0;
     //  int endIndex = 0;
     //  int len = 0;
     //  int bestLen = 0;
     //  for (int i = 0; i < numbers.Length - 1; i++)
     //  {
     //      for (int j = i + 1; j < numbers.Length; j++)
     //      {
     //          int x = numbers[i];
     //          int y = numbers[j];
     //          if (numbers[i] == numbers[j] && len >= bestLen)
     //          {
     //              startIndex = i;
     //              endIndex = j;
     //              len++;
     //          }
     //          else if (numbers[i] == numbers[j])
     //          {
     //              len++;
     //          }
     //
     //      }
     //      if (len > bestLen)
     //      {
     //          bestLen = len;
     //      }
     //      len = 0;
     //  }
     //  var list = new List<int>();
     //  for (int i = startIndex; i <= endIndex; i++)
     //  {
     //      list.Add(numbers[i]);
     //  }
     //  Console.WriteLine($"Start Index:{startIndex} EndIndex:{endIndex}");
     //  Console.WriteLine(string.Join(" ", list));
    }


}

            
        

   
    


