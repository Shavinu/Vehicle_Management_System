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
    public partial class UserReg : Form
    {
        public SqlConnection con;
        public SqlCommand cmd;
        string name;
        string nic;
        string add;
        string tele;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                name = txtName.Text;
                add = txtAdd.Text;
                nic = txtNIC.Text;
                tele = textBox1.Text;

                con.Open();
                cmd = new SqlCommand("Insert into Login Values (@Cu,@Cpass,@Ctype,@Cnic)", con);

                cmd.Parameters.AddWithValue("Cu", name);
                cmd.Parameters.AddWithValue("Cpass", add);
                cmd.Parameters.AddWithValue("Ctype", tele);
                cmd.Parameters.AddWithValue("Cnic",nic);


                if (MessageBox.Show("Are you sure to save this record?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show("User Added Successfully...", "New Client", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public UserReg()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source =(local);Initial Catalog=NIBMDB;Integrated Security=True";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
