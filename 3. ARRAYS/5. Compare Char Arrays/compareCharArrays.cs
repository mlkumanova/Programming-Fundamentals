using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class compareCharArrays
    {
        static void Main(string[] args)
        {

       
        char[] first = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
        char[] second = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

        if (first.Length == second.Length)
        {
            for (int i = 0; i < Math.Min(first.Length, second.Length); i++)
            {
                if (first[i] == second[i] || second[i] > first[i])
                {
                    Console.WriteLine("{0}\n{1}", string.Join("",first), string.Join("",second));
                    break;
                   
                }
                else if (first[i] > second[i])
                {
                    Console.WriteLine("{0}\n{1}", string.Join("", second), string.Join("", first));
                    break;
                }
            }
        }
        else if (first.Length > second.Length)
        {
            Console.WriteLine("{0}\n{1}", string.Join("", second), string.Join("", first));


        }
        else
        {
            Console.WriteLine("{0}\n{1}", string.Join("", first), string.Join("", second));
        }

           

        }




    }
       
    
        


    


