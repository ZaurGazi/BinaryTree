using System;

namespace BinaryTree
{
    class TreeNode
    {
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public int Data { get; set; }
    }
    class BinaryTree
    {
        TreeNode Root = null;

        public bool Add(int data)
        {
            TreeNode before = null; TreeNode after = this.Root;

            while (after != null)
            {
                before = after;
                if (after.Data < data)
                {
                    after = after.Right;

                }
                else after = after.Left;

            }

            TreeNode node = new TreeNode();
            node.Data = data;

            if (this.Root == null)
            {
                this.Root = node;
            }
            else
            {
                if (before.Data < data)
                {
                    before.Right = node;
                }
                else
                {
                    before.Left = node;
                }
            }

            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Add(1);
            tree.Add(5);
            tree.Add(3);
            tree.Add(9);
            Console.WriteLine("Tree Build");
        }
    }
}
