namespace Canvas
{
    partial class CanvasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CanvasForm));
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbWidth = new System.Windows.Forms.ToolStripComboBox();
            this.heightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbType = new System.Windows.Forms.ToolStripComboBox();
            this.tabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlCanvas = new System.Windows.Forms.TabControl();
            this.tabPageCanvas1 = new System.Windows.Forms.TabPage();
            this.panelCanvas1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbcbWidth = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tbcbType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tscbLenguage = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.tscbStyle = new System.Windows.Forms.ToolStripComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.width = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lHeight = new System.Windows.Forms.Label();
            this.lWidth = new System.Windows.Forms.Label();
            this.lY = new System.Windows.Forms.Label();
            this.lX = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStripRightMouseClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmtscmType = new System.Windows.Forms.ToolStripComboBox();
            this.colorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmtscbWidth = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            this.tabControlCanvas.SuspendLayout();
            this.tabPageCanvas1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStripRightMouseClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // colorPanel
            // 
            resources.ApplyResources(this.colorPanel, "colorPanel");
            this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.widthToolStripMenuItem,
            this.heightToolStripMenuItem,
            this.tabsToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // saveToolStripMenuItem
            // 
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            resources.ApplyResources(this.loadToolStripMenuItem, "loadToolStripMenuItem");
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            // 
            // colorToolStripMenuItem
            // 
            resources.ApplyResources(this.colorToolStripMenuItem, "colorToolStripMenuItem");
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // widthToolStripMenuItem
            // 
            resources.ApplyResources(this.widthToolStripMenuItem, "widthToolStripMenuItem");
            this.widthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbWidth});
            this.widthToolStripMenuItem.Name = "widthToolStripMenuItem";
            // 
            // tscbWidth
            // 
            resources.ApplyResources(this.tscbWidth, "tscbWidth");
            this.tscbWidth.Items.AddRange(new object[] {
            resources.GetString("tscbWidth.Items"),
            resources.GetString("tscbWidth.Items1"),
            resources.GetString("tscbWidth.Items2"),
            resources.GetString("tscbWidth.Items3"),
            resources.GetString("tscbWidth.Items4"),
            resources.GetString("tscbWidth.Items5"),
            resources.GetString("tscbWidth.Items6"),
            resources.GetString("tscbWidth.Items7"),
            resources.GetString("tscbWidth.Items8"),
            resources.GetString("tscbWidth.Items9"),
            resources.GetString("tscbWidth.Items10"),
            resources.GetString("tscbWidth.Items11"),
            resources.GetString("tscbWidth.Items12"),
            resources.GetString("tscbWidth.Items13"),
            resources.GetString("tscbWidth.Items14"),
            resources.GetString("tscbWidth.Items15"),
            resources.GetString("tscbWidth.Items16"),
            resources.GetString("tscbWidth.Items17"),
            resources.GetString("tscbWidth.Items18"),
            resources.GetString("tscbWidth.Items19"),
            resources.GetString("tscbWidth.Items20"),
            resources.GetString("tscbWidth.Items21"),
            resources.GetString("tscbWidth.Items22")});
            this.tscbWidth.Name = "tscbWidth";
            // 
            // heightToolStripMenuItem
            // 
            resources.ApplyResources(this.heightToolStripMenuItem, "heightToolStripMenuItem");
            this.heightToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbType});
            this.heightToolStripMenuItem.Name = "heightToolStripMenuItem";
            // 
            // tscbType
            // 
            resources.ApplyResources(this.tscbType, "tscbType");
            this.tscbType.Items.AddRange(new object[] {
            resources.GetString("tscbType.Items"),
            resources.GetString("tscbType.Items1"),
            resources.GetString("tscbType.Items2"),
            resources.GetString("tscbType.Items3"),
            resources.GetString("tscbType.Items4")});
            this.tscbType.Name = "tscbType";
            // 
            // tabsToolStripMenuItem
            // 
            resources.ApplyResources(this.tabsToolStripMenuItem, "tabsToolStripMenuItem");
            this.tabsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabToolStripMenuItem,
            this.deleteTabToolStripMenuItem,
            this.moveLeftToolStripMenuItem,
            this.moveRightToolStripMenuItem});
            this.tabsToolStripMenuItem.Name = "tabsToolStripMenuItem";
            // 
            // newTabToolStripMenuItem
            // 
            resources.ApplyResources(this.newTabToolStripMenuItem, "newTabToolStripMenuItem");
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            this.newTabToolStripMenuItem.Click += new System.EventHandler(this.newTabToolStripMenuItem_Click);
            // 
            // deleteTabToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteTabToolStripMenuItem, "deleteTabToolStripMenuItem");
            this.deleteTabToolStripMenuItem.Name = "deleteTabToolStripMenuItem";
            this.deleteTabToolStripMenuItem.Click += new System.EventHandler(this.deleteTabToolStripMenuItem_Click);
            // 
            // moveLeftToolStripMenuItem
            // 
            resources.ApplyResources(this.moveLeftToolStripMenuItem, "moveLeftToolStripMenuItem");
            this.moveLeftToolStripMenuItem.Name = "moveLeftToolStripMenuItem";
            this.moveLeftToolStripMenuItem.Click += new System.EventHandler(this.moveLeftToolStripMenuItem_Click);
            // 
            // moveRightToolStripMenuItem
            // 
            resources.ApplyResources(this.moveRightToolStripMenuItem, "moveRightToolStripMenuItem");
            this.moveRightToolStripMenuItem.Name = "moveRightToolStripMenuItem";
            this.moveRightToolStripMenuItem.Click += new System.EventHandler(this.moveRightToolStripMenuItem_Click);
            // 
            // tabControlCanvas
            // 
            resources.ApplyResources(this.tabControlCanvas, "tabControlCanvas");
            this.tabControlCanvas.Controls.Add(this.tabPageCanvas1);
            this.tabControlCanvas.Name = "tabControlCanvas";
            this.tabControlCanvas.SelectedIndex = 0;
            this.tabControlCanvas.SelectedIndexChanged += new System.EventHandler(this.tabControlCanvas_SelectedIndexChanged);
            // 
            // tabPageCanvas1
            // 
            resources.ApplyResources(this.tabPageCanvas1, "tabPageCanvas1");
            this.tabPageCanvas1.Controls.Add(this.panelCanvas1);
            this.tabPageCanvas1.Name = "tabPageCanvas1";
            this.tabPageCanvas1.UseVisualStyleBackColor = true;
            // 
            // panelCanvas1
            // 
            resources.ApplyResources(this.panelCanvas1, "panelCanvas1");
            this.panelCanvas1.BackColor = System.Drawing.Color.White;
            this.panelCanvas1.Name = "panelCanvas1";
            this.panelCanvas1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasForm_MouseDown);
            this.panelCanvas1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CanvasForm_MouseMove);
            this.panelCanvas1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CanvasForm_MouseUp);
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tbcbWidth,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.tbcbType,
            this.toolStripSeparator3,
            this.toolStripLabel3,
            this.tscbLenguage,
            this.toolStripLabel5,
            this.tscbStyle});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripButton1
            // 
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // toolStripLabel1
            // 
            resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
            this.toolStripLabel1.Name = "toolStripLabel1";
            // 
            // tbcbWidth
            // 
            resources.ApplyResources(this.tbcbWidth, "tbcbWidth");
            this.tbcbWidth.Items.AddRange(new object[] {
            resources.GetString("tbcbWidth.Items"),
            resources.GetString("tbcbWidth.Items1"),
            resources.GetString("tbcbWidth.Items2"),
            resources.GetString("tbcbWidth.Items3"),
            resources.GetString("tbcbWidth.Items4"),
            resources.GetString("tbcbWidth.Items5"),
            resources.GetString("tbcbWidth.Items6"),
            resources.GetString("tbcbWidth.Items7"),
            resources.GetString("tbcbWidth.Items8"),
            resources.GetString("tbcbWidth.Items9"),
            resources.GetString("tbcbWidth.Items10"),
            resources.GetString("tbcbWidth.Items11"),
            resources.GetString("tbcbWidth.Items12"),
            resources.GetString("tbcbWidth.Items13"),
            resources.GetString("tbcbWidth.Items14"),
            resources.GetString("tbcbWidth.Items15"),
            resources.GetString("tbcbWidth.Items16"),
            resources.GetString("tbcbWidth.Items17"),
            resources.GetString("tbcbWidth.Items18"),
            resources.GetString("tbcbWidth.Items19"),
            resources.GetString("tbcbWidth.Items20"),
            resources.GetString("tbcbWidth.Items21"),
            resources.GetString("tbcbWidth.Items22")});
            this.tbcbWidth.Name = "tbcbWidth";
            this.tbcbWidth.Tag = "";
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // toolStripLabel2
            // 
            resources.ApplyResources(this.toolStripLabel2, "toolStripLabel2");
            this.toolStripLabel2.Name = "toolStripLabel2";
            // 
            // tbcbType
            // 
            resources.ApplyResources(this.tbcbType, "tbcbType");
            this.tbcbType.Items.AddRange(new object[] {
            resources.GetString("tbcbType.Items"),
            resources.GetString("tbcbType.Items1"),
            resources.GetString("tbcbType.Items2"),
            resources.GetString("tbcbType.Items3"),
            resources.GetString("tbcbType.Items4")});
            this.tbcbType.Name = "tbcbType";
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // toolStripLabel3
            // 
            resources.ApplyResources(this.toolStripLabel3, "toolStripLabel3");
            this.toolStripLabel3.Name = "toolStripLabel3";
            // 
            // tscbLenguage
            // 
            resources.ApplyResources(this.tscbLenguage, "tscbLenguage");
            this.tscbLenguage.Items.AddRange(new object[] {
            resources.GetString("tscbLenguage.Items"),
            resources.GetString("tscbLenguage.Items1"),
            resources.GetString("tscbLenguage.Items2")});
            this.tscbLenguage.Name = "tscbLenguage";
            this.tscbLenguage.SelectedIndexChanged += new System.EventHandler(this.tscbLenguage_SelectedIndexChanged);
            // 
            // toolStripLabel5
            // 
            resources.ApplyResources(this.toolStripLabel5, "toolStripLabel5");
            this.toolStripLabel5.Name = "toolStripLabel5";
            // 
            // tscbStyle
            // 
            resources.ApplyResources(this.tscbStyle, "tscbStyle");
            this.tscbStyle.Items.AddRange(new object[] {
            resources.GetString("tscbStyle.Items"),
            resources.GetString("tscbStyle.Items1"),
            resources.GetString("tscbStyle.Items2")});
            this.tscbStyle.Name = "tscbStyle";
            this.tscbStyle.SelectedIndexChanged += new System.EventHandler(this.tscbStyle_SelectedIndexChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cbType
            // 
            resources.ApplyResources(this.cbType, "cbType");
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            resources.GetString("cbType.Items"),
            resources.GetString("cbType.Items1"),
            resources.GetString("cbType.Items2"),
            resources.GetString("cbType.Items3"),
            resources.GetString("cbType.Items4")});
            this.cbType.Name = "cbType";
            // 
            // width
            // 
            resources.ApplyResources(this.width, "width");
            this.width.FormattingEnabled = true;
            this.width.Items.AddRange(new object[] {
            resources.GetString("width.Items"),
            resources.GetString("width.Items1"),
            resources.GetString("width.Items2"),
            resources.GetString("width.Items3"),
            resources.GetString("width.Items4"),
            resources.GetString("width.Items5"),
            resources.GetString("width.Items6"),
            resources.GetString("width.Items7"),
            resources.GetString("width.Items8"),
            resources.GetString("width.Items9"),
            resources.GetString("width.Items10"),
            resources.GetString("width.Items11"),
            resources.GetString("width.Items12"),
            resources.GetString("width.Items13"),
            resources.GetString("width.Items14"),
            resources.GetString("width.Items15"),
            resources.GetString("width.Items16"),
            resources.GetString("width.Items17"),
            resources.GetString("width.Items18"),
            resources.GetString("width.Items19"),
            resources.GetString("width.Items20"),
            resources.GetString("width.Items21"),
            resources.GetString("width.Items22")});
            this.width.Name = "width";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.lHeight);
            this.groupBox1.Controls.Add(this.lWidth);
            this.groupBox1.Controls.Add(this.lY);
            this.groupBox1.Controls.Add(this.lX);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lHeight
            // 
            resources.ApplyResources(this.lHeight, "lHeight");
            this.lHeight.Name = "lHeight";
            // 
            // lWidth
            // 
            resources.ApplyResources(this.lWidth, "lWidth");
            this.lWidth.Name = "lWidth";
            // 
            // lY
            // 
            resources.ApplyResources(this.lY, "lY");
            this.lY.Name = "lY";
            // 
            // lX
            // 
            resources.ApplyResources(this.lX, "lX");
            this.lX.Name = "lX";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // contextMenuStripRightMouseClick
            // 
            resources.ApplyResources(this.contextMenuStripRightMouseClick, "contextMenuStripRightMouseClick");
            this.contextMenuStripRightMouseClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripRightMouseClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmtscmType,
            this.colorToolStripMenuItem1,
            this.cmtscbWidth});
            this.contextMenuStripRightMouseClick.Name = "contextMenuStripRightMouseClick";
            // 
            // cmtscmType
            // 
            resources.ApplyResources(this.cmtscmType, "cmtscmType");
            this.cmtscmType.Items.AddRange(new object[] {
            resources.GetString("cmtscmType.Items"),
            resources.GetString("cmtscmType.Items1"),
            resources.GetString("cmtscmType.Items2"),
            resources.GetString("cmtscmType.Items3"),
            resources.GetString("cmtscmType.Items4")});
            this.cmtscmType.Name = "cmtscmType";
            this.cmtscmType.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
            // 
            // colorToolStripMenuItem1
            // 
            resources.ApplyResources(this.colorToolStripMenuItem1, "colorToolStripMenuItem1");
            this.colorToolStripMenuItem1.Name = "colorToolStripMenuItem1";
            this.colorToolStripMenuItem1.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // cmtscbWidth
            // 
            resources.ApplyResources(this.cmtscbWidth, "cmtscbWidth");
            this.cmtscbWidth.Items.AddRange(new object[] {
            resources.GetString("cmtscbWidth.Items"),
            resources.GetString("cmtscbWidth.Items1"),
            resources.GetString("cmtscbWidth.Items2"),
            resources.GetString("cmtscbWidth.Items3"),
            resources.GetString("cmtscbWidth.Items4"),
            resources.GetString("cmtscbWidth.Items5"),
            resources.GetString("cmtscbWidth.Items6"),
            resources.GetString("cmtscbWidth.Items7"),
            resources.GetString("cmtscbWidth.Items8"),
            resources.GetString("cmtscbWidth.Items9"),
            resources.GetString("cmtscbWidth.Items10"),
            resources.GetString("cmtscbWidth.Items11"),
            resources.GetString("cmtscbWidth.Items12"),
            resources.GetString("cmtscbWidth.Items13"),
            resources.GetString("cmtscbWidth.Items14"),
            resources.GetString("cmtscbWidth.Items15"),
            resources.GetString("cmtscbWidth.Items16"),
            resources.GetString("cmtscbWidth.Items17"),
            resources.GetString("cmtscbWidth.Items18"),
            resources.GetString("cmtscbWidth.Items19"),
            resources.GetString("cmtscbWidth.Items20"),
            resources.GetString("cmtscbWidth.Items21"),
            resources.GetString("cmtscbWidth.Items22")});
            this.cmtscbWidth.Name = "cmtscbWidth";
            this.cmtscbWidth.SelectedIndexChanged += new System.EventHandler(this.Width_SelectedIndexChanged);
            // 
            // CanvasForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.width);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControlCanvas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CanvasForm";
            this.Load += new System.EventHandler(this.CanvasForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlCanvas.ResumeLayout(false);
            this.tabPageCanvas1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStripRightMouseClick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabsToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlCanvas;
        private System.Windows.Forms.TabPage tabPageCanvas1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveRightToolStripMenuItem;
        private System.Windows.Forms.Panel panelCanvas1;
        private System.Windows.Forms.ToolStripComboBox tscbWidth;
        private System.Windows.Forms.ToolStripComboBox tbcbWidth;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ComboBox width;
        private System.Windows.Forms.ToolStripComboBox tbcbType;
        private System.Windows.Forms.ToolStripComboBox tscbType;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lHeight;
        private System.Windows.Forms.Label lWidth;
        private System.Windows.Forms.Label lY;
        private System.Windows.Forms.Label lX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRightMouseClick;
        private System.Windows.Forms.ToolStripComboBox cmtscmType;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox cmtscbWidth;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox tscbLenguage;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox tscbStyle;
    }
}

