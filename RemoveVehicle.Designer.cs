namespace GroupProject
{
    partial class Remove_Vehicle
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblvd = new System.Windows.Forms.Label();
            this.lblrn = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtODO = new System.Windows.Forms.TextBox();
            this.txtyom = new System.Windows.Forms.TextBox();
            this.lblodo = new System.Windows.Forms.Label();
            this.lblyom = new System.Windows.Forms.Label();
            this.lblmod = new System.Windows.Forms.Label();
            this.lblty = new System.Windows.Forms.Label();
            this.lblmak = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cmbVno = new System.Windows.Forms.ComboBox();
            this.txtPro = new System.Windows.Forms.TextBox();
            this.txtAva = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReset.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReset.Location = new System.Drawing.Point(42, 15);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(173, 32);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset Fields";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExit.Location = new System.Drawing.Point(558, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 32);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remove or Search Vehicle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(-183, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Vehicle Availability";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(316, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 32);
            this.dateTimePicker1.TabIndex = 44;
            // 
            // lblvd
            // 
            this.lblvd.AutoSize = true;
            this.lblvd.BackColor = System.Drawing.Color.Transparent;
            this.lblvd.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvd.ForeColor = System.Drawing.Color.White;
            this.lblvd.Location = new System.Drawing.Point(29, 147);
            this.lblvd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblvd.Name = "lblvd";
            this.lblvd.Size = new System.Drawing.Size(278, 29);
            this.lblvd.TabIndex = 43;
            this.lblvd.Text = "Vehicle License Valid Until";
            // 
            // lblrn
            // 
            this.lblrn.AutoSize = true;
            this.lblrn.BackColor = System.Drawing.Color.Transparent;
            this.lblrn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrn.ForeColor = System.Drawing.Color.White;
            this.lblrn.Location = new System.Drawing.Point(29, 73);
            this.lblrn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblrn.Name = "lblrn";
            this.lblrn.Size = new System.Drawing.Size(216, 29);
            this.lblrn.TabIndex = 40;
            this.lblrn.Text = "Registered Number ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.txtMake);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.txtODO);
            this.groupBox1.Controls.Add(this.txtyom);
            this.groupBox1.Controls.Add(this.lblodo);
            this.groupBox1.Controls.Add(this.lblyom);
            this.groupBox1.Controls.Add(this.lblmod);
            this.groupBox1.Controls.Add(this.lblty);
            this.groupBox1.Controls.Add(this.lblmak);
            this.groupBox1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(616, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 312);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Basic Details";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(215, 154);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(189, 36);
            this.txtModel.TabIndex = 39;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(215, 99);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(189, 36);
            this.txtMake.TabIndex = 38;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(215, 44);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(189, 36);
            this.txtType.TabIndex = 37;
            // 
            // txtODO
            // 
            this.txtODO.Location = new System.Drawing.Point(215, 201);
            this.txtODO.Name = "txtODO";
            this.txtODO.Size = new System.Drawing.Size(119, 36);
            this.txtODO.TabIndex = 36;
            // 
            // txtyom
            // 
            this.txtyom.Location = new System.Drawing.Point(215, 252);
            this.txtyom.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtyom.Name = "txtyom";
            this.txtyom.Size = new System.Drawing.Size(136, 36);
            this.txtyom.TabIndex = 29;
            // 
            // lblodo
            // 
            this.lblodo.AutoSize = true;
            this.lblodo.BackColor = System.Drawing.Color.Transparent;
            this.lblodo.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblodo.ForeColor = System.Drawing.Color.White;
            this.lblodo.Location = new System.Drawing.Point(33, 209);
            this.lblodo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblodo.Name = "lblodo";
            this.lblodo.Size = new System.Drawing.Size(56, 29);
            this.lblodo.TabIndex = 22;
            this.lblodo.Text = "Odo";
            // 
            // lblyom
            // 
            this.lblyom.AutoSize = true;
            this.lblyom.BackColor = System.Drawing.Color.Transparent;
            this.lblyom.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyom.ForeColor = System.Drawing.Color.White;
            this.lblyom.Location = new System.Drawing.Point(33, 260);
            this.lblyom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblyom.Name = "lblyom";
            this.lblyom.Size = new System.Drawing.Size(64, 29);
            this.lblyom.TabIndex = 23;
            this.lblyom.Text = "YOM";
            // 
            // lblmod
            // 
            this.lblmod.AutoSize = true;
            this.lblmod.BackColor = System.Drawing.Color.Transparent;
            this.lblmod.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmod.ForeColor = System.Drawing.Color.White;
            this.lblmod.Location = new System.Drawing.Point(31, 154);
            this.lblmod.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblmod.Name = "lblmod";
            this.lblmod.Size = new System.Drawing.Size(78, 29);
            this.lblmod.TabIndex = 21;
            this.lblmod.Text = "Model";
            // 
            // lblty
            // 
            this.lblty.AutoSize = true;
            this.lblty.BackColor = System.Drawing.Color.Transparent;
            this.lblty.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblty.ForeColor = System.Drawing.Color.White;
            this.lblty.Location = new System.Drawing.Point(31, 40);
            this.lblty.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblty.Name = "lblty";
            this.lblty.Size = new System.Drawing.Size(62, 29);
            this.lblty.TabIndex = 24;
            this.lblty.Text = "Type";
            // 
            // lblmak
            // 
            this.lblmak.AutoSize = true;
            this.lblmak.BackColor = System.Drawing.Color.Transparent;
            this.lblmak.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmak.ForeColor = System.Drawing.Color.White;
            this.lblmak.Location = new System.Drawing.Point(31, 95);
            this.lblmak.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblmak.Name = "lblmak";
            this.lblmak.Size = new System.Drawing.Size(70, 29);
            this.lblmak.TabIndex = 20;
            this.lblmak.Text = "Make";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 48;
            this.label3.Text = "Availability";
            // 
            // btnRemove
            // 
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemove.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRemove.Location = new System.Drawing.Point(280, 15);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(215, 32);
            this.btnRemove.TabIndex = 49;
            this.btnRemove.Text = "Remove Vehicle";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cmbVno
            // 
            this.cmbVno.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVno.FormattingEnabled = true;
            this.cmbVno.Location = new System.Drawing.Point(385, 76);
            this.cmbVno.Name = "cmbVno";
            this.cmbVno.Size = new System.Drawing.Size(176, 32);
            this.cmbVno.TabIndex = 50;
            this.cmbVno.Text = "Select Vehicle Number";
            this.cmbVno.SelectedIndexChanged += new System.EventHandler(this.cmbVno_SelectedIndexChanged);
            // 
            // txtPro
            // 
            this.txtPro.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPro.Location = new System.Drawing.Point(316, 76);
            this.txtPro.Name = "txtPro";
            this.txtPro.Size = new System.Drawing.Size(63, 32);
            this.txtPro.TabIndex = 51;
            // 
            // txtAva
            // 
            this.txtAva.Enabled = false;
            this.txtAva.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAva.Location = new System.Drawing.Point(316, 219);
            this.txtAva.Name = "txtAva";
            this.txtAva.Size = new System.Drawing.Size(116, 32);
            this.txtAva.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.txtAva);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.txtPro);
            this.panel2.Controls.Add(this.cmbVno);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.lblvd);
            this.panel2.Controls.Add(this.lblrn);
            this.panel2.Location = new System.Drawing.Point(16, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 330);
            this.panel2.TabIndex = 54;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Location = new System.Drawing.Point(258, 450);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(726, 61);
            this.panel3.TabIndex = 55;
            // 
            // Remove_Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1197, 523);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Remove_Vehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle_Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Vehicle_Search_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblvd;
        private System.Windows.Forms.Label lblrn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtODO;
        private System.Windows.Forms.TextBox txtyom;
        private System.Windows.Forms.Label lblodo;
        private System.Windows.Forms.Label lblyom;
        private System.Windows.Forms.Label lblmod;
        private System.Windows.Forms.Label lblty;
        private System.Windows.Forms.Label lblmak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cmbVno;
        private System.Windows.Forms.TextBox txtPro;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtAva;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}