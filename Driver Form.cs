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
    public partial class Driver_Form : Form
    {

        public SqlConnection con;
        public SqlCommand cmd;
        string LN, dis;
        string name;
        string tele;
        byte[] images = null;
        String imgLocation = "";

        public Driver_Form()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            cmbDNo.ResetText();
            txtadd.Clear();
            //txtDistrict.Clear();
            txtName.Clear();
            //txtVN.Clear();
            btnUpdate.Enabled = false;                                 
        }

        private void Driver_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDataSet.DriverUpdateView' table. You can move, or remove it, as needed.
            this.driverUpdateViewTableAdapter.Fill(this.projectDataSet.DriverUpdateView);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);

                LN = cmbDNo.Text;
                name = txtName.Text;
                dis = txtadd.Text;
                tele = txtNum.Text;
                con.Open();
                cmd = new SqlCommand("update Driver set driverName=@dn,Address = @add,Telephone_No=@tn, ,Image=@Image where Dno=@drin", con);
                
                cmd.Parameters.AddWithValue("drin", LN);
                cmd.Parameters.AddWithValue("dn", name);
                cmd.Parameters.AddWithValue("add", dis);
                cmd.Parameters.AddWithValue("tn", tele);
                cmd.Parameters.AddWithValue("Image", images);

                cmd.ExecuteNonQuery();               
                MessageBox.Show("Driver Updated Successfully...", "Modify Driver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbDNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files(*.png;*.jpg;*.jpeg;*.gif;)|*.jpeg;*.jpg;*.gif;*.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                imgLocation = opnfd.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            
        }
    }
}
