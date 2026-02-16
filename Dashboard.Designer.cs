namespace ClinicManagementProject
{
    partial class Dashboard
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
            this.quickNavPanel = new System.Windows.Forms.Panel();
            this.myAccLbl = new System.Windows.Forms.Label();
            this.dashboardLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.signOutBtn = new System.Windows.Forms.Button();
            this.activityLbl = new System.Windows.Forms.Label();
            this.doctorsLbl = new System.Windows.Forms.Label();
            this.patientsLbl = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.quickNavPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // quickNavPanel
            // 
            this.quickNavPanel.Controls.Add(this.myAccLbl);
            this.quickNavPanel.Controls.Add(this.dashboardLbl);
            this.quickNavPanel.Controls.Add(this.label4);
            this.quickNavPanel.Controls.Add(this.signOutBtn);
            this.quickNavPanel.Controls.Add(this.activityLbl);
            this.quickNavPanel.Controls.Add(this.doctorsLbl);
            this.quickNavPanel.Controls.Add(this.patientsLbl);
            this.quickNavPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.quickNavPanel.Location = new System.Drawing.Point(0, 0);
            this.quickNavPanel.Name = "quickNavPanel";
            this.quickNavPanel.Size = new System.Drawing.Size(238, 483);
            this.quickNavPanel.TabIndex = 0;
            // 
            // myAccLbl
            // 
            this.myAccLbl.AutoSize = true;
            this.myAccLbl.Location = new System.Drawing.Point(33, 283);
            this.myAccLbl.Name = "myAccLbl";
            this.myAccLbl.Size = new System.Drawing.Size(92, 20);
            this.myAccLbl.TabIndex = 6;
            this.myAccLbl.Text = "My Account";
            this.myAccLbl.Click += new System.EventHandler(this.myAccLbl_Click);
            // 
            // dashboardLbl
            // 
            this.dashboardLbl.AutoSize = true;
            this.dashboardLbl.Location = new System.Drawing.Point(30, 99);
            this.dashboardLbl.Name = "dashboardLbl";
            this.dashboardLbl.Size = new System.Drawing.Size(88, 20);
            this.dashboardLbl.TabIndex = 5;
            this.dashboardLbl.Text = "Dashboard";
            this.dashboardLbl.Click += new System.EventHandler(this.dashboardLbl_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "TK Clinic";
            // 
            // signOutBtn
            // 
            this.signOutBtn.Location = new System.Drawing.Point(50, 359);
            this.signOutBtn.Name = "signOutBtn";
            this.signOutBtn.Size = new System.Drawing.Size(121, 47);
            this.signOutBtn.TabIndex = 3;
            this.signOutBtn.Text = "Sign Out";
            this.signOutBtn.UseVisualStyleBackColor = true;
            this.signOutBtn.Click += new System.EventHandler(this.signOutBtn_Click);
            // 
            // activityLbl
            // 
            this.activityLbl.AutoSize = true;
            this.activityLbl.Location = new System.Drawing.Point(33, 237);
            this.activityLbl.Name = "activityLbl";
            this.activityLbl.Size = new System.Drawing.Size(89, 20);
            this.activityLbl.TabIndex = 2;
            this.activityLbl.Text = "Activity Log";
            this.activityLbl.Click += new System.EventHandler(this.activityLbl_Click);
            // 
            // doctorsLbl
            // 
            this.doctorsLbl.AutoSize = true;
            this.doctorsLbl.Location = new System.Drawing.Point(33, 187);
            this.doctorsLbl.Name = "doctorsLbl";
            this.doctorsLbl.Size = new System.Drawing.Size(65, 20);
            this.doctorsLbl.TabIndex = 1;
            this.doctorsLbl.Text = "Doctors";
            this.doctorsLbl.Click += new System.EventHandler(this.doctorsLbl_Click);
            // 
            // patientsLbl
            // 
            this.patientsLbl.AutoSize = true;
            this.patientsLbl.Location = new System.Drawing.Point(33, 144);
            this.patientsLbl.Name = "patientsLbl";
            this.patientsLbl.Size = new System.Drawing.Size(67, 20);
            this.patientsLbl.TabIndex = 0;
            this.patientsLbl.Text = "Patients";
            this.patientsLbl.Click += new System.EventHandler(this.patientsLbl_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(238, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(803, 483);
            this.mainPanel.TabIndex = 3;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 483);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.quickNavPanel);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.quickNavPanel.ResumeLayout(false);
            this.quickNavPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel quickNavPanel;
        private System.Windows.Forms.Label doctorsLbl;
        private System.Windows.Forms.Label patientsLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button signOutBtn;
        private System.Windows.Forms.Label activityLbl;
        private System.Windows.Forms.Label dashboardLbl;
        private System.Windows.Forms.Label myAccLbl;
        private System.Windows.Forms.Panel mainPanel;
    }
}