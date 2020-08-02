using System;


namespace C_Sharp_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            ArraysAdvanced.JaggedArr();
            //ArraysAdvanced.ThreeDArr();    
            //ArraysAdvanced.MultiDimArrayer();
            //RandomString();
           

        }


        /* Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car.
         * If the user enters a value less than the speed limit, program should display Ok on the console. 
         * If the value is above the speed limit, the program should calculate the number of demerit points. 
         * For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
         * If the number of demerit points is above 12, the program should display License Suspended. */

        public static void speedCam ()
        {
            Console.WriteLine("Enter the Speed-Limit: ");
            // Convert the user's inputed String to an integer for doing math with later
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now enter the speed the car is traveling at: ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());
            var demerits = ((carSpeed - speedLimit) / 5);
            

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("OK");
            }
            else if (demerits > 0 && demerits <= 12)
            {
                Console.WriteLine("Number of Demerit Points Incurred: " + demerits);
            }
            else
                Console.WriteLine("LICENSE SUSPENDED");
        }

        // Create for loop to loop through numbers 0 to 10 and only print out the even numbers

        public static void EvenLoop()
        {
            for (var i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // Reverse Order
            for (var h = 10; h >= 0; h--)
            {
                if (h % 2 == 0)
                {
                    Console.WriteLine(h);
                }
            }
        }

        public static void ForEachn()
        {
            var numbers = new int[] { 4, 8, 17, 29 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void WhileName()
        {
            // Be careful when setting a while loop to a 'true' condition 
            while(true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();
                // Program here if there is any whitespace or null is going to skip this block and go down to the
                // break, and end the program. If there are characters/name present it's going to hit the
                // continue keyword and immediately go back to the start of the loop 
                if(!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Hello " + input);
                    continue;
                }

                break;
            }
        }

        public static void RandomString ()
        {
            // Random is a class, instantiate it to use methods on it
            var random = new Random();

            // Declare constant so that if we want to later change the length of characters in randomly generated password
            // We can do it in one location instead of chasing code in multiple locations
            const int charNum = 10;

            for (var i = 0; i < charNum; i++)
            {
                // cast randomNext integer to ascii character for a random string
                Console.Write((char)('a' + random.Next(0, 26))); ;
                
            }
            Console.WriteLine(" ");
            Console.WriteLine("______________________________________________________");
            // C# won't allow explicitly converting/saving the above random code generator to a string (It will only save individual characters).
            // You must first convert to an array

            // Create new character array with 10 elements
            char[] buffer = new char[charNum];
            for (var i = 0; i < charNum; i++)
            {
                // set each individual element in the buffer array to each random character created
                buffer[i] = (char)('a' + random.Next(0, 26));
                
            }
            // After converting the individual characters to an array, instantiate a new String class passing the buffer array as input/overload
            var password = new String(buffer);
            Console.WriteLine("password: " + password);
        }
        

     
    }
}
