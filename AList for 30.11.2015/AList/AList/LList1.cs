using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AList
{
    public class LList1 : IAList
    {
        private class Node
        {
            public int value { get; set; }
            public Node next { get; set; }

            public Node(int val, Node node)
            {
                value = val;
                next = node;
            }

            public Node() { }
        }

        Node root;

        private void SetUpRoot()
        {
            root = new Node();
        }

        public void AddEnd(int element)
        {
            if (root == null)
            {
                SetUpRoot();
                root.value = element;
            }
            else
            {
                Node nodeNow = root;
                Node newNode = new Node(element, null);
                while (nodeNow.next != null)
                {
                    nodeNow = nodeNow.next;
                }
                nodeNow.next = newNode;
            }
        }

        public void AddPos(int pos, int element)
        {
            if (root == null)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            if (Size() <= pos)
            {
                throw new ArgumentOutOfRangeException("There is no element in the position {0}", pos.ToString());
            }
            Node nodeNow = root;
            Node nodeToAddTo = root;
            int i = 0;
            while (i < pos)
            {
                i++;
                nodeNow = nodeNow.next;
                if (i == pos - 1)
                {
                    nodeToAddTo = nodeNow;
                }
            }
            Node tmpNode = nodeNow;
            Node newNode = new Node(element, tmpNode);
            if (pos != 0)
            {
                nodeToAddTo.next = newNode;
            }
            else
            {
                root = newNode;
            }
        }

        public void AddStart(int element)
        {
            if (root == null)
            {
                SetUpRoot();
                root.value = element;
            }
            else
            {
                Node nodeNow = root;
                root = new Node(element, nodeNow);
            }
        }

        public void Clear()
        {
            root = null;
        }

        public int DelEnd()
        {
            if (root == null)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            int res = root.value;
            if (Size() == 1)
            {
                root = null;
            }
            else
            {
                Node nodeNow = root;
                Node prevNow = root;
                while (nodeNow.next != null)
                {
                    prevNow = nodeNow;
                    nodeNow = nodeNow.next;
                }
                res = nodeNow.value;
                prevNow.next = null;
            }
            return res;
        }

        public int DelPos(int pos)
        {
            if (root == null)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            if (Size() <= pos)
            {
                throw new ArgumentOutOfRangeException("There is no element in the position {0}", pos.ToString());
            }
            int res = root.value;
            if (pos==0)
            {
                res=DelStart();
            }
            else
            {
                if (pos==Size()-1)
                {
                    res = DelEnd();
                }
                else
                {
                    int i = 0;
                    Node nodeNow = root;
                    Node nodePrev = root;
                    while (i < pos)
                    {
                        nodePrev= nodeNow;
                        nodeNow = nodeNow.next;
                        i++;
                    }
                    res = nodeNow.value;
                    nodePrev.next = nodeNow.next;
                }
            }
            return res;
        }

        public int DelStart()
        {
            if (root == null)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            int res = root.value;
            root = root.next;
            return res;
        }

        public int Get(int pos)
        {
            if (root == null)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            if (Size() < pos)
            {
                throw new ArgumentOutOfRangeException("There is no element in the position {0}", pos.ToString());
            }
            Node nodeNow = root;
            int res = 0;
            int i = 0;
            while (i < pos)
            {
                i++;
                nodeNow = nodeNow.next;
            }
            res = nodeNow.value;
            return res;
        }

        public void HalfReverse()
        {
            if (root == null)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            Node tmpNode1 = root;
            Node tmpNode2;
            int tmp;
            int size = Size();
            int k = 0;
            if (size % 2 != 0)
            {
                k = 1;
            }
            for (int i = 0; i < (int)(size / 2.0); i++)
            {
                tmpNode2 = tmpNode1.next;
                for (int j = i + 1; j < (int)(size / 2.0) + i+k; j++)
                {
                    tmpNode2 = tmpNode2.next;
                }
                tmp = tmpNode1.value;
                tmpNode1.value = tmpNode2.value;
                tmpNode2.value = tmp;
                tmpNode1 = tmpNode1.next;
            }
        }

        public void Init(int[] array)
        {
            if (array.Length > 0)
            {
                SetUpRoot();
                root.value = array[0];
                Node nodeNow = root;
                Node newNode;
                for (int i = 1; i < array.Length; i++)
                {
                    newNode = new Node(array[i], null);
                    nodeNow.next = newNode;
                    nodeNow = newNode;
                }

            }
        }

        public int Max()
        {
            if(root == null)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            Node nodeNow = root;
            int res = root.value;
            while (nodeNow.next != null)
            {
                nodeNow = nodeNow.next;
                if (nodeNow.value>res)
                {
                    res = nodeNow.value;
                }
            }
            return res;
        }

        public int MaxI()
        {
            if (root == null)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            Node nodeNow = root;
            int max = root.value;
            int i = 0;
            int maxI = 0;
            while (nodeNow.next != null)
            {
                i++;
                nodeNow = nodeNow.next;
                if (nodeNow.value > max)
                {
                    max = nodeNow.value;
                    maxI = i;
                }
            }
            return maxI;
        }

        public int Min()
        {
            if (root == null)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            Node nodeNow = root;
            int res = root.value;
            while (nodeNow.next != null)
            {
                nodeNow = nodeNow.next;
                if (nodeNow.value < res)
                {
                    res = nodeNow.value;
                }
            }
            return res;
        }

        public int MinI()
        {
            if (root == null)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            Node nodeNow = root;
            int min = root.value;
            int i = 0;
            int minI = 0;
            while (nodeNow.next != null)
            {
                i++;
                nodeNow = nodeNow.next;
                if (nodeNow.value < min)
                {
                    min = nodeNow.value;
                    minI = i;
                }
            }
            return minI;
        }

        public void Reverse()
        {
            if (root == null)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            Node tmpNode1 = root;
            Node tmpNode2;
            int tmp;
            int size = Size();
            for (int i=0; i<(int)(size/2.0); i++)
            {
                tmpNode2 = tmpNode1.next;
                for (int j=i+1; j<size-i-1; j++)
                {
                    tmpNode2 = tmpNode2.next;
                }
                tmp = tmpNode1.value;
                tmpNode1.value = tmpNode2.value;
                tmpNode2.value = tmp;
                tmpNode1 = tmpNode1.next;
            }
        }

        public void Set(int pos, int value)
        {
            if (root == null)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            if (Size() < pos)
            {
                throw new ArgumentOutOfRangeException("There is no element in the position {0}", pos.ToString());
            }
            Node nodeNow = root;
            int i = 0;
            while (i < pos)
            {
                i++;
                nodeNow = nodeNow.next;
            }
            nodeNow.value = value;
        }

        public int Size()
        {
            int size = 0;
            Node nodeNow = root;
            while (nodeNow != null)
            {
                size++;
                nodeNow = nodeNow.next;
            }
            return size;
        }

        public void Sort()
        {
            if (root == null)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            Node tmpNode1 = root;
            Node tmpNode2 = root;
            int tmp;
            while (tmpNode1!=null)
            {
                tmpNode2 = tmpNode1.next;
                while (tmpNode2!=null)
                {
                    if (tmpNode2.value<tmpNode1.value)
                    {
                        tmp = tmpNode1.value;
                        tmpNode1.value = tmpNode2.value;
                        tmpNode2.value=tmp;   
                    }
                    tmpNode2 = tmpNode2.next;
                }
                tmpNode1 = tmpNode1.next;
            }
        }

        public int[] ToArray()
        {
            if (root == null)
            {
                return new int[0];
            }
            Node nodeNow = root;
            int[] res = new int[Size()];
            int i = 0;
            while (nodeNow.next != null)
            {
                res[i] = nodeNow.value;
                i++;
                nodeNow = nodeNow.next;
            }
            res[i] = nodeNow.value;
            return res;
        }
    }
}
