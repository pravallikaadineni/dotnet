using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assitedprojects
{
    public class sllprogram
    {
        
            static void Main(string[] args)
            {
                runApp();
            }

            public static void runApp()
            {
                singlelinkedlist list = new singlelinkedlist();
                sllNode n = new sllNode();
                n.Data = "root";
                list.add(n);
                for (int i = 0; i < 10; i++)
                {
                    sllNode node = new sllNode();
                    node.Data = Convert.ToString(i);
                    list.add(node);
                }

                Console.WriteLine("length of singly linked list=" + list.getLengthOfList());

                n = list.getRoot();
                while (n != null)
                {
                    Console.WriteLine(n.Data);
                    n = list.getNext();
                }
            }
        }

    }


