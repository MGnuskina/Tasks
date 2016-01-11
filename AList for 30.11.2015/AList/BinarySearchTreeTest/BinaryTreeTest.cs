using System;
using NUnit.Framework;
using Binary_Search_Tree_Project;

namespace BinarySearchTreeTest
{
    [TestFixture]
    public class BinaryTreeTest
    {
        #region Clear
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[0])]
        public void ClearTest(int[] mas)
        {
            BinarySearchTree b = new BinarySearchTree();
            b.Init(mas);
            b.Clear();
            int size = b.Size();
            Assert.AreEqual(0, size);
        }

        #endregion

        #region Size
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5)]
        [TestCase(new int[] { 50, 25, 11, 26, 7, 70, 101, 67 }, 8)]
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] { 4, 5 }, 2)]
        [TestCase(new int[0], 0)]
        public void SizeTest(int[] mas, int res)
        {
            BinarySearchTree b = new BinarySearchTree();
            b.Init(mas);
            int size = b.Size();
            Assert.AreEqual(res, size);
        }
        #endregion

        #region Add
        [Test]
        [TestCase(new int[] { 50, 25, 11, 26, 7, 70, 101, 67 }, 9, new int[] { 7, 11, 22, 25, 26, 50, 67, 70, 101 })]
        [TestCase(new int[] { 1, 2, -3, 4, 5 }, 6, new int[] { -3, 1, 2, 4, 5, 22 })]
        [TestCase(new int[] { 11, 2, 33, 4, 5 }, 6, new int[] { 2, 4, 5, 11, 22, 33 })]
        [TestCase(new int[] { 100, 2, 3, 4, 55, 43, -2 }, 8, new int[] { -2, 2, 3, 4, 22, 43, 55, 100 })]
        [TestCase(new int[] { 1 }, 2, new int[] { 1, 22 })]
        [TestCase(new int[] { 4, 5 }, 3, new int[] { 4, 5, 22 })]
        [TestCase(new int[0], 1, new int[] { 22 })]
        public void AddTest(int[] mas, int res, int[] expMas)
        {
            BinarySearchTree b = new BinarySearchTree();
            b.Init(mas);
            b.Add(22);
            int size = b.Size();
            Assert.AreEqual(res, size);
            int[] masRes = b.ToArray();
            CollectionAssert.AreEqual(expMas, masRes);
        }
        #endregion

        #region Del
        [Test]
        [TestCase(new int[] { 50, 25, 11, 26, 7, 70, 101, 5 }, 7, new int[] { 5, 7, 25, 26, 50, 70, 101 })]
        [TestCase(new int[] { 1, 2, -3, 4, 5, 11 }, 5, new int[] { -3, 1, 2, 4, 5 })]
        [TestCase(new int[] { 11, 2, 33, 4, 5 }, 4, new int[] { 2, 4, 5, 33 })]
        [TestCase(new int[] { 100, 2, 3, 4, 5, 43, -2, 11 }, 7, new int[] { -2, 2, 3, 4, 5, 43, 100 })]
        [TestCase(new int[] { 5 }, 0, new int[0])]
        [TestCase(new int[] { 4, 5 }, 1, new int[] { 4 })]
        [TestCase(new int[] { 100, 50, 11, 56, 102 }, 4, new int[] { 50, 56, 100, 102 })]
        public void DelTest(int[] mas, int res, int[] expMas)
        {
            BinarySearchTree b = new BinarySearchTree();
            b.Init(mas);
            b.Del(11);
            int size = b.Size();
            Assert.AreEqual(res, size);
            int[] masRes = b.ToArray();
            CollectionAssert.AreEqual(expMas, masRes);
        }

        [Test]
        [TestCase(new int[] { 12, 5, 3,22 }, 3, new int[] {3,5,22 })]
        public void DelTest1(int[] mas, int res, int[] expMas)
        {
            BinarySearchTree b = new BinarySearchTree();
            b.Init(mas);
            b.Del(12);
            int size = b.Size();
            Assert.AreEqual(res, size);
            int[] masRes = b.ToArray();
            CollectionAssert.AreEqual(expMas, masRes);
        }
        #endregion

        #region Nodes
        [Test]
        [TestCase(new int[] { 50, 25, 11, 26, 7, 70, 101, 67 }, 4)]
        [TestCase(new int[] { 1, 2, -3, 4, 5 }, 3)]
        [TestCase(new int[] { 11, 2, 33, 4, 5 }, 3)]
        [TestCase(new int[] { 100, 2, 3, 4, 5, 43, -2 }, 5)]
        [TestCase(new int[] { 5 }, 0)]
        [TestCase(new int[] { 4, 5 }, 1)]
        public void CountNodesTest(int[] mas, int res)
        {
            BinarySearchTree b = new BinarySearchTree();
            b.Init(mas);
            int nodes = b.Nodes();
            Assert.AreEqual(res, nodes);
        }
        #endregion

        #region Leafs
        [Test]
        [TestCase(new int[] { 50, 25, 11, 26, 7, 70, 101, 67 }, 4)]
        [TestCase(new int[] { 1, 2, -3, 4, 5 }, 2)]
        [TestCase(new int[] { 11, 2, 33, 4, 5 }, 2)]
        [TestCase(new int[] { 100, 2, 3, 4, 5, 43, -2 }, 2)]
        [TestCase(new int[] { 5 }, 1)]
        [TestCase(new int[] { 4, 5 }, 1)]
        public void CountLeafsTest(int[] mas, int res)
        {
            BinarySearchTree b = new BinarySearchTree();
            b.Init(mas);
            int nodes = b.Leafs();
            Assert.AreEqual(res, nodes);
        }
        #endregion

        #region ToString
        [Test]
        [TestCase(new int[] { 50, 25, 11, 26, 7, 70, 101, 67 }, new int[] { 7, 11, 25, 26, 50, 67, 70, 101 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 4, 5 }, new int[] { 4, 5 })]
        [TestCase(new int[0], new int[0])]
        public void ToStringTest(int[] mas, int[] expMas)
        {
            BinarySearchTree b = new BinarySearchTree();
            b.Init(mas);
            string masRes = b.TreeToString();
            CollectionAssert.AreEqual(expMas.ToString(), masRes);
        }
        #endregion

        #region Height
        [Test]
        [TestCase(new int[] { 50, 25, 11, 26, 7, 70, 101, 67 }, 4)]
        [TestCase(new int[] { 1, 2, -3, 4, 5 }, 4)]
        [TestCase(new int[] { 11, 2, 33, 4, 5 }, 4)]
        [TestCase(new int[] { 100, 2, 3, 4, 5, 43, -2 }, 6)]
        [TestCase(new int[] { 5 }, 1)]
        [TestCase(new int[] { 4, 5 }, 2)]
        public void CountHeightTest(int[] mas, int res)
        {
            BinarySearchTree b = new BinarySearchTree();
            b.Init(mas);
            int nodes = b.Height();
            Assert.AreEqual(res, nodes);
        }
        #endregion

        #region Width
        [Test]
        [TestCase(new int[] { 50, 25, 11, 26, 7, 70, 101, 67 }, 4)]
        [TestCase(new int[] { 1, 2, -3, 4, 5 }, 2)]
        [TestCase(new int[] { 11, 2, 33, 4, 5 }, 2)]
        [TestCase(new int[] { 100, 2, 3, 4, 5, 43, -2 }, 2)]
        [TestCase(new int[] { 5 }, 1)]
        [TestCase(new int[] { 4, 5 }, 1)]
        public void CountWidthTest(int[] mas, int res)
        {
            BinarySearchTree b = new BinarySearchTree();
            b.Init(mas);
            int nodes = b.Width();
            Assert.AreEqual(res, nodes);
        }
        #endregion

        #region Reverse
        [Test]
        [TestCase(new int[] { 50, 25, 11, 26, 7, 70, 101, 67 }, 8, new int[] { 101, 70, 67, 50, 26, 25, 11, 7 })]
        [TestCase(new int[] { 1, 2, -3, 4, 5 }, 5, new int[] { 5, 4, 2, 1, -3 })]
        [TestCase(new int[] { 11, 2, 33, 4, 5 }, 5, new int[] { 33, 11, 5, 4, 2 })]
        [TestCase(new int[] { 100, 2, 3, 4, 55, 43, -2 }, 7, new int[] { 100, 55, 43, 4, 3, 2, -2 })]
        [TestCase(new int[] { 1 }, 1, new int[] { 1 })]
        [TestCase(new int[] { 4, 5 }, 2, new int[] { 5, 4 })]
        [TestCase(new int[0], 0, new int[0])]
        public void ReverseTest(int[] mas, int res, int[] expMas)
        {
            BinarySearchTree b = new BinarySearchTree();
            b.Init(mas);
            b.Reverse();
            int size = b.Size();
            Assert.AreEqual(res, size);
            int[] masRes = b.ToArray();
            CollectionAssert.AreEqual(expMas, masRes);
        }
        #endregion
    }
}