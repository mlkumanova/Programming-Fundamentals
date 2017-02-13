using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class IntToHexAndBinary
    {
        static void Main(string[] args)
        {
            int decValue = int.Parse(Console.ReadLine());
            string hexValue = decValue.ToString("X");
            string binaryString = Convert.ToString(Convert.ToInt32(hexValue.ToString(), 16), 2);

            Console.WriteLine(hexValue);
            Console.WriteLine(binaryString);
        }
    }

