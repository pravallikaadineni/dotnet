using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Sep14library;

namespace Sep14
{
    
        internal class Program
        {
            static void Main(string[] args)
            {

                Customeruser c = new Customeruser();
                Console.WriteLine("Enter the username");
                c.username = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter the password");
                c.Password = Convert.ToInt64(Console.ReadLine());

                c.validateuser();
             FileStream fs = new FileStream(@"usersample.bin", FileMode.Create, FileAccess.Write);
              BinaryFormatter formatter = new BinaryFormatter();
             formatter.Serialize(fs, c);
           

            fs.Flush();
            fs.Close();
            fs.Dispose();
                Console.ReadLine();
            }
        }
 }




