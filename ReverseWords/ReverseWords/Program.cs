using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //Paired Task: Reverse Sentence Words

            Console.WriteLine("Please enter a sentence here:");

            String userSent = Console.ReadLine();
            String [] sentArray = userSent.Split(' ');
            //foreach (string word in sentArray){
            //    Console.WriteLine(word);
            //}
            Array.Reverse(sentArray);
            Console.WriteLine(string.Join(" ", sentArray));

            Console.ReadLine();

        }
    }
}
