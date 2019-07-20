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
        SqlConnection bag = new SqlConnection(@"Data Source=OGRENCI21\SQLEXPRESS;Initial Catalog=test;Integrated Security=True");
        void vericek()
        {
            bag.Open();
            SqlCommand kmt = new SqlCommand("SELECT * FROM Kategori", bag);
            SqlDataAdapter da = new SqlDataAdapter(kmt);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bag.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            vericek();
        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand kmt = new SqlCommand("Delete from Kategori where KategoriID = '"+textBox1.Text+"'",bag);
            kmt.ExecuteNonQuery();
            bag.Close();
            vericek();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand kmt = new SqlCommand("Insert into Kategori values ('"+textBox1.Text+"','"+textBox2.Text+"')",bag);
            kmt.ExecuteNonQuery();
            bag.Close();
            vericek();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand kmt = new SqlCommand("Update Kategori set KategoriID = '"+textBox1.Text+"',ad = '"+textBox2.Text+"'where KategoriID ="+textBox1.Text+"",bag);
            kmt.ExecuteNonQuery();
            bag.Close();
            vericek();
        }      private void button5_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand kmt = new SqlCommand("SELECT * FROM Kategori where KategoriID = '"+textBox1.Text+"'", bag);
            SqlDataAdapter da = new SqlDataAdapter(kmt);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bag.Close();
        }
    }
}
