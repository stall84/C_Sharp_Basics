using System;
namespace C_Sharp_3
{
    public class Exercises_3
    {




        public static void Problem2 ()
        {
            /* Problem 2: Write a program and ask the user to enter their name.
               Use an array to reverse the name and then store the result in a new string.
               Display the reversed name on the console. */

            Console.WriteLine("Enter your name: ");
            string nameInput = Console.ReadLine();
            Console.WriteLine("nameInput variable: " + nameInput);
            char[] arr = nameInput.ToCharArray();
            Array.Reverse(arr);
            string result = new String(arr);
            Console.WriteLine("Reversed Name String: " + result);

            


        }


    }
}
