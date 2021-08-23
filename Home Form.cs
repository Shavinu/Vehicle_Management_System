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
    public partial class Home_Form : Form
    {
        public Home_Form()
        {
            InitializeComponent();
        }

        private void vehicleDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void eixtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NiBM Vehicle Management System"+Environment.NewLine+"Goodbye Mr. " + Sigup_Form.name, "Alert!", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            this.Close();
            Application.Exit();
        }

        private void addNewDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Driver D1 = new New_Driver();
            D1.Show();
        }

        private void updateExistingDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Driver_Form D2 = new Driver_Form();
            D2.Show();
        }

        private void searchDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Update_Driver D2 = new Update_Driver();
            //D2.Show();
        }

        private void removeDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove_Driver rd = new Remove_Driver();
            rd.Show();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchCurrentTripsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleMovement RD = new VehicleMovement();
            RD.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            welcome w = new welcome();
            w.Show();
            this.Hide();
            Driver_Form p = new Driver_Form();
            p.Close();
            DriverDetailReport p1 = new DriverDetailReport();
            p.Close();
            Group p2 = new Group();
            p2.Close();
            Sigup_Form p3 = new Sigup_Form();
            p3.Close();
            MovementRpt p4 = new MovementRpt();
            p4.Close();
            MoveUpdate p5 = new MoveUpdate();
            p5.Close();
            New_Driver p6 = new New_Driver();
            p6.Close();
            Remove_Driver p7 = new Remove_Driver();
            p7.Close();
            Remove_Vehicle p8 = new Remove_Vehicle();
            p8.Close();
            UserRegistration p9 = new UserRegistration();
            p9.Close();
            VehicleAdd p10 = new VehicleAdd();
            p10.Close();
            VehicleMovement p11 = new VehicleMovement();
            p11.Close();
            VehicleReport p12 = new VehicleReport();
            p12.Close();
            View_Movement p13 = new View_Movement();
            p13.Close();
                        
        }

        private void addNewVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleAdd VA1 = new VehicleAdd();
            VA1.Show();
        }

        private void searchVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Vehicle UV = new Update_Vehicle();
            UV.Show();
        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Group G = new Group();
            G.Show();
        }

        private void driverDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewCurrentTripsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Movement r = new View_Movement();
            r.Show();
        }

        private void Home_Form_Load(object sender, EventArgs e)
        {
            lblun.Text = "Welcome " + Sigup_Form.name;
            lbllog.Text = "Loged in as " + Sigup_Form.type;
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserRegistration ur = new UserRegistration();
            ur.Show();
        }

        private void vehicleDetailReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleReport vr = new VehicleReport();
            vr.Show();
        }

        private void driverReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DriverDetailReport ddr = new DriverDetailReport();
            ddr.Show();
        }

        private void movementReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovementRpt mrpt = new MovementRpt();
            mrpt.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void removeVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove_Vehicle vs = new Remove_Vehicle();
            vs.Show();
        }

        private void createAMovementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleMovement vm = new VehicleMovement();
            vm.Show();
        }

        private void updateMovementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveUpdate move= new MoveUpdate();
            move.Show();
        }

        private void viewCurrentMovementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Movement view = new View_Movement();
            view.Show();
        }

        private void reportingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CreateANewTripRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_trip_request ntrip = new New_trip_request();
            ntrip.Show();
        }

        private void ApproveRejectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewRequest vreq = new ViewRequest();
            vreq.Show();
        }
    }
}
