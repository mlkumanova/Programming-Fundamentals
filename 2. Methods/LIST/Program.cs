using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIST
{
    class Program
    {
        static void Main(string[] args)
        {
            //    List<int> numbers = //Console.ReadLine().Split/(' /').Select(int.Parse).ToList();
            //    List<int> positiveNumbers = new //List<int>();
            //    foreach (var number in numbers)
            //    {
            //        if (number >= 0)
            //        {
            //            positiveNumbers.Add//(number);
            //
            //        }
            //
            //    }
            //    positiveNumbers.Reverse();
            //    Console.WriteLine(string.Join/(", /", positiveNumbers));
            //

            //--------------------------


            //       string[] lists = Console.ReadLine().Split('|');
            //       List<string> result = new List<string>();
            //       for (int i = lists.Length - 1; i >= 0; i--)
            //       {
            //           var list = lists[i].Split('/');
            //           foreach (var item in list)
            //           {
            //               if (item != string.Empty)
            //               {
            //                   result.Add(item);
            //
            //               }
            //           }
            //       }
            //       Console.WriteLine(string.Join(" ", result));

            //------------------------------

            //List<double> list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            //List<double> result = new List<double>();
            //bool areAllDifferent = false;
            //while (!areAllDifferent)
            //{
            //    areAllDifferent = true;
            //    for (int i = 0; i < list.Count; i++)
            //    {
            //        if (i < list.Count-1 && list[i] == list[i+1] )
            //        {
            //            result.Add(list[i] * 2);
            //            i++;
            //            areAllDifferent = false;
            //        }
            //        else
            //        {
            //            result.Add(list[i]);
            //        }
            //    }
            //    list = result;
            //    result = new List<double>();
            //}

            //Console.WriteLine(string.Join(", ",list));

            //--ili---

            //        List<double> list = Console.ReadLine/().Split/(' ').Select(double.Parse).ToList();
            //        bool areAllDifferent = false;
            //        while (!areAllDifferent)
            //        {
            //            areAllDifferent = true;
            //            for (int i = 0; i < list.Count; i++)
            //            {
            //                if (i < list.Count - 1 && list[i] /==/ list[i + 1])
            //                {
            //                    list[i + 1] *= 2;
            //                    list.RemoveAt(i);
            //                    areAllDifferent = false;
            //                }
            //                
            //            }
            //         }
            //
            //        Console.WriteLine(string.Join(", ", list));


            //-------------------------------------

            //        List<string> words = Console.ReadLine().Split(new char[] {',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\',/ '[', /']', ' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            //        List<string> upper = new List<string>();
            //        List<string> lower = new List<string>();
            //List <string> mixed = new List<string>();
            //
            //        foreach (var word in words)
            //        {
            //            bool isUpperCase = true;
            //            bool isLowerCase = true;
            //            for (int i = 0; i < word.Length; i++)
            //            {
            //                if (char.IsUpper(word[i]))
            //                {
            //                    isLowerCase = false; 
            //                }
            //                else if (char.IsLower(word[i]))
            //                {
            //                    isUpperCase = false;
            //
            //                }
            //                else
            //                {
            //                    isLowerCase = false;
            //                    isUpperCase = false;
            //                }
            //            }
            //            if (isLowerCase)
            //            {
            //                lower.Add(word);
            //            }
            //            else if (isUpperCase)
            //            {
            //                upper.Add(word);
            //            }
            //            else
            //            {
            //                mixed.Add(word);
            //            }
            //        }
            //
            //        Console.WriteLine("Lower: {0}",string.Join(", ", lower));
            //        Console.WriteLine("Upper: {0}", string.Join(", ", upper));
            //        Console.WriteLine("Mixed: {0}", string.Join(", ", mixed));


            //--------------------------------
            //sortirane



            ////List<string> words = Console.ReadLine().Split(new char[]
            ////  { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']', ' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            ////      List<string> upper = new List<string>();
            ////      List<string> lower = new List<string>();
            ////      List <string> mixed = new List<string>();



            //   string[] arrOfNames = new[] { "Pesho", "Stamat", "Gosho" };
            //   Array.Sort(arrOfNames);
            //   Array.Reverse(arrOfNames);
            //
            //   foreach (var a in arrOfNames)
            //   {
            //       Console.WriteLine(a);
            //   }

            //----------sortirane po duljina----------------

            // List<string> arrOfNames = new List<string> { "Pesho", "Stddddamat", "sho" };

            // arrOfNames.Sort((word1, word2) => rd2.Length.CompareToword1.Length));
            // foreach (var item in arrOfNames)
            //    {
            //        Console.WriteLine(item);
            //    }

            //---------------------------
            //----count Numbers-----
            // int[] numbers = new[] { 8, 2, 2, 8, 2, 2, 3, 7 };
            // int[] counterOffEachNumber = new int[numbers.Max()+1];
            // foreach (var number in numbers)
            // {
            //     counterOffEachNumber[number]++;
            // }
            // for (int i = 0; i < counterOffEachNumber.Length; i++)
            // {
            //     if (counterOffEachNumber[i] >0)
            //     {
            //         Console.WriteLine("{0} => {1}", i, //counterOffEachNumber);
            //     }
            // }
            //--ili

            //       int[] numbers = new[] { 8, 2, 2, 8, 2, 2, 3, 3 };
            //       Array.Sort(numbers);
            //       int currentEl = numbers[0];
            //       int counter = 1;
            //       for (int i = 1 ; i < numbers.Length; i++)
            //       {
            //           if (numbers[i] == currentEl)
            //           {
            //               counter++;
            //           }
            //           else
            //           {
            //               Console.WriteLine("{0} => {1}", currentEl, counter);
            //               counter = 1;
            //               currentEl = numbers[i];
            //           }
            //       }
            //
            //       Console.WriteLine("{0} => {1}", currentEl, counter);

            //--------------MATRICI------------
            //purviq for zapulvash vtoriq printirash

            //       int rows = int.Parse(Console.ReadLine());
            //       int cols = int.Parse(Console.ReadLine());
            //       int[,] numbers = new int[rows, cols];
            //
            //       for (int row = 0; row < numbers.GetLength(0); row++) //-s /0/ se obhojda reda
            //       {
            //           for (int col = 0; col < numbers.GetLength(1); col++)
            //           {
            //               numbers[row, col] = int.Parse(Console.ReadLine());
            //           }
            //       }
            //
            //       for (int row = 0; row < numbers.GetLength(0); row++)
            //       {
            //           for (int col = 0; col < numbers.GetLength(1); col++)
            //           {
            //               Console.Write(numbers[row, col] + " ");
            //           }
            //           Console.WriteLine();
            //
            //
            //       }


            //---------Rotate Matrix



            //          int rows = int.Parse(Console.ReadLine());
            //          int cols = int.Parse(Console.ReadLine());
            //          var matrix = new string[rows, cols];
            //          for (int row = 0; row < rows; row++)
            //          {
            //              var cells = Console.ReadLine().Split(' ').ToArray();
            //
            //              for (int col = 0; col < cols; col++)
            //              {
            //                  matrix[row, col] = cells[col];
            //              }
            //
            //          }
            //
            //          var rotatedMatrix = new string[matrix.GetLength(1), matrix.GetLength(0)];
            //
            //          for (int row = 0; row < rotatedMatrix.GetLength(0); row++)
            //          {
            //              for (int col = 0; col < rotatedMatrix.GetLength(1); col++)
            //              {
            //                  rotatedMatrix[row, col] = matrix[matrix.GetLength(0) -1 - col, row];
            //              }
            //
            //          }
            //          Console.WriteLine();
            //
            //          for (int row = 0; row < rotatedMatrix.GetLength(0); row++)
            //          {
            //              for (int col = 0; col < rotatedMatrix.GetLength(1); col++)
            //              {
            //                  Console.Write(rotatedMatrix[row, col] + " ");
            //              }
            //              Console.WriteLine();
            //          }

            //-------------------------ALGOSORT---

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int currentPos = 0; currentPos < numbers.Length; currentPos++)
            {
                int currentMin = numbers[currentPos];
                int currentMinIndex = currentPos;
                for (int i = currentPos + 1 ; i < numbers.Length; i++)
                {
                    if (currentMin > numbers[i])
                    {
                        currentMin = numbers[i];
                        currentMinIndex = i;
                    }
                }
                int temp = numbers[currentPos];
                numbers[currentPos] = currentMin;
                numbers[currentMinIndex] = temp;

                            }
            Console.WriteLine(string.Join(" <= ", numbers));


        }
    }
}
