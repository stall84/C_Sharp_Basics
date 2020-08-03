using System;
// To use the List class this specific part of System Collections must be remembered to be required
using System.Collections.Generic;

namespace C_Sharp_3
{
    public class Lists
    {
        // Lists are a popular enumerable data structure that allow you to alter the enumerable
        // list after it's been initialized (unlike array's which cannot be altered once initd).
        // Lists contain methods like Add() and AddRange() where objects, single int's, and additional lists or arrays can
        // be added after init of list

        public static List<int> numberNew = new List<int>() { 2, 4, 6, 8, 10 };

        public static List<int> numberList = new List<int> { 2, 4, 8, 10, 12, 14, 8, 16 };



        // Add and AddRange methods
        public static void Adder ()
        {

            
            numberNew.Add(12);
            numberNew.AddRange(new int[] { 22, 24, 26, 28 });
            foreach(var num in numberNew)
            {
                Console.WriteLine(num);
            }
        }
        // IndexOf method almost identical to array method
        public static void IndexerOf ()
        {
            
            numberNew.Add(8);
            Console.WriteLine("Logging number array: ");    
            foreach (var num in numberNew)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine(" ");
            Console.WriteLine("________________________________________");
            Console.WriteLine(" ");
            // will return the index of element input'd .. otherwise -1
            var index = numberNew.IndexOf(4);
            var lastInd = numberNew.LastIndexOf(8);
            Console.WriteLine("index of 4: " + index);
            Console.WriteLine("last index of 8: " + lastInd);
         
        }

        // Count: Returns a count of number of objects in the List
        public static void Counter ()
        {
            // Notice there is no function/method call in this.. like a property on array (.length)
            var count = numberNew.Count;

            Console.WriteLine("Count: " + count);
        }

        // Remove: Removes object from List

        public static void Remover ()
        {
            
            // Regular Remove method will only remove a single instance of the object you're looking for..
            // If we wanted to remove all 8's from our list.. we would have to add some logic like

            for (var i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] == 8)
                
                    numberList.Remove(numberList[i]);
                
            }

            Console.WriteLine("Logging after removal: " );

            foreach(var number in numberList)
            {
                Console.WriteLine(number);
            }

        }

        // Clear Method: Removes all elements from the List

        public static void Clearer()
        {
            numberList.Clear();

            foreach (var number in numberList)
            {
                Console.WriteLine(number);
            }

        }       
    }
}
