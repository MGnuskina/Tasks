using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AList;

namespace AListTestsProject
{
    [TestClass]
    public class AList1WhiteBoxPersonTest
    {
        Person[] mas = new Person[16] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22), new Person(6, "rr", "qwer", 22), new Person(7, "rr", "qwer", 22), new Person(8, "rr", "qwer", 22), new Person(9, "rr", "qwer", 22),
                new Person(10, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(12, "rr", "qwer", 22), new Person(13, "rr", "qwer", 22), new Person(14, "rr", "qwer", 22),
                new Person(15, "rr", "qwer", 22), new Person(16, "rr", "qwer", 22)};

        #region Size
        [TestMethod]
        public void AListSize16Test()
        {
            var a = new AList1<Person>();
            a.Init(mas);
            int size = a.Size();
            Assert.AreEqual(16, size);
        }
        #endregion

        #region Clear
        [TestMethod]
        public void AListClear16Test()
        {
            var a = new AList1<Person>();
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
            var a = new AList1<Person>();
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
            var a = new AList1<Person>();
            a.Init(mas);
            Person tmp = new Person(17, "rr", "qwer", 22);
            a.AddStart(tmp);
            int size = a.Size();
            Assert.AreEqual(17, size);
            mas = new Person[17] {new Person(17,"rr","qwer",22), new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22), new Person(6, "rr", "qwer", 22), new Person(7, "rr", "qwer", 22), new Person(8, "rr", "qwer", 22), new Person(9, "rr", "qwer", 22),
                new Person(10, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(12, "rr", "qwer", 22), new Person(13, "rr", "qwer", 22), new Person(14, "rr", "qwer", 22),
                new Person(15, "rr", "qwer", 22), new Person(16, "rr", "qwer", 22)};
            Assert.AreEqual(mas.ToString(), a.ToArray().ToString());
        }
        #endregion

