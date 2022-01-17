using DGVPrinterHelper;
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
    public partial class customer_orders : Form
    {
        function fn = new function();
        string query;
        double result = 0;
        string operation = "";
        bool enter_value = false;
        string firstnum, secondnum;
        double a, itax;
        double[] itemCost = new double[18];
        public customer_orders()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string category = comboCategory.Text;
            query = "select name from items where category ='"+category +"'";
            showItemList(query);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // e.Graphics.DrawString(rtreceipt.ResetText)
            e.Graphics.DrawString(rtreceipt.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 0));
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
           
            string category = comboCategory.Text;
            query = "select name from items where category ='" + category + "' and name like '"+txtSerach.Text+"%' ";
            showItemList(query);
           
        }

        private void showItemList(string query)
        {
            listBox1.Items.Clear();
            DataSet ds = fn.getData(query);

            // int i;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantityUpDown.ResetText();
            txtTotal.Clear();

            string text = listBox1.GetItemText(listBox1.SelectedItem);
            txtItemName.Text = text;
            query = "select price from items where name = '" + text + "' ";
            DataSet ds = fn.getData(query);

            try
            {
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }

           
        }

        private void txtQuantityUpDown_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(txtQuantityUpDown.Value.ToString());
            Int64 price = Int64.Parse(txtPrice.Text);
            txtTotal.Text = (quan * price).ToString();
        }

        protected int n, total = 0;

       

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text != "0" && txtTotal.Text != "")
            {
                n = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[n].Cells[0].Value = txtItemName.Text;
                guna2DataGridView1.Rows[n].Cells[1].Value = txtPrice.Text;
                guna2DataGridView1.Rows[n].Cells[2].Value = txtQuantityUpDown.Value;
                guna2DataGridView1.Rows[n].Cells[3].Value = txtTotal.Text;

                total += int.Parse(txtTotal.Text);
                labelTotalAmount.Text = "Tk." + total;
            }
            else
            {
                MessageBox.Show("Minimum Quantity need to be 1 ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //printPreviewDialog1.ShowDialog();
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Amount: " + labelTotalAmount.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(guna2DataGridView1);

            total = 0;
            guna2DataGridView1.Rows.Clear();
            labelTotalAmount.Text = "Tk." + total;
        }

        private void customer_orders_Load(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            payment pa = new payment();
            this.Hide();
            pa.Show();
        }

        int amount;

        

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch { }

        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
            }
            catch { }
            total -= amount;
            labelTotalAmount.Text = "Tk. " + total;
        }
    }
}
