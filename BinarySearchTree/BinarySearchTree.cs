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
            Root = new Node();
        }

        public void InsertLinearly(int value) // I dislike having two while loops here, but I haven't come up with anything better
        {
            if (Root == null)
            {
                Root.Data = value;
                return;
            }

            Node newNode = new Node();
            newNode.Data = value;
            Node nextNode = Root;

            while (nextNode!=null)
            {
                if (value < nextNode.Data)
                    nextNode.Left = nextNode;
                if (value > nextNode.Data)
                    nextNode.Right = nextNode;
            }
            nextNode = newNode;
        }

        public void InsertRecursively()
        {

        }

        public void SearchLinearly()
        {

        }

        public void SearchRecursively()
        {

        }
    }
}
