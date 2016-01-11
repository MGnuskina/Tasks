using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AList
{
    public class AList2 : IAList
    {
        private int[] aList;

        private int start = 15;
        private int end = 15;

        public AList2()
        {
            aList = new int[30];
        }

        public int Size()
        {
            return end - start;
        }

        public void Clear()
        {
            start = aList.Length / 2;
            end = start;
            aList = new int[aList.Length];
        }

        public void Init(int[] array)
        {
            if (array.Length > aList.Length)
            {
                Extend(array.Length);
            }
            start = (int)((aList.Length / 2) - (array.Length / 2));
            end = start + array.Length;
            for (int i = start; i < end; i++)
            {
                aList[i] = array[i - start];
            }
        }

        public int[] ToArray()
        {
            int[] res = new int[end - start];
            for (int i = start; i < end; i++)
            {
                res[i - start] = aList[i];
            }
            return res;
        }

        public void AddStart(int element)
        {
            if (start == 0)
            {
                Extend(aList.Length + 1);
            }
            start--;
            aList[start] = element;
        }

        public void AddEnd(int element)
        {
            if (end == aList.Length)
            {
                Extend(aList.Length + 1);
            }
            end++;
            aList[end - 1] = element;
        }

        public void AddPos(int pos, int element)
        {
            pos = pos + start;
            if (pos < start || pos >= end)
            {
                if (end - start > 0)
                {
                    throw new ArgumentOutOfRangeException("There is no element in the position {0}", pos.ToString());
                }
                else
                {
                    throw new InvalidOperationException("This method can't be used for an empty AList0");
                }
            }
            if (end - start == aList.Length)
            {
                Extend(aList.Length + 1);
            }
            int n = end - start;
            if ((int)((aList.Length - n) / 2) < start)
            {
                start--;
                for (int i = start; i < pos; i++)
                {
                    aList[i] = aList[i + 1];
                }
                aList[pos - 1] = element;
            }
            else
            {
                end++;
                for (int i = end; i >= pos; i--)
                {
                    aList[i] = aList[i - 1];
                }
                aList[pos] = element;
            }
        }

        public int DelStart()
        {
            if (start == end)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            int n = end - start;
            int res = aList[start];
            //if ((int)((aList.Length - n) / 2) > start)
            //{
            //    end--;
            //    for (int i = start; i <= end; i++)
            //    {
            //        aList[i] = aList[i + 1];
            //    }
            //}
            //else
            //{
            //    start++;
            //}
            start++;
            return res;
        }

        public int DelEnd()
        {
            if (start == end)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            int res = aList[end - 1];
            end--;
            //int n = end - start;
            //if ((int)((aList.Length - n) / 2) <= start)
            //{
            //    start++;
            //    for (int i = end - 1; i > start; i--)
            //    {
            //        aList[i] = aList[i - 1];
            //    }
            //}
            //else
            //{
            //    end--;
            //}
            return res;
        }

        public int DelPos(int pos)
        {
            int res = 0;
            pos = pos + start;
            if (pos < start || pos >= end)
            {
                if (end - start > 0)
                {
                    throw new ArgumentOutOfRangeException("There is no element in the position {0}", pos.ToString());
                }
                else
                {
                    throw new InvalidOperationException("This method can't be used for an empty AList0");
                }
            }
            res = aList[pos];
            int n = end - start;
            if ((int)((aList.Length - n) / 2) < start)
            {
                end--;
                for (int i = pos; i < end; i++)
                {
                    aList[i] = aList[i + 1];
                }
            }
            else
            {
                for (int i = pos; i >start; i--)
                {
                    aList[i] = aList[i - 1];
                }
                start++;
            }
            return res;
        }

        public int Min()
        {
            int res = 0;
            if (start == end)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            res = aList[start];
            for (int i = start + 1; i < end; i++)
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
            if (start == end)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            res = aList[start];
            for (int i = start + 1; i < end; i++)
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
            int res = start;
            if (start == end)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            for (int i = start + 1; i < end; i++)
            {
                if (aList[i] < aList[res])
                {
                    res = i;
                }
            }
            return res - start;
        }

        public int MaxI()
        {
            int res = start;
            if (start == end)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            for (int i = start + 1; i < end; i++)
            {
                if (aList[i] > aList[res])
                {
                    res = i;
                }
            }
            return res - start;
        }

        public void Reverse()
        {
            if (start == end)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            int n = end - start;
            for (int i = 0; i < (int)(n / 2.0); i++)
            {
                if (start + n - 1 - i != start + i)
                {
                    aList[start + n - 1 - i] = aList[start + i] + aList[start + n - 1 - i];
                    aList[start + i] = aList[start + n - 1 - i] - aList[start + i];
                    aList[start + n - 1 - i] = aList[start + n - 1 - i] - aList[start + i];
                }
            }
        }

        public void HalfReverse()
        {
            if (start == end)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            int n = (int)(((end - start) / 2.0));
            int k = 0;
            if ((end - start) % 2 != 0)
            {
                k = 1;
            }
            for (int i = 0; i < n; i++)
            {
                aList[start + n + i + k] += aList[start + i];
                aList[start + i] = aList[start + n + i + k] - aList[start + i];
                aList[start + n + i + k] = aList[start + n + i + k] - aList[start + i];
            }
        }

        public int Get(int pos)
        {
            pos += start;
            if (pos < start || pos >= end)
            {
                if (start != end)
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
            pos += start;
            if (pos < start || pos >= end)
            {
                if (start != end)
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
            if (start == end)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            for (int i = start; i < end - 1; i++)
            {
                for (int j = i; j < end; j++)
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

        private void Extend(int expectedLength)
        {
            int n = aList.Length;
            while (n < expectedLength)
            {
                n = n + (int)(n * 0.3);
            }
            int[] tmpArr;
            int size = end - start;
            if (size != 0)
            {
                tmpArr = new int[size];
                for (int i = 0; i < size; i++)
                {
                    tmpArr[i] = aList[i + start];
                }
                aList = new int[n];
                start = (int)((n - (size)) / 2);
                end = start + size;
                for (int i = 0; i < size; i++)
                {
                    aList[i + start] = tmpArr[i];
                }
            }
            else
            {
                aList = new int[n];
                start = (int)(n / 2);
                end = start;
            }
        }
    }
}
