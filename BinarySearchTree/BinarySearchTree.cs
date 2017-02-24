using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        public class Node // I'm getting errors when setting this class to private and I don't understand why
        {
            public Node Left;
            public Node Right;
            public int Data;
        }

        private Node Root;

        public void InsertIteratively(int value)
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

            while (nextNode != null)
            {
                parent = nextNode;
                if (value < nextNode.Data)
                    nextNode = nextNode.Left;
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

        public void DeleteIteratively(int value) // not complete. I don't know how to write this without ref and I don't know how to use ref
        {
            if (Root == null)
                throw new Exception();

            Node currentNode = Root;
            Node parentNode = null;

            if (Root.Data == value) // dublicate code, but only way to delete Root without somehow using the ref keyword
            {
                if (Root.Left == null && Root.Left == null)
                {
                    Root = null;
                    return;
                }
                else if (Root.Left != null && Root.Right == null)
                {
                    Root = Root.Left;
                    return;
                }
                else if (Root.Left == null && Root.Right != null)
                {
                    Root = Root.Right;
                    return;
                }
                else if (Root.Left != null && Root.Right != null)
                {
                    // I don't know how to continue from here

                    //Node tempLeftNode = Root.Left;
                    //Node tempRightNode = Root.Right;
                }
            }
            else if (Root.Data < value)
            {
                currentNode = currentNode.Left;
            }
            else
            {
                currentNode = currentNode.Right;
            }

            while (currentNode != null)
            {
                if (currentNode.Data == value)
                {
                    if (currentNode.Left == null && currentNode.Left == null)
                    {
                        currentNode = null;
                        return;
                    }
                    else if (currentNode.Left != null && currentNode.Right == null)
                    {
                        currentNode = currentNode.Left;
                        return;
                    }
                    else if (currentNode.Left == null && currentNode.Right != null)
                    {
                        currentNode = currentNode.Right;
                        return;
                    }
                    else if (currentNode.Left != null && currentNode.Right != null)
                    {
                        // I don't know how to continue from here

                        //Node tempLeftNode = currentNode.Left;
                        //Node tempRightNode = currentNode.Right;
                    }
                }
                else if (currentNode.Data < value)
                {
                    currentNode = currentNode.Left;
                }
                else
                {
                    currentNode = currentNode.Right;
                }
            }

            if (currentNode == null)
                throw new Exception();
        }

        public void DeleteRecursively(int value)
        {

        }

        public void DeleteRecursively(int value, Node currentNode)
        {

        }
    }
}
