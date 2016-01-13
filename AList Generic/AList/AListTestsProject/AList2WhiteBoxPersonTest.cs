using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AList;

namespace AListTestsProject
{
    [TestClass]
    public class AList2WhiteBoxPersonTest
    {
        Person[] mas = new Person[36] { new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22), new Person(6, "rr", "qwer", 22), new Person(7, "rr", "qwer", 22), new Person(8, "rr", "qwer", 22), new Person(9, "rr", "qwer", 22),
                new Person(10, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(12, "rr", "qwer", 22), new Person(13, "rr", "qwer", 22), new Person(14, "rr", "qwer", 22),
                new Person(15, "rr", "qwer", 22), new Person(16, "rr", "qwer", 22), new Person(17, "rr", "qwer", 22), new Person(18, "rr", "qwer", 22), new Person(19, "rr", "qwer", 22), new Person(20, "rr", "qwer", 22),
                new Person(21, "rr", "qwer", 22), new Person(22, "rr", "qwer", 22), new Person(23, "rr", "qwer", 22), new Person(24, "rr", "qwer", 22), new Person(25, "rr", "qwer", 22),
                new Person(26, "rr", "qwer", 22), new Person(27, "rr", "qwer", 22), new Person(28, "rr", "qwer", 22), new Person(29, "rr", "qwer", 22), new Person(30, "rr", "qwer", 22),
                new Person(31, "rr", "qwer", 22), new Person(32, "rr", "qwer", 22), new Person(33, "rr", "qwer", 22), new Person(34, "rr", "qwer", 22),new Person(35, "rr", "qwer", 22),new Person(36, "rr", "qwer", 22)};

        #region Size
        [TestMethod]
        public void AListSize36Test()
        { 
            var a = new AList2<Person>();
            a.Init(mas);
            int size = a.Size();
            Assert.AreEqual(36, size);
        }
        #endregion

        #region Clear
        [TestMethod]
        public void AListClear36Test()
        {
            var a = new AList2<Person>();
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
            var a = new AList2<Person>();
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
            var a = new AList2<Person>();
            a.Init(mas);
            a.AddStart(new Person(0, "rr", "qwer", 22));
            int size = a.Size();
            mas = new Person[37] {new Person(0, "rr", "qwer", 22), new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22), new Person(6, "rr", "qwer", 22), new Person(7, "rr", "qwer", 22), new Person(8, "rr", "qwer", 22), new Person(9, "rr", "qwer", 22),
                new Person(10, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(12, "rr", "qwer", 22), new Person(13, "rr", "qwer", 22), new Person(14, "rr", "qwer", 22),
                new Person(15, "rr", "qwer", 22), new Person(16, "rr", "qwer", 22), new Person(17, "rr", "qwer", 22), new Person(18, "rr", "qwer", 22), new Person(19, "rr", "qwer", 22), new Person(20, "rr", "qwer", 22),
                new Person(21, "rr", "qwer", 22), new Person(22, "rr", "qwer", 22), new Person(23, "rr", "qwer", 22), new Person(24, "rr", "qwer", 22), new Person(25, "rr", "qwer", 22),
                new Person(26, "rr", "qwer", 22), new Person(27, "rr", "qwer", 22), new Person(28, "rr", "qwer", 22), new Person(29, "rr", "qwer", 22), new Person(30, "rr", "qwer", 22),
                new Person(31, "rr", "qwer", 22), new Person(32, "rr", "qwer", 22), new Person(33, "rr", "qwer", 22), new Person(34, "rr", "qwer", 22),new Person(35, "rr", "qwer", 22),new Person(36, "rr", "qwer", 22)};
            Assert.AreEqual(37, size);
            Assert.AreEqual(mas.ToString(), a.ToArray().ToString());
        }
        #endregion

        #region AddEnd
        [TestMethod]
        public void AListAddEnd36Test()
        {
            var a = new AList2<Person>();
            a.Init(mas);
            a.AddEnd(new Person(0, "rr", "qwer", 22));
            int size = a.Size();
            mas = new Person[37] {new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22), new Person(6, "rr", "qwer", 22), new Person(7, "rr", "qwer", 22), new Person(8, "rr", "qwer", 22), new Person(9, "rr", "qwer", 22),
                new Person(10, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(12, "rr", "qwer", 22), new Person(13, "rr", "qwer", 22), new Person(14, "rr", "qwer", 22),
                new Person(15, "rr", "qwer", 22), new Person(16, "rr", "qwer", 22), new Person(17, "rr", "qwer", 22), new Person(18, "rr", "qwer", 22), new Person(19, "rr", "qwer", 22), new Person(20, "rr", "qwer", 22),
                new Person(21, "rr", "qwer", 22), new Person(22, "rr", "qwer", 22), new Person(23, "rr", "qwer", 22), new Person(24, "rr", "qwer", 22), new Person(25, "rr", "qwer", 22),
                new Person(26, "rr", "qwer", 22), new Person(27, "rr", "qwer", 22), new Person(28, "rr", "qwer", 22), new Person(29, "rr", "qwer", 22), new Person(30, "rr", "qwer", 22),
                new Person(31, "rr", "qwer", 22), new Person(32, "rr", "qwer", 22), new Person(33, "rr", "qwer", 22), new Person(34, "rr", "qwer", 22),new Person(35, "rr", "qwer", 22),new Person(36, "rr", "qwer", 22), new Person(0, "rr", "qwer", 22)};
            Assert.AreEqual(37, size);
            Assert.AreEqual(mas.ToString(), a.ToArray().ToString());
        }
        #endregion

        #region AddPos
        [TestMethod]
        public void AListAddPos36Test()
        {
            var a = new AList2<Person>();
            a.Init(mas);
            a.AddPos(2, new Person(0, "rr", "qwer", 22));
            int size = a.Size();
            mas = new Person[37] {new Person(1, "rr", "qwer", 22), new Person(2, "rr", "qwer", 22), new Person(0, "rr", "qwer", 22),new Person(3, "rr", "qwer", 22), new Person(4, "rr", "qwer", 22),
                new Person(5, "rr", "qwer", 22), new Person(6, "rr", "qwer", 22), new Person(7, "rr", "qwer", 22), new Person(8, "rr", "qwer", 22), new Person(9, "rr", "qwer", 22),
                new Person(10, "rr", "qwer", 22), new Person(11, "rr", "qwer", 22), new Person(12, "rr", "qwer", 22), new Person(13, "rr", "qwer", 22), new Person(14, "rr", "qwer", 22),
                new Person(15, "rr", "qwer", 22), new Person(16, "rr", "qwer", 22), new Person(17, "rr", "qwer", 22), new Person(18, "rr", "qwer", 22), new Person(19, "rr", "qwer", 22), new Person(20, "rr", "qwer", 22),
                new Person(21, "rr", "qwer", 22), new Person(22, "rr", "qwer", 22), new Person(23, "rr", "qwer", 22), new Person(24, "rr", "qwer", 22), new Person(25, "rr", "qwer", 22),
                new Person(26, "rr", "qwer", 22), new Person(27, "rr", "qwer", 22), new Person(28, "rr", "qwer", 22), new Person(29, "rr", "qwer", 22), new Person(30, "rr", "qwer", 22),
                new Person(31, "rr", "qwer", 22), new Person(32, "rr", "qwer", 22), new Person(33, "rr", "qwer", 22), new Person(34, "rr", "qwer", 22),new Person(35, "rr", "qwer", 22),new Person(36, "rr", "qwer", 22)};
            Assert.AreEqual(37, size);
            CollectionAssert.AreEqual(mas, a.ToArray());
        }
        #endregion

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
}
