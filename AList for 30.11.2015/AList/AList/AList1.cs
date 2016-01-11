using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AList
{
    public class AList1 : IAList
    {
        private int[] aList;

        private int top = 0;

        public AList1()
        {
            aList = new int[10];
        }

        public int Size()
        {
            return top;
        }

        public void Clear()
        {
            top = 0;
            aList = new int[aList.Length];
        }

        public void Init(int[] array)
        {
            if (array==null)
            {
                throw new NullReferenceException();
            }
            if (array.Length > aList.Length)
            {
                Extend(array.Length);
            }
            for (int i = 0; i < array.Length; i++)
            {
                aList[i] = array[i];
            }
            top = array.Length;
        }

        public int[] ToArray()
        {
            int[] res = new int[top];
            for (int i = 0; i < top; i++)
            {
                res[i] = aList[i];
            }
            return res;
        }

        public void AddStart(int element)
        {
            int[] tmpArray = new int[top];
            for (int i = 0; i < top; i++)
            {
                tmpArray[i] = aList[i];
            }
            if (top == aList.Length)
            {
                Extend(aList.Length + 1);
            }
            aList[0] = element;
            for (int i = 1; i < top + 1; i++)
            {
                aList[i] = tmpArray[i - 1];
            }
            top++;
        }

        public void AddEnd(int element)
        {
            int[] tmpArray = new int[top];
            for (int i = 0; i < top; i++)
            {
                tmpArray[i] = aList[i];
            }
            if (top == aList.Length)
            {
                Extend(aList.Length + 1);
            }
            for (int i = 0; i < top; i++)
            {
                aList[i] = tmpArray[i];
            }
            aList[top] = element;
            top++;
        }

        public void AddPos(int pos, int element)
        {
            if (pos < 0 || pos >= top)
            {
                if (top > 0)
                {
                    throw new ArgumentOutOfRangeException("There is no element in the position {0}", pos.ToString());
                }
                else
                {
                    throw new InvalidOperationException("This method can't be used for an empty AList0");
                }
            }
            int[] tmpArray = new int[top];
            for (int i = 0; i < top; i++)
            {
                tmpArray[i] = aList[i];
            }
            if (top == aList.Length)
            {
                Extend(aList.Length + 1);
            }
            for (int i = 0; i < pos; i++)
            {
                aList[i] = tmpArray[i];
            }
            aList[pos] = element;
            top++;
            for (int i = pos + 1; i < top; i++)
            {
                aList[i] = tmpArray[i - 1];
            }
        }

        public int DelStart()
        {
            if (top <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            int[] tmpArray = new int[top];
            for (int i = 0; i < top; i++)
            {
                tmpArray[i] = aList[i];
            }
            top--;
            for (int i = 0; i < top; i++)
            {
                aList[i] = tmpArray[i + 1];
            }
            return tmpArray[0];
        }

        public int DelEnd()
        {
            if (top <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            top--;
            return aList[top];
        }

        public int DelPos(int pos)
        {
            if (pos < 0 || pos >= top)
            {
                if (top > 0)
                {
                    throw new ArgumentOutOfRangeException("There is no element in the position {0}", pos.ToString());
                }
                else
                {
                    throw new InvalidOperationException("This method can't be used for an empty AList0");
                }
            }
            int[] tmpArray = new int[top];
            for (int i = 0; i < top; i++)
            {
                tmpArray[i] = aList[i];
            }

            aList = new int[top - 1];
            for (int i = 0; i < pos; i++)
            {
                aList[i] = tmpArray[i];
            }
            for (int i = pos + 1; i < top; i++)
            {
                aList[i - 1] = tmpArray[i];
            }
            top--;
            return tmpArray[pos];
        }

        public int Min()
        {
            int res = 0;
            if (top <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            res = aList[0];
            for (int i = 1; i < top; i++)
            {
                if (aList[i] < res)
                {
                    res = aList[i];
                }
            }
            return res;
        }

        public int Max()
        {
            int res = 0;
            if (top <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            res = aList[0];
            for (int i = 1; i < top; i++)
            {
                if (aList[i] > res)
                {
                    res = aList[i];
                }
            }
            return res;
        }

        public int MinI()
        {
            int res = 0;
            if (top <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            for (int i = 1; i < top; i++)
            {
                if (aList[i] < aList[res])
                {
                    res = i;
                }
            }
            return res;
        }

        public int MaxI()
        {
            int res = 0;
            if (top <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            for (int i = 1; i < top; i++)
            {
                if (aList[i] > aList[res])
                {
                    res = i;
                }
            }
            return res;
        }

        public void Reverse()
        {
            if (top <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            int n = top;
            for (int i = 0; i < (top / 2.0); i++)
            {
                if (n - 1 - i != i)
                {
                    aList[n - 1 - i] = aList[i] + aList[n - 1 - i];
                    aList[i] = aList[n - 1 - i] - aList[i];
                    aList[n - 1 - i] = aList[n - 1 - i] - aList[i];
                }
            }
        }

        public void HalfReverse()
        {
            if (top <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            int n = (int)((top / 2.0));
            int k = 0;
            if (top % 2 != 0)
            {
                k = 1;
            }
            for (int i = 0; i < n; i++)
            {
                aList[n + i + k] += aList[i];
                aList[i] = aList[n + i + k] - aList[i];
                aList[n + i + k] = aList[n + i + k] - aList[i];
            }
        }

        public int Get(int pos)
        {
            if (pos < 0 || pos >= top)
            {
                if (top > 0)
                {
                    throw new ArgumentOutOfRangeException("There is no element in the position {0}", pos.ToString());
                }
                else
                {
                    throw new InvalidOperationException("This method can't be used for an empty AList0");
                }
            }
            return aList[pos];
        }

        public void Set(int pos, int value)
        {
            if (pos < 0 || pos >= top)
            {
                if (top > 0)
                {
                    throw new ArgumentOutOfRangeException("There is no element in the position {0}", pos.ToString());
                }
                else
                {
                    throw new InvalidOperationException("This method can't be used for an empty AList0");
                }
            }
            aList[pos] = value;
        }

        public void Sort()
        {
            if (top <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            for (int i = 0; i < top - 1; i++)
            {
                for (int j = i; j < top; j++)
                {
                    if (aList[i] > aList[j])
                    {
                        aList[j] += aList[i];
                        aList[i] = aList[j] - aList[i];
                        aList[j] = aList[j] - aList[i];
                    }
                }
            }
        }

        private void Extend(int lengthToCover)
        {
            int n = aList.Length;
            while (n < lengthToCover)
            {
                n = n + (int)(n * 0.3);
            }
            int[] tmpArr = new int[aList.Length];
            for (int i = 0; i < aList.Length; i++)
            {
                tmpArr[i] = aList[i];
            }
            aList = new int[n];
            for (int i = 0; i < tmpArr.Length; i++)
            {
                aList[i] = tmpArr[i];
            }
        }
    }
}
