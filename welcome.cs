using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Sigup_Form S = new Sigup_Form();
            S.Show();
            this.Hide();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            UserRegistration L = new UserRegistration();
            L.Show();
        }

        private void welcome_Load(object sender, EventArgs e)
        {
           
        }

        private void btnex_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
