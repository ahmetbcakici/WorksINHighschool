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
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            var secim = listBox1.Items[listBox1.SelectedIndex];
            if (secim == "int")
            {
                textBox1.Text = Convert.ToString(int.MinValue);
                textBox2.Text = Convert.ToString(int.MaxValue);
            }
            if (secim == "long")
            {
                textBox1.Text = Convert.ToString(long.MinValue);
                textBox2.Text = Convert.ToString(long.MaxValue);                
            }
            if (secim == "double")
            {
                textBox1.Text = Convert.ToString(double.MinValue);
                textBox2.Text = Convert.ToString(double.MaxValue);
            }
            if (secim == "float")
            {
                textBox1.Text = Convert.ToString(float.MinValue);
                textBox2.Text = Convert.ToString(float.MaxValue);
            }
            if (secim == "decimal")
            {
                textBox1.Text = Convert.ToString(decimal.MinValue);
                textBox2.Text = Convert.ToString(decimal.MaxValue);
            }
        }
    }
}
