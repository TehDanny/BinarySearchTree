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
            Console.WriteLine("Test 1");
            bst.InsertLinearly(45);
            Console.WriteLine("Test 2");
            bst.InsertLinearly(50);
            bst.InsertLinearly(33);
            bst.InsertLinearly(1);
            bst.InsertLinearly(3000);
            bst.InsertLinearly(65);
            Console.ReadLine();
        }
    }
}
