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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)            
                textBox1.Text = "1000";            
            else if (comboBox1.SelectedIndex == 1)            
                textBox1.Text = "700";            
            else if (comboBox1.SelectedIndex == 2)            
                textBox1.Text = "500";            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Ürün adeti seçiniz!");
                return;
            }
            Odeme od = new Odeme(Convert.ToInt32(textBox1.Text), Convert.ToInt32(numericUpDown1.Value));
            textBox2.Text = od.uruntutari().ToString();
            textBox3.Text = Convert.ToString(Odeme.kdv(Convert.ToInt32(textBox2.Text)));

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.Text = Odeme.odemesekli(Convert.ToInt32(textBox3.Text),comboBox2.SelectedIndex).ToString();
        }
    }
}
