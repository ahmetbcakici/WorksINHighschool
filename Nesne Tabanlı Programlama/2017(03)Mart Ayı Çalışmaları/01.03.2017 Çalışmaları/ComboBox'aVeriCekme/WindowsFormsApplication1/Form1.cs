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
        SqlConnection bag = new SqlConnection(@"Data Source=OGRENCI21\SQLEXPRESS;Initial Catalog=personel;Integrated Security=True");
        void ulkelericek()
        {
            bag.Open();
            SqlCommand kmt = new SqlCommand("select distinct per_ulke from personel",bag);
            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku["per_ulke"]);
            }
            bag.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           ulkelericek();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secilen = comboBox1.SelectedIndex;
            bag.Open();
            SqlCommand kmt = new SqlCommand("select * from personel where per_ulke = '" + comboBox1.Text + "'", bag);
            SqlDataReader oku = kmt.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(oku);
            dataGridView1.DataSource = dt;
            bag.Close();
            
        }
    }
}
