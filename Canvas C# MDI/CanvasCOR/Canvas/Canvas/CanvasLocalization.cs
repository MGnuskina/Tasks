using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canvas
{
    public partial class CanvasForm
    {
        private void tscbLenguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ToolStripComboBox)
            {
                switch ((sender as ToolStripComboBox).SelectedItem.ToString())
                {
                    case "English":
                        Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                        break;
                    case "Русский":
                        Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-ru");
                        break;
                    default:
                        Thread.CurrentThread.CurrentUICulture = new CultureInfo("uk-UA");
                        break;
                }
                ChangeLanguage();

                //listType = new List<string> { "List", "Rectangle", "Elipse", "RoundRectangle", "Fozy" };
                //Binding();
            }
        }

        private static void ChangeLanguage()
        {
            foreach (Form frm in Application.OpenForms)
            {
                LocalizeForm(frm);
            }
            
        }

        private static void LocalizeForm(Form frm)
        {
            var manager = new ComponentResourceManager(frm.GetType());
            manager.ApplyResources(frm, "$this");
            ApplyResources(manager, frm.Controls);
            
        }

        private static void ApplyResources(ComponentResourceManager manager, Control.ControlCollection ctls)
        {
            foreach (Control ctl in ctls)
            {
                manager.ApplyResources(ctl, ctl.Name);
                if (ctl is MenuStrip)
                {
                    ApplyResourcesMenuItems(manager, (ctl as MenuStrip).Items);
                }
                else
                {
                    if (ctl is ToolStrip)
                    {
                        ApplyResourcesToolStripItems(manager, (ctl as ToolStrip).Items);
                    }
                    else
                    {
                        //if (ctl.Name == "cbType")
                        //{
                        //    listType = new List<string>();
                        //    ctl.DataBindings.Clear();
                        //    var cmbBox = ctl as ComboBox;
                        //    //cmbBox.DataSource = null;
                        //    int i = cmbBox.Items.Count;
                        //    cmbBox.Items.Clear();
                        //    for (int j = 0; j < i; j++)
                        //    {
                        //        var str = "";
                        //        if (j == 0)
                        //        {
                        //            str = string.Format("{0}.Items", cmbBox.Name);
                        //        }
                        //        else
                        //        {
                        //            str = string.Format("{0}.Items{1}", cmbBox.Name, j);
                        //        }
                        //        listType.Add(manager.GetString(str));
                        //        cmbBox.DataSource = listType;
                        //        cmbBox.Items.AddRange(new object[]
                        //        {
                        //            manager.GetString(str)
                        //        });
                        //    }

                        //}
                        //else
                        //{
                            ApplyResources(manager, ctl.Controls);
                       // }
                    }
                }
            }
            //ApplyResourcesContextMenuStrip(manager, contextMenuStripRightMouseClick.Items);
        }

        private static void ApplyResourcesMenuItems(ComponentResourceManager manager, ToolStripItemCollection items)
        {
            foreach (var item in items)
            {
                if (item is ToolStripMenuItem)
                {
                    ApplyResourcesMenuItems(manager, (item as ToolStripMenuItem).DropDown.Items);
                    manager.ApplyResources(item, (item as ToolStripMenuItem).Name);
                }
            }
        }

        private static void ApplyResourcesToolStripItems(ComponentResourceManager manager, ToolStripItemCollection items)
        {
            foreach (var item in items)
            {
                if (item is ToolStripLabel)
                {
                    manager.ApplyResources(item, (item as ToolStripLabel).Name);
                }
                else
                {
                    if (item is ToolStripButton)
                    {
                        manager.ApplyResources(item, (item as ToolStripButton).Name);
                    }
                }
            }
        }


        private static void ApplyResourcesContextMenuStrip(ComponentResourceManager manager, ToolStripItemCollection items)
        {
            foreach (var item in items)
            {
                if (item is ToolStripMenuItem)
                {
                    ApplyResourcesMenuItems(manager, (item as ToolStripMenuItem).DropDown.Items);
                    manager.ApplyResources(item, (item as ToolStripMenuItem).Name);
                }
                if (item is ToolStripComboBox)
                {
                    manager.ApplyResources(item, (item as ToolStripComboBox).Name);
                }
            }
        }
    }
}
