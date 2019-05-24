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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-9DCG462N\SQLEXPRESS;Initial Catalog=Archive;Integrated Security=True");

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'archiveDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.archiveDataSet1.Users);
            // TODO: This line of code loads data into the 'archiveDataSet.register' table. You can move, or remove it, as needed.
           // this.registerTableAdapter.Fill(this.archiveDataSet.register);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from users where UserName='"+username.Text+"' and password ='"+oldpassword.Text+"'", con);
            DataTable dt  = new DataTable();
            da.Fill(dt);
            errorProvider1.Clear();
            if(dt.Rows[0][0].ToString() =="1")
            {
                if(currentpass.Text==confirmpass.Text)
                {
                    SqlDataAdapter cc = new SqlDataAdapter("update users set password='" + confirmpass.Text + "' where UserName ='" + username.Text + "' and password='"+oldpassword.Text+"'", con);
                    DataTable dtt = new DataTable();
                    cc.Fill(dtt);
                    MessageBox.Show("Password Changed..!", "Message", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    errorProvider1.SetError(currentpass, "password not match");
                    errorProvider1.SetError(confirmpass, "password not match");
                }
            }
            else
            {
                errorProvider1.SetError(username, "Incorrect UserName");
                errorProvider1.SetError(oldpassword, "Incorrect Password");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "insert into users(Name, Address, phone, UserName, Password) values ('"+Fullname.Text+"', '"+email.Text+ "','"+phone.Text+"',  '" + username1.Text + "', '" + pasword.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            sda.SelectCommand.ExecuteNonQuery();
            // TODO: This line of code loads data into the 'archiveDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.archiveDataSet1.Users);
            // TODO: This line of code loads data into the 'archiveDataSet.register' table. You can move, or remove it, as needed.
            // this.registerTableAdapter.Fill(this.archiveDataSet.register);
            con.Close();
            MessageBox.Show("User Named "+username1.Text+" have added to system", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "Delete from users where UserID ='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            int N = cmd.ExecuteNonQuery();
            MessageBox.Show("1 user has been Deleted... !");
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
    try
    {

        textBox1.Text =  dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox12.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox11.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox2.Text =  dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox10.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox9.Text =  dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                textBox1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            string sqlstr = "update users set Name='"+textBox12.Text+ "', Address='" + textBox11.Text + "', Phone='" + textBox2.Text + "', UserName='" + textBox10.Text + "', Password='" + textBox9.Text + "' where UserID ='"+textBox1.Text+"'";
            SqlCommand cmd = new SqlCommand(sqlstr, con);
            int N = cmd.ExecuteNonQuery();
            MessageBox.Show("1 user has been Updated... !");
            con.Close();
        }
    }
}
