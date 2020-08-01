using System;

namespace C_Sharp_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            speedCam();
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
    }
}
