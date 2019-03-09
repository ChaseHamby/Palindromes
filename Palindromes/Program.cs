using System;
using System.Linq;

namespace Palindromes
{
    class Program
    {
        public static bool IsPalindrome(string myString)
        {
            return myString.SequenceEqual(myString.Reverse());
        }
        static void Main(string[] args)
        {
            string[] array =
            {
            "Stats",
            "deified",
            "deleveled",
            "No X in Nixon",
            "dewed",
            "Hannah",
            "kayak",
            "Was it a cat I saw",
            "madam",
            "rotor",
            "sagas",
            "Dot",
            "Net",
            "Is",
            "Not",
            "A",
            "Palindrome",
            ""
            };
            foreach (string value in array)
            {
                Console.WriteLine("{0} = {1}", value, IsPalindrome(value));
                Console.ReadKey();
            }
        }
    }
}
