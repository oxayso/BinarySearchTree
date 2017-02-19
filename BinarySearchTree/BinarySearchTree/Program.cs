using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
        class Program
    {
        static void Main(string[] args)
        {
            binaryTree binaryTree = new binaryTree(); //test

            binaryTree.Insert(51);
            binaryTree.Insert(23);
            binaryTree.Insert(40);
            binaryTree.Insert(17);
            binaryTree.Insert(39);
            binaryTree.Insert(11);
            binaryTree.Insert(44);


           
            //binaryTree.DisplayTree();

            Console.ReadLine();
        }

    }
}
