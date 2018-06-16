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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

           if (label2.Text == "0")
           {
               timer1.Stop();
                this.Close();
           }
           else
           {
               label2.Text = (Convert.ToInt32(label2.Text) - 1).ToString();
               progressBar1.Value = 100-Convert.ToInt32(label2.Text);

           }
                
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             System.Diagnostics.Process.Start("https://www.facebook.com/cloudcodersl");
        }

        private void button3_Click(object sender, EventArgs e)
        {
             System.Diagnostics.Process.Start("https://www.linkedin.com/in/asirihewage/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
             System.Diagnostics.Process.Start("https://www.freelancer.com/affiliates/email/9407328/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
             System.Diagnostics.Process.Start("https://www.freelancer.com/hireme/asirihewage");
        }

        private void button5_Click(object sender, EventArgs e)
        {
             System.Diagnostics.Process.Start("https://www.google.com/search?client=opera&q=asiri+hewage&sourceid=opera&ie=UTF-8&oe=UTF-8");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            label2.Text = "100";
            timer1.Start();
            timer1.Interval = 1000;
        }
    }
}
