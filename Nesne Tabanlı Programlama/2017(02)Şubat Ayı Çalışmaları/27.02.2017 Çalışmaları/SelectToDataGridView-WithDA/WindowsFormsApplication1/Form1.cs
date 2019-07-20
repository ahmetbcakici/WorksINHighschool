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
        private void button1_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand kmt = new SqlCommand("SELECT * FROM Kategori",bag);
            SqlDataAdapter da = new SqlDataAdapter(kmt);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;           
            bag.Close();
        }
    }
}
