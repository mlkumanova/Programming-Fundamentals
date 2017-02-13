using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
    static void Main(string[] args)
    {
        //   int n = int.Parse(Console.ReadLine());
        //
        //   int[] arr = new int[n];
        //   for (int i = 0; i < n; i++)
        //   {
        //       arr[i] = int.Parse(Console.ReadLine());
        //   }
        //   foreach (var item in arr)
        //   {
        //       
        //       Console.WriteLine(item*5);
        //   }
        //--------------------------------

        //  int n = int.Parse(Console.ReadLine());
        //  int[] arr1 = new int[n];
        //  int[] arr2 = new int[n];
        //  FillArr(arr1);
        //  FillArr(arr2);
        //  bool result = CompareringArr(arr1, arr2);
        //  Console.WriteLine(result);
        //----------------------------------------

        //      char[] arr1 = Console.ReadLine().ToCharArray();
        //      char[] arr2 = Console.ReadLine().ToCharArray();
        //
        //      ComLett(arr1,arr2);
        //     
        //      }

        // 100 80 5 6 7 8 9 1 10 20 30 40 50 60

        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        //Pulnene na masiv s chisla |
        //                          ^

        for (int i = 0; i < arr.Length; i++)
        {

            //arr[i] = int.Parse(Console.ReadLine());
        }
        int counter = 0;
            int bestCounter = 0;

        for (int i = 0; i < arr.Length-1; i++)
        {
            if (arr[i] < arr[i + 1])
            {
                counter++;
            }
            else
            {
                counter = 0;
            }
            if(bestCounter < counter)
            {
                bestCounter = counter;
            }
        }
        Console.WriteLine(bestCounter);



        

    }





    private static void ComLett(char[] arr1, char[] arr2)
    {
        for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
        {
            if (arr1[i] > arr2[i])
            {
                Console.WriteLine($@"{arr1[i]} > {arr2[i]}");
            }
            else if (arr1[i] < arr2[i])
            {
                Console.WriteLine($@"{arr1[i]} < {arr2[i]}");
            }
            else
            {
                Console.WriteLine($@"{arr1[i]} = {arr2[i]}");

            }
        }





    }

    private static bool CompareringArr(int[] arr1, int[] arr2)
    {
        if (arr1.Length == arr2.Length)
        {
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
        }
        return true;
        
    }

    private static void FillArr(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
    }
}

