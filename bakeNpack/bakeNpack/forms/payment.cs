using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bakeNpack.forms
{
    public partial class payment : Form
    {
        function fn = new function();
        string query;
        public payment()
        {
            InitializeComponent();
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            customer_orders cus = new customer_orders();
            this.Hide();
            cus.Show();
        }

        private void payment_Load(object sender, EventArgs e)
        {

        }

        private void payment_Enter(object sender, EventArgs e)
        {

        }

        private void btnCusPay_Click(object sender, EventArgs e)
        {
            if (txtCusName.Text != "" && txtCusGender.Text != "" && txtCusContact.Text != "" && txtCusEmail.Text != "" && txtCusAddress.Text != "" && txtAmount.Text != "" && txtPaymentOption.Text != "" && txtFoodReview.Text != "")
            {
                string name = txtCusName.Text;
                string gender = txtCusGender.Text;
                Int64 contact = Int64.Parse(txtCusContact.Text);
                string email = txtCusEmail.Text;
                string address = txtCusAddress.Text;
                Int64 amount = Int64.Parse(txtAmount.Text);
                string payment = txtPaymentOption.Text;
                string review = txtFoodReview.Text;

                query = "insert into cutomerPurchase (cname,gender,contact,email,caddress,amount,payment,review) values('" + name + "','" + gender + "'," + contact + ",'" + email + "','" + address + "'," + amount + ",'" + payment + "','" + review + "')";
                fn.setData(query);

                txtCusName.Clear();
                txtCusAddress.Clear();
                txtCusGender.SelectedIndex = -1;
                txtCusEmail.Clear();
                txtAmount.Clear();
                txtPaymentOption.SelectedIndex = -1;
                txtFoodReview.Clear();
            }
            else
            {
                MessageBox.Show("Fill all the field.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
