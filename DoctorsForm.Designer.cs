namespace ClinicManagementProject
{
    partial class DoctorsForm
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
            this.doctorData = new System.Windows.Forms.DataGridView();
            this.Label = new System.Windows.Forms.Label();
            this.addDocBtn = new System.Windows.Forms.Button();
            this.deleteDocBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.doctorData)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorData
            // 
            this.doctorData.AllowUserToAddRows = false;
            this.doctorData.AllowUserToDeleteRows = false;
            this.doctorData.AllowUserToResizeColumns = false;
            this.doctorData.AllowUserToResizeRows = false;
            this.doctorData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorData.Location = new System.Drawing.Point(-1, 139);
            this.doctorData.Name = "doctorData";
            this.doctorData.RowHeadersWidth = 62;
            this.doctorData.RowTemplate.Height = 28;
            this.doctorData.Size = new System.Drawing.Size(802, 310);
            this.doctorData.TabIndex = 0;
            this.doctorData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctorData_CellContentClick);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(340, 38);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(118, 32);
            this.Label.TabIndex = 1;
            this.Label.Text = "Doctors";
            // 
            // addDocBtn
            // 
            this.addDocBtn.Location = new System.Drawing.Point(625, 73);
            this.addDocBtn.Name = "addDocBtn";
            this.addDocBtn.Size = new System.Drawing.Size(131, 46);
            this.addDocBtn.TabIndex = 2;
            this.addDocBtn.Text = "Add Doctor";
            this.addDocBtn.UseVisualStyleBackColor = true;
            this.addDocBtn.Click += new System.EventHandler(this.addDocBtn_Click);
            // 
            // deleteDocBtn
            // 
            this.deleteDocBtn.Location = new System.Drawing.Point(12, 73);
            this.deleteDocBtn.Name = "deleteDocBtn";
            this.deleteDocBtn.Size = new System.Drawing.Size(153, 46);
            this.deleteDocBtn.TabIndex = 3;
            this.deleteDocBtn.Text = "Remove Doctor";
            this.deleteDocBtn.UseVisualStyleBackColor = true;
            // 
            // DoctorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteDocBtn);
            this.Controls.Add(this.addDocBtn);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.doctorData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorsForm";
            this.Text = "DoctorsForm";
            this.Load += new System.EventHandler(this.DoctorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView doctorData;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button addDocBtn;
        private System.Windows.Forms.Button deleteDocBtn;
    }
}