namespace Shortcut_Master
{
    partial class frmmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.lstResults = new System.Windows.Forms.ListBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sTip1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResults = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.butMenu = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ImgOpenFolder = new System.Windows.Forms.PictureBox();
            this.ImgRunApp = new System.Windows.Forms.PictureBox();
            this.mnuMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgOpenFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgRunApp)).BeginInit();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstResults
            // 
            this.lstResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstResults.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstResults.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstResults.FormattingEnabled = true;
            this.lstResults.IntegralHeight = false;
            this.lstResults.ItemHeight = 16;
            this.lstResults.Location = new System.Drawing.Point(8, 113);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(297, 179);
            this.lstResults.TabIndex = 1;
            this.lstResults.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstResults_DrawItem);
            this.lstResults.SelectedIndexChanged += new System.EventHandler(this.lstResults_SelectedIndexChanged);
            this.lstResults.DoubleClick += new System.EventHandler(this.lstResults_DoubleClick);
            this.lstResults.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstResults_KeyPress);
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFind.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(4, 6);
            this.txtFind.Multiline = true;
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(289, 20);
            this.txtFind.TabIndex = 3;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            this.txtFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFind_KeyPress);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTip1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 295);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(313, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sTip1
            // 
            this.sTip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sTip1.Name = "sTip1";
            this.sTip1.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.lblResults);
            this.panel1.Location = new System.Drawing.Point(8, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 30);
            this.panel1.TabIndex = 5;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.ForeColor = System.Drawing.Color.White;
            this.lblResults.Location = new System.Drawing.Point(6, 8);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(69, 14);
            this.lblResults.TabIndex = 0;
            this.lblResults.Text = "Results ::";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.txtFind);
            this.panel3.Location = new System.Drawing.Point(8, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(297, 34);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.Resize += new System.EventHandler(this.panel3_Resize);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(8, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 30);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search for ::";
            // 
            // butMenu
            // 
            this.butMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butMenu.BackColor = System.Drawing.Color.Gray;
            this.butMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butMenu.FlatAppearance.BorderSize = 0;
            this.butMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMenu.ForeColor = System.Drawing.Color.White;
            this.butMenu.Location = new System.Drawing.Point(278, 6);
            this.butMenu.Name = "butMenu";
            this.butMenu.Size = new System.Drawing.Size(27, 23);
            this.butMenu.TabIndex = 9;
            this.butMenu.Text = "≡";
            this.toolTip1.SetToolTip(this.butMenu, "Menu");
            this.butMenu.UseVisualStyleBackColor = false;
            this.butMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.butMenu_MouseDown);
            // 
            // ImgOpenFolder
            // 
            this.ImgOpenFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgOpenFolder.Image = ((System.Drawing.Image)(resources.GetObject("ImgOpenFolder.Image")));
            this.ImgOpenFolder.Location = new System.Drawing.Point(134, 94);
            this.ImgOpenFolder.Name = "ImgOpenFolder";
            this.ImgOpenFolder.Size = new System.Drawing.Size(16, 16);
            this.ImgOpenFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgOpenFolder.TabIndex = 11;
            this.ImgOpenFolder.TabStop = false;
            this.toolTip1.SetToolTip(this.ImgOpenFolder, "Open program location");
            this.ImgOpenFolder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImgOpenFolder_MouseDown);
            // 
            // ImgRunApp
            // 
            this.ImgRunApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgRunApp.Image = ((System.Drawing.Image)(resources.GetObject("ImgRunApp.Image")));
            this.ImgRunApp.Location = new System.Drawing.Point(156, 94);
            this.ImgRunApp.Name = "ImgRunApp";
            this.ImgRunApp.Size = new System.Drawing.Size(16, 16);
            this.ImgRunApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgRunApp.TabIndex = 12;
            this.ImgRunApp.TabStop = false;
            this.toolTip1.SetToolTip(this.ImgRunApp, "Run appliaction");
            this.ImgRunApp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImgRunApp_MouseClick);
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout,
            this.mnuVInfo,
            this.toolStripSeparator1,
            this.mnuRefresh,
            this.toolStripSeparator2,
            this.mnuExit});
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(137, 104);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(136, 22);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // mnuVInfo
            // 
            this.mnuVInfo.Name = "mnuVInfo";
            this.mnuVInfo.Size = new System.Drawing.Size(136, 22);
            this.mnuVInfo.Text = "Version Info";
            this.mnuVInfo.Click += new System.EventHandler(this.mnuVInfo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // mnuRefresh
            // 
            this.mnuRefresh.Name = "mnuRefresh";
            this.mnuRefresh.Size = new System.Drawing.Size(136, 22);
            this.mnuRefresh.Text = "Refresh";
            this.mnuRefresh.Click += new System.EventHandler(this.mnuRefresh_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(133, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(136, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(313, 317);
            this.Controls.Add(this.ImgRunApp);
            this.Controls.Add(this.ImgOpenFolder);
            this.Controls.Add(this.butMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lstResults);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shortcut Master";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmmain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.frmmain_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgOpenFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgRunApp)).EndInit();
            this.mnuMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel sTip1;
        private System.Windows.Forms.Button butMenu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.PictureBox ImgOpenFolder;
        private System.Windows.Forms.PictureBox ImgRunApp;
        private System.Windows.Forms.ToolStripMenuItem mnuRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuVInfo;
    }
}

