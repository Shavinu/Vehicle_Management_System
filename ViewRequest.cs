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

namespace GroupProject
{
    public partial class ViewRequest : Form
    {
        public SqlConnection con;
        public SqlCommand cmd;
        string req_ID;
        

        public ViewRequest()
        {
            InitializeComponent();
        }

        private void ViewRequest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'viewRequestSet.ViewRequest' table. You can move, or remove it, as needed.
            this.viewRequestTableAdapter.Fill(this.viewRequestSet.ViewRequest);
            // TODO: This line of code loads data into the 'viewRequestSet.ViewRequest' table. You can move, or remove it, as needed.
            //           this.viewRequestTableAdapter.Fill(this.viewRequestSet.ViewRequest);

            con = new SqlConnection();
            con.ConnectionString = "Data Source =(Local);Initial Catalog=Project;Integrated Security=True";
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            req_ID = txtMID.Text;
            try
            {
                con.Open();
                cmd = new SqlCommand("update Request set Req_Status=@app where Req_No=@req_ID", con);
                cmd.Parameters.AddWithValue("app", "Approved!");
                cmd.Parameters.AddWithValue("req_ID", req_ID);
                cmd.Parameters.AddWithValue("rej", "Rejected!");

                cmd.ExecuteNonQuery();
                MessageBox.Show("Request trip status updated successfully!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void Btnupdate_Click(object sender, EventArgs e)
        {
            req_ID = txtMID.Text;
            try
            {
                con.Open();
                cmd = new SqlCommand("update Request set Req_Status=@app where Req_No=@req_ID", con);
                cmd.Parameters.AddWithValue("rej", "Rejected!");
                cmd.Parameters.AddWithValue("req_ID", req_ID);               

                cmd.ExecuteNonQuery();
                MessageBox.Show("Request trip status updated successfully!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }
    }
}
