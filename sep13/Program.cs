using Sep13library;
using System;
//using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

namespace Sep13
{
    public class Program
    {


        
            static void Main(string[] args)
            {
            FileStream fs3 = new FileStream(@"moviedata.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs2 = new FileStream("moviedataSoap.soap", FileMode.Create, FileAccess.Write);

            FileStream fs_xml = new FileStream(@"moviexmldata.xml", FileMode.Create, FileAccess.Write);
            Movie m1 = new Movie();
                m1.AddMovieDetails("Ariya", "Telugu", "love", 100);
                Movie m2 = new Movie();
                m2.AddMovieDetails("venky", "Telugu", "comedy", 200);
                Movie m3 = new Movie();
                m3.AddMovieDetails("karthikeya2", "telugu", "Mystery", 150);
                Movie m4 = new Movie();
                m4.AddMovieDetails("RRR", "Telugu", "Action", 600);
                Movie m5 = new Movie();
                m5.AddMovieDetails("kick", "Telugu", "Comedy", 110);
                
                User u1 = new User();
                User u2 = new User();
                User u3 = new User();
                User u4 = new User();
                User u5 = new User();
                User u6 = new User();
                u1.AddUser("bhargav",  "teja", "gold");
                u2.AddUser("pravalli", "Varun", "Silver");
                u3.AddUser("nani",     "royal", "gold");
                u4.AddUser("indresh",  " nune", "platinum");
                u5.AddUser("yeshu",     "roy", "gold");
                u6.AddUser("devi",      "reddy", "Silver");
               
                u1.BorrowMovie(m1);
                u2.BorrowMovie(m1);
                u4.BorrowMovie(m1);
                Console.WriteLine("Movie 1 Availability " + m1.Availability);

            // Console.WriteLine("Movie 1 Availability " + m1.Availability);
            u2.RetrunMovie(m1, 4);
            u3.BorrowMovie(m1);
                u6.BorrowMovie(m1);
                u5.BorrowMovie(m1);
                 Console.WriteLine("Movie 1 Availability " + m1.Availability);
                 u1.BorrowMovie(m2);
                 u1.RetrunMovie(m2, 5);
                // u1.BorrowMovie(m3);
                Console.WriteLine("=================================================");
                u1.ShowMyList();
                u2.ShowMyList();
                Console.WriteLine("==================================================");
                u1.SearchByLanguage("Telugu");
                Console.WriteLine("==================================================");
                u1.SearchByGenre("mystry");
                u1.SearchByGenre("action");

            XmlSerializer xml = new XmlSerializer(typeof(User));
            xml.Serialize(fs_xml, u1);
            fs_xml.Flush();
            fs_xml.Close();
            fs_xml.Dispose();

           
            formatter.Serialize(fs3, u1);

            fs3.Flush();
            fs3.Close();
            fs3.Dispose();
            Console.ReadLine();



            //fs.Flush();
            //fs.Close();
            //fs.Dispose();
           // FileStream fs2 = new FileStream("moviedataSoap.soap", FileMode.Create, FileAccess.Write);

            SoapFormatter soap = new SoapFormatter();
            soap.Serialize(fs2, m1);
            fs2.Flush();
            fs2.Close();
            fs2.Dispose();
        
               Console.ReadLine();
            }
        




        }
    }
    