using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class maxSequenceOfEqualELements
{
    static void Main(string[] args)
    {

        //60/100
        var arrInt = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


         int bestStart = 0;
         int bestLength = 1;                   
        int currStart = 1;
         int currLength = 0;
        
        
            for (int j = 1; j < arrInt.Length ; j++)
            {
                if (arrInt[j] == arrInt[currStart])
                {
                    currLength++;
                 if (currLength > bestLength)
                 {
                     bestLength = currLength;
                     bestStart = currStart;
                 }
        
                }
                else
                {
                 currLength = 1;
                 currStart = j;
                }
            }
         for (int i = bestStart; i < bestStart + bestLength; i++)
         {
             Console.Write($@"{arrInt[i]} ");
         }
         Console.WriteLine();
       }

    
}
    

