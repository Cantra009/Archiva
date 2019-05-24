using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Archive
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-9DCG462N\SQLEXPRESS;Initial Catalog=Archive;Integrated Security=True");
        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'archiveDataSet6.District' table. You can move, or remove it, as needed.
            this.districtTableAdapter.Fill(this.archiveDataSet6.District);
            // TODO: This line of code loads data into the 'archiveDataSet2.register' table. You can move, or remove it, as needed.
            //this.registerTableAdapter1.Fill(this.archiveDataSet2.register);
            // TODO: This line of code loads data into the 'archiveDataSet.register' table. You can move, or remove it, as needed.
            // this.registerTableAdapter.Fill(this.archiveDataSet.register);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select Fileno,Name, District, Measure, Department from registrationfile where District ='" + comboBox1.Text + "' ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
