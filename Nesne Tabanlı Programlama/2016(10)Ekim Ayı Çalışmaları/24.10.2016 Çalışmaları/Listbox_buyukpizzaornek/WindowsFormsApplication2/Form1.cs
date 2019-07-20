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
        private void button1_Click(object sender, EventArgs e)
        {
            string secilenekstralar = "";
            int pizzaadet = 0, icecekadet = 0, ek = 0, toplam = 0, icecek = 0, pizza = 0, carpim = 0;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Adınızı ve soyadınızı giriniz!");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Telefon numaranızı giriniz!");
                return;
            }
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Adresi giriniz!");
                return;
            }
            if (comboBox1.Text != "Küçük(10TL)" && comboBox1.Text != "Orta(15TL)" && comboBox1.Text != "Büyük(20TL)")
            {
                MessageBox.Show("Pizza Boyu seçimi yapınız!");
                return;
            }
            if (comboBox2.Text != "33ml Kola(3tl)" && comboBox2.Text != "33ml Gazoz(3tl)" && comboBox2.Text != "33ml Ayran(3tl)" && comboBox2.Text != "1lt Kola(5tl)" && comboBox2.Text != "1lt Gazoz(5tl)" && comboBox2.Text != "1lt Ayran(5tl)") 
            {
                MessageBox.Show("İçecek seçimi yapınız!");
                return;
            }
            if (numericUpDown1.Value == 0 || numericUpDown2.Value == 0)
            {
                MessageBox.Show("Adet giriniz!");
                return;
            }

            pizzaadet = Convert.ToInt16(numericUpDown1.Value);
            icecekadet = Convert.ToInt16(numericUpDown2.Value);


            if (comboBox1.Text == "Küçük(10TL)")            
                pizza = 10 * pizzaadet;            
            else if (comboBox1.Text == "Orta(15TL)")
                pizza = pizzaadet * 15;
            else if (comboBox1.Text == "Büyük(20TL)")
                pizza = pizzaadet * 20;          
            var secilen = comboBox2.SelectedIndex;
            if (secilen == 0 || secilen == 1 || secilen == 2)
                icecek = icecekadet * 3;
            else if (secilen == 3 || secilen == 4 || secilen == 5)
                icecek = icecekadet * 5;


            if (radioButton1.Checked == true)//Menü parası  
                carpim = pizzaadet * 5;
            
            //Ekstralar
            if (checkBox1.Checked == true)
            {
                ek += 5;
                secilenekstralar += "Sucuk ";
            }
            if (checkBox2.Checked == true)
            {
                ek += 5;
                secilenekstralar += "Sosis ";
            }
            if (checkBox3.Checked == true)
            {
                ek += 3;
                secilenekstralar += "Mantar ";
            }
            if (checkBox4.Checked == true)
            {
                ek += 3;
                secilenekstralar += "Kaşar ";
            }
            if (checkBox5.Checked == true)
            {
                ek += 3;
                secilenekstralar += "Peynir ";
            }
            if (checkBox6.Checked == true)
            {
                ek += 3;
                secilenekstralar += "Sebze ";
            }

            toplam += (pizza + icecek + ek + carpim);//Ücreti toplama


            //Listboxlara ekleme
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(richTextBox1.Text);
            listBox4.Items.Add("" + comboBox1.Text + " " + pizzaadet.ToString()+"Adet");
            listBox5.Items.Add("" + comboBox2.Text + " " + icecekadet.ToString()+"Adet");
            if (radioButton1.Checked == true)
                listBox6.Items.Add("Var");
            if (radioButton2.Checked == true)
                listBox6.Items.Add("Yok");
            listBox7.Items.Add(secilenekstralar);
            listBox8.Items.Add(toplam.ToString());

        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            richTextBox1.Clear();
            comboBox1.Text = "Seçiniz";
            comboBox2.Text = "Seçiniz";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls) 
            {
                if (x is ListBox)
                {
                    ListBox a = new ListBox();
                    a.Items.Clear();                    
                }
            }
            /*
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();     */       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sil = listBox1.SelectedIndex;
            if (sil != -1) 
            {
                listBox1.Items.RemoveAt(sil);
                listBox2.Items.RemoveAt(sil);
                listBox3.Items.RemoveAt(sil);
                listBox4.Items.RemoveAt(sil);
                listBox5.Items.RemoveAt(sil);
                listBox6.Items.RemoveAt(sil);
                listBox7.Items.RemoveAt(sil);
                listBox8.Items.RemoveAt(sil);
                
            }
        }

    }
}
