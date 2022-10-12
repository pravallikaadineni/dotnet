using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Sep12attributes
{

    [StereoDisc("hammahamma", "Telugu" , "hahaha")]
    public class Song
    {
        [StereoDisc("i think about u", "English" ,  " sometimes i think about u latenights in the middle of the june")]
        public string Name { get; set; }

        [StereoDisc("neney nani", "telugu", "neney nani neney naniney")]
        public Song()
        {
            Console.WriteLine("Song Default Constructor");
        }
    }
}