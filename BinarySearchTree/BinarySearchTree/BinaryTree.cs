using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class binaryTree
    {
        public Node topOfTree;

        public void Insert(int value)
        {
            if (topOfTree == null)
            {
                topOfTree = new Node(value);
            }
            else
            {
                topOfTree.AddContents(value);
            }
        }

        //public void DisplayTree()
        //{
        //    if (topOfTree == null)
        //    {
        //        Console.WriteLine("Empty Tree");
        //    }
        //    else
        //    {
        //        //topOfTree.DisplayTree(node);
        //    }
        //}

    }      
    
}

