using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AList;

namespace AListTestsProject
{
    [TestClass]
    public class Alist1Test
    {
        public IAList a = new AList1();
        public IAList expectedRes = new AList1();

        #region Size
        [TestMethod]
        public void AList1Size5Test()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            int size = a.Size();
            Assert.AreEqual(5, size);
        }

        [TestMethod]
        public void AList1Size15Test()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, 4, 6, 7, 8, 7, 6, 5, 4, 3, 1 };
            a.Init(mas);
            int size = a.Size();
            Assert.AreEqual(15, size);
        }

        [TestMethod]
        public void AList1Size0Test()
        {
            int[] mas = new int[0];
            a.Init(mas);
            int size = a.Size();
            Assert.AreEqual(0, size);
        }

        [TestMethod]
        public void AList1SizeEmptyTest()
        {
            int size = a.Size();
            Assert.AreEqual(0, size);
        }
        #endregion

        #region Clear
        [TestMethod]
        public void AList1ClearTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            a.Clear();
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList1ClearWith15ElTest()//
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, 4, 6, 7, 8, 7, 6, 5, 4, 3, 1 };
            a.Init(mas);
            a.Clear();
            int length = (a.ToArray()).Length;
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList1ClearEmptyTest()
        {
            a.Clear();
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }
        #endregion

        #region Init //????
        #endregion

        #region ToArray
        [TestMethod]
        public void AList1ToArrayTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            int[] res = a.ToArray();
            CollectionAssert.AreEqual(mas, res);
        }

        [TestMethod]
        public void AList1ToArrayMoreThen10Test()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, 2, 3, 4, 5, 2, 3, 4, 5, 2, 3, 4, 5 };
            a.Init(mas);
            int[] res = a.ToArray();
            CollectionAssert.AreEqual(mas, res);
        }

        [TestMethod]
        public void AList1ToArrayTestEmpty()
        {
            int[] res = a.ToArray();
            CollectionAssert.AreEqual(res, new int[0]);
        }
        #endregion

        #region AddStart
        [TestMethod]
        public void AList1AddStartTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            mas = new int[] { 10, 1, 2, 3, 4, 5 };
            expectedRes.Init(mas);
            a.AddStart(10);
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList1AddStartToEmptyTest()
        {
            int[] mas = new int[] { 8 };
            expectedRes.Init(mas);
            a.AddStart(8);
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }
        #endregion

        #region AddEnd
        [TestMethod]
        public void AList1AddEndTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas); ;
            mas = new int[] { 1, 2, 3, 4, 5, 10 };
            expectedRes.Init(mas);
            a.AddEnd(10);
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList1AddEndToEmptyTest()
        {
            int[] mas = new int[] { 10 };
            expectedRes.Init(mas);
            a.AddEnd(10);
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }
        #endregion

        #region AddPos
        [TestMethod]
        public void AList1AddPosBeginTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            mas = new int[] { 10, 1, 2, 3, 4, 5 };
            expectedRes.Init(mas);
            a.AddPos(0, 10);
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList1AddPosRandomTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            mas = new int[] { 1, 2, 3, 10, 4, 5 };
            expectedRes.Init(mas);
            a.AddPos(3, 10);
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList1")]
        public void AList1AddPosToEmptyTest()
        {
            a.AddPos(10, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "There is no element in the position")]
        public void AList1AddPosPosNotExistTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            a.AddPos(10, 10);
        }
        #endregion

        #region DelStart
        [TestMethod]
        public void AList1DelStartTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            int expectedRes = 1;
            int res = a.DelStart();
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList1")]
        public void AList1DelStartEmptyTest()
        {
            a.DelStart();
        }
        #endregion

        #region DelEnd
        [TestMethod]
        public void AList1DelEndTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            int expectedRes = 5;
            int res = a.DelEnd();
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList1")]
        public void AList1DelEndEmptyTest()
        {
            a.DelEnd();
        }
        #endregion

        #region DelPos
        [TestMethod]
        public void AList1DelPosRandomTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            int expectedRes = 3;
            int res = a.DelPos(2);
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList1")]
        public void AList1DelPosEmptyTest()
        {
            a.DelPos(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "There is no element in the position")]
        public void AList1DelPosPosNotExistTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            a.DelPos(10);
        }
        #endregion

        #region Min
        [TestMethod]
        public void AList1MinRandomTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, -2, 4 };
            a.Init(mas);
            int res = a.Min();
            int expectedRes = -2;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        public void AList1MinMultipleTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, -2, 4, -2 };
            a.Init(mas);
            int res = a.Min();
            int expectedRes = -2;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList1")]
        public void AList1MinEmptyTest()
        {
            a.Min();
        }
        #endregion

        #region Max
        [TestMethod]
        public void AList1MaxRandomTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, -2, 4 };
            a.Init(mas);
            int res = a.Max();
            int expectedRes = 5;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        public void AList1MaxMultipleTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, -2, 4, 5 };
            a.Init(mas);
            int res = a.Max();
            int expectedRes = 5;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList1")]
        public void AList1MaxEmptyTest()
        {
            a.Max();
        }
        #endregion

        #region MinI
        [TestMethod]
        public void AList1MinIRandomTest()
        {
            int[] mas = new int[] { 1, 2, 5, -2, 4 };
            a.Init(mas);
            int res = a.MinI();
            int expectedRes = 3;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        public void AList1MinIMultipleTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, -2, 4, -2 };
            a.Init(mas);
            int res = a.MinI();
            int expectedRes = 5;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList1")]
        public void AList1MinIEmptyTest()
        {
            a.MinI();
        }
        #endregion

        #region MaxI
        [TestMethod]
        public void AList1MaxIRandomTest()
        {
            int[] mas = new int[] { 5, -2, 4 };
            a.Init(mas);
            int res = a.MaxI();
            int expectedRes = 0;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        public void AList1MaxIMultipleTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, -2, 4, 5 };
            a.Init(mas);
            int res = a.MaxI();
            int expectedRes = 4;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList1")]
        public void AList1MaxIEmptyTest()
        {
            a.Min();
        }
        #endregion

        #region Reverse
        [TestMethod]
        public void AList1ReversOddTest()
        {
            int[] mas = new int[] { 1, 2, -3, 4, 5, -2, 6 };
            a.Init(mas);
            mas = new int[] { 6, -2, 5, 4, -3, 2, 1 };
            expectedRes.Init(mas);
            a.Reverse();
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList1ReversEvenTest()
        {
            int[] mas = new int[] { 1, 2, -3, 4 };
            a.Init(mas);
            mas = new int[] { 4, -3, 2, 1 };
            expectedRes.Init(mas);
            a.Reverse();
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList1ReverseOneElTest()
        {
            int[] mas = new int[] { 1 };
            a.Init(mas);
            mas = new int[] { 1 };
            expectedRes.Init(mas);
            a.Reverse();
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList1")]
        public void AList1ReverseEmptyTest()
        {
            a.Reverse();
        }
        #endregion

        #region HalfReverse
        [TestMethod]
        public void AList1HalfReverseOddTest()
        {
            int[] mas = new int[] { 1, 2, -3, 4, 5, -2, 6 };
            a.Init(mas);
            mas = new int[] { 5, -2, 6, 4, 1, 2, -3 };
            expectedRes.Init(mas);
            a.HalfReverse();
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList1HalfReverseEvenTest()
        {
            int[] mas = new int[] { 1, 2, -3, 4, 5, -2 };
            a.Init(mas);
            mas = new int[] { 4, 5, -2, 1, 2, -3 };
            expectedRes.Init(mas);
            a.HalfReverse();
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList1")]
        public void AList1HalfReverseEmptyTest()
        {
            a.HalfReverse();
        }
        #endregion

        #region Get
        [TestMethod]
        public void AList1GetOneEllTest()
        {
            int[] mas = new int[] { 1 };
            a.Init(mas);
            int expectedRes = 1;
            int res = a.Get(0);
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        public void AList1GetRandomTest()
        {
            int[] mas = new int[] { 1, 2, -3, 4, 5, -2 };
            a.Init(mas);
            int expectedRes = 4;
            int res = a.Get(3);
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList1")]
        public void AList1GetEmptyTest()
        {
            a.Get(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "There is no element in the position")]
        public void AList1GetPosNotExistTest()
        {
            int[] mas = new int[] { 1, 2, -3, 4, 5, -2 };
            a.Init(mas);
            a.Get(8);
        }
        #endregion

        #region Set
        [TestMethod]
        public void AList1SetOneEllTest()
        {
            int[] mas = new int[] { 1 };
            a.Init(mas);
            mas = new int[] { 3 };
            expectedRes.Init(mas);
            a.Set(0, 3);
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList1SetRandomTest()
        {
            int[] mas = new int[] { 1, 2, -3, 4, 5, -2 };
            a.Init(mas);
            mas = new int[] { 1, 2, -3, 77, 5, -2 };
            expectedRes.Init(mas);
            a.Set(3, 77);
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList1")]
        public void AList1SetEmptyTest()
        {
            a.Set(0, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "There is no element in the position")]
        public void AList1SetPosNotExistTest()
        {
            int[] mas = new int[] { 1, 2, -3, 4, 5, -2 };
            a.Init(mas);
            a.Set(8, 11);
        }
        #endregion

        #region Sort
        [TestMethod]
        public void AList1SortRandomTest()
        {
            int[] mas = new int[] { 1, 2, -3, 4, 5, -2, 6 };
            a.Init(mas);
            mas = new int[] { -3, -2, 1, 2, 4, 5, 6 };
            expectedRes.Init(mas);
            a.Sort();
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList1SortOneElTest()
        {
            int[] mas = new int[] { 1 };
            a.Init(mas);
            mas = new int[] { 1 };
            expectedRes.Init(mas);
            a.Sort();
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList1")]
        public void AList1SortEmptyTest()
        {
            a.Sort();
        }
        #endregion
    }
}
