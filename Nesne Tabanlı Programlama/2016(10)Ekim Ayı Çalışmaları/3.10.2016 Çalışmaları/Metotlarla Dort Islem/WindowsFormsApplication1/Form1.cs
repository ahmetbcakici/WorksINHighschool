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
        
        void kontrol()
        {
            foreach (Control i in this.Controls)
            {
                if (i is TextBox)
                {
                    if (i.Text == "")
                    {
                        MessageBox.Show(i.Name+" boş");  
                        
                    }
                }
            }
        }
       

        
        int s1, s2;       
        private void topla(int a, int b)
        {
            kontrol();
            
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            label4.Text = (a + b).ToString();            
        }
        private void cikar(int a, int b)
        {
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            label4.Text = (a - b).ToString();
        }
        private void carp(int a, int b)
        {
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            label4.Text = (a * b).ToString();
        }
        private void bol(int a, int b)
        {
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            label4.Text = (a / b).ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {            
            topla(s1,s2);
        }
        private void button2_Click(object sender, EventArgs e)
        {            
            cikar(s1, s2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            carp(s1, s2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bol(s1, s2);
        }
    }
}
