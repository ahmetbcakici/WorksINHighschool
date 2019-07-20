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
            int maas = Convert.ToInt16(textBox4.Text);
            if (radioButton1.Checked == true)
            {
                maas -= 50;
                textBox1.Text = "-50";
            }
            else
                textBox1.Text = "0";            
            if (radioButton4.Checked == true)
            {
                maas += 200;
                textBox2.Text = "+200";
            }
            else if (radioButton5.Checked == true)
            {
                maas += 100;
                textBox2.Text = "+100";
            }
            if (radioButton3.Checked == true)
                textBox2.Text = "0";         
            textBox3.Text = maas.ToString();            
        }            
    }
}

