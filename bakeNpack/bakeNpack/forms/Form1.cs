using bakeNpack.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bakeNpack
{
    public partial class Form1 : Form
    {
        private object txtUsername;

        // private object dashboard;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btncustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dashboard1 ds = new dashboard1("customer");
            ds.Show();
            this.Hide();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if(username.Text == "sabbir" && password.Text == "pass")
            {
                dashboard1 ds = new dashboard1("Admin");
                ds.Show();
                this.Hide();
            }
        }
    }
}
