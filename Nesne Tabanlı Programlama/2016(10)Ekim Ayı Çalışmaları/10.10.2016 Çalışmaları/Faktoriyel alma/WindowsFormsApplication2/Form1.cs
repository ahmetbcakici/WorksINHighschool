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
        private void button1_Click(object sender, EventArgs e)
        {            
            int a = Convert.ToInt16(textBox1.Text);
            int faktoriyel = 1;
            if (a == 0 || a < 0)
            {
                MessageBox.Show("0 veya negatif sayı girilemez!");
                return;
            }
            for (int i = 1; i < a; i++)
            {
                faktoriyel *= i;
            }
            label2.Visible = true;
            label2.Text = faktoriyel.ToString();
        }
    }
}