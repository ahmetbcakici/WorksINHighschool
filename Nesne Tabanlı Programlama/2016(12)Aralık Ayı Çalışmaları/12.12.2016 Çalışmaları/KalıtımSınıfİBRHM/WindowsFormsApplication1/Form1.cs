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
        private void button1_Click(object sender, EventArgs e)
        {
            Ogretmen ogrt = new Ogretmen();
            ogrt.ad = textBox1.Text;
            ogrt.soyad = textBox2.Text;
            ogrt.cinsiyet = textBox3.Text;
            ogrt.yas = textBox4.Text;
            ogrt.brans = textBox5.Text;
            ogrt.nobetgunu = textBox6.Text;
            ogrt.rehberlik = textBox7.Text;
            ogrt.maas = textBox8.Text;
            label10.Text = ogrt.bilgigoster();
            label11.Text = ogrt.obilgigoster();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MudurYrd mdr = new MudurYrd();
            mdr.ad = textBox1.Text;
            mdr.soyad = textBox2.Text;
            mdr.cinsiyet = textBox3.Text;
            mdr.yas = textBox4.Text;
            mdr.odano = textBox9.Text;
            mdr.nobetgunu = textBox6.Text;
            label10.Text = mdr.bilgigoster();
            label11.Text = mdr.mbilgigoster(); 
            
        }
    }
}
