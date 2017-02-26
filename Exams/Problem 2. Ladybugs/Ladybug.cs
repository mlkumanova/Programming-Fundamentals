using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
    static void Main(string[] args)
    {
        var fieldSize = int.Parse(Console.ReadLine());

        var ladybugIndexes = Console.ReadLine()
         .Split()
         .Select(int.Parse)
         .Where(a => a >= 0 && a < fieldSize) // za da ne izlizame ot masiva naprimer 0 1 16
         .ToArray();

        var ladybugs = new int[fieldSize]; // suzdavame nov masiv v koito shte sa kalinkite

        for (int i = 0; i < ladybugIndexes.Length; i++) // pulnim masiva s kalinki
        {
            var currLAdyBugIndex = ladybugIndexes[i];
            ladybugs[currLAdyBugIndex] = 1;
        }

        var line = Console.ReadLine();
        while (line != "end")
        {
            var tokens = line.Split();

            var ladyBugIndex = int.Parse(tokens[0]);
            var direction = tokens[1];
            var flyLengh = int.Parse(tokens[2]);

            if (ladyBugIndex < 0 || ladyBugIndex >= ladybugs.Length) // dali e na validen index
            {
                line = Console.ReadLine();
                continue;
            }
            if (ladybugs[ladyBugIndex] == 0) // ako nqma kalinka no indexa e pravilen
            {
                line = Console.ReadLine();
                continue;
            }

            
            MOveLadybug(ladybugs, ladyBugIndex, flyLengh, direction);

        }
        Console.WriteLine(string.Join(" ", ladybugs));
    }

    private static void MOveLadybug(int[] ladybugs, int ladyBugIndex, int flyLenght, string direction)
    {
        ladybugs [ladyBugIndex] = 0;

        var leftArrayOrFoundPlace = false;
        while (!leftArrayOrFoundPlace)
        {
            switch (direction)
            {
                case "left": ladyBugIndex -= flyLenght; break;
                case "right": ladyBugIndex += flyLenght; break; 
            }

            if (ladyBugIndex < 0 || ladyBugIndex >= ladybugs.Length)
            {
                leftArrayOrFoundPlace = true;
                continue;
            }
            if (ladybugs[ladyBugIndex] == 1)//step over anothe ladybug, keep flying
            {
                continue;
            }
            if (ladybugs[ladyBugIndex] == 0) // ako e namerila kude da kacne
            {
                ladybugs[ladyBugIndex] = 1;
                leftArrayOrFoundPlace = true; // namerila si e mqsto
                continue;
            }
        }
        /*-------------------100/100
    //    var fieldSize = int.Parse(Console.ReadLine());

    //    var ladybugIndexes = Console.ReadLine()
    //     .Split()
    //     .Select(int.Parse)
    //     .Where(a => a >= 0 && a < fieldSize)
    //     .ToArray();

    //    var ladybugs = new int[fieldSize];

    //    for (int i = 0; i < ladybugIndexes.Length; i++)
    //    {
    //        var currLAdyBugIndex = ladybugIndexes[i];
    //        ladybugs[currLAdyBugIndex] = 1;
    //    }

    //    var line = Console.ReadLine();
    //    while (line != "end")
    //    {
    //        var tokens = line.Split();

    //        var ladyBugIndex = int.Parse(tokens[0]);
    //        var direction = tokens[1];
    //        var flyLength = int.Parse(tokens[2]);

    //        if (ladyBugIndex < 0 || ladyBugIndex >= ladybugs.Length)
    //        {
    //            line = Console.ReadLine();
    //            continue;
    //        }
    //        if (ladybugs[ladyBugIndex] == 0)
    //        {
    //            line = Console.ReadLine();
    //            continue;
    //        }
    //        MoveLadybug(ladybugs, ladyBugIndex, flyLength, direction);
    //        line = Console.ReadLine();

    //    }
    //    Console.WriteLine(string.Join(" ", ladybugs));
    //}

    //static void MoveLadybug(int[] ladybugs, int ladyBugIndex, int flyLenght, string direction)
    //{
    //    ladybugs[ladyBugIndex] = 0;

    //    var leftArrayOrFoundPlace = false;
    //    while (!leftArrayOrFoundPlace)
    //    {
    //        switch (direction)
    //        {
    //            case "left": ladyBugIndex -= flyLenght; break;
    //            case "right": ladyBugIndex += flyLenght; break;
    //        }

    //        if (ladyBugIndex < 0 || ladyBugIndex >= ladybugs.Length)
    //        {
    //            leftArrayOrFoundPlace = true;
    //            continue;
    //        }
    //        if (ladybugs[ladyBugIndex] == 1)
    //        {
    //            continue;
    //        }
    //        if (ladybugs[ladyBugIndex] == 0)
    //        {
    //            ladybugs[ladyBugIndex] = 1;
    //            leftArrayOrFoundPlace = true;
    //            continue;
    //        }
    //    }
    //}---------------------------------------------------------*/
}
}

