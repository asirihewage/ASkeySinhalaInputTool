using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ASkey_Sinhala
{
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = "100";
            timer1.Start();
            timer1.Interval = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           if (label1.Text == "0")
           {
               timer1.Stop();
                this.Close();
           }
           else
           {
               label1.Text = (Convert.ToInt32(label1.Text) - 1).ToString();
               progressBar1.Value = 100-Convert.ToInt32(label1.Text);

           }
        }
    }
}
