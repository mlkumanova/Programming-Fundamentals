using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class largestCommonEnd
    {
        static void Main(string[] args)
        {
       string[] first = Console.ReadLine().Split(' ');
       string[] second = Console.ReadLine().Split(' ');
       

        int maxCountLeft = ScanFromLeft(first, second);
        int maxCountRight = ScanFromRight(first, second);
        if (maxCountLeft == 0 && maxCountRight == 0)
        {
            Console.WriteLine(0);
        }
        else if (maxCountLeft > maxCountRight)
        {
            Console.WriteLine(maxCountLeft);
        }
        else
        {
            Console.WriteLine(maxCountRight);
        }

    }

     static int ScanFromRight(string[] first, string[] second)
    {
        int count = 0;
        int maxCount = 0;
        if (first.Length > second.Length)
        {
           
            int longArrayIndex = first.Length - 1;

            for (int i = second.Length - 1 ; i >= 0; i--)
            {
                if (first[longArrayIndex] == second[i])
                {
                    count++;
                }
                else
                {
                    if (maxCount<count)
                    {
                        maxCount = count;
                    }
                    count = 0;
                }
                longArrayIndex--;

            }
        }

        else
        {
                           
                int longArrayIndex = second.Length - 1;

            for (int i = first.Length - 1; i >= 0; i--)
            {
                if (second[longArrayIndex] == first[i])
                {
                    count++;
                }
                else
                {
                    if (maxCount < count)
                    {
                        maxCount = count;
                    }
                    count = 0;
                }
                longArrayIndex--;

            }
        }
        if (maxCount < count)
        {
            maxCount = count;
        }
        return maxCount;


    }

    static int ScanFromLeft(string[] first, string[] second)
    {
        var minLength = Math.Min(first.Length, second.Length);

        var count = 0;
        var maxCount = 0;

        for (int i = 0; i < minLength; i++)
        {
            if (first[i] == second[i])
            {
                count++;
            }
            else
            {
                if (maxCount < count)
                {
                    maxCount = count;
                }
                count = 0;
            }
            
        }
        if (maxCount < count)
        {
            maxCount = count;
        }
        return maxCount;
    }
    }

