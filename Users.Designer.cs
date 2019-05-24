namespace Archive
{
    partial class Users
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
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.registerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.archiveDataSet = new Archive.ArchiveDataSet();
            this.registerTableAdapter = new Archive.ArchiveDataSetTableAdapters.registerTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.registerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.archiveDataSet2 = new Archive.ArchiveDataSet2();
            this.registerTableAdapter1 = new Archive.ArchiveDataSet2TableAdapters.registerTableAdapter();
            this.archiveDataSet6 = new Archive.ArchiveDataSet6();
            this.districtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.districtTableAdapter = new Archive.ArchiveDataSet6TableAdapters.DistrictTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.districtBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(257, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 24);
            this.label10.TabIndex = 14;
            this.label10.Text = "Data From Districts ";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.registerBindingSource, "District", true));
            this.comboBox1.DataSource = this.districtBindingSource;
            this.comboBox1.DisplayMember = "DName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(668, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "DName";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // registerBindingSource
            // 
            this.registerBindingSource.DataMember = "register";
            this.registerBindingSource.DataSource = this.archiveDataSet;
            // 
            // archiveDataSet
            // 
            this.archiveDataSet.DataSetName = "ArchiveDataSet";
            this.archiveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registerTableAdapter
            // 
            this.registerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(837, 451);
            this.dataGridView1.TabIndex = 16;
            // 
            // registerBindingSource1
            // 
            this.registerBindingSource1.DataMember = "register";
            this.registerBindingSource1.DataSource = this.archiveDataSet2;
            // 
            // archiveDataSet2
            // 
            this.archiveDataSet2.DataSetName = "ArchiveDataSet2";
            this.archiveDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registerTableAdapter1
            // 
            this.registerTableAdapter1.ClearBeforeFill = true;
            // 
            // archiveDataSet6
            // 
            this.archiveDataSet6.DataSetName = "ArchiveDataSet6";
            this.archiveDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // districtBindingSource
            // 
            this.districtBindingSource.DataMember = "District";
            this.districtBindingSource.DataSource = this.archiveDataSet6;
            // 
            // districtTableAdapter
            // 
            this.districtTableAdapter.ClearBeforeFill = true;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(866, 536);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Name = "Users";
            this.Text = "District Data";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.districtBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private ArchiveDataSet archiveDataSet;
        private System.Windows.Forms.BindingSource registerBindingSource;
        private ArchiveDataSetTableAdapters.registerTableAdapter registerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ArchiveDataSet2 archiveDataSet2;
        private System.Windows.Forms.BindingSource registerBindingSource1;
        private ArchiveDataSet2TableAdapters.registerTableAdapter registerTableAdapter1;
        private ArchiveDataSet6 archiveDataSet6;
        private System.Windows.Forms.BindingSource districtBindingSource;
        private ArchiveDataSet6TableAdapters.DistrictTableAdapter districtTableAdapter;
    }
}