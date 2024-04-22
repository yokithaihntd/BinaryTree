using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical9
{
    internal class Program
    {
        class Node
        {
            public int Key;
            public Node Left, Right;

            public Node(int item)
            {
                Key = item;
                Left = Right = null;
            }
        }

        class BinaryTree
        {
            Node root;

            BinaryTree()
            {
                root = null;
            }

            void Insert(int key)
            {
                root = InsertRec(root, key);
            }

            Node InsertRec(Node root, int key)
            {
                if (root == null)
                {
                    root = new Node(key);
                    return root;
                }

                if (key < root.Key)
                    root.Left = InsertRec(root.Left, key);
                else if (key > root.Key)
                    root.Right = InsertRec(root.Right, key);

                return root;
            }

            void Inorder()
            {
                InorderRec(root);
            }

            void InorderRec(Node root)
            {
                if (root != null)
                {
                    InorderRec(root.Left);
                    Console.Write(root.Key + " ");
                    InorderRec(root.Right);
                }
            }
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                BinaryTree tree = new BinaryTree();
                int[] keys = { 50, 30, 20, 40, 70, 60, 80 };

                foreach (var key in keys)
                {
                    tree.Insert(key);
                }

                Console.WriteLine("Неупорядкований обхід побудованого бінарного дерева:");
                tree.Inorder();
            }
        }
    }
}
