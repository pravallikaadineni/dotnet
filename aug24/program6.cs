using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace reusablecodelibrary
{
    public class program6
    {
        public static void creatingfile()
        {
            string path = @"D:\repos\filehandlingdemo\firstfile.txt";
            File.Create(path);
        }

    }
}
