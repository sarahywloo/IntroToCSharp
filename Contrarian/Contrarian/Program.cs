using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrarian {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Tell me about what you like or dislike. Eg. 'I like...' or 'I don't like...'");

            String aboutUser = Console.ReadLine();

            if(aboutUser.Contains("don't like")) {
                var response = aboutUser.Replace("don't like", "like");
                Console.WriteLine(response);
            } 
            else if (aboutUser.Contains("do not like")) {
                var response = aboutUser.Replace("do not like", "like");
                Console.WriteLine(response);
            }
            else {
                var response = aboutUser.Replace("like", "don't like");
                Console.WriteLine(response);
            }

            Console.ReadLine();
        }
    }
}
