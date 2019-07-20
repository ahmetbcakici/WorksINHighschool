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
        public DateTime trh1, trh2;
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime zaman = dateTimePicker1.Value;
            if (label1.Text == "Tarih 1")
                trh1 = Convert.ToDateTime(label1.Text = zaman.ToString());
            else
                trh2 = Convert.ToDateTime(label2.Text = zaman.ToString());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            label1.Text = "Tarih 1";
            label2.Text = "Tarih 2";
            label3.Text = "Fark";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "Fark " + (trh1 - trh2).Days.ToString() + "Gün";
        }
    }
}
