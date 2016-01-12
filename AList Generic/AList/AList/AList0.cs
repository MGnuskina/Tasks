using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AList
{
    public class AList0<T>  : IAList<T> where T : IComparable
    {
        private T[] aList;

        public AList0()
        {
            aList = new T[0];
        }

        public int Size()
        {
            return aList.Length;
        }

        public void Clear()
        {
            aList = new T[0];
        }

        public void Init(T[] array)
        {
            aList = new T[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                aList[i] = array[i];
            }
        }

        public T[] ToArray()
        {
            return aList;
        }

        public void AddStart(T element)
        {
            T[] tmpArray = new T[aList.Length];
            for (int i = 0; i < aList.Length; i++)
            {
                tmpArray[i] = aList[i];
            }
            aList = new T[aList.Length + 1];
            aList[0] = element;
            for (int i = 1; i < aList.Length; i++)
            {
                aList[i] = tmpArray[i - 1];
            }
        }

        public void AddEnd(T element)
        {
            T[] tmpArray = new T[aList.Length];
            for (int i = 0; i < aList.Length; i++)
            {
                tmpArray[i] = aList[i];
            }
            aList = new T[aList.Length + 1];
            aList[aList.Length - 1] = element;
            for (int i = 0; i < aList.Length - 1; i++)
            {
                aList[i] = tmpArray[i];
            }
        }

        public void AddPos(int pos, T element)
        {
            if (pos < 0 || pos >= aList.Length + 1)
            {
                if (aList.Length > 0)
                {
                    throw new ArgumentOutOfRangeException("There is no element in the position {0}", pos.ToString());
                }
                else
                {
                    throw new InvalidOperationException("This method can't be used for an empty AList0");
                }
            }
            T[] tmpArray = new T[aList.Length];
            for (int i = 0; i < aList.Length; i++)
            {
                tmpArray[i] = aList[i];
            }
            aList = new T[aList.Length + 1];
            for (int i = 0; i < pos; i++)
            {
                aList[i] = tmpArray[i];
            }
            aList[pos] = element;
            for (int i = pos; i < aList.Length - 1; i++)
            {
                aList[i + 1] = tmpArray[i];
            }
        }

        public T DelStart()
        {
            if (aList.Length <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            T[] tmpArray = new T[aList.Length];
            for (int i = 0; i < aList.Length; i++)
            {
                tmpArray[i] = aList[i];
            }
            aList = new T[aList.Length - 1];
            for (int i = 0; i < aList.Length; i++)
            {
                aList[i] = tmpArray[i + 1];
            }
            return tmpArray[0];
        }

        public T DelEnd()
        {
            if (aList.Length <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            T[] tmpArray = new T[aList.Length];
            for (int i = 0; i < aList.Length; i++)
            {
                tmpArray[i] = aList[i];
            }
            aList = new T[aList.Length - 1];
            for (int i = 0; i < aList.Length; i++)
            {
                aList[i] = tmpArray[i];
            }
            return tmpArray[aList.Length];
        }

        public T DelPos(int pos)
        {
            T[] tmpArray = new T[aList.Length];
            if (pos < 0 || pos >= aList.Length)
            {
                if (aList.Length > 0)
                {
                    throw new ArgumentOutOfRangeException("There is no element in the position {0}", pos.ToString());
                }
                else
                {
                    throw new InvalidOperationException("This method can't be used for an empty AList0");
                }
            }
            for (int i = 0; i < aList.Length; i++)
            {
                tmpArray[i] = aList[i];
            }
            aList = new T[aList.Length - 1];
            for (int i = 0; i < pos; i++)
            {
                aList[i] = tmpArray[i];
            }
            for (int i = pos + 1; i < tmpArray.Length; i++)
            {
                aList[i - 1] = tmpArray[i];
            }
            return tmpArray[pos];
        }

        public T Min()
        {
            T res = default(T);
            if (aList.Length <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            res = aList[0];
            foreach (T a in aList)
            {
                if ( a.CompareTo(res)<0)
                {
                    res = a;
                }
            }
            return res;
        }

        public T Max()
        {
            T res = default(T);
            if (aList.Length <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            res = aList[0];
            foreach (T a in aList)
            {
                if (a.CompareTo(res)>0)
                {
                    res = a;
                }
            }
            return res;
        }

        public int MinI()
        {
            int res = 0;
            if (aList.Length <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            for (int i = 1; i < aList.Length; i++)
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
            if (aList.Length <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            for (int i = 1; i < aList.Length; i++)
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
            if (aList.Length <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            int n = aList.Length;
            T tmp;
            for (int i = 0; i < (int)(aList.Length / 2.0); i++)
            {
                if (n - 1 - i != i)
                {
                    tmp=aList[i];
                    aList[i] = aList[n - 1 - i];
                    aList[n - 1 - i] = tmp;
                }
            }
        }

        public void HalfReverse()
        {
            if (aList.Length <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            int n = (int)((aList.Length / 2.0));
            int k = 0;
            if (aList.Length % 2 != 0)
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
            if (pos < 0 || pos >= aList.Length)
            {
                if (aList.Length > 0)
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
            if (pos < 0 || pos >= aList.Length)
            {
                if (aList.Length > 0)
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
            if (aList.Length <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            T tmp;
            for (int i = 0; i < aList.Length - 1; i++)
            {
                for (int j = i; j < aList.Length; j++)
                {
                    if (aList[i].CompareTo(aList[j])>0)
                    {
                        tmp= aList[i];
                        aList[i] = aList[j];
                        aList[j] = tmp;
                    }
                }
            }
        }
    }
}
