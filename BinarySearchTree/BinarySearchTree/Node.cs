using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public int value;
        public Node leftChild;
        public Node rightChild;

        public Node(int initialValue)
        {
            value = initialValue;
            leftChild = null;
            rightChild = null;
        }

        public class Tree
        {
            public Node topOfTree;

            public Tree()
            {
                topOfTree = null;
            }

            public Tree(int initialValue)
            {
                topOfTree = new Node(initialValue);
            }
        }
    }
}
    
