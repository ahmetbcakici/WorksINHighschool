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
            int toplam = 0,i = 0;
            int baslangic = Convert.ToInt32(textBox1.Text);
            int bitis = Convert.ToInt32(textBox2.Text);
            int sonaerecegisayi = Convert.ToInt32(textBox3.Text);
            for (i = baslangic; i < bitis; i++)
            {
                listBox1.Items.Add(i);
                toplam += i;
                if (toplam > sonaerecegisayi)break;
                if ((toplam % 10) == 0) continue;
                listBox2.Items.Add(toplam);               
                    
            }
            label5.Text = i.ToString();
            label4.Visible = true; label5.Visible = true;
        }
    }
}
