using Binary_Search_Tree_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryTreeVisualization
{
    public partial class BinaryTreeForm : Form
    {
        public BinaryTreeForm()
        {
            InitializeComponent();
        }

        private void drawTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinarySearchTree binaryTree = new BinarySearchTree();
            Draw(binaryTree);
        }

        private void Draw(BinarySearchTree binaryTree)
        {
            int[] array = new int[] { 55, 5, 88, 50, 25, 11, 26, 17, 70, 99, 18, 78, 23,3,4};
            binaryTree.Init(array);
            int length = binaryTree.Height();
            int depth = (int)(Math.Pow(2, length - 1));
            int deltaY = (int)(this.Size.Height / (length + 1));
            int x = (int)(this.Size.Width / 2.0);
            bool[,] isUsed = new bool[length, depth];
            int[,] tree = new int[length, depth];
            binaryTree.ReturnTree(ref tree, ref isUsed);
            Graphics g = CreateGraphics();
            g.Clear(this.BackColor);
            int i = 0;
            BinarySearchTree.Node nowNode = binaryTree.treeRoot;
            GetTree(i, ref nowNode, length, g, deltaY, x, x);
        }

        private void GetTree(int i, ref BinarySearchTree.Node nodeNow, int height, Graphics g, int deltaY, int x, int deltaX)
        {
            Font drawFont = new Font("Arial", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            if (nodeNow != null)
            {
                int y = (i) * deltaY + 30;
                g.DrawEllipse(Pens.Black, x, y, 30, 30);
                g.DrawString(nodeNow.value.ToString(), drawFont, drawBrush, x + 3, y + 3);

                i++;
                int tmp = x;
                deltaX = (int)(deltaX / 2.0);
                if (nodeNow.left != null)
                {
                    x = x - deltaX;
                    GetTree(i, ref nodeNow.left, height, g, deltaY, x, deltaX);
                    g.DrawLine(Pens.Black, tmp + 15, y + 30, x + 15, y + deltaY);
                }

                if (nodeNow.right != null)
                {
                    x = tmp + deltaX;
                    GetTree(i, ref nodeNow.right, height, g, deltaY, x, deltaX);
                    g.DrawLine(Pens.Black, tmp + 15, y + 30, x + 15, y + deltaY);
                }
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            g.Clear(this.BackColor);
        }
    }
}
