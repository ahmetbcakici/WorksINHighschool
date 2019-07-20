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
            int sonuc = 1;
            int girilen = Convert.ToInt16(textBox1.Text);
            int s2 = Convert.ToInt16(numericUpDown1.Value);
            for (int i = 1; i <= s2; i++)
            {
                sonuc *= girilen;
            }
            MessageBox.Show(sonuc.ToString());            
        }
    }
}
