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
using System.IO;

namespace GroupProject
{
    public partial class New_Driver : Form
    {
        public SqlConnection conn;
        public SqlCommand cmd, cmdNo;
        string name, add, ava, tno, licenseno, licenseDue;
        byte[] images = null;
        String imgLocation = "";


        int dn, dn1;

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files(*.png;*.jpg;*.jpeg;*.gif;)|*.jpeg;*.jpg;*.gif;*.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                imgLocation = opnfd.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }

        public New_Driver()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLN_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtAdd.Clear();
            txtLN.Clear();
            txtName.Clear();
            mtxttn.Clear();
            dtpLicenseDue.ResetText();
            txtLicenseNo.Clear();
            
        }

        private void New_Driver_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(); conn.ConnectionString = " Data Source=(local); Initial Catalog=Project;Integrated Security=True";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);

                dn = Convert.ToInt32(txtLN.Text);
                name = txtName.Text;
                add=txtAdd.Text;
                tno = mtxttn.Text;
                licenseno = Convert.ToString(txtLicenseNo.Text);
                licenseDue = dtpLicenseDue.Value.ToShortDateString();
                if (checkBox1.Checked)
                {
                    ava = "Yes";
                }
                else
                {
                    ava = "No";
                }

                conn.Open();
                cmd = new SqlCommand("Insert into Driver Values(@Dno,@DriverName,@License_No,@LicenseRenew_Due,@Telephone_No,@Address,@Availability,@Image)", conn);

                cmd.Parameters.AddWithValue("Dno", dn);
                cmd.Parameters.AddWithValue("DriverName", name);
                cmd.Parameters.AddWithValue("License_No", licenseno);
                cmd.Parameters.AddWithValue("LicenseRenew_Due", licenseDue);                
                cmd.Parameters.AddWithValue("Telephone_No", tno);
                cmd.Parameters.AddWithValue("Address", add);
                cmd.Parameters.AddWithValue("Availability", ava);
                cmd.Parameters.AddWithValue("Image", images);

                if (MessageBox.Show("Are you sure to save this record?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes && imgLocation != null)
                {
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show("Driver Added Successfully!", "New Driver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAdd.Clear();
                    txtLN.Clear();
                    txtName.Clear();
                    mtxttn.Clear();
                    dtpLicenseDue.ResetText();
                    txtLicenseNo.Clear();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
    }
}
