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
using System.IO;
namespace Archive
{
    public partial class ScanFiles : Form
    {
        public ScanFiles()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-9DCG462N\SQLEXPRESS;Initial Catalog=Archive;Integrated Security=True");
        string imglocation = "";
        string imglocation1 = "";
        string imglocation3 = "";
        string imglocation4 = "";
        string imglocation6 = "";
        string imglocation5 = "";
        string imglocation2 = "";
        SqlCommand cmd;
        string id;








        SqlDataAdapter da = new SqlDataAdapter();
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void ScanFiles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'archiveDataSet5.District' table. You can move, or remove it, as needed.
            this.districtTableAdapter.Fill(this.archiveDataSet5.District);
            
        }

        private void file1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if(dialog.ShowDialog()==DialogResult.OK)
                    {
                imglocation = dialog.FileName.ToString();
                pictureBox6.ImageLocation = imglocation;
                    }
        }

        private void file2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation3 = dialog.FileName.ToString();
                pictureBox9.ImageLocation = imglocation3;
            }
        }

        private void file3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation4 = dialog.FileName.ToString();
                pictureBox8.ImageLocation = imglocation4;
            }
        }

        private void file4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation5 = dialog.FileName.ToString();
                pictureBox7.ImageLocation = imglocation5;
            }
        }

        private void file5_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation2 = dialog.FileName.ToString();
                pictureBox10.ImageLocation = imglocation2;
            }
        }

        private void file6_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation1 = dialog.FileName.ToString();
                pictureBox11.ImageLocation = imglocation1;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                byte[] images = null;
                FileStream streem = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(streem);
                images = brs.ReadBytes((int)streem.Length);


                byte[] images1 = null;
                FileStream streem1 = new FileStream(imglocation1, FileMode.Open, FileAccess.Read);
                BinaryReader brs1 = new BinaryReader(streem1);
                images1 = brs1.ReadBytes((int)streem1.Length);

                byte[] images2 = null;
                FileStream streem2 = new FileStream(imglocation2, FileMode.Open, FileAccess.Read);
                BinaryReader brs2 = new BinaryReader(streem2);
                images2 = brs2.ReadBytes((int)streem2.Length);

                byte[] images3 = null;
                FileStream streem3 = new FileStream(imglocation3, FileMode.Open, FileAccess.Read);
                BinaryReader brs3 = new BinaryReader(streem3);
                images3 = brs3.ReadBytes((int)streem3.Length);

                byte[] images4 = null;
                FileStream streem4 = new FileStream(imglocation4, FileMode.Open, FileAccess.Read);
                BinaryReader brs4 = new BinaryReader(streem4);
                images4 = brs4.ReadBytes((int)streem4.Length);

                byte[] images5 = null;
                FileStream streem5 = new FileStream(imglocation5, FileMode.Open, FileAccess.Read);
                BinaryReader brs5 = new BinaryReader(streem5);
                images5 = brs5.ReadBytes((int)streem5.Length);
                

                string sqlquery;
                sqlquery = "insert into registrationfile(FileNo, Name, district, measure, department, file1,file2,file3,file4,file5,file6,DistrictID, UserID) values ('" + Filenotxt.Text + "', '" + Magaca.Text + "', '" + degmada.Text + "', '" + cabirka.Text + "','" + qaybta.Text + "',@images,@images1,@images2,@images3,@images4,@images5,'"+id+"',2)";
                //sqlquery = "insert into registrationfile(file1) values(@images1)";
                cmd = new SqlCommand(sqlquery, con);
                cmd.Parameters.Add(new SqlParameter("@images", images));
                cmd.Parameters.Add(new SqlParameter("@images1", images1));
                cmd.Parameters.Add(new SqlParameter("@images2", images2));
                cmd.Parameters.Add(new SqlParameter("@images3", images3));
                cmd.Parameters.Add(new SqlParameter("@images4", images4));
                cmd.Parameters.Add(new SqlParameter("@images5", images5));
                int N = cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been Saved");
                Filenotxt.Text = "";
                Magaca.Text = "";
                cabirka.Text = "";
                degmada.Text = "";
                qaybta.Text = "";
                pictureBox11.Image = null;
                pictureBox6.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
             
            try
            {
                con.Open();
                string sql = "select FileNo,Name,District,Measure,Department, file1, file2, file3, file4, file5, file6 from registrationFile where FileNo ='" + textBox5.Text + "'";
                cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if(reader.HasRows)
                {
                    textBox6.Text = reader[1].ToString();
                    textBox3.Text = reader[2].ToString();
                    textBox1.Text = reader[3].ToString();
                    textBox2.Text = reader[4].ToString();
                    byte[] img = (byte[])(reader[5]);
                    if (img == null)
                        pictureBox1.Image = null;
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox1.Image = Image.FromStream(ms);
                    }


                    byte[] img1 = (byte[])(reader[6]);
                    if (img == null)
                        pictureBox2.Image = null;
                    else
                    {
                        MemoryStream ms1 = new MemoryStream(img1);
                        pictureBox2.Image = Image.FromStream(ms1);
                    }



                    byte[] img2 = (byte[])(reader[7]);
                    if (img == null)
                        pictureBox2.Image = null;
                    else
                    {
                        MemoryStream ms2 = new MemoryStream(img2);
                        pictureBox12.Image = Image.FromStream(ms2);
                    }


                    byte[] img3 = (byte[])(reader[8]);
                    if (img == null)
                        pictureBox2.Image = null;
                    else
                    {
                        MemoryStream ms3 = new MemoryStream(img3);
                        pictureBox5.Image = Image.FromStream(ms3);
                    }


                    byte[] img4 = (byte[])(reader[9]);
                    if (img == null)
                        pictureBox2.Image = null;
                    else
                    {
                        MemoryStream ms4 = new MemoryStream(img4);
                        pictureBox4.Image = Image.FromStream(ms4);
                    }


                    byte[] img5 = (byte[])(reader[9]);
                    if (img == null)
                        pictureBox2.Image = null;
                    else
                    {
                        MemoryStream ms5 = new MemoryStream(img5);
                        pictureBox3.Image = Image.FromStream(ms5);
                    }


              




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
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //update Code
            try
            {
                byte[] images = null;
                FileStream streem = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(streem);
                images = brs.ReadBytes((int)streem.Length);


                byte[] images1 = null;
                FileStream streem1 = new FileStream(imglocation1, FileMode.Open, FileAccess.Read);
                BinaryReader brs1 = new BinaryReader(streem1);
                images1 = brs1.ReadBytes((int)streem1.Length);

                byte[] images2 = null;
                FileStream streem2 = new FileStream(imglocation2, FileMode.Open, FileAccess.Read);
                BinaryReader brs2 = new BinaryReader(streem2);
                images2 = brs2.ReadBytes((int)streem2.Length);

                byte[] images3 = null;
                FileStream streem3 = new FileStream(imglocation3, FileMode.Open, FileAccess.Read);
                BinaryReader brs3 = new BinaryReader(streem3);
                images3 = brs3.ReadBytes((int)streem3.Length);

                byte[] images4 = null;
                FileStream streem4 = new FileStream(imglocation4, FileMode.Open, FileAccess.Read);
                BinaryReader brs4 = new BinaryReader(streem4);
                images4 = brs4.ReadBytes((int)streem4.Length);

                byte[] images5 = null;
                FileStream streem5 = new FileStream(imglocation5, FileMode.Open, FileAccess.Read);
                BinaryReader brs5 = new BinaryReader(streem5);
                images5 = brs5.ReadBytes((int)streem5.Length);
                con.Open();
                string sqlquery;
                sqlquery = "update registrationfile set Name='"+textBox6.Text+"', district='"+textBox3.Text+"', measure='"+textBox1.Text+"', department='"+textBox2.Text+"', file1=@images,file2=@images1,file3=@images2,file4=@images3,file5=@images4,file6=@images5 where FileNo ='"+textBox5.Text+"'"; 
                //sqlquery = "insert into registrationfile(file1) values(@images1)";
                cmd = new SqlCommand(sqlquery, con);
                cmd.Parameters.Add(new SqlParameter("@images", images));
                cmd.Parameters.Add(new SqlParameter("@images1", images1));
                cmd.Parameters.Add(new SqlParameter("@images2", images2));
                cmd.Parameters.Add(new SqlParameter("@images3", images3));
                cmd.Parameters.Add(new SqlParameter("@images4", images4));
                cmd.Parameters.Add(new SqlParameter("@images5", images5));
                int N = cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been Updated");
                textBox6.Text = "";
                textBox3.Text = "";
                textBox2.Text = "";
                textBox1.Text = "";
                textBox5.Text = "";
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                pictureBox12.Image = null;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imglocation;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation3 = dialog.FileName.ToString();
                pictureBox2.ImageLocation = imglocation3;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation4 = dialog.FileName.ToString();
                pictureBox12.ImageLocation = imglocation4;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation5 = dialog.FileName.ToString();
                pictureBox5.ImageLocation = imglocation5;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation2 = dialog.FileName.ToString();
                pictureBox4.ImageLocation = imglocation2;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation1 = dialog.FileName.ToString();
                pictureBox3.ImageLocation = imglocation1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void degmada_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void qaybta_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed) { 
                con.Open();
                }
                string sel = "select Dname, DistrictID from District where Dname ='" + degmada.Text + "'";
                cmd = new SqlCommand(sel, con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    id = reader[1].ToString();

                }
                //else
                //{
                //    MessageBox.Show("This Distict Does not Exist..!");
                //}
                con.Close();







            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

