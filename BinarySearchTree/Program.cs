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
            bst.InsertIteratively(20);
            bst.InsertIteratively(50);
            Console.WriteLine("Iterative insert works.");
            bst.InsertRecursively(33);
            bst.InsertRecursively(1);
            bst.InsertRecursively(3000);
            bst.InsertRecursively(65);
            Console.WriteLine("Recursive insert works.");

            Node node1 = bst.SearchIteratively(33);
            Console.WriteLine("Search iteratively test: {0}", node1.Data);
            Node node2 = bst.SearchRecursively(1);
            Console.WriteLine("Search recursively test: {0}", node2.Data);

            Console.WriteLine("High value iterative test: {0}", bst.FindHighestValueIteratively());
            Console.WriteLine("High value recursive test: {0}", bst.FindHighestValueRecursively());

            Console.ReadLine();
        }
    }
}
