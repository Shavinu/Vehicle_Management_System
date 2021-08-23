namespace GroupProject
{
    partial class Home_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eixtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tripsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createANewTripRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkTheStatusOfTheTripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driverDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateExistingDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAMovementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMovementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCurrentMovementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleDetailReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driverReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movementReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblun = new System.Windows.Forms.Label();
            this.lbllog = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.approveRejectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tripsToolStripMenuItem,
            this.systemUsersToolStripMenuItem,
            this.driverDetailsToolStripMenuItem,
            this.vehicleDetailsToolStripMenuItem,
            this.movementsToolStripMenuItem,
            this.reportingToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(859, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.eixtToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.fileToolStripMenuItem.Text = "System";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // eixtToolStripMenuItem
            // 
            this.eixtToolStripMenuItem.Name = "eixtToolStripMenuItem";
            this.eixtToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.eixtToolStripMenuItem.Text = "Exit";
            this.eixtToolStripMenuItem.Click += new System.EventHandler(this.eixtToolStripMenuItem_Click);
            // 
            // tripsToolStripMenuItem
            // 
            this.tripsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createANewTripRequestToolStripMenuItem,
            this.approveRejectToolStripMenuItem,
            this.checkTheStatusOfTheTripToolStripMenuItem});
            this.tripsToolStripMenuItem.Name = "tripsToolStripMenuItem";
            this.tripsToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.tripsToolStripMenuItem.Text = "Trips";
            // 
            // createANewTripRequestToolStripMenuItem
            // 
            this.createANewTripRequestToolStripMenuItem.Name = "createANewTripRequestToolStripMenuItem";
            this.createANewTripRequestToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.createANewTripRequestToolStripMenuItem.Text = "Create a new trip request";
            this.createANewTripRequestToolStripMenuItem.Click += new System.EventHandler(this.CreateANewTripRequestToolStripMenuItem_Click);
            // 
            // checkTheStatusOfTheTripToolStripMenuItem
            // 
            this.checkTheStatusOfTheTripToolStripMenuItem.Name = "checkTheStatusOfTheTripToolStripMenuItem";
            this.checkTheStatusOfTheTripToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.checkTheStatusOfTheTripToolStripMenuItem.Text = "Check status";
            // 
            // systemUsersToolStripMenuItem
            // 
            this.systemUsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem});
            this.systemUsersToolStripMenuItem.Name = "systemUsersToolStripMenuItem";
            this.systemUsersToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.systemUsersToolStripMenuItem.Text = "System Users";
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // driverDetailsToolStripMenuItem
            // 
            this.driverDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDriverToolStripMenuItem,
            this.updateExistingDriverToolStripMenuItem,
            this.removeDriverToolStripMenuItem});
            this.driverDetailsToolStripMenuItem.Name = "driverDetailsToolStripMenuItem";
            this.driverDetailsToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.driverDetailsToolStripMenuItem.Text = "Driver";
            this.driverDetailsToolStripMenuItem.Click += new System.EventHandler(this.driverDetailsToolStripMenuItem_Click);
            // 
            // addNewDriverToolStripMenuItem
            // 
            this.addNewDriverToolStripMenuItem.Name = "addNewDriverToolStripMenuItem";
            this.addNewDriverToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.addNewDriverToolStripMenuItem.Text = "Add New Driver";
            this.addNewDriverToolStripMenuItem.Click += new System.EventHandler(this.addNewDriverToolStripMenuItem_Click);
            // 
            // updateExistingDriverToolStripMenuItem
            // 
            this.updateExistingDriverToolStripMenuItem.Name = "updateExistingDriverToolStripMenuItem";
            this.updateExistingDriverToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.updateExistingDriverToolStripMenuItem.Text = "Update / Search Driver";
            this.updateExistingDriverToolStripMenuItem.Click += new System.EventHandler(this.updateExistingDriverToolStripMenuItem_Click);
            // 
            // removeDriverToolStripMenuItem
            // 
            this.removeDriverToolStripMenuItem.Name = "removeDriverToolStripMenuItem";
            this.removeDriverToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.removeDriverToolStripMenuItem.Text = "Remove Driver";
            this.removeDriverToolStripMenuItem.Click += new System.EventHandler(this.removeDriverToolStripMenuItem_Click);
            // 
            // vehicleDetailsToolStripMenuItem
            // 
            this.vehicleDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewVehicleToolStripMenuItem,
            this.searchVehicleToolStripMenuItem,
            this.removeVehicleToolStripMenuItem});
            this.vehicleDetailsToolStripMenuItem.Name = "vehicleDetailsToolStripMenuItem";
            this.vehicleDetailsToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.vehicleDetailsToolStripMenuItem.Text = "Vehicle";
            this.vehicleDetailsToolStripMenuItem.Click += new System.EventHandler(this.vehicleDetailsToolStripMenuItem_Click);
            // 
            // addNewVehicleToolStripMenuItem
            // 
            this.addNewVehicleToolStripMenuItem.Name = "addNewVehicleToolStripMenuItem";
            this.addNewVehicleToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.addNewVehicleToolStripMenuItem.Text = "Add New Vehicle";
            this.addNewVehicleToolStripMenuItem.Click += new System.EventHandler(this.addNewVehicleToolStripMenuItem_Click);
            // 
            // searchVehicleToolStripMenuItem
            // 
            this.searchVehicleToolStripMenuItem.Name = "searchVehicleToolStripMenuItem";
            this.searchVehicleToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.searchVehicleToolStripMenuItem.Text = "Update / Search Vehicle";
            this.searchVehicleToolStripMenuItem.Click += new System.EventHandler(this.searchVehicleToolStripMenuItem_Click);
            // 
            // removeVehicleToolStripMenuItem
            // 
            this.removeVehicleToolStripMenuItem.Name = "removeVehicleToolStripMenuItem";
            this.removeVehicleToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.removeVehicleToolStripMenuItem.Text = "Remove Vehicle";
            this.removeVehicleToolStripMenuItem.Click += new System.EventHandler(this.removeVehicleToolStripMenuItem_Click);
            // 
            // movementsToolStripMenuItem
            // 
            this.movementsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAMovementToolStripMenuItem,
            this.updateMovementToolStripMenuItem,
            this.viewCurrentMovementsToolStripMenuItem});
            this.movementsToolStripMenuItem.Name = "movementsToolStripMenuItem";
            this.movementsToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.movementsToolStripMenuItem.Text = "Movements";
            // 
            // createAMovementToolStripMenuItem
            // 
            this.createAMovementToolStripMenuItem.Name = "createAMovementToolStripMenuItem";
            this.createAMovementToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.createAMovementToolStripMenuItem.Text = "Create a Movement";
            this.createAMovementToolStripMenuItem.Click += new System.EventHandler(this.createAMovementToolStripMenuItem_Click);
            // 
            // updateMovementToolStripMenuItem
            // 
            this.updateMovementToolStripMenuItem.Name = "updateMovementToolStripMenuItem";
            this.updateMovementToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.updateMovementToolStripMenuItem.Text = "Update Movement";
            this.updateMovementToolStripMenuItem.Click += new System.EventHandler(this.updateMovementToolStripMenuItem_Click);
            // 
            // viewCurrentMovementsToolStripMenuItem
            // 
            this.viewCurrentMovementsToolStripMenuItem.Name = "viewCurrentMovementsToolStripMenuItem";
            this.viewCurrentMovementsToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.viewCurrentMovementsToolStripMenuItem.Text = "View Current Movements";
            this.viewCurrentMovementsToolStripMenuItem.Click += new System.EventHandler(this.viewCurrentMovementsToolStripMenuItem_Click);
            // 
            // reportingToolStripMenuItem
            // 
            this.reportingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleDetailReportToolStripMenuItem,
            this.driverReportToolStripMenuItem,
            this.movementReportToolStripMenuItem});
            this.reportingToolStripMenuItem.Name = "reportingToolStripMenuItem";
            this.reportingToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.reportingToolStripMenuItem.Text = "Reports";
            this.reportingToolStripMenuItem.Click += new System.EventHandler(this.reportingToolStripMenuItem_Click);
            // 
            // vehicleDetailReportToolStripMenuItem
            // 
            this.vehicleDetailReportToolStripMenuItem.Name = "vehicleDetailReportToolStripMenuItem";
            this.vehicleDetailReportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.vehicleDetailReportToolStripMenuItem.Text = "Vehicle Detail Report";
            this.vehicleDetailReportToolStripMenuItem.Click += new System.EventHandler(this.vehicleDetailReportToolStripMenuItem_Click);
            // 
            // driverReportToolStripMenuItem
            // 
            this.driverReportToolStripMenuItem.Name = "driverReportToolStripMenuItem";
            this.driverReportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.driverReportToolStripMenuItem.Text = "Driver Report";
            this.driverReportToolStripMenuItem.Click += new System.EventHandler(this.driverReportToolStripMenuItem_Click);
            // 
            // movementReportToolStripMenuItem
            // 
            this.movementReportToolStripMenuItem.Name = "movementReportToolStripMenuItem";
            this.movementReportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.movementReportToolStripMenuItem.Text = "Movement Report";
            this.movementReportToolStripMenuItem.Click += new System.EventHandler(this.movementReportToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupDetailsToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // groupDetailsToolStripMenuItem
            // 
            this.groupDetailsToolStripMenuItem.Name = "groupDetailsToolStripMenuItem";
            this.groupDetailsToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.groupDetailsToolStripMenuItem.Text = "Group Details";
            this.groupDetailsToolStripMenuItem.Click += new System.EventHandler(this.groupDetailsToolStripMenuItem_Click);
            // 
            // lblun
            // 
            this.lblun.AutoEllipsis = true;
            this.lblun.AutoSize = true;
            this.lblun.BackColor = System.Drawing.Color.Transparent;
            this.lblun.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblun.Font = new System.Drawing.Font("Candara", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblun.ForeColor = System.Drawing.Color.Black;
            this.lblun.Location = new System.Drawing.Point(24, 17);
            this.lblun.Name = "lblun";
            this.lblun.Size = new System.Drawing.Size(144, 39);
            this.lblun.TabIndex = 5;
            this.lblun.Text = "Username";
            this.lblun.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbllog
            // 
            this.lbllog.AutoEllipsis = true;
            this.lbllog.AutoSize = true;
            this.lbllog.BackColor = System.Drawing.Color.Transparent;
            this.lbllog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbllog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbllog.Font = new System.Drawing.Font("Candara", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllog.ForeColor = System.Drawing.Color.Black;
            this.lbllog.Location = new System.Drawing.Point(24, 74);
            this.lbllog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllog.Name = "lbllog";
            this.lbllog.Size = new System.Drawing.Size(165, 39);
            this.lbllog.TabIndex = 6;
            this.lbllog.Text = "Loged in as.";
            this.lbllog.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblun);
            this.panel2.Controls.Add(this.lbllog);
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(358, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 132);
            this.panel2.TabIndex = 8;
            // 
            // approveRejectToolStripMenuItem
            // 
            this.approveRejectToolStripMenuItem.Name = "approveRejectToolStripMenuItem";
            this.approveRejectToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.approveRejectToolStripMenuItem.Text = "Approve/Reject";
            this.approveRejectToolStripMenuItem.Click += new System.EventHandler(this.ApproveRejectToolStripMenuItem_Click);
            // 
            // Home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(859, 543);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home_Form";
            this.Load += new System.EventHandler(this.Home_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eixtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleDetailReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupDetailsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem driverDetailsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem vehicleDetailsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem reportingToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem systemUsersToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem driverReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movementReportToolStripMenuItem;
        private System.Windows.Forms.Label lblun;
        private System.Windows.Forms.Label lbllog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem removeVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAMovementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMovementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCurrentMovementsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem movementsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem updateExistingDriverToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addNewDriverToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem removeDriverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tripsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createANewTripRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkTheStatusOfTheTripToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approveRejectToolStripMenuItem;
    }
}