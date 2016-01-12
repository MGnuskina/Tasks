using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AList
{
    public interface IAList<T> where T : IComparable
    {
        int Size();
        void Clear();
        void Init(T[] array);
        T[] ToArray();
        void AddStart(T element);
        void AddEnd(T element);
        void AddPos(int pos, T element);
        T DelStart();
        T DelEnd();
        T DelPos(int pos);
        T Min();
        T Max();
        int MinI();
        int MaxI();
        void Reverse();
        void HalfReverse();
        T Get(int pos);
        void Set(int pos, T value);
        void Sort();
    }
}
