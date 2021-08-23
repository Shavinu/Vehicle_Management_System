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
    public partial class View_Movement : Form
    {
        public SqlConnection conn;
        public SqlCommand cmd;

        public View_Movement()
        {
            InitializeComponent();
        }

        private void View_Movement_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(); conn.ConnectionString = " Data Source=(local); Initial Catalog=Project;Integrated Security=True";
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Movement", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
