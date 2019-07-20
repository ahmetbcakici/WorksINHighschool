using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int girilen = Convert.ToInt16(textBox1.Text);
            int toplam = 0;
            if (girilen == 0 || girilen < 0)
            {
                MessageBox.Show("0 girilemez!");
                return;
            }
            for (int i = 0; i <= girilen; i++) 
            {
                toplam += i;
            }
            label2.Visible = true;
            label2.Text = toplam.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
