using System;
using C_Sharp_Practice_1.Math;


namespace C_Sharp_Practice_1
{
   


    class MainClass
    {
        public static void Main(string[] args)
        {
            int biotch = 10;

            Increment(biotch);
            Console.WriteLine("Value of Biotch: " + biotch);

           
        }

        public static void Increment(int number)
        {
            number += 10;
        }
    }
}
