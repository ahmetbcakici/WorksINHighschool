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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=OGRENCI21\SQLEXPRESS;Initial Catalog=sirket;Integrated Security=True");
        bool k = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if(bag.State == ConnectionState.Closed) bag.Open();
            SqlCommand kmt = new SqlCommand("select * from guvenlik",bag);
            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                if (oku["kullaniciadi"].ToString() == textBox1.Text && oku["sifre"].ToString() == textBox2.Text)
                    k = true;
            }
            if (k == true)
            {
                MessageBox.Show("Giriş Başarılı");
                k = false;
                Form5 frm5 = new Form5();
                frm5.Show();
                this.Hide();

            }
            else
                MessageBox.Show("Giriş Başarısız");
            bag.Close();
        }
    }
}
