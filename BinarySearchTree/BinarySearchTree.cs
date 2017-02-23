using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        public Node Root;

        public BinarySearchTree()
        {
            
        }

        public void InsertLinearly(int value)
        {
            if (Root == null)
            {
                Root = new Node();
                Root.Data = value;
                return;
            }

            Node newNode = new Node();
            newNode.Data = value;
            Node nextNode = Root;
            Node parent = null;

            while (nextNode!=null)
            {
                parent = nextNode;
                if (value < nextNode.Data)
                    nextNode= nextNode.Left;
                else
                    nextNode = nextNode.Right;
            }
            if (value < parent.Data)
                parent.Left = newNode;
            else
                parent.Right = newNode;
        }

        public void InsertRecursively(int value)
        {
            if (Root == null)
            {
                Root.Data = value;
                return;
            }
            InsertRecursively(value, Root);
        }

        private void InsertRecursively(int value, Node currentNode)
        {
            if (value < currentNode.Data)
            {
                if (currentNode.Left == null)
                {
                    currentNode.Left = new Node();
                    currentNode.Left.Data = value;
                }
                else
                {
                    InsertRecursively(value, currentNode.Left);
                }
            }
            else
            {
                if (currentNode.Right == null)
                {
                    currentNode.Right = new Node();
                    currentNode.Right.Data = value;
                }
                else
                {
                    InsertRecursively(value, currentNode.Right);
                }
            }
        }

        public void SearchLinearly()
        {

        }

        public void SearchRecursively()
        {

        }
    }
}
