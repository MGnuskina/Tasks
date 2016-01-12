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

    [TestClass]
    public class AList2Test_IAList_Person : AListTestPerson
    {
        Person[] mas = new Person[16] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22), new Person(6, "rr", "qwer", 22), new Person(7, "rr", "qwer", 22), new Person(8, "rr", "qwer", 22), new Person(9, "rr", "qwer", 22),
                new Person(10, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(12, "rr", "qwer", 22), new Person(13, "rr", "qwer", 22), new Person(14, "rr", "qwer", 22),
                new Person(15, "rr", "qwer", 22), new Person(16, "rr", "qwer", 22)};

        internal override IAList<Person> MakeAList()
        {
            return new AList2<Person>();
        }

        //#region Size
        //[TestMethod]
        //public void AListSize36Test()
        //{
        //    Person[] mas = new Person[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
        //    var a = new AList2<Person>();
        //    a.Init(mas);
        //    int size = a.Size();
        //    Assert.AreEqual(36, size);
        //}
        //#endregion

        //#region Clear
        //[TestMethod]
        //public void AListClear36Test()
        //{
        //    Person[] mas = new Person[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
        //    var a = new AList2<Person>();
        //    a.Init(mas);
        //    a.Clear();
        //    int size = a.Size();
        //    Assert.AreEqual(0, size);
        //}
        //#endregion

        //#region ToArrey
        //[TestMethod]
        //public void AListTOArrey36Test()
        //{
        //    Person[] mas = new Person[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
        //    var a = new AList2<Person>();
        //    a.Init(mas);
        //    int size = a.Size();
        //    Assert.AreEqual(36, size);
        //    CollectionAssert.AreEqual(mas, a.ToArray());
        //}
        //#endregion

        //#region AddStart
        //[TestMethod]
        //public void AListAddstart36Test()
        //{
        //    Person[] mas = new Person[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
        //    var a = new AList2<Person>();
        //    a.Init(mas);
        //    a.AddStart(-1);
        //    int size = a.Size();
        //    mas = new Person[37] { -1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
        //    Assert.AreEqual(37, size);
        //    CollectionAssert.AreEqual(mas, a.ToArray());
        //}
        //#endregion

        //#region AddEnd
        //[TestMethod]
        //public void AListAddEnd36Test()
        //{
        //    Person[] mas = new Person[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
        //    var a = new AList2<Person>();
        //    a.Init(mas);
        //    a.AddEnd(-1);
        //    int size = a.Size();
        //    mas = new Person[37] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36, -1 };
        //    Assert.AreEqual(37, size);
        //    CollectionAssert.AreEqual(mas, a.ToArray());
        //}
        //#endregion

        //#region AddPos
        //[TestMethod]
        //public void AListAddPos36Test()
        //{
        //    Person[] mas = new Person[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
        //    var a = new AList2<Person>();
        //    a.Init(mas);
        //    a.AddPos(2, -1);
        //    int size = a.Size();
        //    mas = new Person[37] { 1, 2, -1, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
        //    Assert.AreEqual(37, size);
        //    CollectionAssert.AreEqual(mas, a.ToArray());
        //}
        //#endregion

        //#region DelStart
        //[TestMethod]
        //public void AListDelStart36Test()
        //{
        //    Person[] mas = new Person[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
        //    var a = new AList2<Person>();
        //    a.Init(mas);
        //    Person res = a.DelStart();
        //    int size = a.Size();
        //    mas = new Person[35] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
        //    Assert.AreEqual(35, size);
        //    Assert.AreEqual(1, res);
        //    CollectionAssert.AreEqual(mas, a.ToArray());
        //}
        //#endregion

        //#region DelEnd
        //[TestMethod]
        //public void AListDelEnd36Test()
        //{
        //    Person[] mas = new Person[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
        //    var a = new AList2<Person>();
        //    a.Init(mas);
        //    Person res = a.DelEnd();
        //    int size = a.Size();
        //    mas = new Person[35] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35 };
        //    Assert.AreEqual(35, size);
        //    Assert.AreEqual(36, res);
        //    CollectionAssert.AreEqual(mas, a.ToArray());
        //}
        //#endregion

        //#region DelEnd
        //[TestMethod]
        //public void AListDelpos36Test()
        //{
        //    Person[] mas = new Person[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
        //    var a = new AList2<Person>();
        //    a.Init(mas);
        //    Person res = a.DelPos(5);
        //    int size = a.Size();
        //    mas = new Person[35] { 1, 2, 3, 4, 5, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
        //    Assert.AreEqual(35, size);
        //    Assert.AreEqual(6, res);
        //    CollectionAssert.AreEqual(mas, a.ToArray());
        //}
        //#endregion

        //#region Min
        //[TestMethod]
        //public void AListMin36Test()
        //{
        //    Person[] mas = new Person[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
        //    var a = new AList2<Person>();
        //    a.Init(mas);
        //    Person res = a.Min();
        //    Assert.AreEqual(1, res);
        //}
        //#endregion

        //#region Max
        //[TestMethod]
        //public void AListMax36Test()
        //{
        //    Person[] mas = new Person[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
        //    var a = new AList2<Person>();
        //    a.Init(mas);
        //    Person res = a.Max();
        //    Assert.AreEqual(36, res);
        //}
        //#endregion

        //#region MinI
        //[TestMethod]
        //public void AListMinI36Test()
        //{
        //    Person[] mas = new Person[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
        //    var a = new AList2<Person>();
        //    a.Init(mas);
        //    Person res = a.MinI();
        //    Assert.AreEqual(0, res);
        //}
        //#endregion

        //#region MaxI
        //[TestMethod]
        //public void AListMaxI36Test()
        //{
        //    Person[] mas = new Person[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
        //    var a = new AList2<Person>();
        //    a.Init(mas);
        //    Person res = a.MaxI();
        //    Assert.AreEqual(35, res);
        //}
        //#endregion

        //#region Reverse
        //[TestMethod]
        //public void AListReverse36Test()
        //{
        //    Person[] mas = new Person[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
        //    var a = new AList2<Person>();
        //    a.Init(mas);
        //    a.Reverse();
        //    int size = a.Size();
        //    mas = new Person[36] { 36, 35, 34, 33, 32, 31, 30, 29, 28, 27, 26, 25, 24, 23, 22, 21, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        //    Assert.AreEqual(36, size);
        //    CollectionAssert.AreEqual(mas, a.ToArray());
        //}
        //#endregion

        //#region HalfReverse
        //[TestMethod]
        //public void AListHalfReverseEven36Test()
        //{
        //    Person[] mas = new Person[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, };
        //    var a = new AList2<Person>();
        //    a.Init(mas);
        //    a.HalfReverse();
        //    int size = a.Size();
        //    mas = new Person[36] { 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
        //    Assert.AreEqual(36, size);
        //    CollectionAssert.AreEqual(mas, a.ToArray());
        //}

        //[TestMethod]
        //public void AListHalfReverseOdd36Test()
        //{
        //    Person[] mas = new Person[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
        //    var a = new AList2<Person>();
        //    a.Init(mas);
        //    a.HalfReverse();
        //    int size = a.Size();
        //    mas = new Person[36] { 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
        //    Assert.AreEqual(36, size);
        //    CollectionAssert.AreEqual(mas, a.ToArray());
        //}
        //#endregion

        //#region Get
        //[TestMethod]
        //public void AListGet36Test()
        //{
        //    Person[] mas = new Person[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
        //    var a = new AList2<Person>();
        //    a.Init(mas);
        //    Person res = a.Get(6);
        //    Assert.AreEqual(7, res);
        //}
        //#endregion

        //#region Set
        //[TestMethod]
        //public void AListSet36Test()
        //{
        //    Person[] mas = new Person[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
        //    var a = new AList2<Person>();
        //    a.Init(mas);
        //    a.Set(6, -7);
        //    Assert.AreEqual(36, a.Size());
        //    Assert.AreEqual(-7, a.Get(6));
        //    mas = new Person[36] { 1, 2, 3, 4, 5, 6, -7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 33, 34, 35, 36 };
        //    CollectionAssert.AreEqual(mas, a.ToArray());
        //}
        //#endregion

        //#region Sort
        //[TestMethod]
        //public void AListSort36Test()
        //{
        //    Person[] mas = new Person[36] { 1, 9, 10, 27, 28, 29, 30, 31, 32, 2, 3, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 4, 5, 6, 7, 8, 33, 34, 35, 36 };
        //    var a = new AList2<Person>();
        //    a.Init(mas);
        //    a.Sort();
        //    Assert.AreEqual(36, a.Size());
        //    mas = new Person[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
        //    CollectionAssert.AreEqual(mas, a.ToArray());
        //}
        //#endregion
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

        //#region Reverse
        //[TestMethod]
        //public void AListReversOddTest()
        //{
        //    var a = MakeAList();
        //    var expectedRes = MakeAList();
        //    Person[] mas = new Person[] { 1, 2, -3, 4, 5, -2, 6 };
        //    a.Init(mas);
        //    mas = new Person[] { 6, -2, 5, 4, -3, 2, 1 };
        //    expectedRes.Init(mas);
        //    a.Reverse();
        //    Assert.AreEqual(7, a.Size());
        //    CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        //}

        //[TestMethod]
        //public void AListReversEvenTest()
        //{
        //    var a = MakeAList();
        //    var expectedRes = MakeAList();
        //    Person[] mas = new Person[] { 1, 2, -3, 4 };
        //    a.Init(mas);
        //    mas = new Person[] { 4, -3, 2, 1 };
        //    expectedRes.Init(mas);
        //    a.Reverse();
        //    Assert.AreEqual(4, a.Size());
        //    CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        //}

        //[TestMethod]
        //public void AListReverseOneElTest()
        //{
        //    var a = MakeAList();
        //    var expectedRes = MakeAList();
        //    Person[] mas = new Person[] { 1 };
        //    a.Init(mas);
        //    mas = new Person[] { 1 };
        //    expectedRes.Init(mas);
        //    a.Reverse();
        //    Assert.AreEqual(1, a.Size());
        //    CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        //}

        //[TestMethod]
        //public void AListReverse2ElTest()
        //{
        //    var a = MakeAList();
        //    var expectedRes = MakeAList();
        //    Person[] mas = new Person[] { 1, 3 };
        //    a.Init(mas);
        //    mas = new Person[] { 3, 1 };
        //    expectedRes.Init(mas);
        //    a.Reverse();
        //    Assert.AreEqual(2, a.Size());
        //    CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        //}

        //[TestMethod]
        //[ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        //public void AListReverseEmptyTest()
        //{
        //    var a = MakeAList();
        //    a.Reverse();
        //}
        //#endregion

        //#region HalfReverse
        //[TestMethod]
        //public void AListHalfReverseOddTest()
        //{
        //    var a = MakeAList();
        //    var expectedRes = MakeAList();
        //    Person[] mas = new Person[] { 1, 2, -3, 4, 5, -2, 6 };
        //    a.Init(mas);
        //    mas = new Person[] { 5, -2, 6, 4, 1, 2, -3 };
        //    expectedRes.Init(mas);
        //    a.HalfReverse();
        //    Assert.AreEqual(7, a.Size());
        //    CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        //}

        //[TestMethod]
        //public void AListHalfReverseEvenTest()
        //{
        //    var a = MakeAList();
        //    var expectedRes = MakeAList();
        //    Person[] mas = new Person[] { 1, 2, -3, 4, 5, -2 };
        //    a.Init(mas);
        //    mas = new Person[] { 4, 5, -2, 1, 2, -3 };
        //    expectedRes.Init(mas);
        //    a.HalfReverse();
        //    Assert.AreEqual(6, a.Size());
        //    CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        //}

        //[TestMethod]
        //public void AListHalfReverse2Test()
        //{
        //    var a = MakeAList();
        //    var expectedRes = MakeAList();
        //    Person[] mas = new Person[] { 1, 2 };
        //    a.Init(mas);
        //    mas = new Person[] { 2, 1 };
        //    expectedRes.Init(mas);
        //    a.HalfReverse();
        //    Assert.AreEqual(2, a.Size());
        //    CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        //}

        //[TestMethod]
        //public void AListHalfReverse1Test()
        //{
        //    var a = MakeAList();
        //    var expectedRes = MakeAList();
        //    Person[] mas = new Person[] { -2 };
        //    a.Init(mas);
        //    mas = new Person[] { -2 };
        //    expectedRes.Init(mas);
        //    a.HalfReverse();
        //    Assert.AreEqual(1, a.Size());
        //    CollectionAssert.AreEqual(expectedRes.ToArray(), a.ToArray());
        //}

        //[TestMethod]
        //[ExpectedException(typeof(InvalidOperationException), "This method can't be used for an empty AList0")]
        //public void AListHalfReverseEmptyTest()
        //{
        //    var a = MakeAList();
        //    a.HalfReverse();
        //}
        //#endregion

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
