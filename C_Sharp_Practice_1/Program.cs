using System;
using C_Sharp_Practice_1.Math;


namespace C_Sharp_Practice_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            Person james = new Person();

            james.FirstName = "James";
            james.LastName = "Stallings";

            james.Introduce();

            var newName = new Strings();

            Calculator calculator = new Calculator();

            var answer = calculator.Add(12, 15);

            int[] numberArr = new int[5] { 14, 21, 9, 88, 14 };

            var boolArr = new bool[3];

            var namesArr = new string[4] { "Thomas", "Scott", "David", "Mike" };

            // Using format strings to create a 'complex' string:
            string firstName = "Taboolah";
            string lastName = "Pastaman";
            string fullName = string.Format("{0} {1}", firstName, lastName);
            Console.WriteLine(fullName);

            var flags = new bool[3];
            flags[1] = true;

            Console.WriteLine("Number Array is: " + numberArr[2]);
            Console.WriteLine("Bool Array is: " + boolArr[1]);
            Console.WriteLine("flag 1 is: " + flags[0]);
            Console.WriteLine("flag 2 is: " + flags[1]);
            Console.WriteLine("flag 3 is: " + flags[2]);
            Console.WriteLine("Third name is: " + namesArr[2]);

            Console.WriteLine("Answer is: " + answer);

         

           
        }
    }
}
