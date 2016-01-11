using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PlayMovieQuotes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework 1/11/2015: Play movie quotes .wav files
            SoundPlayer soundClip1 = new SoundPlayer("http://www.wavsource.com/snds_2016-01-10_6357263721580594/movie_stars/schwarzenegger/mother_talk.wav");
            SoundPlayer soundClip2 = new SoundPlayer("http://www.wavsource.com/snds_2016-01-10_6357263721580594/movie_stars/monroe/diamonds.wav");
            SoundPlayer soundClip3 = new SoundPlayer("http://www.wavsource.com/snds_2016-01-10_6357263721580594/movie_stars/eastwood/make_my_day.wav");

            var soundArray = new [] {
                soundClip1, soundClip2, soundClip3
            };

            Random rand = new Random();

            var pick = rand.Next(3);

            soundArray[pick].Load();
            soundArray[pick].Play();


            //switch (pick)
            //{
            //    case 1:
            //        soundClip1.Load();
            //        soundClip1.Play();
            //        break;

            //    case 2:
            //        soundClip2.Load();
            //        soundClip2.Play();
            //        break;

            //    case 3:
            //        soundClip3.Load();
            //        soundClip3.Play();
            //        break;

        //}
        //to pause
        Console.ReadLine();
        }
    }
}
