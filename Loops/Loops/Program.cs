using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            var studentCount = 24;
            var seatCount = 20;
            seatCount += 5;
            studentCount++;

            if (seatCount >= studentCount) {
                Console.WriteLine("We have enough seats!");
            }
            else {
                Console.WriteLine("Oh no! Not enough seats!");
            }


            //if (args[0] == "cat") {
            //    Console.WriteLine("yay kittens");
            //}
            //else if (args[0] == "dog") {
            //    Console.WriteLine("yay dogs");
            //}
            ////Ternary Operators
            //Console.WriteLine(args[0] == "cat" ? "yay kittens" : "yay dogs");


            int a = 10;
            //post-increment
            Console.WriteLine(a++);
            //pre-increment
            Console.WriteLine(++a);


            //Display all numbers less than 100 which are divisible by seven without a remainder

            for (int i = 0; i < 100; i++) {
                if (i % 7 == 0) {
                    Console.WriteLine(i);
                }
            }


            Console.ReadLine();

        }
    }
}
