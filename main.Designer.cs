namespace Archive
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.districtsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.districtDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repotyViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewFileFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addNewToolStripMenuItem,
            this.viewDataToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.scanFileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1321, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrationToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.administrationToolStripMenuItem.Text = "Administration";
            this.administrationToolStripMenuItem.Click += new System.EventHandler(this.administrationToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.districtsToolStripMenuItem,
            this.addNewToolStripMenuItem1});
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.addNewToolStripMenuItem.Text = " Archive file";
            // 
            // districtsToolStripMenuItem
            // 
            this.districtsToolStripMenuItem.Name = "districtsToolStripMenuItem";
            this.districtsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.districtsToolStripMenuItem.Text = "Districts";
            this.districtsToolStripMenuItem.Click += new System.EventHandler(this.districtsToolStripMenuItem_Click);
            // 
            // addNewToolStripMenuItem1
            // 
            this.addNewToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewFileFormToolStripMenuItem});
            this.addNewToolStripMenuItem1.Name = "addNewToolStripMenuItem1";
            this.addNewToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.addNewToolStripMenuItem1.Text = "Add New File";
            this.addNewToolStripMenuItem1.Click += new System.EventHandler(this.addNewToolStripMenuItem1_Click);
            // 
            // viewDataToolStripMenuItem
            // 
            this.viewDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.districtDataToolStripMenuItem});
            this.viewDataToolStripMenuItem.Name = "viewDataToolStripMenuItem";
            this.viewDataToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.viewDataToolStripMenuItem.Text = "View Data";
            // 
            // districtDataToolStripMenuItem
            // 
            this.districtDataToolStripMenuItem.Name = "districtDataToolStripMenuItem";
            this.districtDataToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.districtDataToolStripMenuItem.Text = "By Districts Data";
            this.districtDataToolStripMenuItem.Click += new System.EventHandler(this.districtDataToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repotyViewToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // repotyViewToolStripMenuItem
            // 
            this.repotyViewToolStripMenuItem.Name = "repotyViewToolStripMenuItem";
            this.repotyViewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.repotyViewToolStripMenuItem.Text = "Report View";
            this.repotyViewToolStripMenuItem.Click += new System.EventHandler(this.repotyViewToolStripMenuItem_Click);
            // 
            // scanFileToolStripMenuItem
            // 
            this.scanFileToolStripMenuItem.Name = "scanFileToolStripMenuItem";
            this.scanFileToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.scanFileToolStripMenuItem.Text = "Scan File";
            this.scanFileToolStripMenuItem.Click += new System.EventHandler(this.scanFileToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 617);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1321, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Archive.Properties.Resources.gg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1350, 694);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // viewFileFormToolStripMenuItem
            // 
            this.viewFileFormToolStripMenuItem.Name = "viewFileFormToolStripMenuItem";
            this.viewFileFormToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewFileFormToolStripMenuItem.Text = "View File Form";
            this.viewFileFormToolStripMenuItem.Click += new System.EventHandler(this.viewFileFormToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 639);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem repotyViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem districtDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem districtsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewFileFormToolStripMenuItem;
    }
}



