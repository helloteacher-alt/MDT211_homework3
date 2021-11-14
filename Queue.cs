using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    class Queue
    {
        private Node root;
        public void Push(Node node)
        {
            if (root == null)
            {
                root = node;
            }
            else
            {
                Node ptr = root;
                while(ptr.next != null)
                {
                    ptr = ptr.next;
                }ptr.next = node;
            }
        }

        public Node Pop()
        {
            if (root == null)
            {
                return null;
            }
                Node node = root;
            root = root.next;
            node.next = null;
            return node;
        }

        public Node Get(int index)
        {
            Node node = root;
            while (index > 0)
            {
                if (node == null)
                {
                    throw new IndexOutOfRangeException();
                }
                else node = node.next;
                index--;
            }
            return node;
        }
    }
}
