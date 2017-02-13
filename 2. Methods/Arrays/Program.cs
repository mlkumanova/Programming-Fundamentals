using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {

        
       string[] days = { "Mond", "Tues", "Wens", "Thu", "Fri", "Sat", "Sund" };
       
        int n = int.Parse(Console.ReadLine());
       
        if (n < 1 || n > 7)
        {
            Console.WriteLine("Invalid");
        }
        else
        {
            var day = days[n - 1];
            Console.WriteLine(day);
        }
        //----------------------------


        //2 prosto chislo - eratosthenes
        // int n = int.Parse(Console.ReadLine());
        //
        //
        // var prime = new bool[n + 1];
        // for (int i = 2; i <= n; i++)
        // {
        //     prime[i] = true;
        //
        // }
        // for (int num = 2 ; num <= n; num++)
        // {
        //     if (prime[num])
        //     {
        //         Console.WriteLine(num);
        //         var p = 2 * num;
        //         while (p <= n)
        //         {
        //             prime[p] = false;
        //             p = p + num;
        //         }
        //     }
        //----------------------------------

        // 3 last 5 numbers sums
        //int n = int.Parse(Console.ReadLine());
        // int k = int.Parse(Console.ReadLine());
        //
        //
        // var arr = new long[n];
        // arr[0] = 1; //Tova 1 poziciqta li e ili stoinostta???????
        // for (int i = 1; i < n; i++)
        // {
        //     //TODO nums[i] = sumata ot predh k chisla
        //     long sum = 0;
        //     for (int prev = i-k; prev <= i-1; prev++)
        //     {
        //         if (prev>=0)
        //         {
        //             sum += arr[prev];
        //         }
        //         arr[i] = sum;
        //     }
        //    
        //     
        // }
        //
        // for (int i = 0; i < n; i++)
        // {
        //     Console.Write(arr[i] + " ");
        // }

        //-------------------------------
        // 4. Min max first last average sum 
        //int n = int.Parse(Console.ReadLine());
        //var nums = new int[n];

        //for (int i = 0; i < n; i++)
        //{
        //    nums[i] = int.Parse(Console.ReadLine());

        //}

        //      var sum = nums[0];
        //      var min = nums[0];
        //      var max = nums[0];
        //      var first = nums[0];
        //      var last = nums[nums.Length - 1];
        //      for (int i = 1; i < n; i++)
        //      {
        //          sum += nums[i];
        //          if (nums[i] > max)
        //          {
        //              max = nums[i];
        //          }
        //          if (nums[i] < min)
        //          {
        //              min = nums[i];
        //          }
        //      }
        //      var average = (double)sum / n;
        //      Console.WriteLine(sum);
        //      Console.WriteLine(min);
        //      Console.WriteLine(max);
        //      Console.WriteLine(min);
        //      Console.WriteLine(last);
        //      Console.WriteLine(average);
        //
        //
        ////     var nums = Console.ReadLine().Split//(/' /').Select(int.Parse).ToArray();
        ////
        ////     Console.WriteLine(nums.Sum());
        ////     Console.WriteLine(nums.Min());
        ////     Console.WriteLine(nums.Max());
        ////     Console.WriteLine(nums.First());
        ////     Console.WriteLine(nums.Last());
        ////     Console.WriteLine(nums.Average());

        //---------------------------------------------------

        //   var nums = Console.ReadLine().Split(' ').Select//(int.Parse).ToArray();
        //
        //   for (int left = 0; left < nums.Length; left++)
        //       for (int right = left+1; right < nums.Length; right+/+)
        //       {
        //           var sum = nums[left] + nums[right];
        //           Contains(nums, left, right, sum);
        //           // if (nums.Contains(sum) )
        //           // {
        //           //     Console.WriteLine("{0} + {1} = {2} ", //nums//[left], nums[right], sum);
        //           // }
        //


        //----------------------------------------

        //var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    //  int rounded;
        //    //  if (nums[i] < 0)
        //    //  {
        //    //      rounded = (int)(nums[i] - 0.5);
        //    //
        //    //  }
        //    //  else
        //    //  {
        //    //      rounded = (int)(nums[i] + 0.5);
        //    //
        //    //  }

        //    int rounded = (nums[i] < 0) ? (int)(nums[i] - 0.5) : (int)(nums[i] + 0.5);

        //    Console.WriteLine("{0} => {1}", nums[i], rounded);
        //}   

        
    }

    private static void Contains(int[] nums, int left, int right, int sum)
    {
        bool exist = false;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == sum)
            {
                exist = true;
                break;
            }
            if (exist)
            {

                Console.WriteLine("{0} + {1} = {2} ", nums[left], nums[right], sum);
            }
        }
    }
}

