using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AList
{
    public class AList1<T> : IAList<T> where T : IComparable
    {
        private T[] aList;

        private int top = 0;

        public AList1()
        {
            aList = new T[10];
        }

        public int Size()
        {
            return top;
        }

        public void Clear()
        {
            top = 0;
            aList = new T[aList.Length];
        }

        public void Init(T[] array)
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

        public T[] ToArray()
        {
            T[] res = new T[top];
            for (int i = 0; i < top; i++)
            {
                res[i] = aList[i];
            }
            return res;
        }

        public void AddStart(T element)
        {
            T[] tmpArray = new T[top];
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

        public void AddEnd(T element)
        {
            T[] tmpArray = new T[top];
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

        public void AddPos(int pos, T element)
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
            T[] tmpArray = new T[top];
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

        public T DelStart()
        {
            if (top <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            T[] tmpArray = new T[top];
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

        public T DelEnd()
        {
            if (top <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            top--;
            return aList[top];
        }

        public T DelPos(int pos)
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
            T[] tmpArray = new T[top];
            for (int i = 0; i < top; i++)
            {
                tmpArray[i] = aList[i];
            }

            aList = new T[top - 1];
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

        public T Min()
        {
            T res = default(T);
            if (top <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            res = aList[0];
            for (int i = 1; i < top; i++)
            {
                if (aList[i].CompareTo(res)<0)
                {
                    res = aList[i];
                }
            }
            return res;
        }

        public T Max()
        {
            T res = default(T);
            if (top <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            res = aList[0];
            for (int i = 1; i < top; i++)
            {
                if (aList[i].CompareTo(res)>0)
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
                if (aList[i].CompareTo(aList[res])<0)
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
                if (aList[i].CompareTo(aList[res])>0)
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
            T tmp;
            for (int i = 0; i < (top / 2.0); i++)
            {
                if (n - 1 - i != i)
                {
                    tmp= aList[i];
                    aList[i] = aList[n - 1 - i];
                    aList[n - 1 - i] = tmp;
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
            T tmp;
            for (int i = 0; i < n; i++)
            {
                tmp= aList[i];
                aList[i] = aList[n + i + k];
                aList[n + i + k] = tmp;
            }
        }

        public T Get(int pos)
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

        public void Set(int pos, T value)
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
                    if (aList[i].CompareTo(aList[j])>0)
                    {
                        T tmp= aList[i];
                        aList[i] = aList[j];
                        aList[j] = tmp;
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
            T[] tmpArr = new T[aList.Length];
            for (int i = 0; i < aList.Length; i++)
            {
                tmpArr[i] = aList[i];
            }
            aList = new T[n];
            for (int i = 0; i < tmpArr.Length; i++)
            {
                aList[i] = tmpArr[i];
            }
        }
    }
}
