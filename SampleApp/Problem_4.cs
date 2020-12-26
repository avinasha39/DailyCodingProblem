////Given the root to a binary tree, implement serialize(root), which serializes the tree into a string, 
//and deserialize(s), which deserializes the string back into the tree.

//For example, given the following Node class

//class Node :
//    def __init__(self, val, left=None, right=None):
//        self.val = val
//        self.left = left
//        self.right = right
//The following test should pass:

//node = Node('root', Node('left', Node('left.left')), Node('right'))
//assert deserialize(serialize(node)).left.left.val == 'left.left'

using System;

namespace SampleApp
{
    /// <summary>
    ///     Defining node of tree
    /// </summary>
    class Node
    {
        public int key;
        public Node left, right;

        public Node(int key)
        {
           this.key = key;
           this.left = this.right = null;
        }
    }

    internal class Problem_4 
    {
        public void Solve()
        {
            Node rootNode = null;
            rootNode = addNode(rootNode, 10, true);
            rootNode = addNode(rootNode, 5, true);
            rootNode = addNode(rootNode, 20, true);
            rootNode = addNode(rootNode, 3, true);
            rootNode = addNode(rootNode, 8, true);
            rootNode = addNode(rootNode, 7, true);

            printTreePreOrder(rootNode);
            Console.WriteLine();
            Console.ReadLine();


            String str = Serialize(rootNode);
            Console.WriteLine(str);
            Console.ReadLine();

            Node start = Deserialize(str);
            Console.WriteLine(start.key);
            printTreePreOrder(start);
            Console.ReadLine();
        }

        private static Node addNode(Node rootNode, int i, bool isRootNode)
        {
            if (rootNode == null)
            {
                return new Node(i);
            }
            else
            {
                if (i > rootNode.key)
                {
                    if (isRootNode)
                    {
                        Node nodeToAdd = addNode(rootNode.right, i, isRootNode);
                        rootNode.right=(nodeToAdd);
                    }
                    else
                    {
                        Node nodeToAdd = addNode(rootNode.left, i, isRootNode);
                        rootNode.left = (nodeToAdd);
                    }

                }
                else
                {
                    if (isRootNode)
                    {
                        Node nodeToAdd = addNode(rootNode.left, i, isRootNode);
                        rootNode.left = (nodeToAdd);
                    }
                    else
                    {
                        Node nodeToAdd = addNode(rootNode.right, i, isRootNode);
                        rootNode.right = (nodeToAdd);
                    }
                }
            }
            return rootNode;
        }

        private void printTreePreOrder(Node node)
        {
            if(node == null)
            {
                return;
            }
            Console.Write(node.key + " ");
            printTreePreOrder(node.left);
            printTreePreOrder(node.right);
        }

        private string Serialize(Node rootnode)
        {
            if(rootnode == null)
            {
                return "null,";
            }
            string str ="";

            str += rootnode.key;
            str += ",";

            str += Serialize(rootnode.left);
            str += Serialize(rootnode.right);

            return str;
        }

        private Node Deserialize(string str)
        {
            String[] temp = str.Split(',');
            return deserializeUsingStaticCounter(temp);
        }

        static int index;
        private Node deserializeUsingStaticCounter(string[] data)
        {
            if (index > data.Length || data[index] == "null")
            {
                index++;
                return null;
            }

            Node node = new Node(int.Parse(data[index++]));
            node.left = (deserializeUsingStaticCounter(data));
            node.right = (deserializeUsingStaticCounter(data));

            return node;
        }


    }
}