//   var fieldSize = int.Parse//(Console.ReadLine());
//   var indexesInitial = Console.ReadLine//().Split().Select(int.Parse).ToArray/();
//   var line = Console.ReadLine();
//   while (line != "end")
//   {
//       var command = line.Split/().ToArray/();
//       var ladybugIndex = command[0];
//       var direction = command[1];
//       var flyLength = command[2];
//


//        int sizeField = int.Parse(Console.ReadLine());
//        int[] indexesToPlantBugs = Console.ReadLine().Split().Select(int.Parse).ToArray();
//        string[] commandInput = Console.ReadLine().Split();

//        int[] field = PlantBugsOnField(sizeField, indexesToPlantBugs);

//        while (commandInput[0] != "end")
//        {
//            int bugIndex = int.Parse(commandInput[0]);
//            string flightDirection = commandInput[1];
//            int flightLength = int.Parse(commandInput[2]);

//            flightDirection = FlightDirectionCorrection(flightDirection, flightLength);

//            //Check for misleading index input
//            if (bugIndex >= 0 && bugIndex < sizeField)
//            {
//                if (field[bugIndex] == 1) //Check if there is an actual bug on that index
//                {
//                    //Take off and leave index empty => 0
//                    field[bugIndex] = 0;

//                    //land LEFT                
//                    if (flightDirection == "left")
//                    {
//                        field = NewFieldLeft(field, bugIndex, flightLength);
//                    }// END OF LEFT direction ---------------------------------


//                    //land RIGHT  
//                    if (flightDirection == "right")
//                    {
//                        field = NewFieldRight(field, bugIndex, flightLength);
//                    }// END OF RIGHT direction -------------------------------


//                }//END OF Check if there is an actual bug on that index
//            } //END OF Check for misleading input index

//            commandInput = Console.ReadLine().Split();

//        } // END OF while (commandInput[0] != "end")

//        // Print output
//        Console.WriteLine(string.Join(" ", field));
//    }



//    // ------------------------- METHODS ------------------------ //

//    //LEFT LAND direction / land if index is 0
//    static int[] NewFieldLeft(int[] field, int bugIndex, int flightLength)
//    {
//    flightLength = Math.Abs(flightLength);
//    for (int i = bugIndex - flightLength; i >= 0; i = i - flightLength)
//    {
//        if (field[i] == 0)
//        {
//            field[i] = 1;
//            break;
//        }
//    }
//    return field;
//} // end of LEFT LAND ----------------------------

////RIGHT land
//private static int[] NewFieldRight(int[] field, int bugIndex, int flightLength)
//{
//    flightLength = Math.Abs(flightLength);
//    for (int i = bugIndex + flightLength; i < field.Length; i = i + flightLength)
//    {
//        if (field[i] == 0)
//        {
//            field[i] = 1;
//            break;
//        }
//    }

//    return field;
//}// end of RIGHT LAND ----------------------------


////Correct flight direction (left/right) based on positive or negative flight lenght
//static string FlightDirectionCorrection(string flightDirection, int flightLength)
//{
//    string correctedDirection = flightDirection;
//    if (flightLength < 0)
//    {
//        switch (flightDirection)
//        {
//            case "left": correctedDirection = "right"; break;
//            case "right": correctedDirection = "left"; break;
//        }
//    }
//    return correctedDirection;
//}
//// END OF Correct flight ------------------------------


//// Plant bugs on field - the very first task
//static int[] PlantBugsOnField(int sizeField, int[] indexToPlantBugs)
//{
//    int[] field = new int[sizeField];
//    for (int i = 0; i < indexToPlantBugs.Length; i++)
//    {
//        if (indexToPlantBugs[i] >= 0 && indexToPlantBugs[i] < sizeField)
//        {
//            field[indexToPlantBugs[i]] = 1;
//        }
//    }
//    return field;
//}


