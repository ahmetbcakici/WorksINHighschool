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
        int dogrusayisi = 0, yanlissayisi = 0, saniye = 0, hak = 3;
        void butongizle()
        {
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Name != "button2" && x.Name != "button1" && x.Name != "button12" && x.Name != "button11" && x.Name != "button13")
                    x.Text = "";               
            }
        }
        void textboxgoster()
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                    x.Visible = true;
            }
        }
        void labelgoster()
        {
            foreach (Control x in this.Controls)
            {
                if (x is Label)
                    x.Visible=true;
            }
        }	
        private void button1_Click(object sender, EventArgs e)
        {
            butongizle();
            textboxgoster();
            button11.Visible = true;
            button1.Visible = false;
            button13.Enabled = true;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "CSharp") dogrusayisi++;
            else yanlissayisi++;
            if (textBox2.Text == "Yandex") dogrusayisi++;
            else yanlissayisi++;
            if (textBox3.Text == "Bilgisayar") dogrusayisi++;
            else yanlissayisi++;
            if (textBox4.Text == "Mouse") dogrusayisi++;
            else yanlissayisi++;
            if (textBox5.Text == "RAM") dogrusayisi++;
            else yanlissayisi++;
            if (textBox6.Text == "HDMI") dogrusayisi++;
            else yanlissayisi++;
            if (textBox7.Text == "Monitör") dogrusayisi++;
            else yanlissayisi++;
            if (textBox8.Text == "Anakart") dogrusayisi++;
            else yanlissayisi++;
            label2.Text = dogrusayisi.ToString();
            label3.Text = yanlissayisi.ToString();
            labelgoster();
            button12.Visible = true;
            button2.Visible = true;
            button11.Visible = false;
            button13.Visible = false;
            label5.Visible = false; label6.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            timer1.Start();
            hak--;
            label5.Visible = true;
            label6.Visible = true;
            if (hak > 0) label6.Text = hak.ToString();
            else
            {
                label5.Text = "Hakkınız bitti";
                label6.Visible = false;
            }            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            if (hak != 0)
            {
                if (saniye < 3)
                {
                    button3.Text = "CSharp";
                    button4.Text = "Yandex";
                    button5.Text = "Bilgisayar";
                    button7.Text = "Mouse";
                    button10.Text = "RAM";
                    button9.Text = "HDMI";
                    button8.Text = "Monitör";
                    button6.Text = "Anakart";
                }
                else
                {
                    saniye = 0;
                    timer1.Stop();
                    butongizle();
                }
            }
            else
            {
                timer1.Stop();
                button13.Enabled = false;
            }
        }
    }
}
