using System;
namespace C_Sharp_2
{
    public class ArraysAdvanced
    {

        public static int[] numbers = new int[] { 15, 22, 98, 51, 52, 29 };

        public static void Arrayer ()
        {
            // Single Dimension Arrays:
            int[] singArr = new int[5] { 14, 41, 32, 88, 32 };
            Console.WriteLine(singArr[3]);
        }

        public static void MultiDimArrayer ()
        {
            // Multi-Dimensional Arrays (Rectangular / Jagged)
            // Difference in intializing/declaring a rectangular multi-dimension array shown below
            // basically just enumerating row-length and column-length in that order
            // Also in declaring the type of array (left side) add comma to denote multi-dim rect
            int[,] rectmatrix = new int[3, 5];
            // If you know the contents of the array at initialization, use object init syntax like:
            var rectArr = new int[3, 5]
            {
                { 1, 3, 5, 7, 9 },
                { 14, 77, 89, 105, 201 },
                { 2, 4, 6, 8, 10 }
            };
            // To acess an element in multi-dim arr use arr[row,column] syntax
            //int element = rectArr[3, 3];  // should output 8
            Console.WriteLine("logging element: " + rectArr[3, 2]);
             
        }

        public static void ThreeDArr ()
        {
            // Three Dimensional Rectangular Array, setting, accessing

            var colors = new int[3, 5, 4];
            colors[0, 0, 0] = 15;
            colors[1, 2, 1] = 30;
            Console.WriteLine("colors log: " + colors[0, 0, 0]);
            Console.WriteLine("colors log2: " + colors[2, 2, 2]);
            Console.WriteLine("colors log3: " + colors[1, 2, 1]);
        }

        public static void JaggedArr ()
        {
            // Jagged arrays can be thought of as an array of arrays
            // Syntax is explicit known value to dimension with empty remaining row/columns
            // For instance to model the jagged array: 0, 1, 2, 3
            //                                         0, 1, 2, 3, 4
            //                                         0, 1, 2
            // Do: Where we define each top level 'row'
            // with a new length of array contained therein
            var jaggedArray = new int[3][];
            jaggedArray[0] = new int[4] { 0, 1, 2, 3 };
            jaggedArray[1] = new int[5] { 0, 1, 2, 3, 4 };
            jaggedArray[2] = new int[3] { 0, 1, 2, };

            // Access values in same way i.e.:
            Console.WriteLine("jaggedArr log: " + jaggedArray[1][3]);  // Should yield 3


        }

        public static void ArrayMethods ()
        {
            // Length (Technically a Property): Returns integer number of elements in the array
            Console.WriteLine("Length of numbers array: " + numbers.Length);

            // IndexOf Method: Usually used to locate object/elements in the array and return their index (integer)
            // Methods have to be called on the Array Class, passing the array you want to work on in as parameter/overloadIndexOf will return an integer.
            var numIndex = Array.IndexOf(numbers, 98);
            Console.WriteLine("Index of 98: " + numIndex);
        }
    }
}
