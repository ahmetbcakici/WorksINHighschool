using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private void orthesaplama(int n1, int n2)
        {
            int sonuc;
            n1 = Convert.ToInt16(textBox1.Text);
            n2 = Convert.ToInt16(textBox2.Text);
            sonuc = ((n1 + n2) / 2);
            if (sonuc >= 50)            
                textBox3.Text = "Geçti";            
            else if (sonuc < 50)            
                textBox3.Text = "Kaldı";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            orthesaplama(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text));
        }
    }
}
