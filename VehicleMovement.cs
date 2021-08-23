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
    public partial class VehicleMovement : Form
    {
        public SqlConnection con;
        public SqlCommand cmd;
        String stTime, endTime, Locat, vehi, endDate, startDate;
        int dri;
    

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtpStartTime.ResetText();
            dtpEndTime.ResetText();
            txtLocation.Clear();
            cmbDriverNo.ResetText();
            cmbVno.ResetText();
        }

        public VehicleMovement()
        {
            InitializeComponent();
        }

        private void ReadyCurrent_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source =(Local);Initial Catalog=Project;Integrated Security=True";
            con.Open();
            cmd = new SqlCommand("select Vno from Vehicle where Availability = 'Yes'", con);
            SqlDataReader vehicleread = cmd.ExecuteReader();
            while (vehicleread.Read())
            {
                cmbVno.Items.Add(vehicleread.GetString(0));
            }
            con.Close();

            con = new SqlConnection();
            con.ConnectionString = "Data Source =(Local);Initial Catalog=Project;Integrated Security=True";
            con.Open();
            cmd = new SqlCommand("select Dno from Driver where Availability = 'Yes'", con);
            SqlDataReader driverread = cmd.ExecuteReader();
            while (driverread.Read())
            {
                cmbDriverNo.Items.Add(driverread.GetInt32(0));
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                vehi = cmbVno.Text;
                dri = Convert.ToInt32(cmbDriverNo.Text);
                stTime = dtpStartTime.Value.ToShortTimeString();
                endTime = dtpEndTime.Value.ToShortTimeString();
                Locat = txtLocation.Text;
                startDate = dtpStartDate.Value.ToShortDateString();
                endDate = dtpEndDate.Value.ToShortDateString(); ;

                con.Open();
                cmd = new SqlCommand("Insert into Movement Values (@VL_Plate,@DR_No,@Start_Date, @End_Date, @Start_Time, @End_Time, @Location)", con);

                cmd.Parameters.AddWithValue("VL_Plate", vehi);
                cmd.Parameters.AddWithValue("DR_No", dri);
                cmd.Parameters.AddWithValue("Start_Date", startDate);
                cmd.Parameters.AddWithValue("End_Date", endDate);
                cmd.Parameters.AddWithValue("Start_Time", stTime);
                cmd.Parameters.AddWithValue("End_Time", endTime);
                cmd.Parameters.AddWithValue("Location", Locat);
                

                if (MessageBox.Show("Are you sure to save this record?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cmd = new SqlCommand("update driver set Availability='No' where Dno = @driver",con);
                    cmd.Parameters.AddWithValue("driver", dri);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();


                    cmd = new SqlCommand("update Vehicle set Availability='No' where Vno = @vehi", con);
                    cmd.Parameters.AddWithValue("vehi", vehi);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show("Movement Recorded Successfully!", "New Movement", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                con.Close();
                dtpStartTime.ResetText();
                dtpEndTime.ResetText();
                txtLocation.Clear();
                cmbDriverNo.ResetText();
                cmbVno.ResetText();
                dtpStartDate.ResetText();
                dtpEndDate.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
