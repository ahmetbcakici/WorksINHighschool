using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P_boxgirisyapma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int hak = 3;
        private void button1_Click(object sender, EventArgs e)
        {
            if (hak != 0)
            {
                if (textBox1.Text == "admin" && textBox2.Text == "123" && textBox3.Text == label4.Text)
                    MessageBox.Show("Başarılı şekilde giriş yaptınız!");
                else
                {
                    hak--;
                    label5.Text = "Kalan hak " + hak.ToString();
                }
            }
            else
            {
                MessageBox.Show("Hakkınız bitmiştir.Program kapanıyor!");
                Application.Exit();
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.PasswordChar = '\0';
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(rnd.Next(1000, 5001));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(rnd.Next(1000, 5001));
        }
    }
}
