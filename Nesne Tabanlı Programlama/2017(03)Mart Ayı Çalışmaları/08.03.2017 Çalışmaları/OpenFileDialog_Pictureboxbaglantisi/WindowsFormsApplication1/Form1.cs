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
        OpenFileDialog dos = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {           
            dos.InitialDirectory = @"C:\Users\Public\Pictures\Sample Pictures";
            dos.Filter = "Resim |*.jpg";
            dos.Title = "Resim Seçiniz";
            if (dos.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = dos.FileName;                
            }
            

        }

    }
}
