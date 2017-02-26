using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CommandInterpreted
{
    static void Main()
    {                        


        List<string> array = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        string inputLine = Console.ReadLine();

        while (inputLine != "end")
        {
            string[] commanParams = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string command = commanParams[0];
            switch (command)
            {
                case "reverse":
                    int reverseStart = int.Parse(commanParams[2]);
                    int reverseCount = int.Parse(commanParams[4]);

                    if (isValid(array, reverseStart, reverseCount))
                    {
                        array.Reverse(reverseStart, reverseCount);
                        //Reverse(array, start, count); //ili ->1
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    break;
                case "sort":
                    int sortStart = int.Parse(commanParams[2]);
                    int sortCount = int.Parse(commanParams[4]);
                    if (isValid(array, sortStart , sortCount))
                    {
                        Sort(array, sortStart, sortCount);
                        //array.Sort(sortStart, sortCount, StringComparer.InvariantCulture);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }

                    break;
                case "rollLeft":
                    int rollLeftCount = int.Parse(commanParams[1]);

                    if (rollLeftCount >= 0)
                    {
                    RollLeft(array, rollLeftCount);

                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }

                    break;
                case "rollRight":
                    int rollRightCount = int.Parse(commanParams[1]);
                    if (rollRightCount >= 0)
                    {
                        RollRight(array, rollRightCount);
                    }

                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    break;
                
            }

            inputLine = Console.ReadLine();
        }
        Console.WriteLine($@"[{string.Join(", ", array)}]");


    }

    private static void RollRight(List<string> array, int rollRightCount)
    {
        rollRightCount = rollRightCount % array.Count;

        for (int i = 0; i < rollRightCount; i++)
        {//ravnqva se na edna rotaciq
            string lastElem = array.Last(); // ili array[array.Count -1]

            array.RemoveAt(array.Count - 1);
            array.Insert(0, lastElem);

        }
    }

    private static void RollLeft(List<string> array, int rollLeftCount)
    {
        rollLeftCount = rollLeftCount % array.Count;

        for (int i = 0; i < rollLeftCount; i++)
        {//ravnqva se na edna rotaciq
            string firstElem = array[0];

            for (int j = 0; j < array.Count - 1; j++)
            {
                array[j] = array[j + 1];
            }
            array[array.Count - 1] = firstElem;
        }
    }


    private static void Sort(List<string> array, int sortStart, int sortCount)
    {
        List<string> resultArray = array.Skip(sortStart).Take(sortCount).OrderBy(x => x).ToList();

        array.RemoveRange(sortStart, sortCount);
        array.InsertRange(sortStart, resultArray);
    }

    private static void Reverse(List<string> array, int start, int count)
    {

       // array.Reverse(start, count); 

        List<string> resultArray = array.Skip(start).Take(count).Reverse().ToList();
        array.RemoveRange(start, count);
        array.InsertRange(start, resultArray); //ili ->1

    }

    private static bool isValid(List<string> array, int start, int count)
    {
        
        if (start>= 0 && start < array.Count && count >= 0 &&(start + count) <= array.Count)
        {
            return true;
        }
        return false;
    }
}




