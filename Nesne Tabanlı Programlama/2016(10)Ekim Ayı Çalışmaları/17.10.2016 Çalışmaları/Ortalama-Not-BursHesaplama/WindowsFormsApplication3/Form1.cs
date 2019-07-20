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

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true && radioButton3.Checked == true)            
                MessageBox.Show("Welcome "+textBox1.Text+" Mr");            
            if (radioButton1.Checked == true && radioButton4.Checked == true)             
                MessageBox.Show("Hoşgeldiniz "+textBox1.Text+" Beyefendi");            
            if (radioButton2.Checked == true && radioButton3.Checked == true)             
                MessageBox.Show("Welcome "+textBox1.Text+" Mrs");            
            if (radioButton2.Checked == true && radioButton4.Checked == true)             
                MessageBox.Show("Hoşgeldiniz "+textBox1.Text+" Hanımefendi");            
        }
    }
}
