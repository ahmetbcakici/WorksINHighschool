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
        string[] ad = new string[5] { "Ahmet", "Mehmet", "Hakan", "Oğuz", "Doğukan" };
        string[] kopyaad = new string[5];
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var x in ad)
            {
                listBox1.Items.Add(x);
            }
            for (int i = 0, j = 4; i < ad.Length; i++, j--) 
            {
                kopyaad[j] = ad[i];
            }
            foreach (var x in kopyaad)
            {
                listBox2.Items.Add(x);
            }
        }
    }
}
