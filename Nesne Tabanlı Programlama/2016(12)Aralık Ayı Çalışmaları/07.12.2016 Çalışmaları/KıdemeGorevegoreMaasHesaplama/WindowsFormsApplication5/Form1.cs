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

        private void button1_Click(object sender, EventArgs e)
        {
            int gorev = Convert.ToInt32(numericUpDown1.Value);
            Maas ms = new Maas(comboBox1.Text, textBox1.Text, gorev);
            label4.Text = ms.hesapla().ToString();
            this.Width = 226;
            this.Height = 226;

        }
    }
}
