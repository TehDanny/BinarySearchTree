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

        public bool SearchLinearly(int value)
        {
            if (Root == null)
                return false;

            if (Root.Data == value)
                return true;

            Node nextNode = Root;
            Node parentNode = null;

            while (nextNode != null)
            {
                parentNode = nextNode;
                if (value == nextNode.Data)
                    return true;
                else if (value < nextNode.Data)
                    nextNode.Left = nextNode;
                else
                    nextNode.Right = nextNode;
            }
            return false;
        }

        public bool SearchRecursively(int value)
        {
            if (Root == null)
                return false;

            Node currentNode = Root;

            SearchRecursively(value, currentNode);
            return false;
        }

        public bool SearchRecursively(int value, Node currentNode)
        {


            return false;
        }
    }
}
