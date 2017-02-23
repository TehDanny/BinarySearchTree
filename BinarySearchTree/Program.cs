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
            BinarySearchTree bst = new BinarySearchTree();
            bst.InsertLinearly(40);
            bst.InsertLinearly(45);
            bst.InsertLinearly(50);
            bst.InsertLinearly(33);
            bst.InsertLinearly(1);
            bst.InsertLinearly(3000);
            bst.InsertLinearly(65);
        }
    }
}
