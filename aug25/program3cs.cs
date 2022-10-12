using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug25programs
{
    internal class program3cs
    {
        static void Main(string[] args)
        {
            string root = @"D:\repos\filehandlingdemo\Results";

            // If directory does not exist, create it.  
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            else
            {
                Console.WriteLine("already exists");
            }
            string subdir1 = @"D:\repos\filehandlingdemo\Results\Results 17-18";
            if (!Directory.Exists(subdir1))
            {
                Directory.CreateDirectory(subdir1);
            }
            string subdir2 = @"D:\repos\filehandlingdemo\Results\Results 18-19";
            if (!Directory.Exists(subdir2))
            {
                Directory.CreateDirectory(subdir2);
            }
            string subdir3 = @"D:\repos\filehandlingdemo\Results\Results 20-21";
            if (!Directory.Exists(subdir3))
            {
                Directory.CreateDirectory(subdir3);
            }
            string[] dirs = Directory.GetDirectories(root);
            foreach (var item in dirs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
