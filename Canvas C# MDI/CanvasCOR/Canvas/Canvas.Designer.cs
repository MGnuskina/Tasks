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
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
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
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color:";
            // 
            // colorPanel
            // 
            this.colorPanel.Location = new System.Drawing.Point(13, 90);
            this.colorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(40, 42);
            this.colorPanel.TabIndex = 1;
            this.colorPanel.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 170);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.widthToolStripMenuItem,
            this.heightToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.tabsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1029, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // widthToolStripMenuItem
            // 
            this.widthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbWidth});
            this.widthToolStripMenuItem.Name = "widthToolStripMenuItem";
            this.widthToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.widthToolStripMenuItem.Text = "Width";
            // 
            // tscbWidth
            // 
            this.tscbWidth.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.tscbWidth.Name = "tscbWidth";
            this.tscbWidth.Size = new System.Drawing.Size(121, 28);
            this.tscbWidth.Text = "Width";
            // 
            // heightToolStripMenuItem
            // 
            this.heightToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbType});
            this.heightToolStripMenuItem.Name = "heightToolStripMenuItem";
            this.heightToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.heightToolStripMenuItem.Text = "Type";
            // 
            // tscbType
            // 
            this.tscbType.Items.AddRange(new object[] {
            "Line",
            "Rectangle",
            "Elipse",
            "RoundRectangle",
            "Fozy"});
            this.tscbType.Name = "tscbType";
            this.tscbType.Size = new System.Drawing.Size(121, 28);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tabsToolStripMenuItem
            // 
            this.tabsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabToolStripMenuItem,
            this.deleteTabToolStripMenuItem,
            this.moveLeftToolStripMenuItem,
            this.moveRightToolStripMenuItem});
            this.tabsToolStripMenuItem.Name = "tabsToolStripMenuItem";
            this.tabsToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.tabsToolStripMenuItem.Text = "Tabs";
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            this.newTabToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.newTabToolStripMenuItem.Text = "New Tab";
            this.newTabToolStripMenuItem.Click += new System.EventHandler(this.newTabToolStripMenuItem_Click);
            // 
            // deleteTabToolStripMenuItem
            // 
            this.deleteTabToolStripMenuItem.Name = "deleteTabToolStripMenuItem";
            this.deleteTabToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.deleteTabToolStripMenuItem.Text = "Delete Tab";
            this.deleteTabToolStripMenuItem.Click += new System.EventHandler(this.deleteTabToolStripMenuItem_Click);
            // 
            // moveLeftToolStripMenuItem
            // 
            this.moveLeftToolStripMenuItem.Name = "moveLeftToolStripMenuItem";
            this.moveLeftToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.moveLeftToolStripMenuItem.Text = "Move Left";
            this.moveLeftToolStripMenuItem.Click += new System.EventHandler(this.moveLeftToolStripMenuItem_Click);
            // 
            // moveRightToolStripMenuItem
            // 
            this.moveRightToolStripMenuItem.Name = "moveRightToolStripMenuItem";
            this.moveRightToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.moveRightToolStripMenuItem.Text = "Move Right";
            this.moveRightToolStripMenuItem.Click += new System.EventHandler(this.moveRightToolStripMenuItem_Click);
            // 
            // tabControlCanvas
            // 
            this.tabControlCanvas.Controls.Add(this.tabPageCanvas1);
            this.tabControlCanvas.Location = new System.Drawing.Point(115, 58);
            this.tabControlCanvas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlCanvas.Name = "tabControlCanvas";
            this.tabControlCanvas.SelectedIndex = 0;
            this.tabControlCanvas.Size = new System.Drawing.Size(916, 550);
            this.tabControlCanvas.TabIndex = 7;
            this.tabControlCanvas.SelectedIndexChanged += new System.EventHandler(this.tabControlCanvas_SelectedIndexChanged);
            // 
            // tabPageCanvas1
            // 
            this.tabPageCanvas1.Controls.Add(this.panelCanvas1);
            this.tabPageCanvas1.Location = new System.Drawing.Point(4, 25);
            this.tabPageCanvas1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageCanvas1.Name = "tabPageCanvas1";
            this.tabPageCanvas1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageCanvas1.Size = new System.Drawing.Size(908, 521);
            this.tabPageCanvas1.TabIndex = 0;
            this.tabPageCanvas1.Text = "Canvas";
            this.tabPageCanvas1.UseVisualStyleBackColor = true;
            // 
            // panelCanvas1
            // 
            this.panelCanvas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCanvas1.Location = new System.Drawing.Point(3, 2);
            this.panelCanvas1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCanvas1.Name = "panelCanvas1";
            this.panelCanvas1.Size = new System.Drawing.Size(902, 517);
            this.panelCanvas1.TabIndex = 0;
            this.panelCanvas1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasForm_MouseDown);
            this.panelCanvas1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CanvasForm_MouseMove);
            this.panelCanvas1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CanvasForm_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tbcbWidth,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.tbcbType});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1029, 28);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(49, 25);
            this.toolStripButton1.Text = "Color";
            this.toolStripButton1.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(52, 25);
            this.toolStripLabel1.Text = "Width:";
            // 
            // tbcbWidth
            // 
            this.tbcbWidth.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.tbcbWidth.Name = "tbcbWidth";
            this.tbcbWidth.Size = new System.Drawing.Size(121, 28);
            this.tbcbWidth.Tag = "";
            this.tbcbWidth.Text = "Width:";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(44, 25);
            this.toolStripLabel2.Text = "Type:";
            // 
            // tbcbType
            // 
            this.tbcbType.Items.AddRange(new object[] {
            "Line",
            "Rectangle",
            "Elipse",
            "RoundRectangle",
            "Fozy"});
            this.tbcbType.Name = "tbcbType";
            this.tbcbType.Size = new System.Drawing.Size(121, 28);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Type:";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Line",
            "Rectangle",
            "Elipse",
            "RoundRectangle",
            "Fozy"});
            this.cbType.Location = new System.Drawing.Point(0, 238);
            this.cbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(109, 24);
            this.cbType.TabIndex = 11;
            // 
            // width
            // 
            this.width.FormattingEnabled = true;
            this.width.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.width.Location = new System.Drawing.Point(4, 169);
            this.width.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(109, 24);
            this.width.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lHeight);
            this.groupBox1.Controls.Add(this.lWidth);
            this.groupBox1.Controls.Add(this.lY);
            this.groupBox1.Controls.Add(this.lX);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(5, 322);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 209);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data:";
            // 
            // lHeight
            // 
            this.lHeight.AutoSize = true;
            this.lHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lHeight.Location = new System.Drawing.Point(67, 125);
            this.lHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHeight.Name = "lHeight";
            this.lHeight.Size = new System.Drawing.Size(0, 20);
            this.lHeight.TabIndex = 18;
            // 
            // lWidth
            // 
            this.lWidth.AutoSize = true;
            this.lWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lWidth.Location = new System.Drawing.Point(67, 93);
            this.lWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lWidth.Name = "lWidth";
            this.lWidth.Size = new System.Drawing.Size(0, 20);
            this.lWidth.TabIndex = 17;
            // 
            // lY
            // 
            this.lY.AutoSize = true;
            this.lY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lY.Location = new System.Drawing.Point(37, 63);
            this.lY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lY.Name = "lY";
            this.lY.Size = new System.Drawing.Size(0, 20);
            this.lY.TabIndex = 16;
            // 
            // lX
            // 
            this.lX.AutoSize = true;
            this.lX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lX.Location = new System.Drawing.Point(37, 32);
            this.lX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lX.Name = "lX";
            this.lX.Size = new System.Drawing.Size(0, 20);
            this.lX.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(0, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Height:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(2, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Width:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(4, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(4, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "X:";
            // 
            // contextMenuStripRightMouseClick
            // 
            this.contextMenuStripRightMouseClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripRightMouseClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmtscmType,
            this.colorToolStripMenuItem1,
            this.cmtscbWidth});
            this.contextMenuStripRightMouseClick.Name = "contextMenuStripRightMouseClick";
            this.contextMenuStripRightMouseClick.Size = new System.Drawing.Size(188, 94);
            // 
            // cmtscmType
            // 
            this.cmtscmType.Items.AddRange(new object[] {
            "Line",
            "Rectangle",
            "Elipse",
            "RoundRectangle",
            "Fozy"});
            this.cmtscmType.Name = "cmtscmType";
            this.cmtscmType.Size = new System.Drawing.Size(121, 28);
            this.cmtscmType.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
            // 
            // colorToolStripMenuItem1
            // 
            this.colorToolStripMenuItem1.Name = "colorToolStripMenuItem1";
            this.colorToolStripMenuItem1.Size = new System.Drawing.Size(187, 26);
            this.colorToolStripMenuItem1.Text = "Color";
            this.colorToolStripMenuItem1.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // cmtscbWidth
            // 
            this.cmtscbWidth.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cmtscbWidth.Name = "cmtscbWidth";
            this.cmtscbWidth.Size = new System.Drawing.Size(121, 28);
            this.cmtscbWidth.SelectedIndexChanged += new System.EventHandler(this.Width_SelectedIndexChanged);
            // 
            // CanvasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 603);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.width);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControlCanvas);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CanvasForm";
            this.Text = "Canvas";
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
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
    }
}

