using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        //args are line arguements that we will pass into the method
        //main is the static method
        static void Main(string[] args)
        {
            //the main method, this line of code will be the first to run to start the programme
            //TypeScript is console.log
            //C# strings MUST be in doubnle quotes!
            Console.WriteLine("Hello World!");

            //TypeScript: Math.random() - [0,1)
            //type of variable goes before the variable name
            //TS variables: let varName: type
            //C# variables: type varName
            Random rand = new Random(); //var rand = new Random();
            var myNum = rand.Next();
            Console.WriteLine(myNum);
            myNum = rand.Next(10); //max value will be 10, so you only get values from 0 - 10
            Console.WriteLine(myNum);
            myNum = rand.Next(5, 10); //max value will be 10, so you only get values from 0 - 10
            Console.WriteLine(myNum);

            //To get the maximum random value possible
            Console.WriteLine(int.MaxValue);
            //To get the minimum random value possible
            Console.WriteLine(int.MinValue);

            //Individual Task I: Display the current time.
            DateTime value = DateTime.Now;
            Console.WriteLine(value);
            Console.WriteLine(value.ToString()); //no difference because C# will automatically call ToString

            //myNum = rand.Next(20);
            Debug.Assert(myNum >= 5 && myNum <10, "Oops! MyNum is out of range :("); //doesn't work here because Debug exists in a different namespace, use ctrl period to choose use system diagnostics
            
            //C# data types
            bool blah = true; //equivalent to a Boolean object
            int stairs = 8; //equivalent to Int32
      
            //get first number
            Console.Write("Enter the first number:");
            string input1 = Console.ReadLine();
            int firstNum;

            if (int.TryParse(input1, out firstNum))
            {
                //get second number
                Console.Write("Enter the second number:");
                int secondNum;
                if (int.TryParse(Console.ReadLine(), out secondNum)){
                    //display result
                    var result = firstNum + secondNum;
                    Console.WriteLine("The result is " + result);
                }
            }



            //// get second number
            //Console.Write("Enter the second number:");
            //var secondNum = int.Parse(Console.ReadLine());

            //// display result
            //var result = firstNum + secondNum;
            //Console.WriteLine("The result is " + result.ToString());

            // pause
            //TypeScript: Prompt()
            Console.ReadLine();
        }
    }
}
