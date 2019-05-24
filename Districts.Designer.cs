namespace Archive
{
    partial class Districts
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.districtIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.archiveDataSet4 = new Archive.ArchiveDataSet4();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.subDistrictIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subDistrictNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subDistrictBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.archiveDataSet3 = new Archive.ArchiveDataSet3();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.subDistrictTableAdapter = new Archive.ArchiveDataSet3TableAdapters.SubDistrictTableAdapter();
            this.districtTableAdapter = new Archive.ArchiveDataSet4TableAdapters.DistrictTableAdapter();
            this.tfwd = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.districtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataSet4)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subDistrictBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(416, 364);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tfwd);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(408, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add District";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "List of Districts";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.districtIDDataGridViewTextBoxColumn1,
            this.dNameDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.districtBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(350, 138);
            this.dataGridView1.TabIndex = 3;
            // 
            // districtIDDataGridViewTextBoxColumn1
            // 
            this.districtIDDataGridViewTextBoxColumn1.DataPropertyName = "DistrictID";
            this.districtIDDataGridViewTextBoxColumn1.HeaderText = "DistrictID";
            this.districtIDDataGridViewTextBoxColumn1.Name = "districtIDDataGridViewTextBoxColumn1";
            this.districtIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dNameDataGridViewTextBoxColumn
            // 
            this.dNameDataGridViewTextBoxColumn.DataPropertyName = "DName";
            this.dNameDataGridViewTextBoxColumn.HeaderText = "DName";
            this.dNameDataGridViewTextBoxColumn.Name = "dNameDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn1
            // 
            this.userIDDataGridViewTextBoxColumn1.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn1.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn1.Name = "userIDDataGridViewTextBoxColumn1";
            // 
            // districtBindingSource
            // 
            this.districtBindingSource.DataMember = "District";
            this.districtBindingSource.DataSource = this.archiveDataSet4;
            // 
            // archiveDataSet4
            // 
            this.archiveDataSet4.DataSetName = "ArchiveDataSet4";
            this.archiveDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(408, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add subDistrict";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "List of subDistricts";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subDistrictIDDataGridViewTextBoxColumn,
            this.subDistrictNameDataGridViewTextBoxColumn,
            this.districtIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.subDistrictBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 150);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(405, 138);
            this.dataGridView2.TabIndex = 8;
            // 
            // subDistrictIDDataGridViewTextBoxColumn
            // 
            this.subDistrictIDDataGridViewTextBoxColumn.DataPropertyName = "SubDistrictID";
            this.subDistrictIDDataGridViewTextBoxColumn.HeaderText = "SubDistrictID";
            this.subDistrictIDDataGridViewTextBoxColumn.Name = "subDistrictIDDataGridViewTextBoxColumn";
            this.subDistrictIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subDistrictNameDataGridViewTextBoxColumn
            // 
            this.subDistrictNameDataGridViewTextBoxColumn.DataPropertyName = "SubDistrictName";
            this.subDistrictNameDataGridViewTextBoxColumn.HeaderText = "SubDistrictName";
            this.subDistrictNameDataGridViewTextBoxColumn.Name = "subDistrictNameDataGridViewTextBoxColumn";
            // 
            // districtIDDataGridViewTextBoxColumn
            // 
            this.districtIDDataGridViewTextBoxColumn.DataPropertyName = "DistrictID";
            this.districtIDDataGridViewTextBoxColumn.HeaderText = "DistrictID";
            this.districtIDDataGridViewTextBoxColumn.Name = "districtIDDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // subDistrictBindingSource
            // 
            this.subDistrictBindingSource.DataMember = "SubDistrict";
            this.subDistrictBindingSource.DataSource = this.archiveDataSet3;
            // 
            // archiveDataSet3
            // 
            this.archiveDataSet3.DataSetName = "ArchiveDataSet3";
            this.archiveDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(313, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(298, 22);
            this.textBox2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name";
            // 
            // subDistrictTableAdapter
            // 
            this.subDistrictTableAdapter.ClearBeforeFill = true;
            // 
            // districtTableAdapter
            // 
            this.districtTableAdapter.ClearBeforeFill = true;
            // 
            // tfwd
            // 
            this.tfwd.FormattingEnabled = true;
            this.tfwd.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.tfwd.Location = new System.Drawing.Point(84, 63);
            this.tfwd.Name = "tfwd";
            this.tfwd.Size = new System.Drawing.Size(125, 24);
            this.tfwd.TabIndex = 9;
            // 
            // Districts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 364);
            this.Controls.Add(this.tabControl1);
            this.Name = "Districts";
            this.Text = "Districts";
            this.Load += new System.EventHandler(this.Districts_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.districtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataSet4)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subDistrictBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private ArchiveDataSet3 archiveDataSet3;
        private System.Windows.Forms.BindingSource subDistrictBindingSource;
        private ArchiveDataSet3TableAdapters.SubDistrictTableAdapter subDistrictTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subDistrictIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subDistrictNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private ArchiveDataSet4 archiveDataSet4;
        private System.Windows.Forms.BindingSource districtBindingSource;
        private ArchiveDataSet4TableAdapters.DistrictTableAdapter districtTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox tfwd;
    }
}