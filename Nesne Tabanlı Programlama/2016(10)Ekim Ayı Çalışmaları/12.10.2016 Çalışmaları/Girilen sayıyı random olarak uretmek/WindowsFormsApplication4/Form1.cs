using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int girilen = Convert.ToInt16(textBox1.Text);
            if (girilen < 0 || girilen > 25)
            {
                MessageBox.Show("En düşük 0 en fazla 25 girebilirsiniz!");
                return;
            }
            listBox1.Items.Clear();
            int a = 0;            
            Random rnd = new Random();
            int rastgele;
            while (true)
            {
                rastgele = rnd.Next(0, 26);
                a++;
                listBox1.Items.Add(rastgele);
                if (rastgele == girilen)
                {
                    label1.Text = a.ToString() + ". rastgele üretilen sayıda bulundu";
                    break;
                }
            }
        }
    }
}