        #region AddEnd
        [TestMethod]
        public void AListAddEnd16Test()
        {
            var a = new AList1<Person>();
            a.Init(mas);
            Person tmp = new Person(17, "rr", "qwer", 22);
            a.AddEnd(tmp);
            int size = a.Size();
            Assert.AreEqual(17, size);
            mas = new Person[17] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22), new Person(6, "rr", "qwer", 22), new Person(7, "rr", "qwer", 22), new Person(8, "rr", "qwer", 22), new Person(9, "rr", "qwer", 22),
                new Person(10, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(12, "rr", "qwer", 22), new Person(13, "rr", "qwer", 22), new Person(14, "rr", "qwer", 22),
                new Person(15, "rr", "qwer", 22), new Person(16, "rr", "qwer", 22), new Person(17,"rr","qwer",22)};
            Person[] res = a.ToArray();
            Assert.AreEqual(res.ToString(), mas.ToString());
        }
        #endregion

        #region AddPos
        [TestMethod]
        public void AListAddPos16Test()
        {
            var a = new AList1<Person>();
            a.Init(mas);
            Person tmp = new Person(17, "rr", "qwer", 22);
            a.AddPos(5, tmp);
            int size = a.Size();
            Assert.AreEqual(17, size);
            mas = new Person[17] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22), new Person(17, "rr", "qwer", 22), new Person(6, "rr", "qwer", 22), new Person(7, "rr", "qwer", 22), new Person(8, "rr", "qwer", 22), new Person(9, "rr", "qwer", 22),
                new Person(10, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(12, "rr", "qwer", 22), new Person(13, "rr", "qwer", 22), new Person(14, "rr", "qwer", 22),
                new Person(15, "rr", "qwer", 22), new Person(16, "rr", "qwer", 22)};
            Assert.AreEqual(a.ToArray().ToString(), mas.ToString());
        }
        #endregion

        #region DelStart
        [TestMethod]
        public void AListDelStart16Test()
        {
            var a = new AList1<Person>();
            a.Init(mas);
            Person res = a.DelStart();
            int size = a.Size();
            Assert.AreEqual(15, size);
            Assert.AreEqual(res.ToString(), (new Person(1, "rr", "qwer", 22)).ToString());
            Assert.AreEqual(a.ToArray().ToString(), mas.ToString());
        }
        #endregion

        #region DelEnd
        [TestMethod]
        public void AListDelEnd16Test()
        {
            var a = new AList1<Person>();
            a.Init(mas);
            Person res = a.DelEnd();
            int size = a.Size();
            Assert.AreEqual(15, size);
            Assert.AreEqual(res.ToString(), (new Person(16, "rr", "qwer", 22)).ToString());
            mas = new Person[15] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22), new Person(6, "rr", "qwer", 22), new Person(7, "rr", "qwer", 22), new Person(8, "rr", "qwer", 22), new Person(9, "rr", "qwer", 22),
                new Person(10, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(12, "rr", "qwer", 22), new Person(13, "rr", "qwer", 22), new Person(14, "rr", "qwer", 22),
                new Person(15, "rr", "qwer", 22)};
            Assert.AreEqual(a.ToArray().ToString(), mas.ToString());
        }
        #endregion

        #region DelPos
        [TestMethod]
        public void AListDelPos16Test()
        {
            var a = new AList1<Person>();
            a.Init(mas);
            Person res = a.DelPos(3);
            int size = a.Size();
            Assert.AreEqual(15, size);
            Assert.AreEqual(res.ToString(), (new Person(6, "rr", "qwer", 22)).ToString());
            mas = new Person[15] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22), new Person(6, "rr", "qwer", 22), new Person(7, "rr", "qwer", 22), new Person(8, "rr", "qwer", 22), new Person(9, "rr", "qwer", 22),
                new Person(10, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(12, "rr", "qwer", 22), new Person(13, "rr", "qwer", 22), new Person(14, "rr", "qwer", 22),
                new Person(15, "rr", "qwer", 22), new Person(16, "rr", "qwer", 22)};
            Assert.AreEqual(a.ToArray().ToString(), mas.ToString());
        }
        #endregion

        #region Min
        [TestMethod]
        public void AListMin16Test()
        {
            var a = new AList1<Person>();
            a.Init(mas);
            Person res = a.Min();
            Assert.AreEqual(1, res.ID);
        }
        #endregion

        #region Max
        [TestMethod]
        public void AListMax16Test()
        {
            var a = new AList1<Person>();
            a.Init(mas);
            Person res = a.Max();
            Assert.AreEqual(16, res.ID);
        }
        #endregion

        #region MinI
        [TestMethod]
        public void AListMinI16Test()
        {
            var a = new AList1<Person>();
            a.Init(mas);
            int res = a.MinI();
            Assert.AreEqual(0, res);
        }
        #endregion

        #region MaxI
        [TestMethod]
        public void AListMaxI16Test()
        {
            var a = new AList1<Person>();
            a.Init(mas);
            int res = a.MaxI();
            Assert.AreEqual(15, res);
        }
        #endregion

        #region Reverse
        [TestMethod]
        public void AListREverse16Test()
        {
            var a = new AList1<Person>();
            a.Init(mas);
            a.Reverse();
            int size = a.Size();
            Assert.AreEqual(16, size);
            mas = new Person[16] { new Person(16, "rr", "qwer", 22), new Person(15, "rr", "qwer", 22), new Person(14, "rr", "qwer", 22), new Person(13, "rr", "qwer", 22),
                new Person(12, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(10, "rr", "qwer", 22), new Person(9, "rr", "qwer", 22), new Person(8, "rr", "qwer", 22),
                new Person(7, "rr", "qwer", 22), new Person(6, "rr", "qwer", 22), new Person(5, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22),
                new Person(2, "rr", "qwer", 22), new Person(1, "rr", "qwer", 22)};
            Assert.AreEqual(a.ToArray().ToString(), mas.ToString());
        }
        #endregion

        #region HalfReverse
        [TestMethod]
        public void AListHalfREverseEven16Test()
        {
            var a = new AList1<Person>();
            a.Init(mas);
            a.HalfReverse();
            int size = a.Size();
            Assert.AreEqual(16, size);
            mas = new Person[16] {new Person(8, "rr", "qwer", 22), new Person(9, "rr", "qwer", 22), new Person(10, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22),
                new Person(12, "rr", "qwer", 22), new Person(13, "rr", "qwer", 22), new Person(14, "rr", "qwer", 22),
                new Person(15, "rr", "qwer", 22), new Person(16, "rr", "qwer", 22), new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22),
                new Person(4, "rr", "qwer", 22), new Person(5, "rr", "qwer", 22), new Person(6, "rr", "qwer", 22), new Person(7, "rr", "qwer", 22)};
            Assert.AreEqual(a.ToArray().ToString(), mas.ToString());
        }

        [TestMethod]
        public void AListHalfREverseOdd16Test()
        {
            Person[] mas = new Person[15] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22), new Person(6, "rr", "qwer", 22), new Person(7, "rr", "qwer", 22), new Person(8, "rr", "qwer", 22), new Person(9, "rr", "qwer", 22),
                new Person(10, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(12, "rr", "qwer", 22), new Person(13, "rr", "qwer", 22), new Person(14, "rr", "qwer", 22),
                new Person(15, "rr", "qwer", 22),};
            var a = new AList1<Person>();
            a.Init(mas);
            a.HalfReverse();
            int size = a.Size();
            Assert.AreEqual(15, size);
            mas = new Person[15] { new Person(9, "rr", "qwer", 22), new Person(10, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(12, "rr", "qwer", 22),
                new Person(13, "rr", "qwer", 22), new Person(14, "rr", "qwer", 22), new Person(15, "rr", "qwer", 22), new Person(8, "rr", "qwer", 22),  new Person(1, "rr", "qwer", 22),
                new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22), new Person(6, "rr", "qwer", 22), new Person(7, "rr", "qwer", 22),};
            Assert.AreEqual(a.ToArray().ToString(), mas.ToString());
        }
        #endregion

        #region Get
        [TestMethod]
        public void AListGet16Test()
        {
            var a = new AList1<Person>();
            a.Init(mas);
            Person res = a.Get(3);
            Assert.AreEqual((new Person(10, "rr", "qwer", 22)).ToString(), res.ToString());
        }
        #endregion

        #region Set
        [TestMethod]
        public void AListSet16Test()
        {
            var a = new AList1<Person>();
            a.Init(mas);
            a.Set(8, new Person(17, "rr", "qwer", 22));
            mas = new Person[16] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22), new Person(6, "rr", "qwer", 22), new Person(7, "rr", "qwer", 22), new Person(8, "rr", "qwer", 22), new Person(17, "rr", "qwer", 22),
                new Person(10, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(12, "rr", "qwer", 22), new Person(13, "rr", "qwer", 22), new Person(14, "rr", "qwer", 22),
                new Person(15, "rr", "qwer", 22), new Person(16, "rr", "qwer", 22)};
            Assert.AreEqual(16, a.Size());
            Assert.AreEqual((new Person(17, "rr", "qwer", 22)).ToString(), a.Get(8).ToString());
            Assert.AreEqual(a.ToArray().ToString(), mas.ToString());
        }
        #endregion

        #region Sort
        [TestMethod]
        public void AListSort16Test()
        {
            var a = new AList1<Person>();
            a.Init(mas);
            a.Sort();
            mas = new Person[16] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22), new Person(6, "rr", "qwer", 22), new Person(7, "rr", "qwer", 22), new Person(8, "rr", "qwer", 22), new Person(9, "rr", "qwer", 22),
                new Person(10, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(12, "rr", "qwer", 22), new Person(13, "rr", "qwer", 22), new Person(14, "rr", "qwer", 22),
                new Person(15, "rr", "qwer", 22), new Person(16, "rr", "qwer", 22)};
            Assert.AreEqual(16, a.Size());
            Assert.AreEqual(a.ToArray().ToString(), mas.ToString());
        }
        #endregion
    }
}
