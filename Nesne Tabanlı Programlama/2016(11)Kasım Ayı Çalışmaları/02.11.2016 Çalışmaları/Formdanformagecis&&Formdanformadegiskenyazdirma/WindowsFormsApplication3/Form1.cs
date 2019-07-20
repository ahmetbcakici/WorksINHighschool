using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string metin = "abc";
        private void button1_Click(object sender, EventArgs e)
        {
          //  metin = textBox1.Text;
            Form2 f2 = new Form2();
            f2.label2.Text = textBox2.Text;
            f2.Show();
            this.Hide();
        }
    }
}
