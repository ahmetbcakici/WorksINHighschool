using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt16(textBox1.Text), s2 = Convert.ToInt16(textBox2.Text), sonuc = 0;
            var secilen = comboBox1.SelectedItem;
            if (secilen == "+")
                sonuc = s1 + s2;
            else if (secilen == "-")
                sonuc = s1 - s2;
            else if (secilen == "*")
                sonuc = s1 * s2;
            else if (secilen == "/")
                sonuc = s1 / s2;
            else
                MessageBox.Show("Boş bırakmayınız!");
            MessageBox.Show("Sonuç: "+sonuc.ToString());
        }
    }
}
