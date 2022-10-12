using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace aug25programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\repos\filehandlingdemo\";
            Console.WriteLine("Enter the file name");
            string fname = Console.ReadLine();


            fname = string.Concat(path, fname);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1.Create  2.Add  3.Edit  4.Truncate ");
            int choice = Convert.ToInt32(Console.ReadLine());
            FileStream s1 = null;
            StreamWriter sw = null;
            switch (choice)
            {
                case 1:
                    FileStream f = new FileStream(fname, FileMode.Create);
                    break;
                case 2:

                    try
                    {
                        s1 = new FileStream($"{fname}", FileMode.Create, FileAccess.Write);
                        sw = new StreamWriter(s1);
                        Console.Write("Enter the contents:");
                        string s = Console.ReadLine();
                        sw.Write(s);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        sw.Flush();

                        s1.Flush();
                        sw.Close();
                        s1.Close();
                        sw.Dispose();
                        s1.Dispose();
                    }
                    break;
                case 3:
                    FileStream fs = null;
                    StreamWriter ss = null;
                    try
                    {
                        fs = new FileStream(fname, FileMode.Append);
                        ss = new StreamWriter(fs);
                        ss.WriteLine("tinara frnds :)");


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        ss.Close();
                        fs.Close();
                        Console.WriteLine(" append  successfully...");
                    }
                    break;
                case 4:
                    FileStream fs1 = new FileStream(fname, FileMode.Truncate);
                    StreamWriter ss1 = new StreamWriter(fs1);
                    break;
                default:
                    Console.WriteLine("Enter a Valid Input");
                    break;
            }
            Console.ReadLine();





        }
    }
}
        
