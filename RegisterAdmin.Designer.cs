namespace ClinicManagementProject
{
    partial class RegisterAdminControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.registerAccBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.loginLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(90, 123);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(237, 26);
            this.firstNameTxt.TabIndex = 1;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(379, 123);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(237, 26);
            this.lastNameTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(90, 197);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(237, 26);
            this.emailTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(379, 197);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(237, 26);
            this.passwordTxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // registerAccBtn
            // 
            this.registerAccBtn.Location = new System.Drawing.Point(198, 263);
            this.registerAccBtn.Name = "registerAccBtn";
            this.registerAccBtn.Size = new System.Drawing.Size(326, 37);
            this.registerAccBtn.TabIndex = 10;
            this.registerAccBtn.Text = "Register Account";
            this.registerAccBtn.UseVisualStyleBackColor = true;
            this.registerAccBtn.Click += new System.EventHandler(this.registerAccBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Already Have an Account?";
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loginLbl.Location = new System.Drawing.Point(426, 317);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(48, 20);
            this.loginLbl.TabIndex = 12;
            this.loginLbl.Text = "Login";
            this.loginLbl.Click += new System.EventHandler(this.loginLbl_Click);
            // 
            // RegisterAdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registerAccBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.label1);
            this.Name = "RegisterAdminControl";
            this.Size = new System.Drawing.Size(840, 467);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button registerAccBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label loginLbl;
    }
}
