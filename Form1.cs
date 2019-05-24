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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-9DCG462N\SQLEXPRESS;Initial Catalog=Archive;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from Users where UserName = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            this.Hide();

            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                main mm = new main();
                mm.Show();
            }
            else
            {
                MessageBox.Show("User or password are incorrect");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
            }else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
