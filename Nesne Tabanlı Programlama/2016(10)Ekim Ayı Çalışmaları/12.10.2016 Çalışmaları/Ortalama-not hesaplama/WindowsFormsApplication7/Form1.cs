using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int not;
            int not1 = Convert.ToInt16(textBox1.Text);
            int not2 = Convert.ToInt16(textBox2.Text);
            int sozlu = Convert.ToInt16(textBox3.Text);

            int ortalama = ((not1 + not2 + sozlu) / 3);
            textBox4.Text = ortalama.ToString();
            if (ortalama >= 0 && ortalama <= 49)
            {
                not = 1;
                textBox5.Text = not.ToString();
            }
            else if (ortalama >= 50 && ortalama <= 59)
            {
                not = 2;
                textBox5.Text = not.ToString();
            }
            else if (ortalama >= 60 && ortalama <= 69)
            {
                not = 3;
                textBox5.Text = not.ToString();
            }
            else if (ortalama >= 70 && ortalama <= 84)
            {
                not = 4;
                textBox5.Text = not.ToString();
            }
            else if (ortalama >= 85 && ortalama <= 100) 
            {
                not = 5;
                textBox5.Text = not.ToString();
            }



        }
    }
}
