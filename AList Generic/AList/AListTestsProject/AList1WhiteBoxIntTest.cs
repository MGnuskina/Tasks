using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AList;

namespace AListTestsProject
{
    [TestClass]
    public class AList1WhiteBoxIntTest
    {
        #region Size
        [TestMethod]
        public void AListSize16Test()
        {
            var a = new AList1<int>();
            int[] mas = new int[16];
            a.Init(mas);
            int size = a.Size();
            Assert.AreEqual(16, size);
        }
        #endregion

        #region Clear
        [TestMethod]
        public void AListClear16Test()
        {
            var a = new AList1<int>();
            int[] mas = new int[16];
            a.Init(mas);
            a.Clear();
            int size = a.Size();
            Assert.AreEqual(0, size);
        }
        #endregion

        #region ToArrey
        [TestMethod]
        public void AListTOArrey16Test()
        {
            int[] mas = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            var a = new AList1<int>();
            a.Init(mas);
            int size = a.Size();
            Assert.AreEqual(16, size);
            CollectionAssert.AreEqual(mas, a.ToArray());
        }
        #endregion

        #region AddStart
        [TestMethod]
        public void AListAddStart16Test()
        {
            int[] mas = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            var a = new AList1<int>();
            a.Init(mas);
            a.AddStart(-1);
            int size = a.Size();
            Assert.AreEqual(17, size);
            mas = new int[17] { -1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            CollectionAssert.AreEqual(mas, a.ToArray());
        }
        #endregion

        #region AddEnd
        [TestMethod]
        public void AListAddEnd16Test()
        {
            int[] mas = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            var a = new AList1<int>();
            a.Init(mas);
            a.AddEnd(-1);
            int size = a.Size();
            Assert.AreEqual(17, size);
            mas = new int[17] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, -1 };
            CollectionAssert.AreEqual(mas, a.ToArray());
        }
        #endregion

        #region AddPos
        [TestMethod]
        public void AListAddPos16Test()
        {
            int[] mas = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            var a = new AList1<int>();
            a.Init(mas);
            a.AddPos(5, -1);
            int size = a.Size();
            Assert.AreEqual(17, size);
            mas = new int[17] { 1, 2, 3, 4, 5, -1, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            CollectionAssert.AreEqual(mas, a.ToArray());
        }
        #endregion

        #region DelStart
        [TestMethod]
        public void AListDelStart16Test()
        {
            int[] mas = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            var a = new AList1<int>();
            a.Init(mas);
            int res = a.DelStart();
            int size = a.Size();
            Assert.AreEqual(15, size);
            Assert.AreEqual(1, res);
            mas = new int[15] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            CollectionAssert.AreEqual(mas, a.ToArray());
        }
        #endregion

        #region DelEnd
        [TestMethod]
        public void AListDelEnd16Test()
        {
            int[] mas = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            var a = new AList1<int>();
            a.Init(mas);
            int res = a.DelEnd();
            int size = a.Size();
            Assert.AreEqual(15, size);
            Assert.AreEqual(16, res);
            mas = new int[15] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            CollectionAssert.AreEqual(mas, a.ToArray());
        }
        #endregion

        #region DelPos
        [TestMethod]
        public void AListDelPos16Test()
        {
            int[] mas = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            var a = new AList1<int>();
            a.Init(mas);
            int res = a.DelPos(3);
            int size = a.Size();
            Assert.AreEqual(15, size);
            Assert.AreEqual(4, res);
            mas = new int[15] { 1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            CollectionAssert.AreEqual(mas, a.ToArray());
        }
        #endregion

        #region Min
        [TestMethod]
        public void AListMin16Test()
        {
            int[] mas = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            var a = new AList1<int>();
            a.Init(mas);
            int res = a.Min();
            Assert.AreEqual(1, res);
        }
        #endregion

        #region Max
        [TestMethod]
        public void AListMax16Test()
        {
            int[] mas = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            var a = new AList1<int>();
            a.Init(mas);
            int res = a.Max();
            Assert.AreEqual(16, res);
        }
        #endregion

        #region MinI
        [TestMethod]
        public void AListMinI16Test()
        {
            int[] mas = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            var a = new AList1<int>();
            a.Init(mas);
            int res = a.MinI();
            Assert.AreEqual(0, res);
        }
        #endregion

        #region MaxI
        [TestMethod]
        public void AListMaxI16Test()
        {
            int[] mas = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            var a = new AList1<int>();
            a.Init(mas);
            int res = a.MaxI();
            Assert.AreEqual(15, res);
        }
        #endregion

        #region Reverse
        [TestMethod]
        public void AListREverse16Test()
        {
            int[] mas = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            var a = new AList1<int>();
            a.Init(mas);
            a.Reverse();
            int size = a.Size();
            Assert.AreEqual(16, size);
            mas = new int[16] { 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            CollectionAssert.AreEqual(mas, a.ToArray());
        }
        #endregion

        #region HalfReverse
        [TestMethod]
        public void AListHalfREverseEven16Test()
        {
            int[] mas = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            var a = new AList1<int>();
            a.Init(mas);
            a.HalfReverse();
            int size = a.Size();
            Assert.AreEqual(16, size);
            mas = new int[16] { 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8 };
            CollectionAssert.AreEqual(mas, a.ToArray());
        }

        [TestMethod]
        public void AListHalfREverseOdd16Test()
        {
            int[] mas = new int[15] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var a = new AList1<int>();
            a.Init(mas);
            a.HalfReverse();
            int size = a.Size();
            Assert.AreEqual(15, size);
            mas = new int[15] { 9, 10, 11, 12, 13, 14, 15, 8, 1, 2, 3, 4, 5, 6, 7 };
            CollectionAssert.AreEqual(mas, a.ToArray());
        }
        #endregion

        #region Get
        [TestMethod]
        public void AListGet16Test()
        {
            int[] mas = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            var a = new AList1<int>();
            a.Init(mas);
            int res = a.Get(3);
            Assert.AreEqual(4, res);
        }
        #endregion

        #region Set
        [TestMethod]
        public void AListSet16Test()
        {
            int[] mas = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            var a = new AList1<int>();
            a.Init(mas);
            a.Set(8, -3);
            mas = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, -3, 10, 11, 12, 13, 14, 15, 16 };
            Assert.AreEqual(16, a.Size());
            Assert.AreEqual(-3, a.Get(8));
            CollectionAssert.AreEqual(mas, a.ToArray());
        }
        #endregion

        #region Sort
        [TestMethod]
        public void AListSort16Test()
        {
            int[] mas = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            var a = new AList1<int>();
            a.Init(mas);
            a.Sort();
            mas = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            Assert.AreEqual(16, a.Size());
            CollectionAssert.AreEqual(mas, a.ToArray());
        }
        #endregion
    }
}
