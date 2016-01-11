using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AList
{
    public class AListR : IAList
    {
        private int[] aList;

        private int start = 15;
        private int end = 15;

        public AListR()
        {
            aList = new int[30];
        }

        public int Size()
        {
            int res;
            if (end >= start)
            {
                res = end - start;
            }
            else
            {
                res = aList.Length - start + end;
            }
            return res;
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
            int size = Size();
            int[] res = new int[size];
            if (end >= start)
            {
                for (int i = start; i < end; i++)
                {
                    res[i - start] = aList[i];
                }
            }
            else
            {
                for (int i = start; i < aList.Length; i++)
                {
                    res[i - start] = aList[i];
                }
                for (int i = 0; i < end; i++)
                {
                    res[aList.Length - start + i] = aList[i];
                }
            }
            return res;
        }

        public void AddStart(int element)
        {
            if (start == end)
            {
                Extend(aList.Length + 1);
            }
            if (start == 0)
            {
                start = aList.Length;
            }
            start--;
            aList[start] = element;
        }

        public void AddEnd(int element)
        {
            if (end == start)
            {
                Extend(aList.Length + 1);
            }
            if (end == aList.Length)
            {
                end = 0;
            }
            end++;
            aList[end - 1] = element;
        }

        public void AddPos(int pos, int element)
        {
            int size = Size();
            if (pos >= size)
            {
                if (size > 0)
                {
                    throw new ArgumentOutOfRangeException("There is no element in the position {0}", pos.ToString());
                }
                else
                {
                    throw new InvalidOperationException("This method can't be used for an empty AList0");
                }
            }
            if (start == end)
            {
                Extend(aList.Length + 1);
            }
            if (start > end)
            {
                if (aList.Length - start > pos)
                {
                    pos = start + pos;
                    end++;
                    for (int i = end; i > 0; i--)
                    {
                        aList[i] = aList[i - 1];
                    }
                    aList[0] = aList[aList.Length - 1];
                    for (int i = aList.Length - 1; i <= pos; i++)
                    {
                        aList[i] = aList[i + 1];
                    }
                }
                else
                {
                    pos = pos - (aList.Length - start);
                    end++;
                    for (int i = end; i > pos; i--)
                    {
                        aList[i] = aList[i - 1];
                    }
                }
                aList[pos] = element;
            }
            else
            {
                end++;
                for (int i = end; i >= pos + start; i--)
                {
                    aList[i] = aList[i - 1];
                }
                aList[pos + start] = element;
            }
        }

        public int DelStart()
        {
            if (start == end)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            int res = aList[start];
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
            return res;
        }

        public int DelPos(int pos)
        {
            int size = Size();
            if (pos >= size)
            {
                if (size > 0)
                {
                    throw new ArgumentOutOfRangeException("There is no element in the position {0}", pos.ToString());
                }
                else
                {
                    throw new InvalidOperationException("This method can't be used for an empty AList0");
                }
            }
            int res;
            if (start == end)
            {
                Extend(aList.Length + 1);
            }
            if (start > end)
            {
                if (aList.Length - start > pos)
                {
                    pos = start + pos;
                    res = aList[pos];
                    for (int i = pos; i < start; i++)
                    {
                        aList[i] = aList[i + 1];
                    }
                    start++;
                }
                else
                {
                    pos = pos - (aList.Length - start);
                    res = aList[pos];
                    end--;
                    for (int i = pos; i < end; i++)
                    {
                        aList[i] = aList[i + 1];
                    }
                }
            }
            else
            {
                end--;
                res = aList[pos + start];
                for (int i = pos + start; i < end; i++)
                {
                    aList[i] = aList[i + 1];
                }
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
            if (start > end)
            {
                for (int i = start; i < aList.Length; i++)
                {
                    if (aList[i] < res)
                    {
                        res = aList[i];
                    }
                }
                for (int i = 0; i < end; i++)
                {
                    if (aList[i] < res)
                    {
                        res = aList[i];
                    }
                }
            }
            else
            {
                for (int i = start + 1; i < end; i++)
                {
                    if (aList[i] < res)
                    {
                        res = aList[i];
                    }
                }
            }
            return res;
        }

        public int Max()
        {
            int res = start;
            if (start == end)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            res = aList[start];
            if (start > end)
            {
                for (int i = start; i < aList.Length; i++)
                {
                    if (aList[i] > res)
                    {
                        res = aList[i];
                    }
                }
                for (int i = 0; i < end; i++)
                {
                    if (aList[i] > res)
                    {
                        res = aList[i];
                    }
                }
            }
            else
            {
                for (int i = start + 1; i < end; i++)
                {
                    if (aList[i] > res)
                    {
                        res = aList[i];
                    }
                }
            }
            return res;
        }

        public int MinI()
        {
            int res = start;
            int resEl = aList[start];
            if (start == end)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            res = start;
            if (start > end)
            {
                for (int i = start; i < aList.Length; i++)
                {
                    if (aList[i] < resEl)
                    {
                        res = i;
                        resEl = aList[i];
                    }
                }
                res = res - start;
                for (int i = 0; i < end; i++)
                {
                    if (aList[i] < resEl)
                    {
                        res = i;
                        resEl = aList[i];
                    }
                }
                res = res + (aList.Length - start - 1);//-1
            }
            else
            {
                for (int i = start + 1; i < end; i++)
                {
                    if (aList[i] < aList[res])
                    {
                        res = i;
                    }
                }
                res = res - start;
            }
            return res;
        }

        public int MaxI()
        {
            int res = start;
            int resEl = aList[start];
            if (start == end)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            if (start > end)
            {
                for (int i = start; i < aList.Length; i++)
                {
                    if (aList[i] > resEl)
                    {
                        res = i;
                        resEl = aList[i];
                    }
                }
                res = res - start;
                for (int i = 0; i < end; i++)
                {
                    if (aList[i] > resEl)
                    {
                        res = i;
                        resEl = aList[i];
                    }
                }
                res = res + (aList.Length - start - 1);//-1
            }
            else
            {
                for (int i = start + 1; i < end; i++)
                {
                    if (aList[i] > aList[res])
                    {
                        res = i;
                    }
                }
                res = res - start;
            }
            return res;
        }

        public void Reverse()
        {
            int size = Size();
            if (size == 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            int n = (int)(size / 2.0);
            if (start < end)
            {
                for (int i = 0; i < n; i++)
                {
                    if (start + size - 1 - i != start + i)
                    {
                        aList[start + size - 1 - i] = aList[start + i] + aList[start + size - 1 - i];
                        aList[start + i] = aList[start + size - 1 - i] - aList[start + i];
                        aList[start + size - 1 - i] = aList[start + size - 1 - i] - aList[start + i];
                    }
                }
            }
            else
            {
                int k = aList.Length - start;
                for (int i = end; i > end - n; i--)
                {
                    if (i - end < k)
                    {
                        if (start + size - 1 - i != start + i)
                        {
                            aList[start + end - i] = aList[i] + aList[start + end - i];
                            aList[i] = aList[start + end - i] - aList[i];
                            aList[start + end - i] = aList[start + end - i] - aList[i];
                        }
                    }
                    else
                    {
                        if (size - i - k - 1 != i)
                        {
                            aList[size - i - k - 1] = aList[i] + aList[size - i - k - 1];
                            aList[i] = aList[size - i - k - 1] - aList[i];
                            aList[size - i - k - 1] = aList[size - i - k - 1] - aList[i];
                        }
                    }
                }
            }
        }

        public void HalfReverse()
        {
            int size = Size();
            if (size == 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            int k = 0;
            int n = (int)(size / 2.0);
            if ((size) % 2 != 0)
            {
                k = 1;
            }
            if (start < end)
            {
                for (int i = 0; i < n; i++)
                {
                    aList[start + n + i + k] += aList[start + i];
                    aList[start + i] = aList[start + n + i + k] - aList[start + i];
                    aList[start + n + i + k] = aList[start + n + i + k] - aList[start + i];
                }
            }
            else
            {
                int dif = aList.Length - start;
                for (int i=0; i<n; i++)
                {
                    if (i > dif)
                    {
                        aList[n + i + k-dif] += aList[i];
                        aList[i] = aList[n + i + k - dif] - aList[i];
                        aList[n + i + k - dif] = aList[n + i + k - dif] - aList[i];
                    }
                    else
                    {
                        aList[n + i + k - dif] += aList[start + i];
                        aList[start + i] = aList[n + i + k - dif] - aList[start + i];
                        aList[n + i + k - dif] = aList[n + i + k - dif] - aList[start + i];
                    }
                }
            }
        }

        public int Get(int pos)
        {
            int size = Size();
            if (pos >= size)
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
            int res = aList[pos + start];
            if (start > end)
            {
                if (pos < (aList.Length - start))
                {
                    res = aList[start + pos];
                }
                else
                {
                    res = aList[pos - aList.Length + start];
                }
            }
            return res;
        }

        public void Set(int pos, int value)
        {
            int size = Size();
            if (pos >= size)
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
            if (start > end)
            {
                if (pos < (aList.Length - start))
                {
                    aList[start + pos] = value;
                }
                else
                {
                    aList[pos - aList.Length + start] = value;
                }
            }
            else
            {
                aList[pos + start] = value;
            }
        }

        public void Sort()
        {
            int size = Size();
            if (size == 0)
            {
                throw new InvalidOperationException("This method can't be used for an empty AList0");
            }
            if (start < end)
            {
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
            else
            {
                for (int i = start; i < aList.Length; i++)
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
                    for (int j = 0; j < end; j++)
                    {
                        if (aList[i] > aList[j])
                        {
                            aList[j] += aList[i];
                            aList[i] = aList[j] - aList[i];
                            aList[j] = aList[j] - aList[i];
                        }
                    }
                }
                for (int i = 0; i < end; i++)
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
