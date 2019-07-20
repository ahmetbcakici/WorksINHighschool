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
        int kalansure = 60, dogrusayisi = 0, yanlissayisi = 0;
        void dogruyanliskontrol()
        {
            button2.Enabled = false;
            if (radioButton2.Checked == true)//Soru1 doğrusu            
                dogrusayisi += 1;
            if (radioButton1.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true)
                yanlissayisi += 1;
            if (radioButton7.Checked == true)//Soru2 doğrusu            
                dogrusayisi += 1;
            if (radioButton5.Checked == true || radioButton6.Checked == true || radioButton8.Checked == true)
                yanlissayisi += 1;
            if (radioButton11.Checked == true)//Soru3 doğrusu            
                dogrusayisi += 1;
            if (radioButton10.Checked == true || radioButton9.Checked == true || radioButton12.Checked == true)
                yanlissayisi += 1;
            if (radioButton15.Checked == true)//Soru4 doğrusu
                dogrusayisi += 1;
            if (radioButton13.Checked == true || radioButton14.Checked == true || radioButton16.Checked == true)
                yanlissayisi += 1;
            if (radioButton19.Checked == true) //Soru5 doğrusu            
                dogrusayisi += 1;
            if (radioButton17.Checked == true || radioButton18.Checked == true || radioButton20.Checked == true)
                yanlissayisi += 1;
            if (radioButton21.Checked == true)
                dogrusayisi += 1;
            if (radioButton22.Checked == true || radioButton23.Checked == true || radioButton24.Checked == true)
                yanlissayisi += 1;

            label10.Text = dogrusayisi.ToString();
            label11.Text = yanlissayisi.ToString();
            progressBar2.Value = dogrusayisi;
            if (dogrusayisi <= 2)
            {
                label20.Text = "Kötü";
                label20.ForeColor = Color.Red;
            }
            else if (dogrusayisi > 2 && dogrusayisi <= 4)
            {
                label20.Text = "Orta";
                label20.ForeColor = Color.Yellow;
            }
            else if (dogrusayisi >= 5)
            {
                label20.Text = "İyi";
                label20.ForeColor = Color.Green;
            }
            label20.Visible = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (kalansure == 0)
            {
                timer1.Stop();
                MessageBox.Show("Süreniz doldu!");                
                dogruyanliskontrol();
            }
            else
            {
                kalansure--;
                progressBar1.Value = kalansure;
                label2.Text = kalansure.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            if (textBox1.Text == ""||textBox2.Text == "")
            {
                MessageBox.Show("Alanları doldurunuz!");
                return;
            }
            string tc = textBox1.Text;
            string adsoyad = textBox2.Text;
            label19.Text = tc;            
            label18.Text = adsoyad;
            label19.Visible = true;
            label18.Visible = true;
            timer1.Enabled = true;
            foreach (Control x in this.Controls)
            {
                if (x is GroupBox)                
                    x.Enabled = true;                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dogruyanliskontrol();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
