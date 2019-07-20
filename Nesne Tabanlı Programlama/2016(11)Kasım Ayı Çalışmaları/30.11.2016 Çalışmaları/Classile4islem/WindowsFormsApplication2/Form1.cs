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
            try
            {
                if (comboBox1.SelectedIndex == 0 )
                {
                    label2.Text = Islem.topla(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    label2.Text = Islem.cikar(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    label2.Text = Islem.carp(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    label2.Text = Islem.bol(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Sayısal değer giriniz!");   
            }
            label4.Text = Islem.sayac.ToString();
            
        }
    }
}
