using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _775AhmetCakici_Sinav2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Matematik mt = new Matematik();
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Matematik.rastgelesayi1());
            textBox2.Text = Convert.ToString(Matematik.rastgelesayi2());
            textBox3.Text = Convert.ToString(Matematik.rastgelesayi3());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int ortalama;
            Matematik mt2 = new Matematik(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text), Convert.ToInt16(textBox3.Text));            
            ortalama = mt2.ortalama(Convert.ToInt16(textBox1.Text),Convert.ToInt16(textBox2.Text),Convert.ToInt16(textBox3.Text));
            mt2.enbuyuk();
            mt2.enkucuk();
            if (textBox6.Text == ortalama.ToString())
            {
                label7.ForeColor = Color.Green;
                label7.Visible = true;
                label7.Text = "Doğru";
            }
            else
            {
                label7.ForeColor = Color.Red;
                label7.Visible = true;
                label7.Text = "Yanlış";
            }

            if (textBox5.Text == mt2.enbuyuk().ToString())
            {
                label8.ForeColor = Color.Green;
                label8.Visible = true;
                label8.Text = "Doğru";
            }
            else
            {
                label8.ForeColor = Color.Red;
                label8.Visible = true;
                label8.Text = "Yanlış";
            }

            if (textBox4.Text == mt2.enkucuk().ToString())
            {
                label9.ForeColor = Color.Green;
                label9.Visible = true;
                label9.Text = "Doğru";
            }
            else
            {
                label9.ForeColor = Color.Red;
                label9.Visible = true;
                label9.Text = "Yanlış";
            }

               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Matematik.rastgelesayi1());
            textBox2.Text = Convert.ToString(Matematik.rastgelesayi2());
            textBox3.Text = Convert.ToString(Matematik.rastgelesayi3());
        }
    }
}
