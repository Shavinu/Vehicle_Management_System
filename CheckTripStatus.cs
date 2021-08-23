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
    public partial class CheckTripStatus : Form
    {
        public CheckTripStatus()
        {
            InitializeComponent();
        }

        private void CheckTripStatus_Load(object sender, EventArgs e)
        {
            label2.Text = Sigup_Form.name;
        }
    }
}
