using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AList
{
    public class LListR : IAList
    {
        private class Node
        {
            public int value;
            public Node front;
            public Node rear;

            public Node(int val, Node nodeFront, Node nodeRear)
            {
                value = val;
                front = nodeFront;
                rear = nodeRear;
            }

            public Node(int val)
            {
                value = val;
            }
        }

        Node root;

        public void AddEnd(int element)
        {
            if (root == null)
            {
                root = new Node(element);
                root.rear = root;
                root.front = root;
            }
            else
            {
                Node newNode = new Node(element, root, root.rear);
                if (Size() == 1)
                {
                    root.front = newNode;
                    root.rear = newNode;
                    newNode.rear = root;
                }
                else
                {
                    root.rear.front = newNode;
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
            int size = Size();
            if (size <= pos)
            {
                throw new ArgumentOutOfRangeException("There is no element in the position {0}", pos.ToString());
            }
            if (pos == 0)
            {
                AddStart(element);
            }
            else
            {
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
                Node newNode = new Node(element, nodeNow, nodeNow.rear);
                nodeNow.rear.front = newNode;
                nodeNow.rear = newNode;
            }
        }

        public void AddStart(int element)
        {
            if (root == null)
            {
                root = new Node(element, root, root);///??????
                root.front = root;
                root.rear = root;
            }
            else
            {
                Node newNode = new Node(element, root, root.rear);
                if (Size() > 1)
                {
                    root.rear.front = newNode;
                    root.rear = newNode;
                }
                else
                {
                    root.rear = newNode;
                    root.front = newNode;
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
            int res;
            if (Size() == 1)
            {
                res = root.value;
                root = null;
            }
            else
            {
                res = root.rear.value;
                root.rear.rear.front = root;
                root.rear = root.rear.rear;
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
            int res;
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
                    res = nodeNow.value;
                    nodeNow.rear.front = nodeNow.front;
                    nodeNow.front.rear = nodeNow.rear;
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
                root.front.rear = root.rear;
                root.rear.front = root.front;
                root = root.front;
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
            if (array.Length > 0)
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    AddStart(array[i]);
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
            while (nodeNow.front != root)
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
            while (nodeNow.front != root)
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
            while (nodeNow.front != root)
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
            while (nodeNow.front != root)
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
            while (nodeNow.front != root && nodeNow.front!=null)
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
            while (tmpNode1 != root.rear)
            {
                tmpNode2 = tmpNode1.front;
                while (tmpNode2 != root)
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
            Node nodeNow = root.front;
            int[] res = new int[Size()];
            int i = 1;
            res[0] = root.value;
            while (nodeNow != root)
            {
                res[i] = nodeNow.value;
                i++;
                nodeNow = nodeNow.front;
            }
            return res;
        }
    }
}
