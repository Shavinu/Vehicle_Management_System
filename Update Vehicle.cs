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
    public partial class Update_Vehicle : Form
    {
        public SqlConnection con;
        public SqlCommand cmd;
        string refe, LEDate;
        int  ODO;

        public Update_Vehicle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmbVehi.ResetText();
            dtpLV.ResetText();
            txtODO.Clear();
            btnupdate.Enabled = false;
        }

        private void Update_Vehicle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDataSet.View_1' table. You can move, or remove it, as needed.
            this.view_1TableAdapter.Fill(this.projectDataSet.View_1);
            con = new SqlConnection();
            con.ConnectionString = "Data Source =(Local);Initial Catalog=Project;Integrated Security=True";
            con.Open();
            cmd = new SqlCommand("select Vno from Vehicle", con);
            SqlDataReader myread = cmd.ExecuteReader();
            btnupdate.Enabled = false;
            if (myread.HasRows)
            {
                while (myread.Read())
                {
                    cmbVehi.Items.Add(myread.GetString(0));
                }
            }
                 con.Close();
        }

        private void cmbVehi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String LP = cmbVehi.Text;
                con.Open();
                cmd = new SqlCommand("Select VLdate, ODO from Vehicle where Vno=@vno", con);
                cmd.Parameters.AddWithValue("vno", LP);
                SqlDataReader myread = cmd.ExecuteReader();

                if (myread.HasRows)
                {
                    while (myread.Read())
                    {
                        dtpLV.Text = Convert.ToString(myread.GetDateTime(0));
                        txtODO.Text = Convert.ToString(myread.GetInt32(1));                        
                        btnupdate.Enabled = true;                        
                    }
                }
                else
                {
                    MessageBox.Show("Vehicle Does not exisit!" + Environment.NewLine + Environment.NewLine + "Please check Driver License Number agin.", "Alert", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    txtODO.Clear();
                    dtpLV.ResetText();
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void BindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                refe = cmbVehi.Text;
            LEDate = dtpLV.Value.ToShortDateString();
            ODO = Convert.ToInt32(txtODO.Text);

           
                con.Open();
                if (String.IsNullOrEmpty(txtODO.Text) || txtODO.Text.Any(Char.IsLetter) || txtODO.Text.Any(Char.IsWhiteSpace) || txtODO.Text.Any(Char.IsControl))               
                {
                    MessageBox.Show("Enter numeric values only!");
                }
                else
                {
                    if (MessageBox.Show("Are you sure to update this record?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        cmd = new SqlCommand("update Vehicle set VLdate=@_LDate,ODO=@_ODO where Vno=@refe", con);

                        cmd.Parameters.AddWithValue("_LDate", LEDate);
                        cmd.Parameters.AddWithValue("_ODO", ODO);
                        cmd.Parameters.AddWithValue("refe", refe);

                        if (MessageBox.Show("Are you sure to make changes in this record?"+Environment.NewLine+"Changes cannot be undo!", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Vehicle Details Updated Successfully!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmd.Dispose();
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    }
}
