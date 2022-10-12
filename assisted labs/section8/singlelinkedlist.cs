using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assitedprojects
{
    public class singlelinkedlist
    {
        private sllNode root = null;
        private sllNode current = null;
        private int length;

        public sllNode Root
        {
            get { return this.root; }
            set { this.root = value; }
        }

        public int Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        public void add(sllNode node)
        {
            node.Next = null;
            if (root == null)
            {
                root = node;
                length = 1;
                current = root;
            }
            else
            {
                current.Next = node;
                current = node;
                length++;
            }
        }

        public sllNode getCurrent()
        {
            return this.current;
        }

        public sllNode getRoot()
        {
            current = root;
            return this.root;
        }

        public sllNode getNext()
        {
            if (current.Next != null)
            {
                current = current.Next;
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
