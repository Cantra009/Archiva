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
    public partial class Districts : Form
    {
        public Districts()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-9DCG462N\SQLEXPRESS;Initial Catalog=Archive;Integrated Security=True");
        private void Districts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'archiveDataSet4.District' table. You can move, or remove it, as needed.
            this.districtTableAdapter.Fill(this.archiveDataSet4.District);
            // TODO: This line of code loads data into the 'archiveDataSet3.SubDistrict' table. You can move, or remove it, as needed.
            this.subDistrictTableAdapter.Fill(this.archiveDataSet3.SubDistrict);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string sql = "insert into subdistrict(subdistrictname,DistrictID, UserID) Values('" + textBox2.Text + "',2,2)";
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("SubDistrict Added..!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string sql = "insert into district(Dname,UserID) Values('" + textBox1.Text + "',2)";
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("District Added..!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
