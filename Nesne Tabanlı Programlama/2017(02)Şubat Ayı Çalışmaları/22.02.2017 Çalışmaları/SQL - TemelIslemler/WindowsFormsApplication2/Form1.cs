using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Personel;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();   
            SqlCommand kmt = new SqlCommand("INSERT INTO PersonelBilgi values (4,'Rıdvan Aracı')",baglanti);
            kmt.ExecuteNonQuery();
            baglanti.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("UPDATE PersonelBilgi set adsoyad = 'NULL' where id = 2",baglanti);
            kmt.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("DELETE PersonelBilgi where id = 4", baglanti);
            kmt.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
