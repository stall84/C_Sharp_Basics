using System;
using System.Collections.Generic;

namespace C_Sharp_4
{
    // A couple different very useful string formatting methods :
    // ToLower();
    // ToUpper();
    // Trim() < removes whitespace .. very useful taking user input from forms, etc
    // IndexOf('whatever');
    // LastIndexOf();

    // Substring(startIndex);
    // Substring(startIndex, length);
    // Replace()
    // IsNullOrEmpty();
    // IsNullOrWhitespace();
    // Split(' ')

    



    public class Strings_Advanced
    {

        public static void NumConverter ()
        {
            string s = "1234";
            string s2 = "5678";
            int s3 = 4309;
            int s4 = 35;

            // Two diff ways to convert string to int: Using the Parse method on the int class, or the
            // Convert class with the ToInt32() method
            // ConvertToInt32 might be the safer method b/c if string input is null or empty will return zero instead of throw exception

            int i = int.Parse(s);
            int j = Convert.ToInt32(s2);

            Console.WriteLine("Parsed String to Int: " + i);
            Console.WriteLine("Parsed String through ConvertToInt32: " + j);

            // Converting Numbers to Strings take on a few diff forms with diff format strings
            // For instance "C" is the format string for currency.. "C0" is currency with no cents:

            string p = s4.ToString();
            string q = s4.ToString("C");

            Console.WriteLine("Int converted to currency string: " + q);
            Console.WriteLine("Int converted to regular string: " + p);

        }

        public static void Trimmer ()
        {
            // Practice using format string to save code:

            string fullName = " Michael Stallings  ";

            Console.WriteLine("Untrimmed fullName: '{0}'", fullName);
            Console.WriteLine("Trimmed Name: '{0}'", fullName.Trim()); ;
        }

        public static void Upperer ()
        {
            // You can chain methods. All methods return a new string, leaving the original string un-modified/immutable

            string fullName = " Michael Stallings  ";
            Console.WriteLine("Trimmed&Uppered Name: '{0}'", fullName.Trim().ToUpper());

        }

        public static void Splitter ()
        {
            string fullName = "Michael Stallings  ";
            // Objective is to split the name into first & last
            // One/First method we'll use will search for the IndexOf the whitespace (notice we've removed
            // the whitespace before the M for this case.
            // After finding the whitespace between first/last name. use the Substring method using both it's overloads
            // and the index to determine which substrings to return

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1).Trim();
            Console.WriteLine("Firstname: {0}, Lastname: '{1}'", firstName, lastName);

            // An easier method is to utilize the Split method.. It will return a string array.
            // Since split method on a string returns a string array, splitting on the (trimmed) whitespace
            // will return an array of first and last name that can be accessed like any element of an array

            
            fullName.Trim();        // First trim the extra whitespace off ends
            var names = fullName.Split(' ');  // Then set the split returned array to a variable

            Console.WriteLine("Split returned Firstname: " + names[0]);
            Console.WriteLine("Split returned Lastname: " + names[1]);
        }

        public static void Replacer ()
        {
            string fullName = "Michael Stallings  ";
            // Replace firstname with shortened version 'Mike'
            var newName = fullName.Replace("Michael", "Mike");
            //Console.WriteLine(newName);
            Console.WriteLine(fullName);
            Console.WriteLine(fullName.Replace("Michael", "Mike"));


        }

        public static void VoidChecker ()
        {
            // Say for instance you want to check if user input'd a credit card number..
            // You want to validate the string that was entered

            Console.WriteLine("Enter Credit Card Number");
            var cc = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(cc))
            {
                Console.WriteLine("Invalid!");
                
            } else
            Console.WriteLine("K Thx");
        }

        public static void NewNumConverter ()
        {
            // Writing a simple program to show how conversions will usually always happen
            // due to user input almost always being in string form that will need to be converted
            // to int

            Console.WriteLine("Enter your age: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered: " + age);

            // If you want to go the opposite direction and convert a number to a string:
            float price = 29.95f;
            var final = price.ToString("C");
            Console.WriteLine("Converting float to string: {0} ", final );

        }

        public static void Sumarizer ()
        {
            // Summarizing text (usually seen as adding ellipses on blog posts, etc ...)
            // If sentence length is below a certain threshold, display it, othwerise, sumarize it

            const int sentLength = 100;

            var sentence = "Its fo rizzle facilisi. Etiam faucibus pharetra neque. Nizzle vulputate stuff crazy maurizzle. " +
                "Cool accumsizzle odio fizzle bizzle. Curabitizzle adipiscing nibh funky fresh fo shizzle my nizzle. " +
                "crunk, break yo neck, yall eget eleifend crackalackin, dolizzle bibendum orci, eu placerizzle quam maurizzle away mi. " +
                "Etiam own yo', funky fresh things aliquet aliquam, tellizzle nisl lacinia orci, hizzle dope nulla things cool purizzle. Nizzle aliquizzle izzle pede. " +
                "Brizzle pulvinizzle my shizz dolizzle. Fo shizzle get down get down enim, tempizzle nec, facilisis nec, rizzle check out this, sizzle. " +
                "You son of a bizzle egizzle massa its fo rizzle tellivizzle gangsta dictum." +
                " Vestibulizzle ma nizzle shizzle my nizzle crocodizzle izzle sem tincidunt phat. Its fo rizzle bizzle gangsta. Maecenizzle boom shackalack. " +
                "Vivamizzle fermentum consequizzle shiz. Pellentesque things. Lorizzle fo shizzle mammasay mammasa mamma oo sa sit amizzle, ass adipiscing elizzle. " +
                "Gangster urna arcu, bizzle mofo, sagittis i'm in the shizzle, pharetra eu, fo shizzle. Lorem pimpin' fizzle sit amet, fo shizzle my nizzle adipiscing da bomb.";


            // One method would be to use Substring method, but that will inevitably cut off a word.
            // A better algorithm is to push the whole words into a string array by Splitting them on
            // the whitespace

            if (sentence.Length < sentLength)
            {
                Console.WriteLine(sentence);
            }
            else
            {
                var words = sentence.Split(' ');
                // Create a character # tracking variable
                var totalCharacters = 0;

                // Create variable to hold the words that will be in the summary. Make it a List
                // So its dynamic as to it's size/length 
                var summaryWords = new List<string>();

                // Now loop over the words array

                foreach (var word in words)
                {
                    // Push the words up until the cutoff into the summary list
                    summaryWords.Add(word);
                    // For each word in the array, add it to the totalChar variable
                    // using the Length property of the individual string-word being iterated over
                    // Add 1 to account for space after word
                    totalCharacters += word.Length + 1;
                    if (totalCharacters > sentLength)
                        break;
                    
                }

                var summary = String.Join(" ", summaryWords) + "...";
                Console.WriteLine(summary);
            }
        }

    }



}
