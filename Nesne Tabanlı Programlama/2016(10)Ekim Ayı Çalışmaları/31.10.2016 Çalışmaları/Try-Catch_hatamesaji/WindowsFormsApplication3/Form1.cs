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
            try
            {
                int s1 = Convert.ToInt16(textBox1.Text), s2 = Convert.ToInt16(textBox2.Text);
                label4.Text = (s1 + s2).ToString();
                label4.Visible = true; label3.Visible = true;
            }
            catch (FormatException a)//Sayısal veri türüne harf girilmesi
            {
                MessageBox.Show("Alana sayısal değer giriniz!\n" + a.Message);
            }
            catch (OverflowException a)//Overflow = Veri türünün alabileceği sayı aralığını aşması
            {
                MessageBox.Show("Alana aşırı yüksek değer girdiniz!\n" + a.Message);
            }
            

        }
    }
}