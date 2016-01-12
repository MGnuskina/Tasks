using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AList;

namespace AListTestsProject
{
    [TestClass]
    public class AList0Test//:AListTest
    {
        public IAList a = new AList0();
        public IAList expectedRes = new AList0();

        #region Size
        [TestMethod]
        public void AList0Size5Test()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            int size = a.Size();
            Assert.AreEqual(5, size);
        }

        [TestMethod]
        public void AList0Size0Test()
        {
            int[] mas = new int[0];
            a.Init(mas);
            int size = a.Size();
            Assert.AreEqual(0, size);
        }

        [TestMethod]
        public void AList0SizeEmptyTest()
        {
            int size = a.Size();
            Assert.AreEqual(0, size);
        }
        #endregion

        #region Clear
        [TestMethod]
        public void AList0ClearTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            a.Clear();
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList0ClearEmptyTest()
        {
            a.Clear();
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }
        #endregion

        #region Init //????
        #endregion

        #region ToArray
        [TestMethod]
        public void AList0ToArrayTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            int[] res = a.ToArray();
            CollectionAssert.AreEqual(mas, res);
        }

        [TestMethod]
        public void AList0ToArrayTestEmpty()
        {
            int[] res = a.ToArray();
            CollectionAssert.AreEqual(res, new int[0]);
        }
        #endregion

        #region AddStart
        [TestMethod]
        public void AList0AddStartTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            mas = new int[] { 10, 1, 2, 3, 4, 5 };
            expectedRes.Init(mas);
            a.AddStart(10);
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList0AddStartToEmptyTest()
        {
            int[] mas = new int[] { 8 };
            expectedRes.Init(mas);
            a.AddStart(8);
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }
        #endregion

        #region AddEnd
        [TestMethod]
        public void AList0AddEndTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            mas = new int[] { 1, 2, 3, 4, 5, 10 };
            expectedRes.Init(mas);
            a.AddEnd(10);
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList0AddEndToEmptyTest()
        {
            int[] mas = new int[] { 10 };
            expectedRes.Init(mas);
            a.AddEnd(10);
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }
        #endregion

        #region AddPos
        [TestMethod]
        public void AList0AddPosBeginTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            mas = new int[] { 10, 1, 2, 3, 4, 5 };
            expectedRes.Init(mas);
            a.AddPos(0, 10);
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList0AddPosRandomTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            mas = new int[] { 1, 2, 3, 10, 4, 5 };
            expectedRes.Init(mas);
            a.AddPos(3, 10);
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        public void AList0AddPosToEmptyTest()
        {
            a.AddPos(10, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "There is no element in the position")]
        public void AList0AddPosPosNotExistTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            a.AddPos(10, 10);
        }
        #endregion

        #region DelStart
        [TestMethod]
        public void AList0DelStartTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            int expectedRes = 1;
            int res = a.DelStart();
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        public void AList0DelStartEmptyTest()
        {
            a.DelStart();
        }
        #endregion

        #region DelEnd
        [TestMethod]
        public void AList0DelEndTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            int expectedRes = 5;
            int res = a.DelEnd();
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        public void AList0DelEndEmptyTest()
        {
            a.DelEnd();
        }
        #endregion

        #region DelPos
        [TestMethod]
        public void AList0DelPosRandomTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            int expectedRes = 3;
            int res = a.DelPos(2);
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        public void AList0DelPosEmptyTest()
        {
            a.DelPos(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "There is no element in the position")]
        public void AList0DelPosPosNotExistTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            a.DelPos(10);
        }
        #endregion

        #region Min
        [TestMethod]
        public void AList0MinRandomTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, -2, 4 };
            a.Init(mas);
            int res = a.Min();
            int expectedRes = -2;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        public void AList0MinMultipleTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, -2, 4, -2 };
            a.Init(mas);
            int res = a.Min();
            int expectedRes = -2;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        public void AList0MinEmptyTest()
        {
            a.Min();
        }
        #endregion

        #region Max
        [TestMethod]
        public void AList0MaxRandomTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, -2, 4 };
            a.Init(mas);
            int res = a.Max();
            int expectedRes = 5;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        public void AList0MaxMultipleTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, -2, 4, 5 };
            a.Init(mas);
            int res = a.Max();
            int expectedRes = 5;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        public void AList0MaxEmptyTest()
        {
            a.Max();
        }
        #endregion

        #region MinI
        [TestMethod]
        public void AList0MinIRandomTest()
        {
            int[] mas = new int[] { 1, 2, 5, -2, 4 };
            a.Init(mas);
            int res = a.MinI();
            int expectedRes = 3;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        public void AList0MinIMultipleTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, -2, 4, -2 };
            a.Init(mas);
            int res = a.MinI();
            int expectedRes = 5;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        public void AList0MinIEmptyTest()
        {
            a.MinI();
        }
        #endregion

        #region MaxI
        [TestMethod]
        public void AList0MaxIRandomTest()
        {
            int[] mas = new int[] { 5, -2, 4 };
            a.Init(mas);
            int res = a.MaxI();
            int expectedRes = 0;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        public void AList0MaxIMultipleTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, -2, 4, 5 };
            a.Init(mas);
            int res = a.MaxI();
            int expectedRes = 4;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        public void AList0MaxIEmptyTest()
        {
            a.Min();
        }
        #endregion

        #region Reverse
        [TestMethod]
        public void AList0ReversOddTest()
        {
            int[] mas = new int[] { 1, 2, -3, 4, 5, -2, 6 };
            a.Init(mas);
            mas = new int[] { 6, -2, 5, 4, -3, 2, 1 };
            expectedRes.Init(mas);
            a.Reverse();
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList0ReversEvenTest()
        {
            int[] mas = new int[] { 1, 2, -3, 4 };
            a.Init(mas);
            mas = new int[] { 4, -3, 2, 1 };
            expectedRes.Init(mas);
            a.Reverse();
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList0ReverseOneElTest()
        {
            int[] mas = new int[] { 1 };
            a.Init(mas);
            mas = new int[] { 1 };
            expectedRes.Init(mas);
            a.Reverse();
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        public void AList0ReverseEmptyTest()
        {
            a.Reverse();
        }
        #endregion

        #region HalfReverse
        [TestMethod]
        public void AList0HalfReverseOddTest()
        {
            int[] mas = new int[] { 1, 2, -3, 4, 5, -2, 6 };
            a.Init(mas);
            mas = new int[] { 5, -2, 6, 4, 1, 2, -3 };
            expectedRes.Init(mas);
            a.HalfReverse();
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList0HalfReverseEvenTest()
        {
            int[] mas = new int[] { 1, 2, -3, 4, 5, -2 };
            a.Init(mas);
            mas = new int[] { 4, 5, -2, 1, 2, -3 };
            expectedRes.Init(mas);
            a.HalfReverse();
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        public void AList0HalfReverseEmptyTest()
        {
            a.HalfReverse();
        }
        #endregion

        #region Get
        [TestMethod]
        public void AList0GetOneEllTest()
        {
            int[] mas = new int[] { 1 };
            a.Init(mas);
            int expectedRes = 1;
            int res = a.Get(0);
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        public void AList0GetRandomTest()
        {
            int[] mas = new int[] { 1, 2, -3, 4, 5, -2 };
            a.Init(mas);
            int expectedRes = 4;
            int res = a.Get(3);
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        public void AList0GetEmptyTest()
        {
            a.Get(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "There is no element in the position")]
        public void AList0GetPosNotExistTest()
        {
            int[] mas = new int[] { 1, 2, -3, 4, 5, -2 };
            a.Init(mas);
            a.Get(8);
        }
        #endregion

        #region Set
        [TestMethod]
        public void AList0SetOneEllTest()
        {
            int[] mas = new int[] { 1 };
            a.Init(mas);
            mas = new int[] { 3 };
            expectedRes.Init(mas);
            a.Set(0, 3);
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList0SetRandomTest()
        {
            int[] mas = new int[] { 1, 2, -3, 4, 5, -2 };
            a.Init(mas);
            mas = new int[] { 1, 2, -3, 77, 5, -2 };
            expectedRes.Init(mas);
            a.Set(3, 77);
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        public void AList0SetEmptyTest()
        {
            a.Set(0, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "There is no element in the position")]
        public void AList0SetPosNotExistTest()
        {
            int[] mas = new int[] { 1, 2, -3, 4, 5, -2 };
            a.Init(mas);
            a.Set(8, 11);
        }
        #endregion

        #region Sort
        [TestMethod]
        public void AList0SortRandomTest()
        {
            int[] mas = new int[] { 1, 2, -3, 4, 5, -2, 6 };
            a.Init(mas);
            mas = new int[] { -3, -2, 1, 2, 4, 5, 6 };
            expectedRes.Init(mas);
            a.Sort();
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList0SortOneElTest()
        {
            int[] mas = new int[] { 1 };
            a.Init(mas);
            mas = new int[] { 1 };
            expectedRes.Init(mas);
            a.Sort();
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        public void AList0SortEmptyTest()
        {
            a.Sort();
        }
        #endregion
    }
}
