using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AList
{
    public class LList2 : IAList
    {
        private class Node
        {
            public int value { get; set; }
            public Node front { get; set; }
            public Node rear { get; set; }

            public Node(int val, Node nodeFront, Node nodeRear)
            {
                value = val;
                front = nodeFront;
                rear = nodeRear;
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
                Node newNode;
                if (Size() == 1)
                {
                    newNode = new Node(element, null, null);
                    root.front = newNode;
                    root.rear = newNode;
                }
                else
                {
                    Node endElement = root.rear;
                    newNode = new Node(element, null, endElement);
                    endElement.front = newNode;
                    root.rear = newNode;
                }
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
            Node newNode;
            int size = Size();
            if (pos == 0)
            {
                AddStart(element);
            }
            else
            {
                Node nodeNow = root;
                Node startNode;
                int i;
                if (pos <= (size - 1) / 2.0)
                {
                    i = 0;
                    while (i < pos)
                    {
                        i++;
                        nodeNow = nodeNow.front;
                    }
                }
                else
                {
                    i = size;
                    while (i > pos)
                    {
                        i--;
                        nodeNow = nodeNow.rear;
                    }
                }
                startNode = nodeNow.rear;
                newNode = new Node(element, nodeNow, startNode);
                nodeNow.rear = newNode;
                if (startNode == null)
                {
                    root.front = newNode;
                }
                else
                {
                    startNode.front = newNode;
                }
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
                Node newNode;
                if (Size() == 1)
                {
                    newNode = new Node(element, root, root);
                }
                else
                {
                    Node endElement = root.rear;
                    root.rear = null;
                    newNode = new Node(element, root, endElement);
                }
                root = newNode;
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
                Node endNode = root.rear;
                res = endNode.value;
                if (Size() == 2)
                {
                    root.rear = null;
                    root.front = null;
                }
                else
                {
                    Node newEndNode = endNode.rear;
                    root.rear = newEndNode;
                    newEndNode.front = null;
                }
            }
            return res;
        }

        public int DelPos(int pos)
        {
            if (root == null)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            int size = Size();
            if (size <= pos)
            {
                throw new ArgumentOutOfRangeException("There is no element in the position {0}", pos.ToString());
            }
            int res = root.value;
            if (pos == 0)
            {
                res = DelStart();
            }
            else
            {
                if (pos == size - 1)
                {
                    res = DelEnd();
                }
                else
                {
                    int i = 0;
                    Node nodeNow = root;
                    Node nodePrev = root;
                    Node nodeNext;
                    if (pos - 1 <= (size - 1) / 2.0)
                    {
                        i = 0;
                        while (i < pos)
                        {
                            i++;
                            nodeNow = nodeNow.front;
                        }
                    }
                    else
                    {
                        i = size;
                        while (i > pos)
                        {
                            i--;
                            nodeNow = nodeNow.rear;
                        }
                    }
                    if (pos == 1)
                    {
                        if (size != 2)
                        {
                            nodeNext = nodeNow.front;
                            nodeNext.rear = null;
                            root.front = nodeNow;
                        }
                        else
                        {
                            root.front = null;
                            root.rear = null;
                        }
                    }
                    nodeNext = nodeNow.front;
                    nodePrev = nodeNow.rear;
                    res = nodeNow.value;
                    nodePrev.front = nodeNext;
                    nodeNext.rear = nodePrev;
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
            if (Size() == 1)
            {
                root = null;
            }
            else
            {
                Node endNode = root.rear;
                if (Size() == 2)
                {
                    root = root.front;
                }
                else
                {
                    Node newEndNode = root.rear;
                    root = root.front;
                    root.rear = newEndNode;
                    Node newSecond = root.front;
                    newSecond.rear = null;
                }
            }
            return res;
        }

        public int Get(int pos)
        {
            if (root == null)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            int size = Size();
            if (size < pos)
            {
                throw new ArgumentOutOfRangeException("There is no element in the position {0}", pos.ToString());
            }
            int res;
            Node nodeNow = root;
            int i;
            if (pos <= (size - 1) / 2.0)
            {
                i = 0;
                while (i < pos)
                {
                    i++;
                    nodeNow = nodeNow.front;
                }
            }
            else
            {
                i = size;
                while (i > pos)
                {
                    i--;
                    nodeNow = nodeNow.rear;
                }
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
            Node tmpNode2 = root.rear;
            int tmp;
            int size = Size();
            int k = 0;
            if (size % 2 != 0)
            {
                k = 1;
            }
            for (int i = 1; i < (int)(size / 2.0); i++)
            {
                tmpNode1 = tmpNode1.front;
            }
            tmpNode2 = tmpNode1.front;
            tmpNode1 = root;
            if (k == 1 && size > 1)
            {
                tmpNode2 = tmpNode2.front;
            }
            for (int i = 0; i < (int)(size / 2.0); i++)
            {
                if (tmpNode1 == null)
                {
                    tmpNode1 = root;
                }
                tmp = tmpNode1.value;
                tmpNode1.value = tmpNode2.value;
                tmpNode2.value = tmp;
                tmpNode1 = tmpNode1.front;
                tmpNode2 = tmpNode2.front;
            }
        }

        public void Init(int[] array)
        {
            Node newNode;
            if (array.Length > 0)
            {
                SetUpRoot();
                root.value = array[0];
                if (array.Length > 1)
                {
                    newNode = new Node(array[1], null, null);
                    root.front = newNode;
                    root.rear = newNode;
                }
                Node nodeNow = root.front;
                for (int i = 2; i < array.Length; i++)
                {
                    newNode = new Node(array[i], null, nodeNow);
                    nodeNow.front = newNode;
                    root.rear = newNode;
                    nodeNow = newNode;
                }
            }
        }

        public int Max()
        {
            if (root == null)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            Node nodeNow = root;
            int res = root.value;
            while (nodeNow.front != null)
            {
                nodeNow = nodeNow.front;
                if (nodeNow.value > res)
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
            while (nodeNow.front != null)
            {
                i++;
                nodeNow = nodeNow.front;
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
            while (nodeNow.front != null)
            {
                nodeNow = nodeNow.front;
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
            while (nodeNow.front != null)
            {
                i++;
                nodeNow = nodeNow.front;
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
            Node tmpNode2 = root.rear;
            int tmp;
            int size = Size();
            for (int i = 0; i < (int)(size / 2.0); i++)
            {
                tmp = tmpNode1.value;
                tmpNode1.value = tmpNode2.value;
                tmpNode2.value = tmp;
                tmpNode1 = tmpNode1.front;
                tmpNode2 = tmpNode2.rear;
            }
        }

        public void Set(int pos, int value)
        {
            if (root == null)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            int size = Size();
            if (size < pos)
            {
                throw new ArgumentOutOfRangeException("There is no element in the position {0}", pos.ToString());
            }
            Node nodeNow = root;
            int i;
            if (pos <= (size - 1) / 2.0)
            {
                i = 0;
                while (i < pos)
                {
                    i++;
                    nodeNow = nodeNow.front;
                }
            }
            else
            {
                i = size;
                while (i > pos)
                {
                    i--;
                    nodeNow = nodeNow.rear;
                }
            }
            nodeNow.value = value;
        }

        public int Size()
        {
            if (root == null)
            {
                return 0;
            }
            int size = 1;
            Node nodeNow = root;
            while (nodeNow.front != null)
            {
                size++;
                nodeNow = nodeNow.front;
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
            while (tmpNode1 != null)
            {
                tmpNode2 = tmpNode1.front;
                while (tmpNode2 != null)
                {
                    if (tmpNode2.value < tmpNode1.value)
                    {
                        tmp = tmpNode1.value;
                        tmpNode1.value = tmpNode2.value;
                        tmpNode2.value = tmp;
                    }
                    tmpNode2 = tmpNode2.front;
                }
                tmpNode1 = tmpNode1.front;
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
            while (nodeNow.front != null)
            {
                res[i] = nodeNow.value;
                i++;
                nodeNow = nodeNow.front;
            }
            res[i] = nodeNow.value;
            return res;
        }
    }
}
