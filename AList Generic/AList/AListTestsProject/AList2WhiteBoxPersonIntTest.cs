using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AList;

namespace AListTestsProject
{
    [TestClass]
    public class AList2WhiteBoxPersonIntTest
    {
        #region Size
        [TestMethod]
        public void AListSize36Test()
        {
            int[] mas = new int[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
            var a = new AList2<int>();
            a.Init(mas);
            int size = a.Size();
            Assert.AreEqual(36, size);
        }
        #endregion

        #region Clear
        [TestMethod]
        public void AListClear36Test()
        {
            int[] mas = new int[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
            var a = new AList2<int>();
            a.Init(mas);
            a.Clear();
            int size = a.Size();
            Assert.AreEqual(0, size);
        }
        #endregion

        #region ToArrey
        [TestMethod]
        public void AListTOArrey36Test()
        {
            int[] mas = new int[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
            var a = new AList2<int>();
            a.Init(mas);
            int size = a.Size();
            Assert.AreEqual(36, size);
            CollectionAssert.AreEqual(mas, a.ToArray());
        }
        #endregion

        #region AddStart
        [TestMethod]
        public void AListAddstart36Test()
        {
            int[] mas = new int[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
            var a = new AList2<int>();
            a.Init(mas);
            a.AddStart(-1);
            int size = a.Size();
            mas = new int[37] { -1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
            Assert.AreEqual(37, size);
            CollectionAssert.AreEqual(mas, a.ToArray());
        }
        #endregion

        #region AddEnd
        [TestMethod]
        public void AListAddEnd36Test()
        {
            int[] mas = new int[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
            var a = new AList2<int>();
            a.Init(mas);
            a.AddEnd(-1);
            int size = a.Size();
            mas = new int[37] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36, -1 };
            Assert.AreEqual(37, size);
            CollectionAssert.AreEqual(mas, a.ToArray());
        }
        #endregion

        #region AddPos
        [TestMethod]
        public void AListAddPos36Test()
        {
            int[] mas = new int[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
            var a = new AList2<int>();
            a.Init(mas);
            a.AddPos(2, -1);
            int size = a.Size();
            mas = new int[37] { 1, 2, -1, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
            Assert.AreEqual(37, size);
            CollectionAssert.AreEqual(mas, a.ToArray());
        }
        #endregion

        #region DelStart
        [TestMethod]
        public void AListDelStart36Test()
        {
            int[] mas = new int[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
            var a = new AList2<int>();
            a.Init(mas);
            int res = a.DelStart();
            int size = a.Size();
            mas = new int[35] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
            Assert.AreEqual(35, size);
            Assert.AreEqual(1, res);
            CollectionAssert.AreEqual(mas, a.ToArray());
        }
        #endregion

        #region DelEnd
        [TestMethod]
        public void AListDelEnd36Test()
        {
            int[] mas = new int[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
            var a = new AList2<int>();
            a.Init(mas);
            int res = a.DelEnd();
            int size = a.Size();
            mas = new int[35] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35 };
            Assert.AreEqual(35, size);
            Assert.AreEqual(36, res);
            CollectionAssert.AreEqual(mas, a.ToArray());
        }
        #endregion

        #region DelEnd
        [TestMethod]
        public void AListDelpos36Test()
        {
            int[] mas = new int[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
            var a = new AList2<int>();
            a.Init(mas);
            int res = a.DelPos(5);
            int size = a.Size();
            mas = new int[35] { 1, 2, 3, 4, 5, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
            Assert.AreEqual(35, size);
            Assert.AreEqual(6, res);
            CollectionAssert.AreEqual(mas, a.ToArray());
        }
        #endregion

        #region Min
        [TestMethod]
        public void AListMin36Test()
        {
            int[] mas = new int[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
            var a = new AList2<int>();
            a.Init(mas);
            int res = a.Min();
            Assert.AreEqual(1, res);
        }
        #endregion

        #region Max
        [TestMethod]
        public void AListMax36Test()
        {
            int[] mas = new int[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
            var a = new AList2<int>();
            a.Init(mas);
            int res = a.Max();
            Assert.AreEqual(36, res);
        }
        #endregion

        #region MinI
        [TestMethod]
        public void AListMinI36Test()
        {
            int[] mas = new int[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
            var a = new AList2<int>();
            a.Init(mas);
            int res = a.MinI();
            Assert.AreEqual(0, res);
        }
        #endregion

        #region MaxI
        [TestMethod]
        public void AListMaxI36Test()
        {
            int[] mas = new int[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
            var a = new AList2<int>();
            a.Init(mas);
            int res = a.MaxI();
            Assert.AreEqual(35, res);
        }
        #endregion

        #region Reverse
        [TestMethod]
        public void AListReverse36Test()
        {
            int[] mas = new int[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
            var a = new AList2<int>();
            a.Init(mas);
            a.Reverse();
            int size = a.Size();
            mas = new int[36] { 36, 35, 34, 33, 32, 31, 30, 29, 28, 27, 26, 25, 24, 23, 22, 21, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Assert.AreEqual(36, size);
            CollectionAssert.AreEqual(mas, a.ToArray());
        }
        #endregion

        #region HalfReverse
        [TestMethod]
        public void AListHalfReverseEven36Test()
        {
            int[] mas = new int[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, };
            var a = new AList2<int>();
            a.Init(mas);
            a.HalfReverse();
            int size = a.Size();
            mas = new int[36] { 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            Assert.AreEqual(36, size);
            CollectionAssert.AreEqual(mas, a.ToArray());
        }

        [TestMethod]
        public void AListHalfReverseOdd36Test()
        {
            int[] mas = new int[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
            var a = new AList2<int>();
            a.Init(mas);
            a.HalfReverse();
            int size = a.Size();
            mas = new int[36] { 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            Assert.AreEqual(36, size);
            CollectionAssert.AreEqual(mas, a.ToArray());
        }
        #endregion

        #region Get
        [TestMethod]
        public void AListGet36Test()
        {
            int[] mas = new int[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
            var a = new AList2<int>();
            a.Init(mas);
            int res = a.Get(6);
            Assert.AreEqual(7, res);
        }
        #endregion

        #region Set
        [TestMethod]
        public void AListSet36Test()
        {
            int[] mas = new int[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
            var a = new AList2<int>();
            a.Init(mas);
            a.Set(6, -7);
            Assert.AreEqual(36, a.Size());
            Assert.AreEqual(-7, a.Get(6));
            mas = new int[36] { 1, 2, 3, 4, 5, 6, -7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
            CollectionAssert.AreEqual(mas, a.ToArray());
        }
        #endregion

        #region Sort
        [TestMethod]
        public void AListSort36Test()
        {
            int[] mas = new int[36] { 1, 9, 10, 27, 28, 29, 30, 31, 32, 2, 3, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 4, 5, 6, 7, 8, 33, 34, 35, 36 };
            var a = new AList2<int>();
            a.Init(mas);
            a.Sort();
            Assert.AreEqual(36, a.Size());
            mas = new int[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
            CollectionAssert.AreEqual(mas, a.ToArray());
        }
        #endregion
    }
}
