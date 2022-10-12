using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace assitedprojects
{
    public class doublylinkedlist
    {
        private dllNode root = null;
        private dllNode current = null;
        private int length;

        public dllNode Root
        {
            get { return this.root; }
            set { this.root = value; }
        }

        public int Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        public void add(dllNode dnode)
        {
            dnode.Next = null;
            if (root == null)
            {
                root = dnode;
                length = 1;
                current = root;
                root.Prev = null;
            }
            else
            {
                current.Next = dnode;
                dnode.Prev = current;
                current = dnode;
                length++;
            }
        }

        public dllNode getCurrent()
        {
            return this.current;
        }

        public dllNode getRoot()
        {
            current = root;
            return this.root;
        }

        public dllNode getNext()
        {
            if (current.Next != null)
            {
                current = current.Next;
                return current;
            }
            else
                return null;
        }

        public dllNode getPrev()
        {
            if (current.Prev != null)
            {
                current = current.Prev;
                return current;
            }
            else
                return null;
        }

        public int getLengthOfList()
        {
            return this.length;
        }
    }

}

