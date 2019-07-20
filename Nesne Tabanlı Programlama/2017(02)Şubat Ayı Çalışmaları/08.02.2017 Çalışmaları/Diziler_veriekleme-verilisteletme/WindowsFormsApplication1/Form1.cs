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
        string[] dizi = new string[5];
        int syc = 0, kalan = 5;
        private void button1_Click(object sender, EventArgs e)
        {
            dizi[syc] = textBox1.Text;
            syc++;
            kalan--;
            label2.Text = kalan.ToString();                
            if (kalan == 0)
            {
                button2.Enabled = true;
                button1.Enabled = false;
                textBox1.Clear();
                textBox1.Enabled = false;
                label1.Visible = false;
                label2.Visible = false;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var x in dizi)
            {
                listBox1.Items.Add(x);
            }
        }
    }
}
