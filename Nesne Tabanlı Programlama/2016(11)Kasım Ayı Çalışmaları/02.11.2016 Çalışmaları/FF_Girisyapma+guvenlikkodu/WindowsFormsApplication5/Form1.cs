using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int rastgele = 0;
        private void button1_Click(object sender, EventArgs e)
        { 
            rastgele = rnd.Next(1000, 5001);
            label4.Text = rastgele.ToString();
            Form2 frm2 = new Form2();
            string id = "ahmet", sifre = "12345";
           
            if (id == textBox1.Text && sifre == textBox2.Text && rastgele.ToString() == textBox3.Text)
            {
                frm2.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Başarısız");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Visible = true;
            rastgele = rnd.Next(1000, 5001);
            label4.Text = rastgele.ToString();
        }
    }
}
