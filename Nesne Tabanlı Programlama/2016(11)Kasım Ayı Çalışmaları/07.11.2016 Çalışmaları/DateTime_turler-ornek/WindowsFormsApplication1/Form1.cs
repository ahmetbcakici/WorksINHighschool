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
        void goster()
        {
            foreach (Control x in this.Controls)
            {
                if (x is Label)                
                    x.Visible = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            goster();
            button1.Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime zaman = dateTimePicker1.Value;
            label20.Text = zaman.Day.ToString();
            label19.Text = zaman.Month.ToString();
            label18.Text = zaman.Year.ToString();

            /*
            label20.Text = DateTime.Now.Day.ToString();//günü alır
            label19.Text = DateTime.Now.Month.ToString();//ayı alır
            label18.Text = DateTime.Now.Year.ToString();//yılı alır*/
            label15.Text = DateTime.Now.Hour.ToString();//saati alır
            label16.Text = DateTime.Now.Minute.ToString();//dakikayı alır
            label17.Text = DateTime.Now.Second.ToString();//saniyeyi alır
            label13.Text = DateTime.Now.ToLongDateString();//uzun tarihi alır
            label14.Text = DateTime.Now.ToShortDateString();//kısa tarihi alır
            label11.Text = DateTime.Now.ToLongTimeString();//uzun saati alır
            label12.Text = DateTime.Now.ToShortTimeString();//kısa saati alır
        }
    }
}
