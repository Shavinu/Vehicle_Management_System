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
    public partial class New_trip_request : Form
    {
        public SqlConnection con;
        public SqlCommand cmd;
        string empId, tripdate, description, returning, requestNo, status="On Approval";

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dtpTripdate.Enabled = false;
            }
            else
            {
                dtpTripdate.Enabled = true;
            }
        }

        private void btnrf_Click(object sender, EventArgs e)
        {
            txtDes.Clear();
            dtpTripdate.ResetText();
            cmbEmpID.ResetText();            
            chkReturn.Checked=false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                //requestNo = mskRequestNo.Text;
                empId = cmbEmpID.Text;
                tripdate = dtpTripdate.Value.ToShortDateString();
                description = txtDes.Text;
                if (chkReturn.Checked)
                {
                    returning = "Yes";
                }
                else
                {
                    returning = "No";
                }

                con.Open();
                cmd = new SqlCommand("Insert into Request Values (@reDate,@restatus,@reqDes,@Returning,@empId)", con);

                //cmd.Parameters.AddWithValue("reID", requestNo);
                cmd.Parameters.AddWithValue("reDate", tripdate);
                cmd.Parameters.AddWithValue("restatus", status);
                cmd.Parameters.AddWithValue("reqDes", description);
                cmd.Parameters.AddWithValue("Returning", returning);
                cmd.Parameters.AddWithValue("empId", empId);

                if (MessageBox.Show("Are you sure to save this record?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show("Request Submitted Successfully!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtDes.Clear();
                    dtpTripdate.ResetText();
                    cmbEmpID.ResetText();
                    chkReturn.Checked = false;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public New_trip_request()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void New_trip_request_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = " Data Source=(local); Initial Catalog=Project;Integrated Security=True";

            //To fill the combo box with empID
            con.Open();
            cmd = new SqlCommand("select EmpID from Employee", con);
            SqlDataReader empID = cmd.ExecuteReader();
            while (empID.Read())
            {
                cmbEmpID.Items.Add(empID.GetString(0));
            }
            con.Close();
        }
    }
}
