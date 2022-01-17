using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace bakeNpack
{
    class function
    {
        //protected SqlConnection getConnection = "data source = DESKTOP-OJMPJK3\\SQLEXPRESS;database = bakeNpack; integrated security = True";

        protected SqlConnection getConnection() //extract data from the database
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-OJMPJK3;database = bakeNpack; integrated security = True"; 
            return con;
        }
        public DataSet getData(string query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(string query) //inser delete update
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Processed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
