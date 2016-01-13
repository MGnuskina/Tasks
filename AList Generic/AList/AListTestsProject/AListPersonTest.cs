using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AList;

namespace AListTestsProject
{
    [TestClass]
    public class AList0Test_IAList_Person : AListTestPerson
    {
        internal override IAList<Person> MakeAList()
        {
            return new AList0<Person>();
        }
    }

    [TestClass]
    public class AList1Test_IAList_Person : AListTestPerson
    {
        internal override IAList<Person> MakeAList()
        {
            return new AList1<Person>();
        }
    }

    [TestClass]
    public class AList2Test_IAList_Person : AListTestPerson
    {
        internal override IAList<Person> MakeAList()
        {
            return new AList2<Person>();
        }
    }

    [TestClass]
    public abstract class AListTestPerson
    {
        internal abstract IAList<Person> MakeAList();

        #region Size
        [TestMethod]
        public void AListSize5Test()
        {
            Person[] mas = new Person[5] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22)};
            var a = MakeAList();
            a.Init(mas);
            int size = a.Size();
            Assert.AreEqual(5, size);
        }

        [TestMethod]
        public void AListSize2Test()
        {
            var a = MakeAList();
            Person[] mas = new Person[2] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22) };
            a.Init(mas);
            int size = a.Size();
            Assert.AreEqual(2, size);
        }

        [TestMethod]
        public void AListSize1Test()
        {
            var a = MakeAList();
            Person[] mas = new Person[1] { new Person(1, "rr", "qwer", 22) };
            a.Init(mas);
            int size = a.Size();
            Assert.AreEqual(1, size);
        }

        [TestMethod]
        public void AListSize0Test()
        {
            var a = MakeAList();
            Person[] mas = new Person[0];
            a.Init(mas);
            int size = a.Size();
            Assert.AreEqual(0, size);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void AListSizeEmptyTest()
        {
            var a = MakeAList();
            a.Init(null);
            int size = a.Size();
        }
        #endregion

        #region Clear
        [TestMethod]
        public void AListClearTest()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[5] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22)};
            a.Init(mas);
            a.Clear();
            Assert.AreEqual(0, a.Size());
            Assert.AreEqual((expectedRes.ToArray()).ToString(), (a.ToArray()).ToString());
        }

        [TestMethod]
        public void AListClear2Test()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[2] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22) };
            a.Init(mas);
            a.Clear();
            Assert.AreEqual(0, a.Size());
            Assert.AreEqual((expectedRes.ToArray()).ToString(), (a.ToArray()).ToString());
        }

        [TestMethod]
        public void AListClear1Test()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[1] { new Person(1, "rr", "qwer", 22) };
            a.Init(mas);
            a.Clear();
            Assert.AreEqual(0, a.Size());
            Assert.AreEqual((expectedRes.ToArray()).ToString(), (a.ToArray()).ToString());
        }

        [TestMethod]
        public void AListClearEmptyTest()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            a.Clear();
            Assert.AreEqual(0, a.Size());
            Assert.AreEqual((expectedRes.ToArray()).ToString(), (a.ToArray()).ToString());
        }
        #endregion

        #region ToArray
        [TestMethod]
        public void AListToArrayTest()
        {
            var a = MakeAList();
            Person[] mas = new Person[5] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22)};
            a.Init(mas);
            Person[] res = a.ToArray();
            Assert.AreEqual(5, res.Length);
            Assert.AreEqual(mas.ToString(), res.ToString());
        }

        [TestMethod]
        public void AListToArray2Test()
        {
            var a = MakeAList();
            Person[] mas = new Person[2] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22) };
            a.Init(mas);
            Person[] res = a.ToArray();
            Assert.AreEqual(2, res.Length);
            Assert.AreEqual(mas.ToString(), res.ToString());
        }

        [TestMethod]
        public void AListToArray1Test()
        {
            var a = MakeAList();
            Person[] mas = new Person[1] { new Person(1, "rr", "qwer", 22) };
            a.Init(mas);
            Person[] res = a.ToArray();
            Assert.AreEqual(1, res.Length);
            Assert.AreEqual(mas.ToString(), res.ToString());
        }

        [TestMethod]
        public void AListToArrayTestEmpty()
        {
            var a = MakeAList();
            Person[] res = a.ToArray();
            Assert.AreEqual(0, res.Length);
            CollectionAssert.AreEqual(res, new Person[0]);
        }
        #endregion

        #region AddStart
        [TestMethod]
        public void AListAddStartTest()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[5] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22)};
            a.Init(mas);
            mas = new Person[6] {new Person(6, "rr", "qwer", 22), new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22)};
            expectedRes.Init(mas);
            a.AddStart(new Person(6, "rr", "qwer", 22));
            Assert.AreEqual(6, a.Size());
            Assert.AreEqual((new Person(6, "rr", "qwer", 22)).ToString(), a.Get(0).ToString());
            Assert.AreEqual(expectedRes.ToArray().ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        public void AListAddStart2Test()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[2] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22) };
            a.Init(mas);
            mas = new Person[3] { new Person(6, "rr", "qwer", 22), new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22) };
            expectedRes.Init(mas);
            a.AddStart(new Person(6, "rr", "qwer", 22));
            Assert.AreEqual(3, a.Size());
            Assert.AreEqual((new Person(6, "rr", "qwer", 22)).ToString(), a.Get(0).ToString());
            Assert.AreEqual(expectedRes.ToArray().ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        public void AListAddStart1Test()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[1] { new Person(1, "rr", "qwer", 22) };
            a.Init(mas);
            mas = new Person[2] { new Person(6, "rr", "qwer", 22), new Person(1, "rr", "qwer", 22) };
            expectedRes.Init(mas);
            a.AddStart(new Person(6, "rr", "qwer", 22));
            Assert.AreEqual(2, a.Size());
            Assert.AreEqual((new Person(6, "rr", "qwer", 22)).ToString(), a.Get(0).ToString());
            Assert.AreEqual(expectedRes.ToArray().ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        public void AListAddStartToEmptyTest()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[1] { new Person(1, "rr", "qwer", 22) };
            expectedRes.Init(mas);
            a.AddStart(new Person(6, "rr", "qwer", 22));
            Assert.AreEqual(1, a.Size());
            Assert.AreEqual((new Person(6, "rr", "qwer", 22)).ToString(), a.Get(0).ToString());
            Assert.AreEqual(expectedRes.ToArray().ToString(), a.ToArray().ToString());
        }
        #endregion

        #region AddEnd
        [TestMethod]
        public void AListAddEndTest()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[5] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22)};
            a.Init(mas);
            mas = new Person[6] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22), new Person(6, "rr", "qwer", 22) };
            expectedRes.Init(mas);
            a.AddEnd(new Person(6, "rr", "qwer", 22));
            Assert.AreEqual(6, a.Size());
            Assert.AreEqual((new Person(6, "rr", "qwer", 22)).ToString(), a.Get(5).ToString());
            Assert.AreEqual(expectedRes.ToArray().ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        public void AListAddEnd2Test()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[2] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22) };
            a.Init(mas);
            mas = new Person[3] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(6, "rr", "qwer", 22)};
            expectedRes.Init(mas);
            a.AddEnd(new Person(6, "rr", "qwer", 22));
            Assert.AreEqual(3, a.Size());
            Assert.AreEqual((new Person(6, "rr", "qwer", 22)).ToString(), a.Get(2).ToString());
            Assert.AreEqual(expectedRes.ToArray().ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        public void AListAddEnd1Test()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[1] { new Person(1, "rr", "qwer", 22) };
            a.Init(mas);
            mas = new Person[2] { new Person(1, "rr", "qwer", 22), new Person(6, "rr", "qwer", 22) };
            expectedRes.Init(mas);
            a.AddEnd(new Person(6, "rr", "qwer", 22));
            Assert.AreEqual(2, a.Size());
            Assert.AreEqual((new Person(6, "rr", "qwer", 22)).ToString(), a.Get(1).ToString());
            Assert.AreEqual(expectedRes.ToArray().ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        public void AListAddEndToEmptyTest()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[1] { new Person(6, "rr", "qwer", 22) };
            expectedRes.Init(mas);
            a.AddEnd(new Person(6, "rr", "qwer", 22));
            Assert.AreEqual(1, a.Size());
            Assert.AreEqual((new Person(6, "rr", "qwer", 22)).ToString(), a.Get(0).ToString());
            Assert.AreEqual(expectedRes.ToArray().ToString(), a.ToArray().ToString());
        }
        #endregion

        #region AddPos
        [TestMethod]
        public void AListAddPosBegPersonest()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[5] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22)};
            a.Init(mas);
            mas = new Person[6] {new Person(6, "rr", "qwer", 22), new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22)};
            expectedRes.Init(mas);
            a.AddPos(0, new Person(6, "rr", "qwer", 22));
            Assert.AreEqual(6, a.Size());
            Assert.AreEqual((new Person(6, "rr", "qwer", 22)).ToString(), a.Get(0).ToString());
            Assert.AreEqual(expectedRes.ToArray().ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        public void AListAddPos2Test()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[2] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22)};
            a.Init(mas);
            mas = new Person[3] { new Person(1, "rr", "qwer", 22), new Person(6, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22)};
            expectedRes.Init(mas);
            a.AddPos(1, new Person(6, "rr", "qwer", 22));
            Assert.AreEqual(3, a.Size());
            Assert.AreEqual((new Person(6, "rr", "qwer", 22)).ToString(), a.Get(1).ToString());
            Assert.AreEqual(expectedRes.ToArray().ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        public void AListAddPos1Test()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[1] { new Person(1, "rr", "qwer", 22)};
            a.Init(mas);
            mas = new Person[2] {new Person(6, "rr", "qwer", 22), new Person(1, "rr", "qwer", 22)};
            expectedRes.Init(mas);
            a.AddPos(0, new Person(6, "rr", "qwer", 22));
            Assert.AreEqual(2, a.Size());
            Assert.AreEqual((new Person(6, "rr", "qwer", 22)).ToString(), a.Get(0).ToString());
            Assert.AreEqual(expectedRes.ToArray().ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        public void AListAddPosRandomTest()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[5] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22)};
            a.Init(mas);
            mas = new Person[6] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(6, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22)};
            expectedRes.Init(mas);
            a.AddPos(3, new Person(6, "rr", "qwer", 22));
            Assert.AreEqual(6, a.Size());
            Assert.AreEqual((new Person(6, "rr", "qwer", 22)).ToString(), a.Get(3).ToString());
            Assert.AreEqual(expectedRes.ToArray().ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        public void AListAddPosToEmptyTest()
        {
            var a = MakeAList();
            a.AddPos(10, new Person(6, "rr", "qwer", 22));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "There is no element in the position")]
        public void AListAddPosPosNotExistTest()
        {
            var a = MakeAList();
            Person[] mas = new Person[5] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22)};
            a.Init(mas);
            a.AddPos(10, new Person(6, "rr", "qwer", 22));
        }
        #endregion

        #region DelStart
        [TestMethod]
        public void AListDelStartTest()
        {
            var a = MakeAList();
            Person[] mas = new Person[5] {new Person(6, "rr", "qwer", 22), new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22)};
            a.Init(mas);
            Person expectedRes = new Person(6, "rr", "qwer", 22);
            Person res = a.DelStart();
            mas = new Person[4] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22) };
            Assert.AreEqual(4, a.Size());
            Assert.AreEqual(expectedRes.ToString(), res.ToString());
            Assert.AreEqual(mas.ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        public void AListDelStart2Test()
        {
            var a = MakeAList();
            Person[] mas = new Person[2] { new Person(6, "rr", "qwer", 22), new Person(1, "rr", "qwer", 22)};
            a.Init(mas);
            Person expectedRes = new Person(6, "rr", "qwer", 22);
            Person res = a.DelStart();
            mas = new Person[] { new Person(1, "rr", "qwer", 22) };
            Assert.AreEqual(1, a.Size());
            Assert.AreEqual(expectedRes.ToString(), res.ToString());
            Assert.AreEqual(mas.ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        public void AListDelStart1Test()
        {
            var a = MakeAList();
            Person[] mas = new Person[1] { new Person(6, "rr", "qwer", 22)};
            a.Init(mas);
            Person expectedRes = new Person(6, "rr", "qwer", 22);
            Person res = a.DelStart();
            mas = new Person[0];
            Assert.AreEqual(0, a.Size());
            Assert.AreEqual(expectedRes.ToString(), res.ToString());
            Assert.AreEqual(mas.ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        public void AListDelStartEmptyTest()
        {
            var a = MakeAList();
            a.DelStart();
        }
        #endregion

        #region DelEnd
        [TestMethod]
        public void AListDelEndTest()
        {
            var a = MakeAList();
            Person[] mas = new Person[5] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(6, "rr", "qwer", 22) };
            a.Init(mas);
            Person expectedRes = new Person(6, "rr", "qwer", 22);
            Person res = a.DelEnd();
            mas = new Person[4] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22) };
            Assert.AreEqual(4, a.Size());
            Assert.AreEqual(expectedRes.ToString(), res.ToString());
            Assert.AreEqual(mas.ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        public void AListDelEnd2Test()
        {
            var a = MakeAList();
            Person[] mas = new Person[2] { new Person(4, "rr", "qwer", 22), new Person(6, "rr", "qwer", 22) };
            a.Init(mas);
            Person expectedRes = new Person(6, "rr", "qwer", 22);
            Person res = a.DelEnd();
            mas = new Person[1] { new Person(1, "rr", "qwer", 22)};
            Assert.AreEqual(1, a.Size());
            Assert.AreEqual(expectedRes.ToString(), res.ToString());
            Assert.AreEqual(mas.ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        public void AListDelEnd1Test()
        {
            var a = MakeAList();
            Person[] mas = new Person[1] { new Person(6, "rr", "qwer", 22) };
            a.Init(mas);
            Person expectedRes = new Person(6, "rr", "qwer", 22);
            Person res = a.DelEnd();
            mas = new Person[0];
            Assert.AreEqual(0, a.Size());
            Assert.AreEqual(expectedRes.ToString(), res.ToString());
            Assert.AreEqual(mas.ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        public void AListDelEndEmptyTest()
        {
            var a = MakeAList();
            a.DelEnd();
        }
        #endregion

        #region DelPos
        [TestMethod]
        public void AListDelPosRandomTest()
        {
            var a = MakeAList();
            Person[] mas = new Person[5] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22) };
            a.Init(mas);
            Person expectedRes = new Person(3, "rr", "qwer", 22);
            Person res = a.DelPos(2);
            mas = new Person[4] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22), new Person(5, "rr", "qwer", 22) };
            Assert.AreEqual(4, a.Size());
            Assert.AreEqual(expectedRes.ToString(), res.ToString());
            Assert.AreEqual(mas.ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        public void AListDelPos2Test()
        {
            var a = MakeAList();
            Person[] mas = new Person[2] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22)};
            a.Init(mas);
            Person expectedRes = new Person(2, "rr", "qwer", 22);
            Person res = a.DelPos(1);
            mas = new Person[] { new Person(1, "rr", "qwer", 22) };
            Assert.AreEqual(1, a.Size());
            Assert.AreEqual(expectedRes.ToString(), res.ToString());
            Assert.AreEqual(mas.ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        public void AListDelPos1Test()
        {
            var a = MakeAList();
            Person[] mas = new Person[1] { new Person(1, "rr", "qwer", 22) };
            a.Init(mas);
            Person expectedRes = new Person(1, "rr", "qwer", 22);
            Person res = a.DelPos(0);
            mas = new Person[0];
            Assert.AreEqual(0, a.Size());
            Assert.AreEqual(expectedRes.ToString(), res.ToString());
            Assert.AreEqual(mas.ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        public void AListDelPosEmptyTest()
        {
            var a = MakeAList();
            a.DelPos(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "There is no element in the position")]
        public void AListDelPosPosNotExistTest()
        {
            var a = MakeAList();
            Person[] mas = new Person[4] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22), new Person(5, "rr", "qwer", 22) };
            a.Init(mas);
            a.DelPos(10);
        }
        #endregion

        #region Min
        [TestMethod]
        public void AListMinRandomTest()
        {
            var a = MakeAList();
            Person[] mas = new Person[5] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(-5, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22) };
            a.Init(mas);
            Person res = a.Min();
            Person expectedRes = new Person(-5, "rr", "qwer", 22);
            Assert.AreEqual(expectedRes.ToString(), res.ToString());
        }

        [TestMethod]
        public void AListMin2Test()
        {
            var a = MakeAList();
            Person[] mas = new Person[2] { new Person(1, "rr", "qwer", 22), new Person(-2, "rr", "qwer", 22)};
            a.Init(mas);
            Person res = a.Min();
            Person expectedRes = new Person(-2, "rr", "qwer", 22);
            Assert.AreEqual(expectedRes.ToString(), res.ToString());
        }

        [TestMethod]
        public void AListMin1Test()
        {
            var a = MakeAList();
            Person[] mas = new Person[1] { new Person(1, "rr", "qwer", 22) };
            a.Init(mas);
            Person res = a.Min();
            Person expectedRes = new Person(1, "rr", "qwer", 22);
            Assert.AreEqual(expectedRes.ToString(), res.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        public void AListMinEmptyTest()
        {
            var a = MakeAList();
            a.Min();
        }
        #endregion

        #region Max
        [TestMethod]
        public void AListMaxRandomTest()
        {
            var a = MakeAList();
            Person[] mas = new Person[5] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(10, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22) };
            a.Init(mas);
            Person res = a.Max();
            Person expectedRes = new Person(10, "rr", "qwer", 22);
            Assert.AreEqual(expectedRes.ToString(), res.ToString());
        }

        [TestMethod]
        public void AListMan2Test()
        {
            var a = MakeAList();
            Person[] mas = new Person[2] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22) };
            a.Init(mas);
            Person res = a.Max();
            Person expectedRes = new Person(2, "rr", "qwer", 22);
            Assert.AreEqual(expectedRes.ToString(), res.ToString());
        }

        [TestMethod]
        public void AListMax1Test()
        {
            var a = MakeAList();
            Person[] mas = new Person[1] { new Person(1, "rr", "qwer", 22)};
            a.Init(mas);
            Person res = a.Max();
            Person expectedRes = new Person(1, "rr", "qwer", 22);
            Assert.AreEqual(expectedRes.ToString(), res.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        public void AListMaxEmptyTest()
        {
            var a = MakeAList();
            a.Max();
        }
        #endregion

        #region MinI
        [TestMethod]
        public void AListMinIRandomTest()
        {
            var a = MakeAList();
            Person[] mas = new Person[5] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(-1, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22) };
            a.Init(mas);
            int res = a.MinI();
            int expectedRes = 2;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        public void AListMinI2Test()
        {
            var a = MakeAList();
            Person[] mas = new Person[2] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22) };
            a.Init(mas);
            int res = a.MinI();
            int expectedRes = 0;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        public void AListMinI1Test()
        {
            var a = MakeAList();
            Person[] mas = new Person[1] { new Person(1, "rr", "qwer", 22)};
            a.Init(mas);
            int res = a.MinI();
            int expectedRes = 0;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        public void AListMinIEmptyTest()
        {
            var a = MakeAList();
            a.MinI();
        }
        #endregion

        #region MaxI
        [TestMethod]
        public void AListMaxIRandomTest()
        {
            var a = MakeAList();
            Person[] mas = new Person[5] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22) };
            a.Init(mas);
            int res = a.MaxI();
            int expectedRes = 2;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        public void AListMaxI2Test()
        {
            var a = MakeAList();
            Person[] mas = new Person[2] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22) };
            a.Init(mas);
            int res = a.MaxI();
            int expectedRes = 1;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        public void AListMaxI1Test()
        {
            var a = MakeAList();
            Person[] mas = new Person[1] { new Person(1, "rr", "qwer", 22) };
            a.Init(mas);
            int res = a.MaxI();
            int expectedRes = 0;
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        public void AListMaxIEmptyTest()
        {
            var a = MakeAList();
            a.Min();
        }
        #endregion

        #region Reverse
        [TestMethod]
        public void AListReversOddTest()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[5] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22) };
            a.Init(mas);
            mas = new Person[5] { new Person(5, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22),
                new Person(1, "rr", "qwer", 22) };
            expectedRes.Init(mas);
            a.Reverse();
            Assert.AreEqual(5, a.Size());
            Assert.AreEqual(expectedRes.ToArray().ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        public void AListReversEvenTest()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[4] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22) };
            a.Init(mas);
            mas = new Person[4] { new Person(4, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(1, "rr", "qwer", 22) };
            expectedRes.Init(mas);
            a.Reverse();
            Assert.AreEqual(4, a.Size());
            Assert.AreEqual(expectedRes.ToArray().ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        public void AListReverseOneElTest()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[1] { new Person(1, "rr", "qwer", 22)};
            a.Init(mas);
            mas = new Person[1] { new Person(1, "rr", "qwer", 22) };
            expectedRes.Init(mas);
            a.Reverse();
            Assert.AreEqual(1, a.Size());
            Assert.AreEqual(expectedRes.ToArray().ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        public void AListReverse2ElTest()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[2] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22)};
            a.Init(mas);
            mas = new Person[2] { new Person(2, "rr", "qwer", 22), new Person(1, "rr", "qwer", 22) };
            expectedRes.Init(mas);
            a.Reverse();
            Assert.AreEqual(2, a.Size());
            Assert.AreEqual(expectedRes.ToArray().ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        public void AListReverseEmptyTest()
        {
            var a = MakeAList();
            a.Reverse();
        }
        #endregion

        #region HalfReverse
        [TestMethod]
        public void AListHalfReverseOddTest()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[5] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22) };
            a.Init(mas);
            mas = new Person[5] { new Person(4, "rr", "qwer", 22), new Person(5, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(1, "rr", "qwer", 22),
                new Person(2, "rr", "qwer", 22) };
            expectedRes.Init(mas);
            a.HalfReverse();
            Assert.AreEqual(5, a.Size());
            Assert.AreEqual(expectedRes.ToArray().ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        public void AListHalfReverseEvenTest()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[4] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22)};
            a.Init(mas);
            mas = new Person[4] { new Person(11, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22), new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22) };
            expectedRes.Init(mas);
            a.HalfReverse();
            Assert.AreEqual(4, a.Size());
            Assert.AreEqual(expectedRes.ToArray().ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        public void AListHalfReverse2Test()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[2] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22) };
            a.Init(mas);
            mas = new Person[2] { new Person(2, "rr", "qwer", 22), new Person(1, "rr", "qwer", 22) };
            expectedRes.Init(mas);
            a.HalfReverse();
            Assert.AreEqual(2, a.Size());
            Assert.AreEqual(expectedRes.ToArray().ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        public void AListHalfReverse1Test()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[1] { new Person(1, "rr", "qwer", 22)};
            a.Init(mas);
            mas = new Person[1] { new Person(1, "rr", "qwer", 22) };
            expectedRes.Init(mas);
            a.HalfReverse();
            Assert.AreEqual(1, a.Size());
            Assert.AreEqual(expectedRes.ToArray().ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        public void AListHalfReverseEmptyTest()
        {
            var a = MakeAList();
            a.HalfReverse();
        }
        #endregion

        #region Get
        [TestMethod]
        public void AListGetOneEllTest()
        {
            var a = MakeAList();
            Person[] mas = new Person[] { new Person(1, "rr", "qwer", 22) };
            a.Init(mas);
            Person expectedRes = new Person(1, "rr", "qwer", 22);
            Person res = a.Get(0);
            Assert.AreEqual(expectedRes.ToString(), res.ToString());
        }

        [TestMethod]
        public void AListGet2EllTest()
        {
            var a = MakeAList();
            Person[] mas = new Person[2] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22) };
            a.Init(mas);
            Person expectedRes = new Person(1, "rr", "qwer", 22);
            Person res = a.Get(0);
            Assert.AreEqual(expectedRes.ToString(), res.ToString());
        }

        [TestMethod]
        public void AListGetRandomTest()
        {
            var a = MakeAList();
            Person[] mas = new Person[5] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22) };
            a.Init(mas);
            Person expectedRes = new Person(2, "rr", "qwer", 22);
            Person res = a.Get(2);
            Assert.AreEqual(expectedRes.ToString(), res.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        public void AListGetEmptyTest()
        {
            var a = MakeAList();
            a.Get(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "There is no element in the position")]
        public void AListGetPosNotExistTest()
        {
            var a = MakeAList();
            Person[] mas = new Person[5] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22) };
            a.Init(mas);
            a.Get(8);
        }
        #endregion

        #region Set
        [TestMethod]
        public void AListSetOneEllTest()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[1] { new Person(1, "rr", "qwer", 22) };
            a.Init(mas);
            mas = new Person[] { new Person(10, "rr", "qwer", 22) };
            expectedRes.Init(mas);
            a.Set(0, new Person(10, "rr", "qwer", 22));
            Assert.AreEqual(1, a.Size());
            Assert.AreEqual(expectedRes.ToArray().ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        public void AListSet2EllTest()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[2] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22) };
            a.Init(mas);
            mas = new Person[2] { new Person(1, "rr", "qwer", 22), new Person(10, "rr", "qwer", 22) };
            expectedRes.Init(mas);
            a.Set(1, new Person(10, "rr", "qwer", 22));
            Assert.AreEqual(2, a.Size());
            Assert.AreEqual(expectedRes.ToArray().ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        public void AListSetRandomTest()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[5] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22) };
            a.Init(mas);
            mas = new Person[5] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(10, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22) };
            expectedRes.Init(mas);
            a.Set(3, new Person(10, "rr", "qwer", 22));
            Assert.AreEqual(5, a.Size());
            Assert.AreEqual(expectedRes.ToArray().ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        public void AListSetEmptyTest()
        {
            var a = MakeAList();
            a.Set(0, new Person(10, "rr", "qwer", 22));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "There is no element in the position")]
        public void AListSetPosNotExistTest()
        {
            var a = MakeAList();
            Person[] mas = new Person[5] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22) };
            a.Init(mas);
            a.Set(8, new Person(10, "rr", "qwer", 22));
        }
        #endregion

        #region Sort
        [TestMethod]
        public void AListSortRandomTest()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[5] { new Person(1, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(1, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22) };
            a.Init(mas);
            mas = new Person[5] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22), new Person(5, "rr", "qwer", 22),
                new Person(11, "rr", "qwer", 22) };
            expectedRes.Init(mas);
            a.Sort();
            Assert.AreEqual(5, a.Size());
            Assert.AreEqual(expectedRes.ToArray().ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        public void AListSort2ElTest()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[2] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22) };
            a.Init(mas);
            mas = new Person[2] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22) };
            expectedRes.Init(mas);
            a.Sort();
            Assert.AreEqual(2, a.Size());
            Assert.AreEqual(expectedRes.ToArray().ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        public void AListSortOneElTest()
        {
            var a = MakeAList();
            var expectedRes = MakeAList();
            Person[] mas = new Person[1] { new Person(1, "rr", "qwer", 22) };
            a.Init(mas);
            mas = new Person[1] { new Person(1, "rr", "qwer", 22)};
            expectedRes.Init(mas);
            a.Sort();
            Assert.AreEqual(1, a.Size());
            Assert.AreEqual(expectedRes.ToArray().ToString(), a.ToArray().ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        public void AListSortEmptyTest()
        {
            var a = MakeAList();
            a.Sort();
        }
        #endregion
    }
}
