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
        bool k = false;
        SqlConnection bag = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=guvenlik;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand kmt = new SqlCommand("select * from bilgiler",bag);
            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                if (oku["kullaniciadi"].ToString() == textBox1.Text && oku["sifre"].ToString() == textBox2.Text)                
                    k = true;                
            }
            if (k == true)
            {
                MessageBox.Show("Giriş yapıldı");
                Form2 frm2 = new Form2();
                frm2.Show();
            }
            else
            {
                var a = MessageBox.Show("Yanlış Giriş\nKayıt Olmak İster Misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                    tabControl1.SelectedIndex = 2;

            }
            bag.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string degisecekkullaniciadi = textBox3.Text;
            string degiseceksifre = textBox4.Text;

            bag.Open();
            SqlCommand komut = new SqlCommand("update bilgiler set sifre = '" + textBox6.Text + "' where kullaniciadi = '" + degisecekkullaniciadi + "' and sifre = '"+degiseceksifre+"'", bag);
            komut.ExecuteNonQuery();
            MessageBox.Show("Şifre Değiştirildi");
            bag.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand komut = new SqlCommand("Insert into bilgiler values ('"+textBox5.Text+"','"+textBox7.Text+"')",bag);
            komut.ExecuteNonQuery();
            bag.Close();


        }

    }
}
