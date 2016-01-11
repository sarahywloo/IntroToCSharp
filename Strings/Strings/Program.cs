using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings {
    class Program {
        static void Main(string[] args) {

            //Class Notes on C# Strings

            var ssn = "\\d{3}-\\d{2}-\\d{4}";
            // match ###-\-###
            //           \d{3}-\\-\d{3}
            var thing = "\\d{3}-\\\\-\\d{3}";
            thing = @"\d{3}-\\-\d{3}";

            Console.WriteLine("the quick brown fox".Contains("quick")); // true
            Console.WriteLine("the quick brown fox".Contains("dog"));   // false

            //                          1         2         3         4
            //                0123456789012345678901234567890123456789012
            var quickBrown = "the quick brown fox jumps over the lazy dog";
            Console.WriteLine(quickBrown.StartsWith("the qu")); // true
            Console.WriteLine(quickBrown.EndsWith("zy dog")); // true

            Console.WriteLine(quickBrown.IndexOf("fox")); // 16
            Console.WriteLine(quickBrown.IndexOf("s"));   // 24
            Console.WriteLine(quickBrown.IndexOf("cat")); // -1

            Console.WriteLine(quickBrown.Insert(40, "red ")); // .... lazy red dog
            Console.WriteLine(quickBrown);                     // .... lazy dog
                                                               // quickBrown = quickBrown.Insert(40, "red ");

            Console.WriteLine(string.IsNullOrEmpty(""));  // true
            Console.WriteLine(string.IsNullOrEmpty(null));// true
            Console.WriteLine(string.IsNullOrEmpty(" ")); // false
            Console.WriteLine(string.IsNullOrEmpty(quickBrown));// false

            Console.WriteLine(string.IsNullOrWhiteSpace(""));           // true
            Console.WriteLine(string.IsNullOrWhiteSpace(null));         // true
            Console.WriteLine(string.IsNullOrWhiteSpace("    "));       // true
            Console.WriteLine(string.IsNullOrWhiteSpace("\n\t   \n"));  // true

            Console.WriteLine(quickBrown.Split(' ')); // ["the", "quick", "brown"...]
            Console.WriteLine("a  b".Split(' ')); // ["a", "", "b"]
            Console.WriteLine("a  b".Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries));
            // ["a", "b"]

            // Strings are immutable!!! quickBrown remains unchanged
            Console.WriteLine(quickBrown.Remove(4, 6)); // the brown fox....

            Console.WriteLine(quickBrown.Replace("fox", "cat")); // ... brown cat...
            Console.WriteLine(quickBrown.Replace("o", "*")); // replace ALL o's

            Console.WriteLine("abcd".ToUpper()); // ABCD
            Console.WriteLine("ABCD".ToLower()); // abcd

            Console.WriteLine(quickBrown.Substring(4, 5));  // quick
            Console.WriteLine(quickBrown.Substring(31, 3)); // the
            Console.WriteLine(quickBrown.Substring(16, 7)); // fox jum
            Console.WriteLine(quickBrown.Substring(26)); // over the lazy dog

            Console.WriteLine(string.Join("-", "1 2 3 4 5".Split(' ')));
            // 1-2-3-4-5

            Console.WriteLine("    asduhfl   \n".Trim()); // asduhfl
            Console.WriteLine("ad fjk".Trim());           // ad fjk

            Console.ReadLine();

        }
    }
}
