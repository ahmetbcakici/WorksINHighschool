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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
                listBox2.Items.Add(textBox2.Text);
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Lütfen öğrenci bilgilerini girin.");
            }
            else if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Lütfen tüm öğrenci bilgilerini girin.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sil1 = listBox1.SelectedIndex;
            int sil2 = listBox2.SelectedIndex;
            if (sil1 == sil2 && sil1 != -1 && sil2 != -1)
            {
                listBox1.Items.RemoveAt(sil1);
                listBox2.Items.RemoveAt(sil2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                MessageBox.Show("Lütfen sadece Ad ya da Soyad girişi yapınız.");
            }
            else if (textBox1.Text != "")
            {
                int a = listBox1.Items.Count;
                if (listBox1.Items.Contains(textBox1.Text) == true)
                {
                    a = listBox2.SelectedIndex;
                    listBox1.SelectedIndex = listBox1.FindString(textBox1.Text, a);
                    listBox2.SelectedIndex = listBox1.FindString(textBox1.Text, a);
                    textBox2.Text = listBox2.Items[listBox2.SelectedIndex].ToString();
                }
                else
                {
                    MessageBox.Show("Kayıt bulunamadı");
                }
            }
            else if (textBox2.Text != "")
            {
                if (listBox2.Items.Contains(textBox2.Text) == true)
                {
                    listBox1.SelectedIndex = listBox1.FindString(textBox1.Text);
                    listBox2.SelectedIndex = listBox1.FindString(textBox1.Text);
                    textBox1.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
                }
                else
                {
                    MessageBox.Show("Kayıt bulunamadı");
                }
                if (textBox2.Text != "")
                {
                    textBox2.Text = "";
                }
                else if (textBox1.Text != "")
                {
                    textBox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce Ad ya da Soyad girişi yapınız.");
            }
            
        }
    }
}
