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
    public partial class Remove_Driver : Form
    {
        public SqlConnection con;
        public SqlCommand cmd;
        string DriverLI;

        public Remove_Driver()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtAva.Clear();
            cmbDno.ResetText();
            txtDrivName.Clear();
            mskTele.ResetText();
            txtAdd.Clear();
            txtLicenseNo.Clear();
            dtpLicenseDue.ResetText();
            btnRemoveDriver.Enabled = false;
        }

        private void Remove_Driver_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source =(Local);Initial Catalog=Project;Integrated Security=True";
            btnRemoveDriver.Enabled = false;
            con.Open();
            cmd = new SqlCommand("select Dno from Driver", con);
            SqlDataReader DRead = cmd.ExecuteReader();
            while (DRead.Read())
            {
               cmbDno.Items.Add(DRead.GetInt32(0));
            }
            con.Close();
        }

        private void btnRemoveDriver_Click(object sender, EventArgs e)
        {
            try
            {
                DriverLI = cmbDno.Text;
                con.Open();
                cmd = new SqlCommand("delete from Driver where Dno = @DID", con);
                cmd.Parameters.AddWithValue("DID", DriverLI);

                if (MessageBox.Show("Are you sure to delete this Driver?" + Environment.NewLine + Environment.NewLine + "Changes Cannot be undo!", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show("Driver Deleted Successfully!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    cmbDno.ResetText();
                    txtAdd.Clear();
                    txtAva.Clear();
                    txtDrivName.Clear();
                    mskTele.ResetText();
                    txtLicenseNo.Clear();
                    dtpLicenseDue.ResetText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbDno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DriverLI = cmbDno.Text;
                con.Open();
                cmd = new SqlCommand("Select driverName, License_No, LicenseRenew_Due, Telephone_No, Address, Availability from Driver where Dno=@DID", con);
                cmd.Parameters.AddWithValue("DID", DriverLI);

                SqlDataReader myread = cmd.ExecuteReader();

                if (myread.HasRows)
                {
                    while (myread.Read())
                    {
                        txtDrivName.Text = myread.GetString(0);
                        txtLicenseNo.Text = myread.GetString(1);
                        dtpLicenseDue.Text = myread.GetString(2);
                        //dtpLicenseDue.Text = Convert.ToString(myread.GetInt32(1));
                        mskTele.Text = myread.GetString(3);
                        txtAdd.Text = myread.GetString(4);                        
                        txtAva.Text = myread.GetString(5);
                        
                    }
                    btnRemoveDriver.Enabled = true;
                    
                }
                else
                {
                    MessageBox.Show("Driver Does not exisit!" + Environment.NewLine + Environment.NewLine + "Please check Driver License Number agin.", "Alert", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    cmbDno.ResetText();
                    txtAdd.Clear();
                    txtAva.Clear();
                    txtDrivName.Clear();
                    mskTele.ResetText();
                }
                con.Close();
            }
            catch (Exception)
            {
                if (MessageBox.Show("Form Load Error", "Alert!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Hand) == DialogResult.Abort)
                {
                    this.Close();
                    Home_Form r = new Home_Form();
                    r.Show();
                }

            }
        }
    }
}
