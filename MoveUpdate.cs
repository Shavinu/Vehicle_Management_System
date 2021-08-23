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

    public partial class MoveUpdate : Form
    {
        public SqlConnection con;
        public SqlCommand cmd;

        public MoveUpdate()
        {
            InitializeComponent();
        }

        private void MoveUpdate_Load(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection();
                con.ConnectionString = "Data Source =(Local);Initial Catalog=Project;Integrated Security=True";
                con.Open();
                cmd = new SqlCommand("select VL_Plate from Movement", con);
                SqlDataReader vehicleread = cmd.ExecuteReader();
                while (vehicleread.Read())
                {
                    cmbVno.Items.Add(vehicleread.GetString(0));
                }


                con = new SqlConnection();
                con.ConnectionString = "Data Source =(Local);Initial Catalog=Project;Integrated Security=True";
                con.Open();
                cmd = new SqlCommand("select Dr_No from Movement", con);
                SqlDataReader driverread = cmd.ExecuteReader();
                while (driverread.Read())
                {
                    cmbDno.Items.Add(driverread.GetInt32(0));
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
    

        private void btnDriUp_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int Dno = Convert.ToInt32(cmbDno.Text);
                String vnn = cmbVno.Text;
                String drUp = Convert.ToString("Yes");
                if (MessageBox.Show("Are you sure to update this record?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("update Driver set Availability=@Ava where Dno=@DD", con);
                    cmd.Parameters.AddWithValue("Ava", drUp);
                    cmd.Parameters.AddWithValue("DD", Dno);
                    cmd = new SqlCommand("update Vehicle set Availability=@Ava where Vno=@VV", con);
                    cmd.Parameters.AddWithValue("Ava", drUp);
                    cmd.Parameters.AddWithValue("VV", vnn);

                    cmd = new SqlCommand("delete from movement where DR_No=@DR", con);
                    cmd.Parameters.AddWithValue("DR", Dno);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Movement Updated Successfully!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbDno.ResetText();
                    cmbVno.ResetText();
                    cmd.Dispose();                   
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbDno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String LP = cmbDno.Text;
                con.Open();
                cmd = new SqlCommand("Select DR_No, VL_Plate from Movement where DR_No=@DD", con);
                cmd.Parameters.AddWithValue("DD", LP);
                SqlDataReader myread = cmd.ExecuteReader();

                if (myread.HasRows)
                {
                    while (myread.Read())
                    {
                        cmbVno.Text = myread.GetString(1);
                    }
                }
                else
                {
                    MessageBox.Show("Vehicle Does not exisit!" + Environment.NewLine + Environment.NewLine + "Please check Driver License Number agin.", "Alert", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    cmbDno.ResetText();
                    cmbVno.ResetText();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

