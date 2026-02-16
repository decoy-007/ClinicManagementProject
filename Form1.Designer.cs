namespace ClinicManagementProject
{
    partial class SignInForm
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
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.signUpLbl = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(191, 154);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(333, 26);
            this.emailTxt.TabIndex = 0;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(191, 200);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(333, 26);
            this.passwordTxt.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(191, 250);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(333, 37);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Clinic Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dont Have an Account? ";
            // 
            // signUpLbl
            // 
            this.signUpLbl.AutoSize = true;
            this.signUpLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.signUpLbl.Location = new System.Drawing.Point(367, 313);
            this.signUpLbl.Name = "signUpLbl";
            this.signUpLbl.Size = new System.Drawing.Size(66, 20);
            this.signUpLbl.TabIndex = 8;
            this.signUpLbl.Text = "Sign Up";
            this.signUpLbl.Click += new System.EventHandler(this.signUpLbl_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.signUpLbl);
            this.contentPanel.Controls.Add(this.label1);
            this.contentPanel.Controls.Add(this.label3);
            this.contentPanel.Controls.Add(this.loginBtn);
            this.contentPanel.Controls.Add(this.passwordTxt);
            this.contentPanel.Controls.Add(this.emailTxt);
            this.contentPanel.Location = new System.Drawing.Point(49, 27);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(698, 400);
            this.contentPanel.TabIndex = 9;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contentPanel);
            this.Name = "SignInForm";
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.SignInForm_Load);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label signUpLbl;
        private System.Windows.Forms.Panel contentPanel;
    }
}

