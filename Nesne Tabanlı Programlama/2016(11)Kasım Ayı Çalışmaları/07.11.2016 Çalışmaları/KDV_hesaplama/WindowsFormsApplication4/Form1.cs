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
        int urunfiyati = 0, uruntutari = 0;
        float kdv = 0,toplam = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            urunhesapla();
            kdvhesapla();
        }
        void kdvhesapla()
        {
            kdv = uruntutari * 18 / 100;
            toplam = uruntutari + kdv;
            textBox4.Text = toplam.ToString();
        }
        void urunhesapla()
        {
            uruntutari = (Convert.ToInt32(textBox2.Text)* urunfiyati);
            textBox3.Text = uruntutari.ToString();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secilen = comboBox1.SelectedIndex;
            if (secilen == 0)
            {
                urunfiyati = 1000;
                textBox1.Text = urunfiyati.ToString();
            }
            else if (secilen == 1)
            {
                urunfiyati = 700;
                textBox1.Text = urunfiyati.ToString();
            }
            else if (secilen == 2)
            {
                urunfiyati = 500;
                textBox1.Text = urunfiyati.ToString();
            }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            float gecici = 0;
            int secilenindex = comboBox2.SelectedIndex;
            if (secilenindex == 0)
            {
                float yuzdeal = toplam * 10 / 100;
                toplam -= yuzdeal;
                textBox5.Text = toplam.ToString();
            }
            else if (secilenindex == 1)
            {
                gecici = toplam / 12;
                textBox5.Text = gecici.ToString();
            }
            else if (secilenindex == 2)
            {
                gecici = toplam / 24;
                textBox5.Text = gecici.ToString();
            }
            else if (secilenindex == 3)
            {
                gecici = toplam / 36;
                textBox5.Text = gecici.ToString();
            }
        }
    }
}//Axess(%10 indirimli)
/*Garanti(12 Ay Taksitle)
ING(24 Ay Taksitle)
İş Bankası(36 Ay Taksitle)*/
