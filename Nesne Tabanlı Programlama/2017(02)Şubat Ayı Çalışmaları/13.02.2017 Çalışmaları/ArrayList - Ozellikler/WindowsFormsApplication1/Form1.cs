using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void listele()
        {
            listBox1.Items.Clear();
            foreach (var x in dizi)
            {
                listBox1.Items.Add(x);
            }
        }
        ArrayList dizi = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            dizi.Add(textBox1.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                if (dizi.Contains(textBox2.Text) == true)
                    MessageBox.Show("Veri bulundu");
                else 
                    MessageBox.Show("Test");
            }
            else
                MessageBox.Show("Lütfen aranacak veriyi giriniz!");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listele();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = dizi.Count.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            dizi.Sort();
            listele();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            dizi.Reverse();
            listele();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            dizi.Clear();
            listele();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            dizi.Insert(Convert.ToInt32(numericUpDown1.Value), textBox3.Text);
            listele();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = (Convert.ToInt32(dizi.BinarySearch(textBox2.Text)).ToString());            
        }
    }
}
