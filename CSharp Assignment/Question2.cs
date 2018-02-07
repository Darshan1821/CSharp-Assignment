using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_Assignment
{
    class Question2
    {
        private static string[] words = new string[] { "Boat", "House", "Cat", "River", "Cupboard" };

        public static void Question12()
        {
            Console.WriteLine("Plurals:\n");
            foreach (var w in words) Console.WriteLine(w + "s");
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("Replaced 2nd word:\n");
            words[1] = "Home";
            foreach (var w in words) Console.WriteLine(w);
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("Added new word:\n");
            List<string> word = words.ToList();
            word.Add("Darshan");
            words = word.ToArray();
            foreach (var w in words) Console.WriteLine(w);
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("Words length = 7:\n");
            var wordlen = Array.FindAll(words, w => w.Length == 7);
            foreach (var w in wordlen) Console.WriteLine(w);
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("3rd Word:\n");
            Console.WriteLine(words[2]);
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("Ascending Order:\n");
            var ascending = words.OrderBy( w => w );
            foreach (var w in ascending) Console.WriteLine(w);
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("Reverse Order:\n");
            var reverse = words.Reverse();
            foreach (var w in reverse) Console.WriteLine(w);
        }
    }
}
