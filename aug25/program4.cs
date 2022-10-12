using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug25programs
{
    internal class program4
    {
        static void Main(string[] args)
        {
           
            var drv = DriveInfo.GetDrives();
            foreach (DriveInfo dInfo in drv)
            {
                Console.WriteLine(dInfo.Name);
            }
        }
    }
}
