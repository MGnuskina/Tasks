using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AList
{
    public class AList0 : IAList
    {
        private int[] aList;

        public AList0()
        {
            aList = new int[0];
        }

        public int Size()
        {
            return aList.Length;
        }

        public void Clear()
        {
            aList = new int[0];
        }

        public void Init(int[] array)
        {
            aList = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                aList[i] = array[i];
            }
        }

        public int[] ToArray()
        {
            return aList;
        }

        public void AddStart(int element)
        {
            int[] tmpArray = new int[aList.Length];
            for (int i = 0; i < aList.Length; i++)
            {
                tmpArray[i] = aList[i];
            }
            aList = new int[aList.Length + 1];
            aList[0] = element;
            for (int i = 1; i < aList.Length; i++)
            {
                aList[i] = tmpArray[i - 1];
            }
        }

        public void AddEnd(int element)
        {
            int[] tmpArray = new int[aList.Length];
            for (int i = 0; i < aList.Length; i++)
            {
                tmpArray[i] = aList[i];
            }
            aList = new int[aList.Length + 1];
            aList[aList.Length - 1] = element;
            for (int i = 0; i < aList.Length - 1; i++)
            {
                aList[i] = tmpArray[i];
            }
        }

        public void AddPos(int pos, int element)
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
            int[] tmpArray = new int[aList.Length];
            for (int i = 0; i < aList.Length; i++)
            {
                tmpArray[i] = aList[i];
            }
            aList = new int[aList.Length + 1];
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

        public int DelStart()
        {
            if (aList.Length <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            int[] tmpArray = new int[aList.Length];
            for (int i = 0; i < aList.Length; i++)
            {
                tmpArray[i] = aList[i];
            }
            aList = new int[aList.Length - 1];
            for (int i = 0; i < aList.Length; i++)
            {
                aList[i] = tmpArray[i + 1];
            }
            return tmpArray[0];
        }

        public int DelEnd()
        {
            if (aList.Length <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            int[] tmpArray = new int[aList.Length];
            for (int i = 0; i < aList.Length; i++)
            {
                tmpArray[i] = aList[i];
            }
            aList = new int[aList.Length - 1];
            for (int i = 0; i < aList.Length; i++)
            {
                aList[i] = tmpArray[i];
            }
            return tmpArray[aList.Length];
        }

        public int DelPos(int pos)
        {
            int[] tmpArray = new int[aList.Length];
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
            aList = new int[aList.Length - 1];
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

        public int Min()
        {
            int res = 0;
            if (aList.Length <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            res = aList[0];
            foreach (int a in aList)
            {
                if (a < res)
                {
                    res = a;
                }
            }
            return res;
        }

        public int Max()
        {
            int res = 0;
            if (aList.Length <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            res = aList[0];
            foreach (int a in aList)
            {
                if (a > res)
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
            if (aList.Length <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            for (int i = 1; i < aList.Length; i++)
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
            if (aList.Length <= 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            int n = aList.Length;
            for (int i = 0; i < (int)(aList.Length / 2.0); i++)
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
            for (int i = 0; i < n; i++)
            {
                aList[n + i + k] += aList[i];
                aList[i] = aList[n + i + k] - aList[i];
                aList[n + i + k] = aList[n + i + k] - aList[i];
            }
        }

        public int Get(int pos)
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

        public void Set(int pos, int value)
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
            for (int i = 0; i < aList.Length - 1; i++)
            {
                for (int j = i; j < aList.Length; j++)
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
    }
}
