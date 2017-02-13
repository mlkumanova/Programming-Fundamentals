using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
        int numberOfPeople = int.Parse(Console.ReadLine());
        int capacityOfElevator = int.Parse(Console.ReadLine());

        double fullCourses = (int)(Math.Ceiling((double) numberOfPeople / capacityOfElevator));
        double round = numberOfPeople % capacityOfElevator;

        if (fullCourses % 2 == 0)
        {
            Console.WriteLine($@"{fullCourses}");

        }
        else
        {
            Console.WriteLine($@"{fullCourses}
");
        }
        }

        }
    

