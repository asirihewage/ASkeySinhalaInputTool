using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Threading;


namespace ASkey_Sinhala
{
    public partial class Form1 : Form
    {
        public void splash()
        {     
            Application.Run(new Form4());
        }

private void Form1_Minimize(object sender, EventArgs e)
{
    if (FormWindowState.Minimized == this.WindowState)
    {
       notifyIcon1.Visible = true;
       notifyIcon1.ShowBalloonTip(5000);
       this.Hide();
this.TopMost = false;
    }

    else if (FormWindowState.Normal == this.WindowState)
    {
       notifyIcon1.Visible = false;
    }
}

        public Form1()
        {
             Thread t = new Thread(new ThreadStart(splash));
             t.Start();
             Thread.Sleep(15625);
            InitializeComponent();
            t.Abort();
            this.FormClosing +=new FormClosingEventHandler(Form1_FormClosing);
            this.ShowInTaskbar = false;
            this.MaximizeBox = false;
        }

      
private void Form1_FormClosing(object sender, FormClosingEventArgs e)
   {
      if (e.CloseReason != CloseReason.UserClosing)
         return;

      if (MessageBox.Show("Thank you for using ASkey tool.\nYou are going to close this application. Your data will not be saved. Are you sure?", "Closing ASkey Tool", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            e.Cancel = true;
      
      
   }

        private void Form1_Load(object sender, EventArgs e)
        {


              webBrowser1.DocumentText = textBox1.Text;
        if(System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory+"/ASkey.txt")){
                    
                    string date = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory+"/ASkey.txt");
                    string end = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    DateTime one = Convert.ToDateTime(date);

                    DateTime two = Convert.ToDateTime(end);
                    DateTime expiryDate = one.AddDays(30);
                    DateTime dateOnly = expiryDate.Date;
                    System.TimeSpan dif = expiryDate.Subtract(two);
string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

                   if( dif!=null){
                    label1.Text = "Lisenced to " + userName + " on " + date+  "\nTrial Expires on "+ dateOnly; }

                    if(expiryDate <= two){
                        MessageBox.Show("Sorry, the product has been expired. please contact the developer for a new product key. \nThank you for using ASkey Tool trial for 30 days. ", "ASkey Expired!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(1);
}

            }else{
                label1.Text = "Welcome!";
                string key = DateTime.Today.ToString("yyyy-MM-dd");
            string fileName = "ASkey.txt";
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory +  fileName, key.ToString());
                }
        }



        private void learnTypingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
           form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void minimizeToSystemTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void eMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:asiriofficial@gmail.com?subject=Contact-ASkey_tool&body=Message_body_here");
        }

        private void sendBugReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:asiriofficial@gmail.com?subject=BugReport-ASkey_tool&body=Bug_report_here");
        }

        private void customerComplaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:asiriofficial@gmail.com?subject=Complaint-ASkey_tool&body=Complaints_here");
        }

        private void developerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form3 about = new Form3();
            about.Show();
        }

        private void googleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?client=opera&q=asiri+hewage&sourceid=opera&ie=UTF-8&oe=UTF-8");
        }

        private void faceBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/cloudcodersl");
        }

        private void linkedInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/asirihewage");
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
                   this.Show();
                   this.TopMost = true;
                 this.WindowState = FormWindowState.Normal;
        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
        }





    }
}
