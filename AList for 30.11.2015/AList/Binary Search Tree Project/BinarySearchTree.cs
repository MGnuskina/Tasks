using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree_Project
{
    public class BinarySearchTree
    {
        public class Node
        {
            public int value;
            public Node left;
            public Node right;

            public Node(int val, Node l, Node r)
            {
                value = val;
                left = l;
                right = r;
            }

            public Node(int val) : this(val, null, null) { }

            public Node() : this(0, null, null) { }
        }
        public Node treeRoot;

        public void Clear()
        {
            treeRoot = null;
        }

        public void Add(int value)
        {
            if (treeRoot == null)
            {
                treeRoot = new Node(value);
            }
            else
            {
                Node nodeNow = FindNode(value, treeRoot);
                if (value < nodeNow.value)
                {
                    nodeNow.left = new Node(value);
                }
                else
                {
                    if (value > nodeNow.value)
                    {
                        nodeNow.right = new Node(value);
                    }
                    else
                    {
                        throw new ArgumentException("This element already exists!");
                    }
                }
            }
        }

        public void Del(int value)
        {
            if (treeRoot == null)
            {
                throw new NullReferenceException("The tree is empty!");
            }

            Node nodeToDel = FindNode(value, treeRoot);
            Node parent = FindParent(nodeToDel, treeRoot);

            if (nodeToDel.right == null && nodeToDel.left == null)
            {
                if (parent.right == nodeToDel)
                {
                    parent.right = null;
                }
                else
                {
                    if (parent.right == null && parent.left == null)
                    {
                        treeRoot = null;
                    }
                    else
                    {
                        parent.left = null;
                    }
                }
            }
            else
            {
                if (nodeToDel.right == null)
                {
                    if (parent.right == nodeToDel)
                    {
                        parent.right = nodeToDel.left;
                    }
                    else
                    {
                        parent.left = nodeToDel.left;
                    }
                }
                else
                {
                    if (nodeToDel.left == null)
                    {
                        if (parent.right == nodeToDel)
                        {
                            parent.right = nodeToDel.right;
                        }
                        else
                        {
                            parent.left = nodeToDel.right;
                        }
                    }
                    else
                    {
                        int tmp = nodeToDel.right.value;//
                        Del(tmp);
                        nodeToDel.value = tmp;
                    }
                }
            }
        }

        public void Init(int[] array)
        {
            if (array.Length > 0)
            {
                treeRoot = new Node(array[0]);
                for (int i = 1; i < array.Length; i++)
                {
                    Add(array[i]);
                }
            }
        }

        public int[] ToArray()
        {
            int size = Size();
            int[] res = new int[size];
            int i = 0;
            if (size > 0)
            {
                FindElements(treeRoot, ref res, ref i);
            }
            return res;
        }

        public string TreeToString()
        {
            return ToArray().ToString();
        }

        public int Size()
        {
            int size = 0;
            if (treeRoot != null)
            {
                FindSize(treeRoot, ref size);
            }
            return size;
        }

        public int Nodes()
        {
            return Size() - Leafs();
        }

        public int Leafs()
        {
            int res = 0;
            FindLeafsCount(treeRoot, ref res);
            return res;
        }

        public int Height()
        {
            return FindHeight(treeRoot);
        }

        public int Width()
        {
            int height = Height();
            int maxWidth = 0;
            int width;
            for (int i = 0; i <= height; i++)
            {
                width = FindWidth(treeRoot, i);
                if (width > maxWidth)
                {
                    maxWidth = width;
                }
            }
            return maxWidth;
        }

        public void Reverse()
        {
            Reverse(treeRoot);
        }

        private bool CheckIfNodeExists(Node node, Node[] passedNodes, int j)
        {
            bool res = false;
            int i = 0;
            while (i <= j && res == false)
            {
                if (passedNodes[i] == node)
                {
                    res = true;
                }
            }
            return res;
        }

        private Node FindNode(int value, Node nodeNow)
        {
            if (value < nodeNow.value && nodeNow.left != null)
            {
                nodeNow = FindNode(value, nodeNow.left);
            }
            else
            {
                if (value > nodeNow.value && nodeNow.right != null)
                {
                    nodeNow = FindNode(value, nodeNow.right);
                }
            }
            return nodeNow;
        }

        private void FindSize(Node nodeNow, ref int size)
        {
            size++;
            if (nodeNow.left != null)
            {
                FindSize(nodeNow.left, ref size);
            }
            if (nodeNow.right != null)
            {
                FindSize(nodeNow.right, ref size);
            }
        }

        private void FindElements(Node nodeNow, ref int[] elements, ref int i)
        {
            if (nodeNow.left != null)
            {
                FindElements(nodeNow.left, ref elements, ref i);
                elements[i] = nodeNow.value;
                i++;
            }
            else
            {
                elements[i] = nodeNow.value;
                i++;
            }
            if (nodeNow.right != null)
            {
                FindElements(nodeNow.right, ref elements, ref i);
            }
        }

        private bool CheckArrayExist(int[] elements, int size, int value)
        {
            bool used = false;
            for (int j = 0; j < size; j++)
            {
                if (elements[j] == value)
                {
                    used = true;
                }
            }
            return used;
        }

        private void FindNodeCount(Node nodeNow, ref int countNodes)
        {
            if (nodeNow.left != null)
            {
                FindNodeCount(nodeNow.left, ref countNodes);
                countNodes++;
            }
            if (nodeNow.right != null)
            {
                FindNodeCount(nodeNow.right, ref countNodes);
                countNodes++;
            }
        }

        private void FindLeafsCount(Node nodeNow, ref int countLeafs)
        {
            if (nodeNow.left == null && nodeNow.right == null)
            {
                countLeafs++;
            }
            if (nodeNow.left != null)
            {
                FindLeafsCount(nodeNow.left, ref countLeafs);
            }
            if (nodeNow.right != null)
            {
                FindLeafsCount(nodeNow.right, ref countLeafs);
            }
        }

        private int FindHeight(Node nodeNow)
        {
            if (nodeNow == null)
            {
                return 0;
            }
            int left, right;
            left = FindHeight(nodeNow.left);
            right = FindHeight(nodeNow.right);
            if (left > right)
            {
                return left + 1;
            }
            else
            {
                return right + 1;
            }
        }

        private int FindWidth(Node nodeNow, int level)
        {
            if (nodeNow == null)
            {
                return 0;
            }
            if (level == 1)
            {
                return 1;
            }
            else
            {
                if (level > 1)
                {
                    return FindWidth(nodeNow.left, level - 1) + FindWidth(nodeNow.right, level - 1);
                }
                else
                {
                    return 0;
                }
            }
        }

        private void Reverse(Node nodeNow)
        {
            if (nodeNow != null)
            {
                Node tmpNode = nodeNow.left;
                nodeNow.left = nodeNow.right;
                nodeNow.right = tmpNode;

                if (nodeNow.left != null)
                {
                    Reverse(nodeNow.left);
                }
                if (nodeNow.right != null)
                {
                    Reverse(nodeNow.right);
                }
            }
        }

        private Node FindParent(Node nodeToFind, Node nodeNow)
        {
            if (nodeNow.left != null && nodeToFind != nodeNow.left && nodeToFind.value < nodeNow.value)
            {
                nodeNow = FindParent(nodeToFind, nodeNow.left);
            }
            if (nodeNow.right != null && nodeToFind != nodeNow.right && nodeToFind.value > nodeNow.value)
            {
                nodeNow = FindParent(nodeToFind, nodeNow.right);
            }
            return nodeNow;
        }

        public void ReturnTree(ref int[,] tree, ref bool[,] isUsed)///////
        {
            int i = 0;
            int j = (int)(Math.Pow(2,Height()-2))+1;
            GetTree(ref tree, ref isUsed,  ref i, ref j, treeRoot, Height());
        }

        private void GetTree(ref int[,] tree,ref bool[,] isUsed, ref int i, ref int j, Node nodeNow, int height)
        {
            if (nodeNow != null)
            {
                tree[i, j] = nodeNow.value;
                isUsed[i,j] = true;
                i++;
                //j = j - i+1;
                j--;
                GetTree(ref tree, ref isUsed, ref i, ref j, nodeNow.left, height);
                //i++;
                j++;
                GetTree(ref tree, ref isUsed, ref i, ref j, nodeNow.right, height);
                i--;
                //j--;
            }
        }
    }
}
