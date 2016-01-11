using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AList0IE
{
    public class AList0IEn : IEnumerator<int>
    {
        int[] alist = new int[0];
        int i = -1;

        public AList0IEn(int[] mas)
        {
            if (mas.Length > 0)
            {
                alist = new int[mas.Length];
                alist = mas;
                i = 0;
            }
        }

        public int Current
        {
            get
            {
                return alist[i];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
            alist = new int[0];
        }

        public bool MoveNext()
        {
            bool res = false;
            if (alist.Length>(i+1))
            {
                i++;
                res = true;
            }
            return res;
        }

        public void Reset()
        {
            i = 0;
        }
    }
}
