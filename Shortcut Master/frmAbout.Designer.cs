namespace Shortcut_Master
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.PicIcon = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.lblAppInfo = new System.Windows.Forms.Label();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.cmdOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PicIcon
            // 
            this.PicIcon.Image = ((System.Drawing.Image)(resources.GetObject("PicIcon.Image")));
            this.PicIcon.Location = new System.Drawing.Point(12, 12);
            this.PicIcon.Name = "PicIcon";
            this.PicIcon.Size = new System.Drawing.Size(48, 48);
            this.PicIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicIcon.TabIndex = 0;
            this.PicIcon.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(79, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(164, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Shortcut Master";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.Crimson;
            this.lblVersion.Location = new System.Drawing.Point(79, 43);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(71, 13);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version 1.2";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(126, 118);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(85, 13);
            this.lblLink.TabIndex = 3;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "Visit Home Page";
            this.lblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_LinkClicked);
            // 
            // lblAppInfo
            // 
            this.lblAppInfo.AutoSize = true;
            this.lblAppInfo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppInfo.Location = new System.Drawing.Point(79, 66);
            this.lblAppInfo.Name = "lblAppInfo";
            this.lblAppInfo.Size = new System.Drawing.Size(214, 14);
            this.lblAppInfo.TabIndex = 4;
            this.lblAppInfo.Text = "Free start menu program locator.";
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDeveloper.Location = new System.Drawing.Point(79, 89);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(210, 13);
            this.lblDeveloper.TabIndex = 5;
            this.lblDeveloper.Text = "Developed by Ben J a.k.a DreamVB";
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(266, 147);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(52, 22);
            this.cmdOk.TabIndex = 6;
            this.cmdOk.Text = "OK";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 181);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.lblAppInfo);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.PicIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.LinkLabel lblLink;
        private System.Windows.Forms.Label lblAppInfo;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Button cmdOk;
    }
}