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

        public void InsertIterarively(int value)
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

        public Node SearchInteratively(int value)
        {
            if (Root == null)
                return null;

            if (Root.Data == value)
                return Root;

            Node currentNode = Root;
            Node parentNode = null;

            while (currentNode != null)
            {
                parentNode = currentNode;
                if (value == currentNode.Data)
                    return currentNode;
                else if (value < currentNode.Data)
                    currentNode.Left = currentNode;
                else
                    currentNode.Right = currentNode;
            }
            return null;
        }

        public Node SearchRecursively(int value)
        {
            if (Root == null)
                return null;

            Node currentNode = Root;

            return SearchRecursively(value, currentNode);
        }

        public Node SearchRecursively(int value, Node currentNode)
        {
            if (currentNode == null)
                return null;

            if (value == currentNode.Data)
                return currentNode;
            else if (value < currentNode.Data)
                SearchRecursively(value, currentNode.Left);
            else
                SearchRecursively(value, currentNode.Right);

            return null;
        }

        public void DeleteIteratively()
        {

        }

        public void DeleteRecursively()
        {

        }
    }
}
