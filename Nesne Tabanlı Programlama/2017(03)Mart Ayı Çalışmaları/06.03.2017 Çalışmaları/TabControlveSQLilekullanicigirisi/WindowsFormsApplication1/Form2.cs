using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=guvenlik;Integrated Security=True");
        string dosyayolu = "";
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] resim = File.ReadAllBytes(dosyayolu);
                SqlCommand kmt = new SqlCommand("insert into resim(resimno,resimad,resim)values('" + Convert.ToInt32(textBox1.Text) + "','" + textBox2.Text + "',@image)", bag);
                bag.Open();
                kmt.Parameters.Add("@image", SqlDbType.Image, resim.Length).Value = resim;
                MessageBox.Show("eklendi");
                kmt.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "eklenemedi"); }
            finally { bag.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("Select * from resim", bag);
            bag.Open();
            SqlDataReader oku = kmt.ExecuteReader();
            DataTable ta = new DataTable();
            ta.Load(oku); dataGridView1.DataSource = ta;
            bag.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = "C:\\Users\\Public\\Pictures\\Sample Pictures";
            file.Filter = "resim dosyası |*.jpg";
            file.Title = "resim dosyası seçiniz";
            if (file.ShowDialog() == DialogResult.OK)
            {
                dosyayolu = file.FileName;
            }
            pictureBox1.ImageLocation = dosyayolu;
            FileStream fs = new FileStream(dosyayolu, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            fs.Close();
            br.Close();
        }
    }
}
