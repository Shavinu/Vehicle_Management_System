namespace GroupProject
{
    partial class Update_Vehicle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Vehicle));
            this.label1 = new System.Windows.Forms.Label();
            this.lblvn = new System.Windows.Forms.Label();
            this.lbllvu = new System.Windows.Forms.Label();
            this.dtpLV = new System.Windows.Forms.DateTimePicker();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnrf = new System.Windows.Forms.Button();
            this.lblodo = new System.Windows.Forms.Label();
            this.txtODO = new System.Windows.Forms.TextBox();
            this.cmbVehi = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.projectDataSet = new GroupProject.ProjectDataSet();
            this.view1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_1TableAdapter = new GroupProject.ProjectDataSetTableAdapters.View_1TableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Detail Update";
            // 
            // lblvn
            // 
            this.lblvn.AutoSize = true;
            this.lblvn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvn.ForeColor = System.Drawing.Color.White;
            this.lblvn.Location = new System.Drawing.Point(18, 41);
            this.lblvn.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblvn.Name = "lblvn";
            this.lblvn.Size = new System.Drawing.Size(174, 29);
            this.lblvn.TabIndex = 1;
            this.lblvn.Text = "Vehicle Number";
            // 
            // lbllvu
            // 
            this.lbllvu.AutoSize = true;
            this.lbllvu.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllvu.ForeColor = System.Drawing.Color.White;
            this.lbllvu.Location = new System.Drawing.Point(18, 101);
            this.lbllvu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbllvu.Name = "lbllvu";
            this.lbllvu.Size = new System.Drawing.Size(200, 29);
            this.lbllvu.TabIndex = 2;
            this.lbllvu.Text = "License Valid Until";
            // 
            // dtpLV
            // 
            this.dtpLV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view1BindingSource, "VLdate", true));
            this.dtpLV.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLV.Location = new System.Drawing.Point(266, 94);
            this.dtpLV.Margin = new System.Windows.Forms.Padding(5);
            this.dtpLV.MaxDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpLV.MinDate = new System.DateTime(2019, 3, 24, 0, 0, 0, 0);
            this.dtpLV.Name = "dtpLV";
            this.dtpLV.Size = new System.Drawing.Size(373, 36);
            this.dtpLV.TabIndex = 4;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Transparent;
            this.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnupdate.Location = new System.Drawing.Point(210, 27);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(129, 43);
            this.btnupdate.TabIndex = 7;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnexit.Location = new System.Drawing.Point(393, 27);
            this.btnexit.Margin = new System.Windows.Forms.Padding(5);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(129, 43);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "Exit Form";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnrf
            // 
            this.btnrf.BackColor = System.Drawing.Color.Transparent;
            this.btnrf.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnrf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnrf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnrf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrf.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnrf.Location = new System.Drawing.Point(38, 27);
            this.btnrf.Margin = new System.Windows.Forms.Padding(5);
            this.btnrf.Name = "btnrf";
            this.btnrf.Size = new System.Drawing.Size(129, 43);
            this.btnrf.TabIndex = 9;
            this.btnrf.Text = "Reset Fields";
            this.btnrf.UseVisualStyleBackColor = false;
            this.btnrf.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblodo
            // 
            this.lblodo.AutoSize = true;
            this.lblodo.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblodo.ForeColor = System.Drawing.Color.White;
            this.lblodo.Location = new System.Drawing.Point(18, 173);
            this.lblodo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblodo.Name = "lblodo";
            this.lblodo.Size = new System.Drawing.Size(130, 29);
            this.lblodo.TabIndex = 10;
            this.lblodo.Text = "ODO Meter";
            // 
            // txtODO
            // 
            this.txtODO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view1BindingSource, "ODO", true));
            this.txtODO.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtODO.Location = new System.Drawing.Point(266, 166);
            this.txtODO.Margin = new System.Windows.Forms.Padding(5);
            this.txtODO.Name = "txtODO";
            this.txtODO.Size = new System.Drawing.Size(164, 36);
            this.txtODO.TabIndex = 11;
            // 
            // cmbVehi
            // 
            this.cmbVehi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view1BindingSource, "Vno", true));
            this.cmbVehi.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVehi.FormattingEnabled = true;
            this.cmbVehi.Location = new System.Drawing.Point(266, 33);
            this.cmbVehi.Margin = new System.Windows.Forms.Padding(5);
            this.cmbVehi.Name = "cmbVehi";
            this.cmbVehi.Size = new System.Drawing.Size(199, 37);
            this.cmbVehi.TabIndex = 13;
            this.cmbVehi.SelectedIndexChanged += new System.EventHandler(this.cmbVehi_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.cmbVehi);
            this.panel1.Controls.Add(this.txtODO);
            this.panel1.Controls.Add(this.lblodo);
            this.panel1.Controls.Add(this.dtpLV);
            this.panel1.Controls.Add(this.lbllvu);
            this.panel1.Controls.Add(this.lblvn);
            this.panel1.Location = new System.Drawing.Point(36, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 236);
            this.panel1.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnrf);
            this.panel3.Controls.Add(this.btnexit);
            this.panel3.Controls.Add(this.btnupdate);
            this.panel3.Location = new System.Drawing.Point(90, 474);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(551, 92);
            this.panel3.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(722, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(459, 360);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vehicle Photo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.view1BindingSource, "Picture", true));
            this.pictureBox1.Location = new System.Drawing.Point(15, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // projectDataSet
            // 
            this.projectDataSet.DataSetName = "ProjectDataSet";
            this.projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view1BindingSource
            // 
            this.view1BindingSource.DataMember = "View_1";
            this.view1BindingSource.DataSource = this.projectDataSet;
            // 
            // view_1TableAdapter
            // 
            this.view_1TableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.view1BindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1219, 27);
            this.bindingNavigator1.TabIndex = 43;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // Update_Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1219, 615);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Update_Vehicle";
            this.Text = "Update_Vehicle";
            this.Load += new System.EventHandler(this.Update_Vehicle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblvn;
        private System.Windows.Forms.Label lbllvu;
        private System.Windows.Forms.DateTimePicker dtpLV;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnrf;
        private System.Windows.Forms.Label lblodo;
        private System.Windows.Forms.TextBox txtODO;
        private System.Windows.Forms.ComboBox cmbVehi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ProjectDataSet projectDataSet;
        private System.Windows.Forms.BindingSource view1BindingSource;
        private ProjectDataSetTableAdapters.View_1TableAdapter view_1TableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}