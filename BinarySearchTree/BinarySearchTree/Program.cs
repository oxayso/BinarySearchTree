using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{

    public class Node
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

            public void Add(int initialValue)
            {
                if (topOfTree == null) //tree = empty 
                {
                    Node newNode = new Node(initialValue);
                    topOfTree = newNode;
                    return;
                }
                Node currentNode = topOfTree;
                bool added = false;
                do
                {

                    if (initialValue < currentNode.value)
                    {

                        if (currentNode.leftChild == null)
                        {
                            //value will be added
                            Node newNode = new Node(initialValue);
                            currentNode.leftChild = newNode;
                            added = true;
                        }
                        else
                        {
                            currentNode = currentNode.leftChild;
                        }
                        if (initialValue >= currentNode.value)
                        {
                            if (currentNode.rightChild == null)
                            {
                                Node newNode = new Node(initialValue);
                                currentNode.rightChild = newNode;
                                added = true;
                            }
                            else
                            {
                                currentNode = currentNode.rightChild;
                            }
                        }
                    }
                } while (!added);
            }

            public void RecursiveAdd(int initialValue)
            { //recursive
                AddRc(ref topOfTree, initialValue);
            }

            private void AddRc(ref Node node, int initialValue)
            {
                // private recursive search for where to add to node 
                if (node == null)
                {
                    Node newNode = new Node(initialValue);
                    node = newNode;
                    return;
                }
                if (initialValue >= node.value)
                {
                    AddRc(ref node.rightChild, initialValue);
                    return;
                }
            }

            public void PrintTree(Node node, ref string nodeString)
            {
                if (node == null) { node = topOfTree; }
                if (node.leftChild != null)
                {
                    PrintTree(node.leftChild, ref nodeString);
                    nodeString = nodeString + node.value.ToString().PadLeft(3);
                }
                else
                {
                    nodeString = nodeString + node.value.ToString().PadLeft(3);
                }
                if (node.rightChild != null)
                {
                    PrintTree(node.rightChild, ref nodeString);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
