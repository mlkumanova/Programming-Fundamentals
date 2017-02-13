using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class bombNumbers
{
    static void Main(string[] args)
    {
        //Write a program that reads sequence of numbers and special bomb number with a certain power. Your task is to detonate every occurrence of the special bomb number and according to its power his neighbors from left and right.Detonations are performed from left to right and all detonated numbers disappear. Finally print the sum of the remaining elements in the sequence.
        /* 1 2 2 4 2 2 2 9  1 4 4 2 8 9 1
           4 2              9 3
           ---              ---
           12               5*/
        /*Special number is 4 with power 2. After detontaion we left with the sequence [1, 2, 9] with sum 12.*/
        /*Special number is 9 with power 3. After detontaion we left with the sequence [1, 4] with sum 5. Since the 9 has only 1 neighbour from the right we remove just it (one number instead of 3).*/

     
        List<int> seqOfNum = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> specialNum = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int specialNumber = specialNum[0];
        int detronPower = specialNum[1];

        for (int i = 0; i < seqOfNum.Count; i++)
        {
            if (seqOfNum[i] == specialNumber)
            {
                int leftExplosion = i - detronPower;
                int rightExplosion = i + detronPower;

                if (leftExplosion < 0)
                {
                    leftExplosion = 0;
                }
                if (rightExplosion > seqOfNum.Count - 1)
                {
                    rightExplosion = seqOfNum.Count - 1;
                }
                int detronationLength = rightExplosion - leftExplosion + 1;
                seqOfNum.RemoveRange(leftExplosion, detronationLength);
                i = 0;
            }
           
        }
        Console.WriteLine(seqOfNum.Sum());




     
    }
}


