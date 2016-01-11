using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            //Individual Task II
            Console.Write("Please enter date in format MM/DD/YYYY:");
            //or we can use var userDate here
            string userDate = Console.ReadLine();
            DateTime thisDate = DateTime.Parse(userDate);
            Console.WriteLine(thisDate.ToLongDateString());
            Console.WriteLine(thisDate.ToString("o"));

            Console.ReadLine();

        }
    }
}
