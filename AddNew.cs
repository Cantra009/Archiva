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
    public partial class AddNew : Form
    {
        public AddNew()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-9DCG462N\SQLEXPRESS;Initial Catalog=Archive;Integrated Security=True");
        private readonly object date2;

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT INTO [Archive].[dbo].[AddForm]([fileno],[date1],[districtref],[date2],[formno],[planingref],[date3],[cno],[Name] ,[District],[Village],[Department],[Measurement],[north],[south],[west],[East],[Date4],[grno],[Amount]) Values('" + Filenotxt.Text+ "','" + date1.Text + "','" + tfwd.Text + "','" + dateTimePicker2.Text + "','" + FormNo.Text + "','" + numericUpDown2.Text + "','" + Date3.Text + "','" + numericUpDown1.Text + "','" + Magaca.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + dateTimePicker1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" Data has been Saved");
            //clean
            Filenotxt.Text = "";
            date1.Text = "";
            tfwd.Text = "";
            //date2.Text = "" ;
            FormNo.Text = "";
            numericUpDown2.Text = "";
            Date3.Text = "";
            numericUpDown1.Text = "";
            Magaca.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            dateTimePicker1.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
           


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNew_Load(object sender, EventArgs e)
        {

        }

        private void Filenotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void FormNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
