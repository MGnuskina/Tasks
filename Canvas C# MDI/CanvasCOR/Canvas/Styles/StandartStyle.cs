using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Canvas
{
    public static class StandartStyle
    {
        static void ApplyTheme(Label c)
        {
            c.Font = new Font("Times New Roman", 9.0f);
            c.BackColor = Color.White;
            c.ForeColor = Color.Black;
        }

        static void ApplyTheme(ComboBox c)
        {
            c.Font = new Font("Times New Roman", 9.0f);
            c.BackColor = Color.White;
            c.ForeColor = Color.Black;
            c.FlatStyle = FlatStyle.System;
        }

        static void ApplyTheme(Form c)
        {
            c.BackColor = Color.White;
            c.ForeColor = Color.Black;
        }

        static void ApplyTheme(ToolStrip c)
        {
            c.Font = new Font("Times New Roman", 9.0f);
            c.BackColor = Color.White;
            c.ForeColor = Color.Black;
            for (int i = 0; i < c.Items.Count; i++)
            {
                if (c.Items[i] is ToolStripComboBox)
                {
                    ApplyTheme(c.Items[i] as ToolStripComboBox);
                }
            }
        }

        static void ApplyTheme(GroupBox c)
        {
            c.Font = new Font("Times New Roman", 9.0f);
            c.BackColor = Color.White;
            c.ForeColor = Color.Black;
        }

        static void ApplyTheme(MenuStrip c)
        {
            c.Font = new Font("Times New Roman", 9.0f);
            c.BackColor = Color.White;
            c.ForeColor = Color.Black;
            foreach (var cb in c.Items)
            {
                if (cb is ToolStripComboBox)
                {
                    ApplyTheme(cb as ToolStripComboBox);
                }
                if (cb is ToolStripMenuItem)
                {
                    ApplyTheme(cb as ToolStripMenuItem);
                }
            }
        }

        static void ApplyTheme(ToolStripComboBox c)
        {
            c.Font = new Font("Times New Roman", 9.0f);
            c.BackColor = Color.White;
            c.ForeColor = Color.Black;
            c.FlatStyle = FlatStyle.System;
        }

        static void ApplyTheme(ToolStripMenuItem c)
        {
            c.Font = new Font("Times New Roman", 9.0f);
            c.BackColor = Color.White;
            c.ForeColor = Color.Black;
            foreach (var cb in c.DropDown.Items)
            {
                if (cb is ToolStripComboBox)
                {
                    ApplyTheme(cb as ToolStripComboBox);
                }
                if (cb is ToolStripMenuItem)
                {
                    ApplyTheme(cb as ToolStripMenuItem);
                }
                c.DropDown.BackColor = Color.White;
            }
        }

        static void ApplyTheme(TabControl c)
        {
            c.Font = new Font("Times New Roman", 9.0f);
            c.BackColor = Color.White;
            c.ForeColor = Color.Black;
            foreach (var tb in c.TabPages)
            {
                ApplyTheme(tb as TabPage);
            }
        }

        static void ApplyTheme(TabPage c)
        {
            c.Font = new Font("Times New Roman", 9.0f);
            c.BackColor = Color.White;
            c.ForeColor = Color.Black;
            foreach (var tb in c.Controls)
            {
                ApplyTheme(tb as Panel);
            }
        }

        static void ApplyTheme(Panel c)
        {
            c.Font = new Font("Times New Roman", 9.0f);
        }

        public static void ApplyThemeContextMenu(ContextMenuStrip c)
        {
            c.Font = new Font("Times New Roman", 9.0f);
            c.BackColor = Color.White;
            c.ForeColor = Color.Black;
            foreach (var tb in c.Items)
            {
                if (tb is ToolStripMenuItem)
                {
                    ApplyTheme(tb as ToolStripMenuItem);
                }
                else
                {
                    if (tb is ToolStripComboBox)
                    {
                        ApplyTheme(tb as ToolStripComboBox);
                    }
                }
            }
        }

        public static void UseTheme(Form form)
        {
            ApplyTheme(form);
            foreach (var c in form.Controls)
            {
                switch (c.GetType().ToString())
                {
                    case "System.Windows.Forms.ToolStrip":
                        ApplyTheme((ToolStrip)c);
                        break;
                    case "System.Windows.Forms.Label":
                        ApplyTheme((Label)c);
                        break;
                    case "System.Windows.Forms.ComboBox":
                        ApplyTheme((ComboBox)c);
                        break;
                    case "System.Windows.Forms.GroupBox":
                        ApplyTheme((GroupBox)c);
                        break;
                    case "System.Windows.Forms.MenuStrip":
                        ApplyTheme((MenuStrip)c);
                        break;
                    case "System.Windows.Forms.TabControl":
                        ApplyTheme((TabControl)c);
                        break;
                    case "System.Windows.Forms.Panel":
                        ApplyTheme((Panel)c);
                        break;
                }
            }
            
        }
    }
}
