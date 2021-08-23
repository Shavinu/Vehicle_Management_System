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
    public partial class Sigup_Form : Form
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public static string name;
        public static string type;
        public static string RealName;

        public Sigup_Form()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sigup_Form_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(local);Initial Catalog=Project;Integrated Security=True";
             }

        private void btnRest_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
            txtUser.Clear();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            name = txtUser.Text;
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(local);Initial Catalog=Project;Integrated Security=True";
            con.Open();
            cmd = new SqlCommand("select * from LogUser where username= @un and password=@pw", con);
            cmd.Parameters.AddWithValue("un", txtUser.Text);
            cmd.Parameters.AddWithValue("pw", txtPass.Text);
            SqlDataReader myread = cmd.ExecuteReader();
            if (myread.HasRows)
            {
                while (myread.Read())
                {
                    type = myread.GetString(3);
                    if (myread.GetString(3) == "Administrator")
                    {
                        Home_Form HF = new Home_Form();
                        HF.driverDetailsToolStripMenuItem.Enabled = false;
                        HF.vehicleDetailsToolStripMenuItem.Enabled = false;
                        
                        HF.movementsToolStripMenuItem.Enabled = false;
                        HF.reportingToolStripMenuItem.Enabled = false;
                       // HF.Enabled = false;
                        HF.Show();
                        this.Hide();
                    }
                    else if (myread.GetString(3) == "Transport Manager")
                    {
                        Home_Form HF1 = new Home_Form();
                        
                        HF1.movementsToolStripMenuItem.Enabled = false;
                        HF1.vehicleDetailsToolStripMenuItem.Enabled = false;
                        HF1.systemUsersToolStripMenuItem.Enabled = false;
                        HF1.Show();
                        this.Hide();
                    }
                    else if (myread.GetString(3) == "Vehicle Coordinator")
                    {
                        Home_Form HF1 = new Home_Form();
                        HF1.systemUsersToolStripMenuItem.Enabled = false;
                        //HF1.removeDriverToolStripMenuItem.Enabled = false;
                        //HF1.addNewDriverToolStripMenuItem.Enabled = false;
                        HF1.updateExistingDriverToolStripMenuItem.Enabled = true;
                        HF1.reportingToolStripMenuItem.Enabled = false;                        
                        HF1.Show();
                        this.Hide();
                    }
                    else if (myread.GetString(3) == "Staff/Branch Manager")
                    {
                        Home_Form HF1 = new Home_Form();
                        HF1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("You are not a valid user!" +Environment.NewLine+ "Contact System Administrator for Login purpose!", "Login Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Invalid Login" + '\n' + " Do you want to continue ?", "Login Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    txtPass.Clear();
                    txtUser.Clear();
                }

                else
                {
                    if (MessageBox.Show("You are about to return to previous page. Do you wish to continue?", "Exiting Form", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        this.Close();
                        welcome w = new welcome();
                        w.Show();
                    }
                }
                    
            }
                con.Close();
                cmd.Dispose();
            }

        private void btnLog_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnLog_MouseLeave(object sender, EventArgs e)
        {
            
        }
    }
    }
