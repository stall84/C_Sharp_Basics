using System;
using System.Collections.Generic;


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

        public static void Problem3 ()
        {

            /* Problem 3: Write a program and ask the user to enter 5 numbers. 
             * If a number has been previously entered, display an error message and ask the user to re-try. 
             * Once the user successfully enters 5 unique numbers, sort them and display the result on the console. */

            // First instantiate a new list to hold the numbers
            // Using a while loop to continue to prompt user to add numbers:

            List<int> numbers = new List<int>();

            while(numbers.Count < 5)
            {
                Console.WriteLine("Please add a number to the list: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("You previously entered that number, please re-enter new int");
                    continue;
                }

                numbers.Add(number);
                numbers.Sort();
                foreach(var num in numbers)
                {
                    Console.WriteLine(num);
                }

            }

            
        }


    }
}
