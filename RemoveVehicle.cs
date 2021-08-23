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
    public partial class Remove_Vehicle : Form
    {
        public SqlConnection con;
        public SqlCommand cmd;
        string vno;           

        public Remove_Vehicle()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Vehicle_Search_Load(object sender, EventArgs e)
        {
            btnRemove.Enabled = false;
            con = new SqlConnection();
            con.ConnectionString = "Data Source =(Local);Initial Catalog=Project;Integrated Security=True";
            con.Open();
            cmd = new SqlCommand("select Vno from Vehicle", con);
            SqlDataReader vehicleread = cmd.ExecuteReader();
            while (vehicleread.Read())
            {
                cmbVno.Items.Add(vehicleread.GetString(0));
            }
            con.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbVno.ResetText();
            txtyom.Clear();
            txtODO.Clear();
            txtAva.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtPro.Clear();
            txtType.Clear();
            txtyom.Clear();
            dateTimePicker1.ResetText();
            btnRemove.Enabled = true;
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                btnRemove.Enabled = true;
                
                con.Open();
                vno = cmbVno.Text;
                cmd = new SqlCommand("Select Province, VLdate, Make, Model, ODO, YOM, Type, Availability from Vehicle where Vno=@vn", con);
                cmd.Parameters.AddWithValue("vn", vno);
                SqlDataReader sqldr = cmd.ExecuteReader();
                if (sqldr.HasRows)
                {
                    while (sqldr.Read())
                    {
                        txtPro.Text = sqldr.GetString(0);
                        dateTimePicker1.Text = Convert.ToString(sqldr.GetDateTime(1));
                        txtMake.Text = sqldr.GetString(2);
                        txtModel.Text = sqldr.GetString(3);
                        txtODO.Text = Convert.ToString(sqldr.GetInt32(4));
                        txtyom.Text = Convert.ToString(sqldr.GetString(5));
                        txtType.Text = sqldr.GetString(6);
                        txtAva.Text = sqldr.GetString(7);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Vehicle Number!!", "Alert", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                    txtyom.Clear();
                    txtODO.Clear();
                    txtAva.Clear();
                    txtMake.Clear();
                    txtModel.Clear();
                    txtPro.Clear();
                    txtType.Clear();
                    txtyom.Clear();
                    dateTimePicker1.ResetText();
                }
            }
            catch (Exception rt)
            {
                MessageBox.Show(rt.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void cmbVno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                btnRemove.Enabled = true;
                
                con.Open();
                vno = cmbVno.Text;
                cmd = new SqlCommand("Select Province, VLdate, Make, Model, ODO, YOM, Type, Availability from Vehicle where Vno=@vn", con);
                cmd.Parameters.AddWithValue("vn", vno);
                SqlDataReader sqldr = cmd.ExecuteReader();
                if (sqldr.HasRows)
                {
                    while (sqldr.Read())
                    {
                        txtPro.Text = sqldr.GetString(0);
                        dateTimePicker1.Text = Convert.ToString(sqldr.GetDateTime(1));
                        txtMake.Text = sqldr.GetString(2);
                        txtModel.Text = sqldr.GetString(3);
                        txtODO.Text = Convert.ToString(sqldr.GetInt32(4));
                        txtyom.Text = Convert.ToString(sqldr.GetString(5));
                        txtType.Text = sqldr.GetString(6);
                        txtAva.Text = sqldr.GetString(7);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Vehicle Number!!", "Alert", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                    txtyom.Clear();
                    txtODO.Clear();
                    txtAva.Clear();
                    txtMake.Clear();
                    txtModel.Clear();
                    txtPro.Clear();
                    txtType.Clear();
                    txtyom.Clear();
                    dateTimePicker1.ResetText();
                }
                
            }
            catch (Exception rt)
            {
                MessageBox.Show(rt.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                vno = cmbVno.Text;
                con.Open();
                cmd = new SqlCommand("delete from Vehicle where Vno = @vno", con);
                cmd.Parameters.AddWithValue("vno", vno);

                if (MessageBox.Show("Are you sure to delete this Driver?" + Environment.NewLine + Environment.NewLine + "Changes Cannot be undo!", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show("Driver Deleted Successfully!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    txtyom.Clear();
                    txtODO.Clear();
                    txtAva.Clear();
                    txtMake.Clear();
                    txtModel.Clear();
                    txtPro.Clear();
                    txtType.Clear();
                    txtyom.Clear();
                    dateTimePicker1.ResetText();
                    cmbVno.ResetText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
