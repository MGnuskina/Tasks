using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AList
{
    public interface IAList
    {
        int Size();
        void Clear();
        void Init(int[] array);
        int[] ToArray();
        void AddStart(int element);
        void AddEnd(int element);
        void AddPos(int pos, int element);
        int DelStart();
        int DelEnd();
        int DelPos(int pos);
        int Min();
        int Max();
        int MinI();
        int MaxI();
        void Reverse();
        void HalfReverse();
        int Get(int pos);
        void Set(int pos, int value);
        void Sort();
    }
}
