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
            bst.InsertIteratively(40);
            Console.WriteLine("Test 1");
            bst.InsertIteratively(45);
            Console.WriteLine("Test 2");
            bst.InsertIteratively(50);
            bst.InsertIteratively(33);
            bst.InsertIteratively(1);
            bst.InsertIteratively(3000);
            bst.InsertIteratively(65);
            Console.ReadLine();
        }
    }
}
