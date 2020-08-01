using System;

namespace C_Sharp_Exercises_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            BigNum();

            Console.WriteLine("_________________________________________");
            Console.WriteLine("_________________________________________");
            Console.WriteLine("                                         ");

            ImageR();

        }

        public static void BigNum()
        {
            Console.WriteLine("Enter first number: ");
            var numOne = Console.ReadLine();
            var conNumOne = Convert.ToUInt32(numOne);
            Console.WriteLine("Enter second number: ");
            var numTwo = Console.ReadLine();
            var conNumTwo = Convert.ToUInt32(numTwo);

            if (conNumOne > conNumTwo)
            {
                Console.WriteLine("First number was largest: " + conNumOne + " > " + conNumTwo);
            }
            else
            {
                Console.WriteLine("Second number was largest: " + conNumTwo + " > " + conNumOne);
            }
        }

        public static void ImageR()
        {
            Console.WriteLine("Enter WIDTH of image in pixels(px): ");
            var inputWidth = Console.ReadLine();
            var width = Convert.ToInt32(inputWidth);
            Console.WriteLine("Enter HEIGHT of image in pixels(px): ");
            var inputHeight = Console.ReadLine();
            var height = Convert.ToInt32(inputHeight);

            switch(width > height)
            {
                case true:
                    Console.WriteLine("Image is LANDSCAPE (width > height)");
                    break;
                case false:
                    Console.WriteLine("Image is PORTRAIT (height > width)");
                    break;

            }
        }
    }
}
