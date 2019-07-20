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
        float fiyat = 0, toplam = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Ürün seçiniz!");
                return;
            }
            string secilenurun = comboBox1.Text;
            listBox1.Items.Add(secilenurun);
            listBox2.Items.Add(fiyat.ToString());
        }
        private void button2_Click(object sender, EventArgs e)
        {
                float yuzdeuc = 0, yuzdebes = 0, toplam2 = 0;
            if (radioButton1.Checked == true)
            {
                yuzdeuc = toplam * 3 / 100;
                toplam2 = toplam - yuzdeuc;
            }
            if (radioButton2.Checked == true)
            {
                yuzdebes = toplam * 5 / 100;
                toplam2 = toplam - yuzdebes;
            }
            if (radioButton3.Checked == true)
            {
                toplam2 = toplam;
            }
            label6.Text = toplam2.ToString();
            label6.Visible = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var a = listBox1.SelectedIndex;
            if (a != -1)
            {
                listBox1.Items.RemoveAt(a);
                listBox2.Items.RemoveAt(a);
            }
            else
            {
                MessageBox.Show("Silinecek ürün seçmelisiniz!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.Text = "";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            label6.Visible = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = comboBox1.SelectedItem;
            if (a == "Gazoz(3TL)")
            {
                fiyat = 3;
                textBox1.Text = fiyat.ToString();
            }
            if (a == "Kola(3TL)")
            {
                fiyat = 3;
                textBox1.Text = fiyat.ToString();
            }
            if (a == "Makarna(5TL)")
            {
                fiyat = 5;
                textBox1.Text = fiyat.ToString();
            }
            if (a == "Et Dürüm(10TL)")
            {
                fiyat = 10;
                textBox1.Text = fiyat.ToString();
            }
            if (a == "Tavuk Dürüm(7TL)")
            {
                fiyat = 7;
                textBox1.Text = fiyat.ToString();
            }
            toplam += fiyat;
        }
    }
}
