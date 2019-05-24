using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archive
{
    public partial class ViewAddFile : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-9DCG462N\SQLEXPRESS;Initial Catalog=Archive;Integrated Security=True");
        public ViewAddFile()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "SELECT  [date1],[districtref],[date2],[formno],[planingref],[date3],[cno],[Name],[District],[Village],[Department] ,[Measurement],[north],[south],[west],[East],[Date4],[grno],[Amount] FROM[Archive].[dbo].[AddForm]  WHERE fileno ='" + Filenotxt.Text+"' ";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {

                    date1.Text= reader["date1"].ToString();
                    tfwd.Text= reader["districtref"].ToString();
                    
                    dateTimePicker2.Text= reader["date2"].ToString();
                    FormNo.Text = reader["formno"].ToString();
                    numericUpDown2.Text = reader["planingref"].ToString();
                    Date3.Text= reader["date3"].ToString();
                    numericUpDown1.Text = reader["cno"].ToString() ;
                    Magaca.Text = reader["Name"].ToString();
                    textBox1.Text= reader["District"].ToString();
                    textBox2.Text= reader["Village"].ToString();
                    textBox3.Text= reader["Department"].ToString(); 
                    textBox4.Text= reader["Measurement"].ToString();
                    comboBox1.Text= reader["north"].ToString();
                    comboBox2.Text= reader["south"].ToString();
                    comboBox3.Text= reader["west"].ToString();
                    comboBox4.Text= reader["East"].ToString();
                    dateTimePicker1.Text= reader["Date4"].ToString();
                    textBox5.Text= reader["grno"].ToString();
                    textBox6.Text= reader["Amount"].ToString();



                }
                else
                {
                    MessageBox.Show("this fileno does not exist.");
                }
                con.Close();
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sqlquery;
                sqlquery = "UPDATE [Archive].[dbo].[AddForm]SET [date1] ='"+date1.Text+ "' ,[districtref] ='"+tfwd.Text+ "' ,[date2] ='"+dateTimePicker2.Text+ "' ,[formno] ='"+FormNo.Text+ "' ,[planingref] ='"+numericUpDown2.Text+ "' ,[date3] ='"+Date3.Text+ "',[cno] ='"+numericUpDown1.Text+ "' ,[Name] ='"+Magaca.Text+ "',[District] ='"+textBox1.Text+ "',[Village] ='"+textBox2.Text+ "' ,[Department] ='"+textBox3.Text+ "',[Measurement] ='"+textBox4.Text+ "',[north] ='"+comboBox1.Text+ "'  ,[south] ='"+comboBox2.Text+ "',[west] ='"+comboBox3.Text+ "' ,[East] ='"+comboBox4.Text+ "' ,[Date4]='"+dateTimePicker1.Text+ "' ,[grno] ='"+textBox5.Text+ "',[Amount] ='"+textBox6.Text+"' WHERE fileno='" + Filenotxt.Text+"'";
                //sqlquery = "insert into registrationfile(file1) values(@images1)";
                SqlCommand cmd = new SqlCommand(sqlquery, con);

                int N = cmd.ExecuteNonQuery();
                if (N ==1) { 
                MessageBox.Show("Data has been Updated");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "Delete from users where UserID ='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            int N = cmd.ExecuteNonQuery();
            MessageBox.Show("1 user has been Deleted... !");
            con.Close();
        }
    }
}
