using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int abc = 0;
        public static int EnKucukBul(params TextBox[] sayilar)
        {
            int a = Convert.ToInt32(sayilar[0].Text);
            foreach (var x in sayilar)
            {
                if (Convert.ToInt32(x.Text) < a)
                    a = Convert.ToInt32(x.Text);
            }
            return a;
        }
        public static int EnBuyukBul(params TextBox[] sayilar)
        {
            int a = Convert.ToInt32(sayilar[0].Text);
            foreach (var x in sayilar)
            {
                if (Convert.ToInt32(x.Text) > a)
                    a = Convert.ToInt32(x.Text);
            }
            return a;
        }
        public static int ToplamiBul(params TextBox[] sayilar)
        {
            int a = 0;
            foreach (var x in sayilar)
            {
                a += Convert.ToInt32(x.Text);
            }
            return a;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(EnKucukBul(textBox1, textBox2, textBox3, textBox4, textBox5, textBox6));
            

        }
        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
