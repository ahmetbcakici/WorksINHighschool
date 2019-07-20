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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string dosyayolu = "";
        SqlConnection con = new SqlConnection("Data Source=OGRENCI21\\SQLEXPRESS;Initial Catalog=resim;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] resim = File.ReadAllBytes(dosyayolu);
                SqlCommand cmd = new SqlCommand("insert into resim(resim_no,resim_ad,resim)values('" + Convert.ToInt32(textBox1.Text) + "','" + textBox2.Text + "',@image)", con);
                con.Open();
                cmd.Parameters.Add("@image", SqlDbType.Image, resim.Length).Value = resim;
                MessageBox.Show("eklendi");
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "eklenemedi"); }
            finally { con.Close(); }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from resim", con);
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataReader oku = cmd.ExecuteReader();
            DataTable ta = new DataTable();
            ta.Load(oku); dataGridView1.DataSource = ta;
            con.Close();
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
