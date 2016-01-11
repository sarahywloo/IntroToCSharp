using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNewsWithArray
{
    class Program
    {
        static void Main(string[] args)
        {

            //Individual Task IV
            var news = new string [] {
                "Martians Attack!", "Seahawks win Superbowl!", "Random News Headline!"
            };

            Random rand = new Random();

            var randNum = rand.Next(news.Length);

            var randNews = news[randNum];

            Console.WriteLine(randNews);

            Console.ReadLine();
        }
    }
}
