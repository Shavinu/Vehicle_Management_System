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
    public partial class VehicleAdd : Form
    {
        public SqlConnection con;
        public SqlCommand cmd;
        string plate, pro, vLdate, mk,mod, type, ava;        
        byte[] images = null;
        String imgLocation = "";


        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtODO.Text.Length > 6)
                {
                    MessageBox.Show("Exceeded digits!" + Environment.NewLine + "Make sure that you have entered 6 digits.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtODO.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Exceeded digits!" + Environment.NewLine + "Make sure that you have entered 6 digits.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtODO.Clear();
            }
        }

        private void txtyom_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtyom.Text) <= 1980 || Convert.ToInt32(txtyom.Text) > 2018)
                {
                    MessageBox.Show("Please check Year Of Manufacture" + Environment.NewLine + "Year of manufacture should be between 1980 to 2018", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtyom.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check Year Of Manufacture" + Environment.NewLine + "Year of manufacture should be between 1980 to 2018", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtyom.Clear();
            }
        }

        private void txtyom_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtyom.Text.Length > 4 || txtyom.Text.Length < 4)
                {
                    MessageBox.Show("Exceeded digits!" + Environment.NewLine + "Make sure that you have entered 4 digits.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtyom.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Exceeded digits!" + Environment.NewLine + "Make sure that you have entered 4 digits.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtyom.Clear();
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtODO.Text) < 0 || Convert.ToInt32(txtODO.Text) >= 310000)
                {
                    MessageBox.Show("Please check vehicle millege!" + Environment.NewLine + "ODO should be between 0 and 310000", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtODO.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check vehicle millege!" + Environment.NewLine + "ODO should be between 0 and 310000", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtODO.Clear();
            }
        }

        private void cmbtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files(*.png;*.jpg;*.jpeg;*.gif;)|*.jpeg;*.jpg;*.gif;*.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                imgLocation = opnfd.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pictureBox1.ResetText();
        }

        int YOM, ODO;
        

        private void button1_Click(object sender, EventArgs e)
        {
            txtPlate.ResetText();
            cmbProvince.ResetText();
            cmbmodel.ResetText();
            cmbmake.ResetText();
            cmbtype.ResetText();
            txtODO.Clear();
            txtyom.Clear();
            dtpLicense.ResetText();
            cmbAva.ResetText();
        }

        

        public VehicleAdd()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Vehicle_Add_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source =(Local);Initial Catalog=Project;Integrated Security=True";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);

            try
            {

                plate = txtPlate.Text;
                pro = cmbProvince.Text;
                vLdate = dtpLicense.Value.ToShortDateString();
                mk = cmbmake.Text;
                ODO = Convert.ToInt32(txtODO.Text);
                YOM = Convert.ToInt32(txtyom.Text);                         
                type = cmbtype.Text;
                mod = cmbmodel.Text;
                ava = cmbAva.Text;

                con.Open();
                cmd = new SqlCommand("Insert into Vehicle Values (@Vno,@Province,@VLdate, @Make, @Model, @ODO, @YOM, @Type, @Availability,@Image)", con);

                cmd.Parameters.AddWithValue("Vno", plate);
                cmd.Parameters.AddWithValue("Province", pro);
                cmd.Parameters.AddWithValue("VLdate", vLdate);

               
                cmd.Parameters.AddWithValue("Make", mk);
                cmd.Parameters.AddWithValue("Model", mod);

                cmd.Parameters.AddWithValue("Odo", ODO);
                cmd.Parameters.AddWithValue("Yom", YOM);
                cmd.Parameters.AddWithValue("Type", type);
                cmd.Parameters.AddWithValue("Availability", ava);
                cmd.Parameters.AddWithValue("Image", images);

                if (MessageBox.Show("Are you sure to save this record?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show("Vehicle Added Successfully!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtPlate.ResetText();
                    cmbProvince.ResetText();
                    cmbmodel.ResetText();
                    cmbmake.ResetText();
                    cmbtype.ResetText();
                    txtODO.Clear();
                    txtyom.Clear();
                    dtpLicense.ResetText();
                    cmbAva.ResetText();
                    pictureBox1.ResetText();
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
