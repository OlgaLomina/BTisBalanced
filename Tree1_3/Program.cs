using System;
//Tree1 Problems
// 3. Determine if a binary tree is balanced
/* An empty tree is height-balanced. A non-empty binary tree T is balanced if:
1) Left subtree of T is balanced
2) Right subtree of T is balanced
3) The difference between heights of left subtree and right subtree is not more than 1.
 * */
namespace Tree1_3
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int val)
        {
            data = val;
            left = null;
            right = null;
        }
    }

    public class BinaryTree
    {
        public Node root;
        public BinaryTree()
        {
            root = null;
        }

        public int IsBalanced(Node root)
        {
            if (root == null)
               return 0;

            int leftH = IsBalanced(root.left);
            if (leftH == -1)
            {
                return -1;
            }
            int rightH = IsBalanced(root.right);
            if (rightH == -1)
            {
                return -1;
            }
            int diff = leftH - rightH;
            if (Math.Abs(diff) > 1)
            {
                return -1;
            }
            return 1 + Math.Max(leftH, rightH);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(50);
            root.left = new Node(25);
            root.right = new Node(70);
            root.left.left = new Node(10);
            root.left.right = new Node(40);
            root.left.right.left = new Node(30);
            //root.right.left = new Node(60);
            /*root.right.left.right = new Node(65);
            root.right.left.right.left = new Node(62);*/
            //root.right.right = new Node(80);
            //root.right.right.right = new Node(90);

            BinaryTree tree = new BinaryTree();

            int result = tree.IsBalanced(root);
            if (result >= 0)
            {
                Console.WriteLine("A binary tree is balanced");
            }
            else
            {
                Console.WriteLine("A binary tree is NOT balanced");
            }
        }
    }
}
