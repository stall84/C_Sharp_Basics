using System;
namespace C_Sharp_3
{
    public class Array_Props_Methods
    {
        public static int[] numbers = new int[] { 15, 88, 120, 66, 908, 308, 41, 55 };
        public static int[] numbers2 = new int[] { 0, 2, 4, 6, 8, 10, 12 };
        public static string[] names = new string[] { "Donny", "Sarah", "Smithers", "Steven", "Jessica", "Helen", "JERRY" };
        public static string[] names2 = new string[] { "Johnson", "Stevenson", "Caruthers", "Smith", "Stallings" };
        

        // Length Property
        public static void Lengther ()
        {
            // Length is actually an array property so you can simply add it after a dot
            Console.WriteLine("Length of numbers array: " + numbers.Length);
        }

        // IndexOf Method
        public static void IndexOfer ()
        {
            // This is an array method, so you have to call the Array class, passing the array you
            // wish to search on (usually) as the first of multiple 'overloads' or params
            // IndexOf will return an integer so we will store it in a variable to console it out

            var indexInt = Array.IndexOf(numbers, 41);
            Console.WriteLine("Index Of '41': " + indexInt);

        }

        // Clear Method
        public static void Clearer ()
        {
            // The Clear method inputs the array to operate on, the index to start clearing at,
            // then the elements to clear from that starting index. In integer arrays it will clear out
            // the int's to zero. in bool arrays it will clear bools to false and in string arrays
            // it will clear strings to null

            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect after clearing numbers array: ");
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
            Array.Clear(names, 2, 3);
            Console.WriteLine("Effect after clearing names array: ");
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

        }

        // Copy Method
        public static void Copyer ()
        {
            // Takes source array as first param, destination array as second param, and length to copy
            // Default is to start copy-in at first element, but with overloads you can specify source index
            // to start at and destination index to start at
            Array.Copy(names, names2, 2);
            Console.WriteLine("Effect of copying: ");
            foreach(var name in names2)
            {
                Console.WriteLine(name);
            }
        }

        // Sort Method
        // A lot to learn on this method obviously.. something like 17 overloads
        // https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=netcore-3.1

        public static void Sorter ()
        {
            Array.Sort(names2);
            Console.WriteLine("Effect of a straight sort of names2 array: ");

            foreach(var lastName in names2)
            {
                Console.WriteLine(lastName);
            }

            Array.Sort(numbers);
            Console.WriteLine("Effect of a straight sort of numbers array: ");

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

        }

        // Reverse Method
        public static void Reverser ()
        {
            Array.Reverse(names);
            Console.WriteLine("Effect of reversing names array: ");
                foreach(var name in names)
            {
                Console.WriteLine(name);
            }
        }

    }
}
