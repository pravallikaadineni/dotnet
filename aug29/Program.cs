using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug29
{
    internal class Program
    {
        
            public class GenericNode<s>
        {
            public s data;
            public GenericNode<s> nextNode = null;

            public GenericNode(s data)
            {
                this.data = data;
            }
        }

        // generic linked list
        public class GenericLinkedList<s>
        {
            private GenericNode<s> head = null;

            public void Add(s newListItem)
            {
                if (head == null)
                {
                    head = new GenericNode<s>(newListItem);
                }
                else
                {
                    GenericNode<s> curr = head;
                    while (curr.nextNode != null)
                    {
                        curr = curr.nextNode;
                    }
                    curr.nextNode = new GenericNode<s>(newListItem);
                }
            }

            public void DisplayNodes()
            {
                GenericNode<s> curr = head;
                while (curr != null)
                {
                    System.Console.WriteLine(curr.data);
                    curr = curr.nextNode;
                }
            }
        }

        class TestGenericLinkedList
        {
            static void Main(string[] args)
            {
                GenericLinkedList<System.Object > rrr = new GenericLinkedList<System.Object>();
                rrr.Add(401);
                rrr.Add(45.251);
                rrr.Add("pravalli");
                rrr.Add(true);
                rrr.DisplayNodes();
                Console.ReadLine();
            }
        }
    }
}

    

