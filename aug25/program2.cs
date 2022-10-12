using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug25programs
{
    internal class program2
    {
        static void Main(string[] args)
        {
            string path = @"D:\C#\FileHandlingDemo\";
            Console.WriteLine("Enter the file name");
            string fname = Console.ReadLine();

            //File.Create(path+fname);
            fname = string.Concat(path, fname);

            // File.Create(fname);
            // Console.WriteLine("file created successfully...");

            //string s = "pravalli";

            // File.WriteAllText(fname, s);
            // string k = "adineni";
            // File.AppendAllText(fname, k);
            //Console.WriteLine("file created successfully with contents...");
            // File.Copy(fname, "copiedFile.txt");
            //File.Move(fname, "MovedFile.txt");
            /*FileInfo fileInfo = new FileInfo(fname);
            Console.WriteLine(fileInfo.FullName + "  Full Name");
             Console.WriteLine(fileInfo.DirectoryName + " DirectoryName");
            Console.WriteLine(fileInfo.CreationTime);
            Console.WriteLine(fileInfo.Extension);*/
            File.Delete(fname);
            Console.WriteLine("file deleted successfully");

            Console.ReadLine();
        }
    }
}
