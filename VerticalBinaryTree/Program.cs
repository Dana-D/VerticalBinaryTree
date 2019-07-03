using System;

namespace VerticalBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.left.left = new Node(3);
            root.right = new Node(4);
            root.right.right = new Node(5);

            root.verticalPrint();
        }
    }

    class Node
    {
        public Node left;
        public Node right;
        public int value;

        public Node(int v)
        {
            value = v;
        }

        public void verticalPrint()
        {
            printHelper(this);
        }

        public void printHelper(Node node)
        {
            if(node.left == null && node.right == null)
            {
                Console.WriteLine(node.value);
            }
            if(node.left != null)
            {
                printHelper(node.left);
                Console.WriteLine(node.value);
            }
            if(node.right != null)
            {
                printHelper(node.right);
                Console.WriteLine(node.value);
            }
        }
    }
}
