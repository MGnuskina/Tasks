using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree_Project
{
    public class BinaryTreeLink
    {
        protected class Node
        {
            public int Value { get; set; }
            public Link Left { get; set; }
            public Link Right { get; set; }

            public Node(int val, Link l, Link r)
            {
                Value = val;
                Left = l;
                Right = r;
            }
        }

        protected class Link
        {
            public Node element;

            public Link(int val, Link l, Link r)
            {
                element = new Node(val, l, r);
            }

            public Link(int val) : this(val, null, null) { }

            public Link() : this(0, null, null) { }
        }

        Link treeRoot;

        public void Clear()
        {
            treeRoot = null;
        }

        public void Add(int value)
        {
            if (treeRoot == null)
            {
                treeRoot = new Link(value);
            }
            else
            {
                Link nodeNow = FindNode(value, treeRoot);
                if (value < nodeNow.element.Value)
                {
                    nodeNow.element.Left = new Link(value);
                }
                else
                {
                    if (value > nodeNow.element.Value)
                    {
                        nodeNow.element.Right = new Link(value);
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

            Link nodeToDel = FindNode(value, treeRoot);
            Link parent = FindParent(nodeToDel, treeRoot);

            if (nodeToDel.element.Right == null && nodeToDel.element.Left == null)
            {
                if (parent.element.Right == nodeToDel)
                {
                    parent.element.Right = null;
                }
                else
                {
                    if (parent.element.Right == null && parent.element.Left == null)
                    {
                        treeRoot = null;
                    }
                    else
                    {
                        parent.element.Left = null;
                    }
                }
            }
            else
            {
                if (nodeToDel.element.Right == null)
                {
                    if (parent.element.Right == nodeToDel)
                    {
                        parent.element.Right = nodeToDel.element.Left;
                    }
                    else
                    {
                        parent.element.Left = nodeToDel.element.Left;
                    }
                }
                else
                {
                    if (nodeToDel.element.Left == null)
                    {
                        if (parent.element.Right == nodeToDel)
                        {
                            parent.element.Right = nodeToDel.element.Right;
                        }
                        else
                        {
                            parent.element.Left = nodeToDel.element.Right;
                        }
                    }
                    else
                    {
                        int tmp = nodeToDel.element.Right.element.Value;//
                        Del(tmp);
                        nodeToDel.element.Value = tmp;
                    }
                }
            }
        }

        public void Init(int[] array)
        {
            if (array.Length > 0)
            {
                treeRoot = new Link(array[0]);
                for (int i = 1; i < array.Length; i++)
                {
                    Add(array[i]);
                }
            }
        }

        public int[] ToArray()
        {
            int size = Size();
            List<int> res = new List<int>();
            if (size > 0)
            {
                res = FindElements(treeRoot, res);
            }
            return res.ToArray(); ;
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
                size = FindSize(treeRoot, size);
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
            res = FindLeafsCount(treeRoot, res);
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

        private bool CheckIfNodeExists(Link node, Link[] passedNodes, int j)
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

        private Link FindNode(int value, Link nodeNow)
        {
            if (value < nodeNow.element.Value && nodeNow.element.Left != null)
            {
                nodeNow = FindNode(value, nodeNow.element.Left);
            }
            else
            {
                if (value > nodeNow.element.Value && nodeNow.element.Right != null)
                {
                    nodeNow = FindNode(value, nodeNow.element.Right);
                }
            }
            return nodeNow;
        }

        private int FindSize(Link nodeNow, int size)
        {
            if (nodeNow.element.Left != null)
            {
                size = FindSize(nodeNow.element.Left, size);
            }
            if (nodeNow.element.Right != null)
            {
                size = FindSize(nodeNow.element.Right, size);
            }
            return size + 1;
        }

        private List<int> FindElements(Link nodeNow, List<int> elements)
        {
            if (nodeNow.element.Left != null)
            {
                elements = FindElements(nodeNow.element.Left, elements);
                elements.Add(nodeNow.element.Value);
            }
            else
            {
                elements.Add(nodeNow.element.Value);
            }
            if (nodeNow.element.Right != null)
            {
                elements = FindElements(nodeNow.element.Right, elements);
            }
            return elements;
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

        private int FindNodeCount(Link nodeNow, int countNodes)
        {
            if (nodeNow.element.Left != null)
            {
                countNodes = FindNodeCount(nodeNow.element.Left, countNodes);
                return countNodes + 1;
            }
            if (nodeNow.element.Right != null)
            {
                countNodes = FindNodeCount(nodeNow.element.Right, countNodes);
                return countNodes + 1;
            }
            return countNodes;
        }

        private int FindLeafsCount(Link nodeNow, int countLeafs)
        {
            if (nodeNow.element.Left == null && nodeNow.element.Right == null)
            {
                return countLeafs + 1;
            }
            if (nodeNow.element.Left != null)
            {
                countLeafs = FindLeafsCount(nodeNow.element.Left, countLeafs);
            }
            if (nodeNow.element.Right != null)
            {
                countLeafs = FindLeafsCount(nodeNow.element.Right, countLeafs);
            }
            return countLeafs;
        }

        private int FindHeight(Link nodeNow)
        {
            if (nodeNow == null)
            {
                return 0;
            }
            int left, right;
            left = FindHeight(nodeNow.element.Left);
            right = FindHeight(nodeNow.element.Right);
            if (left > right)
            {
                return left + 1;
            }
            else
            {
                return right + 1;
            }
        }

        private int FindWidth(Link nodeNow, int level)
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
                    return FindWidth(nodeNow.element.Left, level - 1) + FindWidth(nodeNow.element.Right, level - 1);
                }
                else
                {
                    return 0;
                }
            }
        }

        private void Reverse(Link nodeNow)
        {
            if (nodeNow != null)
            {
                Link tmpNode = nodeNow.element.Left;
                nodeNow.element.Left = nodeNow.element.Right;
                nodeNow.element.Right = tmpNode;

                if (nodeNow.element.Left != null)
                {
                    Reverse(nodeNow.element.Left);
                }
                if (nodeNow.element.Right != null)
                {
                    Reverse(nodeNow.element.Right);
                }
            }
        }

        private Link FindParent(Link nodeToFind, Link nodeNow)
        {
            if (nodeNow.element.Left != null && nodeToFind != nodeNow.element.Left && nodeToFind.element.Value < nodeNow.element.Value)
            {
                nodeNow = FindParent(nodeToFind, nodeNow.element.Left);
            }
            if (nodeNow.element.Right != null && nodeToFind != nodeNow.element.Right && nodeToFind.element.Value > nodeNow.element.Value)
            {
                nodeNow = FindParent(nodeToFind, nodeNow.element.Right);
            }
            return nodeNow;
        }
    }
}
