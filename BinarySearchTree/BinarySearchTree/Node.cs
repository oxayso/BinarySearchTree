using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
   public class Node
    {
        public int contents;
        public Node leftChild;
        public Node rightChild;
        public Node(int value)
        {
            contents = value;
            leftChild = null;
            rightChild = null;
        }

        public void AddContents(int value)
        {
            if (contents > value)
            {
                AddChildren(value);
            }
            else if (contents < value)
            {
                AddChildren(value);
            }

        }

        public void AddChildren(int value)
        {
            if (leftChild == null)
            {
                leftChild = new Node(value);
            }
            else
            {
                leftChild.AddContents(value);
            }
            if (rightChild == null)
            {
                rightChild = new Node(value);
            }
            else
            {
                rightChild.AddContents(value);
            }
        }
            public void DisplayTree(Node node)
        {
            if (node == null)
            {
                return;
            }

            DisplayTree(node.leftChild);

            DisplayTree(node.rightChild);
        }       
    }
}
    
