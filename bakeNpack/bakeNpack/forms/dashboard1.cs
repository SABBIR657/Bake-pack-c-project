using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bakeNpack.forms
{
    public partial class dashboard1 : Form
    {
        public dashboard1()
        {
            InitializeComponent();
        }
        public dashboard1(String user)
        {
            InitializeComponent();

            if(user == "customer")
            {
                additemsbtn.Hide();
                updateitemsbtn.Hide();
                Removeitemsbtn.Hide();
                employeeinfobtn.Hide();
                cashinfobtn.Hide();
            }
            else if(user == "Admin")
            {
                additemsbtn.Show();
                updateitemsbtn.Show();
                Removeitemsbtn.Show();
                employeeinfobtn.Show();
                cashinfobtn.Show();
            }
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {
            uC_additems1.Visible = false;
            uC_UpdateItems1.Visible = false;
            uC_RemoveItem1.Visible = false;
            uC_CashInfo1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void placeorderbtn_Click(object sender, EventArgs e)
        {
            customer_orders cusorder = new customer_orders();
            this.Hide();
            cusorder.Show();
        }

        private void employeeinfobtn_Click(object sender, EventArgs e)
        {
           
        }

        private void additemsbtn_Click(object sender, EventArgs e)
        {
            uC_additems1.Visible = true;
            uC_additems1.BringToFront();
        }

        private void updateitemsbtn_Click(object sender, EventArgs e)
        {
            uC_UpdateItems1.Visible = true;
            uC_UpdateItems1.BringToFront();
        }

        private void Removeitemsbtn_Click(object sender, EventArgs e)
        {
            uC_RemoveItem1.Visible = true;
            uC_RemoveItem1.BringToFront();
        }

        private void cashinfobtn_Click(object sender, EventArgs e)
        {
            uC_CashInfo1.Visible = true;
            uC_CashInfo1.BringToFront();
        }
    }
}
