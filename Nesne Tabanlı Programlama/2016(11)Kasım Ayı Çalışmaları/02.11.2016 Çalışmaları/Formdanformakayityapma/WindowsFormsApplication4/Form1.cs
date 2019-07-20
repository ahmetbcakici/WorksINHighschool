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
        bool k = false;
        void kontrol()
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox || x is ComboBox)
                {
                    if (x.Text == "")
                    {
                        k = true;
                        break;                            
                    }
                    else
                        k = false;
                }
                if (radioButton1.Checked == false && radioButton2.Checked == false)
                    k = true;
                else
                    k = false; 
            }
        }
        void temizle()
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox || x is ComboBox)                
                    x.Text = "";                
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        Form2 frm2 = new Form2();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            var a = comboBox1.SelectedItem;
            if (a == "Bilişim")
            {
                comboBox2.Items.Add("Web");
                comboBox2.Items.Add("Veritabanı");
            }
            if (a == "Muhasebe")
            {
                comboBox2.Items.Add("Pazarlama");
                comboBox2.Items.Add("Ticaret");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            kontrol();
            if (k != true)
            {
                string sinif = "";
                if (radioButton1.Checked == true)                
                    sinif = "1.Sınıf";                
                if (radioButton2.Checked == true)                
                    sinif = "2.Sınıf";                

                frm2.listBox1.Items.Add(textBox1.Text);
                frm2.listBox2.Items.Add(textBox2.Text);
                frm2.listBox3.Items.Add(comboBox1.Text);
                frm2.listBox4.Items.Add(comboBox2.Text);
                frm2.listBox5.Items.Add(sinif);
                temizle();
            }
            else            {
                MessageBox.Show("BOŞ GEÇEMEZSİNİZ!");
                return;
            }        
        }
        private void button2_Click(object sender, EventArgs e)
        {            
            frm2.Show();
            this.Hide();
        }
    }
}
