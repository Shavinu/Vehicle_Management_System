namespace GroupProject
{
    partial class welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcome));
            this.btnLog = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnex = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.Gray;
            this.btnLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLog.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.Color.White;
            this.btnLog.Location = new System.Drawing.Point(17, 15);
            this.btnLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(220, 64);
            this.btnLog.TabIndex = 3;
            this.btnLog.Text = "Login";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnex);
            this.panel1.Controls.Add(this.btnLog);
            this.panel1.Location = new System.Drawing.Point(707, 352);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 145);
            this.panel1.TabIndex = 4;
            // 
            // btnex
            // 
            this.btnex.BackColor = System.Drawing.Color.Gray;
            this.btnex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnex.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnex.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnex.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnex.ForeColor = System.Drawing.Color.White;
            this.btnex.Location = new System.Drawing.Point(79, 87);
            this.btnex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnex.Name = "btnex";
            this.btnex.Size = new System.Drawing.Size(108, 43);
            this.btnex.TabIndex = 4;
            this.btnex.Text = "Exit";
            this.btnex.UseVisualStyleBackColor = false;
            this.btnex.Click += new System.EventHandler(this.btnex_Click);
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(977, 512);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "welcome";
            this.Load += new System.EventHandler(this.welcome_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnex;
    }
}