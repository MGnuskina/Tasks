using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AList;

namespace AListTestsProject
{
    [TestClass]
    public class AList2Test
    {
        public IAList a = new AList2();
        public IAList expectedRes = new AList2();

        #region Size
        [TestMethod]
        public void AList2Size5Test()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            int size = a.Size();
            Assert.AreEqual(5, size);
        }

        [TestMethod]
        public void AList2Size0Test()
        {
            int[] mas = new int[0];
            a.Init(mas);
            int size = a.Size();
            Assert.AreEqual(0, size);
        }

        [TestMethod]
        public void AList2SizeEmptyTest()
        {
            int size = a.Size();
            Assert.AreEqual(0, size);
        }
        #endregion

        #region Clear
        [TestMethod]
        public void AList2ClearTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            a.Clear();
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList2ClearEmptyTest()
        {
            a.Clear();
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }
        #endregion

        #region Init //????
        #endregion

        #region ToArray
        [TestMethod]
        public void AList2ToArrayTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            int[] res = a.ToArray();
            CollectionAssert.AreEqual(mas, res);
        }

        [TestMethod]
        public void AList2ToArrayTestEmpty()
        {
            int[] res = a.ToArray();
            CollectionAssert.AreEqual(res, new int[0]);
        }
        #endregion

        #region AddStart
        [TestMethod]
        public void AList2AddStartTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            mas = new int[] { 10, 1, 2, 3, 4, 5 };
            expectedRes.Init(mas);
            a.AddStart(10);
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList2AddStartToEmptyTest()
        {
            int[] mas = new int[] { 8 };
            expectedRes.Init(mas);
            a.AddStart(8);
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }
        #endregion

        #region AddEnd
        [TestMethod]
        public void AList2AddEndTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            mas = new int[] { 1, 2, 3, 4, 5, 10 };
            expectedRes.Init(mas);
            a.AddEnd(10);
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList2AddEndToEmptyTest()
        {
            int[] mas = new int[] { 10 };
            expectedRes.Init(mas);
            a.AddEnd(10);
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }
        #endregion

        #region AddPos
        [TestMethod]
        public void AList2AddPosBeginOddTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            mas = new int[] { 10, 1, 2, 3, 4, 5 };
            expectedRes.Init(mas);
            a.AddPos(0, 10);
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList2AddPosBeginEvenTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, 8 };
            a.Init(mas);
            mas = new int[] { 10, 1, 2, 3, 4, 5, 8 };
            expectedRes.Init(mas);
            a.AddPos(0, 10);
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList2AddPosRandomOddTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            mas = new int[] { 1, 2, 3, 10, 4, 5 };
            expectedRes.Init(mas);
            a.AddPos(3, 10);
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList2AddPosRandomEvenTest()
        {
            int[] mas = new int[] { 1, 2, 33, 3, 4, 5 };
            a.Init(mas);
            mas = new int[] { 1, 2, 33, 10, 3, 4, 5 };
            expectedRes.Init(mas);
            a.AddPos(3, 10);
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList2")]
        public void AList2AddPosToEmptyTest()
        {
            a.AddPos(10, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "There is no element in the position")]
        public void AList2AddPosPosNotExistTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            a.AddPos(10, 10);
        }
        #endregion

        #region DelStart
        [TestMethod]
        public void AList2DelStartTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            int expectedRes = 1;
            int res = a.DelStart();
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList2")]
        public void AList2DelStartEmptyTest()
        {
            a.DelStart();
        }
        #endregion

        #region DelEnd
        [TestMethod]
        public void AList2DelEndTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            int expectedRes = 5;
            int res = a.DelEnd();
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList2")]
        public void AList2DelEndEmptyTest()
        {
            a.DelEnd();
        }
        #endregion

        #region DelPos
        [TestMethod]
        public void AList2DelPosRandomTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            int expectedRes = 3;
            int res = a.DelPos(2);
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList2")]
        public void AList2DelPosEmptyTest()
        {
            a.DelPos(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "There is no element in the position")]
        public void AList2DelPosPosNotExistTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            a.Init(mas);
            a.DelPos(10);
        }
        #endregion

        #region Min
        [TestMethod]
        public void AList2MinRandomTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, -2, 4 };
            a.Init(mas);
            int res = a.Min();
            int expectedRes = -2;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        public void AList2MinMultipleTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, -2, 4, -2 };
            a.Init(mas);
            int res = a.Min();
            int expectedRes = -2;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList2")]
        public void AList2MinEmptyTest()
        {
            a.Min();
        }
        #endregion

        #region Max
        [TestMethod]
        public void AList2MaxRandomTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, -2, 4 };
            a.Init(mas);
            int res = a.Max();
            int expectedRes = 5;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        public void AList2MaxMultipleTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, -2, 4, 5 };
            a.Init(mas);
            int res = a.Max();
            int expectedRes = 5;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList2")]
        public void AList2MaxEmptyTest()
        {
            a.Max();
        }
        #endregion

        #region MinI
        [TestMethod]
        public void AList2MinIRandomTest()
        {
            int[] mas = new int[] { 1, 2, 5, -2, 4 };
            a.Init(mas);
            int res = a.MinI();
            int expectedRes = 3;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        public void AList2MinIMultipleTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, -2, 4, -2 };
            a.Init(mas);
            int res = a.MinI();
            int expectedRes = 5;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList2")]
        public void AList2MinIEmptyTest()
        {
            a.MinI();
        }
        #endregion

        #region MaxI
        [TestMethod]
        public void AList2MaxIRandomTest()
        {
            int[] mas = new int[] { 5, -2, 4 };
            a.Init(mas);
            int res = a.MaxI();
            int expectedRes = 0;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        public void AList2MaxIMultipleTest()
        {
            int[] mas = new int[] { 1, 2, 3, 4, 5, -2, 4, 5 };
            a.Init(mas);
            int res = a.MaxI();
            int expectedRes = 4;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList2")]
        public void AList2MaxIEmptyTest()
        {
            a.Min();
        }
        #endregion

        #region Reverse
        [TestMethod]
        public void AList2ReversOddTest()
        {
            int[] mas = new int[] { 1, 2, -3, 4, 5, -2, 6 };
            a.Init(mas);
            mas = new int[] { 6, -2, 5, 4, -3, 2, 1 };
            expectedRes.Init(mas);
            a.Reverse();
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList2ReversEvenTest()
        {
            int[] mas = new int[] { 1, 2, -3, 4 };
            a.Init(mas);
            mas = new int[] { 4, -3, 2, 1 };
            expectedRes.Init(mas);
            a.Reverse();
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList2ReverseOneElTest()
        {
            int[] mas = new int[] { 1 };
            a.Init(mas);
            mas = new int[] { 1 };
            expectedRes.Init(mas);
            a.Reverse();
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList2")]
        public void AList2ReverseEmptyTest()
        {
            a.Reverse();
        }
        #endregion

        #region HalfReverse
        [TestMethod]
        public void AList2HalfReverseOddTest()
        {
            int[] mas = new int[] { 1, 2, -3, 4, 5, -2, 6 };
            a.Init(mas);
            mas = new int[] { 5, -2, 6, 4, 1, 2, -3 };
            expectedRes.Init(mas);
            a.HalfReverse();
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList2HalfReverseEvenTest()
        {
            int[] mas = new int[] { 1, 2, -3, 4, 5, -2 };
            a.Init(mas);
            mas = new int[] { 4, 5, -2, 1, 2, -3 };
            expectedRes.Init(mas);
            a.HalfReverse();
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList2")]
        public void AList2HalfReverseEmptyTest()
        {
            a.HalfReverse();
        }
        #endregion

        #region Get
        [TestMethod]
        public void AList2GetOneEllTest()
        {
            int[] mas = new int[] { 1 };
            a.Init(mas);
            int expectedRes = 1;
            int res = a.Get(0);
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        public void AList2GetRandomTest()
        {
            int[] mas = new int[] { 1, 2, -3, 4, 5, -2 };
            a.Init(mas);
            int expectedRes = 4;
            int res = a.Get(3);
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList2")]
        public void AList2GetEmptyTest()
        {
            a.Get(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "There is no element in the position")]
        public void AList2GetPosNotExistTest()
        {
            int[] mas = new int[] { 1, 2, -3, 4, 5, -2 };
            a.Init(mas);
            a.Get(8);
        }
        #endregion

        #region Set
        [TestMethod]
        public void AList2SetOneEllTest()
        {
            int[] mas = new int[] { 1 };
            a.Init(mas);
            mas = new int[] { 3 };
            expectedRes.Init(mas);
            a.Set(0, 3);
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList2SetRandomTest()
        {
            int[] mas = new int[] { 1, 2, -3, 4, 5, -2 };
            a.Init(mas);
            mas = new int[] { 1, 2, -3, 77, 5, -2 };
            expectedRes.Init(mas);
            a.Set(3, 77);
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList2")]
        public void AList2SetEmptyTest()
        {
            a.Set(0, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "There is no element in the position")]
        public void AList2SetPosNotExistTest()
        {
            int[] mas = new int[] { 1, 2, -3, 4, 5, -2 };
            a.Init(mas);
            a.Set(8, 11);
        }
        #endregion

        #region Sort
        [TestMethod]
        public void AList2SortRandomTest()
        {
            int[] mas = new int[] { 1, 2, -3, 4, 5, -2, 6 };
            a.Init(mas);
            mas = new int[] { -3, -2, 1, 2, 4, 5, 6 };
            expectedRes.Init(mas);
            a.Sort();
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        public void AList2SortOneElTest()
        {
            int[] mas = new int[] { 1 };
            a.Init(mas);
            mas = new int[] { 1 };
            expectedRes.Init(mas);
            a.Sort();
            CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList2")]
        public void AList2SortEmptyTest()
        {
            a.Sort();
        }
        #endregion
    }
}
