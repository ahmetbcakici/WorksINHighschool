using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=OGRENCI21\SQLEXPRESS;Initial Catalog=sirket;Integrated Security=True");
        void vericek()
        {
            if (bag.State == ConnectionState.Closed) bag.Open();
            SqlCommand komt = new SqlCommand("select * from musteri", bag);
            SqlDataAdapter da = new SqlDataAdapter(komt);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bag.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (bag.State == ConnectionState.Closed) bag.Open();
            SqlCommand kmt = new SqlCommand("insert into musteri values('" + Convert.ToInt32(textBox1.Text) + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();
            vericek();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            vericek();
        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception)
            {

            }        
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (bag.State == ConnectionState.Closed) bag.Open();
            SqlCommand komut = new SqlCommand("update musteri set musteriad = '" + textBox2.Text + "',musterisoyad = '" + textBox3.Text + "',mustericinsiyet = '" + textBox4.Text + "',musteritcno = '" + textBox5.Text + "'where musterino = "+textBox1.Text+"", bag);
            komut.ExecuteNonQuery();
            bag.Close();
            vericek();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bag.State == ConnectionState.Closed) bag.Open();
            SqlCommand komut = new SqlCommand("delete from musteri where musterino = "+textBox1.Text+"",bag);
            komut.ExecuteNonQuery();
            bag.Close();
            vericek();
        }
    }
}