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
        float toplam;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                if (radioButton1.Checked == true)
                {
                    textBox2.Text = (int.Parse(textBox1.Text) * 15 / 100).ToString();
                }
                else if (radioButton2.Checked == true)
                {
                    textBox2.Text = (int.Parse(textBox1.Text) * 25 / 100).ToString();
                }
                toplam = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                textBox3.Text = toplam.ToString();
            }

            if (radioButton4.Checked == true)
            {
                if (radioButton1.Checked == true)
                {
                    textBox2.Text = (int.Parse(textBox1.Text) * 15 / 100).ToString();
                }
                else if (radioButton2.Checked == true)
                {
                    textBox2.Text = (int.Parse(textBox1.Text) * 25 / 100).ToString();
                }
                toplam = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                textBox3.Text = (toplam - ((toplam * 5) / 100)).ToString();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
