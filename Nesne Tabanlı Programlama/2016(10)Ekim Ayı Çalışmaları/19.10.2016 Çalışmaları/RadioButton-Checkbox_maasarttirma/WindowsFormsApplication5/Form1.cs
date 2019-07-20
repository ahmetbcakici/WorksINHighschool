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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            int maas = Convert.ToInt16(textBox1.Text);
            if (checkBox1.Checked == true)            
                maas += 50;            
            if (checkBox2.Checked == true)            
                maas += 50;            
            if (checkBox3.Checked == true)            
                maas += 50;            
            if (checkBox4.Checked== true)  
                maas += 50;
            if (radioButton1.Checked == true)
                maas += 100;
            else if (radioButton2.Checked == true)
                maas += 200;
            else if (radioButton3.Checked == true)
                maas += 300;
            else if (radioButton4.Checked == true)
                maas += 400;
            if (radioButton7.Checked == true)            
                maas += 100;            
            else if (radioButton6.Checked == true)            
                maas += 200;            
            else if (radioButton5.Checked == true)            
                maas += 300;            
            else if (radioButton9.Checked == true)            
                maas += 500; 
            textBox2.Text = maas.ToString();
        }
    }
}