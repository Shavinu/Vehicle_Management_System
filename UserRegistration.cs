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
    public partial class UserRegistration : Form
    {
        public SqlConnection con;
        public SqlCommand cmd1, cmd2, cmd3;
        string name, user, pass, dpt, title, tele, address, userType, other, empID, secure, designation;
        string change;

        private void button2_Click(object sender, EventArgs e)
        {
            cmbDpt.ResetText();
            cmbTitle.ResetText();
            txtName.Clear();
          //  txtNIC.Clear();
            txtPassC.Clear();
            txtPassO.Clear();
            txtUser.Clear();
            con.Close();
        }

        private void txtPassC_Leave(object sender, EventArgs e)
        {
            if (txtPassO.Text == txtPassC.Text)
            {
                btnReg.Enabled = true;
            }

            else
            {
                MessageBox.Show("Password does not match" + '\n' + "Type the password again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                btnReg.Enabled = false;
                txtPassO.Clear();
                txtPassC.Clear();

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cmbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            change = cmbTitle.Text;
            if (change == "Transport Manager")
            {
                txtOther.Clear();
                txtOther.Enabled = true;
                label12.Text = "Grade";
            }
            else if (change == "Staff/Branch Manager")
            {
                txtOther.Clear();
                txtOther.Enabled = true;
                label12.Text = "Branch Code";
            }
            else if (change == "Vehicle Coordinator")
            {
                txtOther.Clear();
                txtOther.Enabled = true;
                label12.Text = "Service";
            }
            else if (change == "Administrator")
            {
                txtOther.Clear();
                txtOther.Enabled = false;
            }
        }

        private void txtEmpID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tele = Convert.ToString(txtTele.Text);
                address = txtAddress.Text;
                other = txtOther.Text;
                userType = cmbTitle.Text;
                empID = txtEmpID.Text;
                secure = txtSecurity.Text;
                designation = cmbDesignation.Text;
                change = cmbTitle.Text;

                name = txtName.Text;
                user = txtUser.Text;
                pass = txtPassC.Text;
                dpt = cmbDpt.Text;
                title = cmbTitle.Text;
                if (String.IsNullOrEmpty(txtName.Text) || txtName.Text.Any(Char.IsDigit) || 
                    String.IsNullOrEmpty(txtUser.Text)|| txtUser.Text.Any(Char.IsDigit))
                                     
                {
                    MessageBox.Show("Please check your Name or User ID Again,,,?");
                }
                else
                {
                    con.Open();
                    cmd1 = new SqlCommand("Insert into LogUser Values (@users,@pass, @secure, @systemuser)", con);

                    cmd1.Parameters.AddWithValue("users", user);
                    cmd1.Parameters.AddWithValue("pass", pass);
                    cmd1.Parameters.AddWithValue("secure", secure);
                    cmd1.Parameters.AddWithValue("systemuser", userType);

                    cmd2 = new SqlCommand("Insert into Employee Values (@EmpID,@EmpName,@Telephone, @Address, @designation)", con);

                    cmd2.Parameters.AddWithValue("EmpID", empID);
                    cmd2.Parameters.AddWithValue("EmpName", name);
                    cmd2.Parameters.AddWithValue("Telephone", tele);
                    cmd2.Parameters.AddWithValue("Address", address);
                    cmd2.Parameters.AddWithValue("designation", designation);


                    if (change == "Transport Manager")
                    {
                        cmd3 = new SqlCommand("Insert into TransportManager Values (@EmpID,@grade)", con);

                        cmd3.Parameters.AddWithValue("EmpID", empID);
                        cmd3.Parameters.AddWithValue("grade", other);
                    }
                    else if (change == "Vehicle Coordinator")
                    {
                        cmd3 = new SqlCommand("Insert into VehicleCoordinator Values (@EmpID,@service)", con);

                        cmd3.Parameters.AddWithValue("EmpID", empID);
                        cmd3.Parameters.AddWithValue("service", other);
                    }
                    else if (change == "Staff/Branch Manager")
                    {
                        cmd3 = new SqlCommand("Insert into BranchStaff Values (@EmpID,@BranchCode)", con);

                        cmd3.Parameters.AddWithValue("EmpID", empID);
                        cmd3.Parameters.AddWithValue("BranchCode", other);
                    }


                    if (MessageBox.Show("Are you sure to save this record?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        cmd1.ExecuteNonQuery();
                        cmd1.Dispose();
                        cmd2.ExecuteNonQuery();
                        cmd2.Dispose();
                        cmd3.ExecuteNonQuery();
                        cmd3.Dispose();
                        MessageBox.Show("User Added Successfully...", "New Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbDpt.ResetText();
                        cmbTitle.ResetText();
                        txtName.Clear();
                        //txtNIC.Clear();
                        txtPassC.Clear();
                        txtPassO.Clear();
                        txtUser.Clear();
                        con.Close();
                    }
                    con.Close();


                }
     
             }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbDpt.ResetText();
                cmbTitle.ResetText();
                txtName.Clear();
               // txtNIC.Clear();
                txtPassC.Clear();
                txtPassO.Clear();
                txtUser.Clear();
                con.Close();
            }
        }

        public UserRegistration()
        {
            InitializeComponent();
        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source =(Local);Initial Catalog=Project;Integrated Security=True";
            btnReg.Enabled = false;

            txtOther.Enabled = false;
        }
    }
}
