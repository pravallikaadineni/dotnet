using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static aug29ps2.Class1;

namespace aug29ps2
{
    public class Program
    {
       
            static void Main(string[] args)
            {
                UserDataStore<string> stringdata = new UserDataStore<string>();
                stringdata.AddOrEdit(0, "welcome");
                string printdata = stringdata.ReturnData(0);
                Console.WriteLine(printdata);
                Console.WriteLine("-------------------");
                stringdata.AddOrEdit(0, "hii");
                stringdata.AddOrEdit(0, "generic classes");
                stringdata.AddOrEdit(1, "welcome to c# programming");
                stringdata.AddOrEdit(2, "generic methods");  
                stringdata.ShowData(0);
                stringdata.ShowData(1);
                stringdata.ShowData(2);



            Console.ReadLine();

            }
        }
    }

    

