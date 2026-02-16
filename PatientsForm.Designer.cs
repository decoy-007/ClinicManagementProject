namespace ClinicManagementProject
{
    partial class PatientsForm
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
            this.patientControlTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dropPatientBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.addPatientBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.patientsData = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearchDropped = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.patientsDroppedData = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.addGroupBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.patientGroupsData = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchVisit = new System.Windows.Forms.TextBox();
            this.addPatientVisitBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.patientVisitData = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.patientSymptomsData = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupAssignData = new System.Windows.Forms.DataGridView();
            this.patientControlTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsData)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDroppedData)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientGroupsData)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitData)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientSymptomsData)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupAssignData)).BeginInit();
            this.SuspendLayout();
            // 
            // patientControlTab
            // 
            this.patientControlTab.Controls.Add(this.tabPage1);
            this.patientControlTab.Controls.Add(this.tabPage2);
            this.patientControlTab.Controls.Add(this.tabPage3);
            this.patientControlTab.Controls.Add(this.tabPage4);
            this.patientControlTab.Controls.Add(this.tabPage5);
            this.patientControlTab.Controls.Add(this.tabPage6);
            this.patientControlTab.Location = new System.Drawing.Point(1, 64);
            this.patientControlTab.Name = "patientControlTab";
            this.patientControlTab.SelectedIndex = 0;
            this.patientControlTab.Size = new System.Drawing.Size(798, 386);
            this.patientControlTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dropPatientBtn);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.searchTxt);
            this.tabPage1.Controls.Add(this.addPatientBtn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.patientsData);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Patients";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dropPatientBtn
            // 
            this.dropPatientBtn.Location = new System.Drawing.Point(225, 6);
            this.dropPatientBtn.Name = "dropPatientBtn";
            this.dropPatientBtn.Size = new System.Drawing.Size(132, 51);
            this.dropPatientBtn.TabIndex = 5;
            this.dropPatientBtn.Text = "Drop Patient";
            this.dropPatientBtn.UseVisualStyleBackColor = true;
            this.dropPatientBtn.Click += new System.EventHandler(this.dropPatientBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Search Patient";
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(419, 31);
            this.searchTxt.Multiline = true;
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(207, 26);
            this.searchTxt.TabIndex = 3;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // addPatientBtn
            // 
            this.addPatientBtn.Location = new System.Drawing.Point(651, 6);
            this.addPatientBtn.Name = "addPatientBtn";
            this.addPatientBtn.Size = new System.Drawing.Size(132, 51);
            this.addPatientBtn.TabIndex = 2;
            this.addPatientBtn.Text = "Add Patient";
            this.addPatientBtn.UseVisualStyleBackColor = true;
            this.addPatientBtn.Click += new System.EventHandler(this.addPatientBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patients";
            // 
            // patientsData
            // 
            this.patientsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsData.Location = new System.Drawing.Point(0, 78);
            this.patientsData.Name = "patientsData";
            this.patientsData.RowHeadersWidth = 62;
            this.patientsData.RowTemplate.Height = 28;
            this.patientsData.Size = new System.Drawing.Size(790, 272);
            this.patientsData.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtSearchDropped);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.patientsDroppedData);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Patients Dropped";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(366, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Search Patient";
            // 
            // txtSearchDropped
            // 
            this.txtSearchDropped.Location = new System.Drawing.Point(370, 29);
            this.txtSearchDropped.Multiline = true;
            this.txtSearchDropped.Name = "txtSearchDropped";
            this.txtSearchDropped.Size = new System.Drawing.Size(207, 26);
            this.txtSearchDropped.TabIndex = 6;
            this.txtSearchDropped.TextChanged += new System.EventHandler(this.txtSearchDropped_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(651, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 51);
            this.button2.TabIndex = 5;
            this.button2.Text = "Print List";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Patients Dropped";
            // 
            // patientsDroppedData
            // 
            this.patientsDroppedData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDroppedData.Location = new System.Drawing.Point(0, 76);
            this.patientsDroppedData.Name = "patientsDroppedData";
            this.patientsDroppedData.RowHeadersWidth = 62;
            this.patientsDroppedData.RowTemplate.Height = 28;
            this.patientsDroppedData.Size = new System.Drawing.Size(790, 272);
            this.patientsDroppedData.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.addGroupBtn);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.patientGroupsData);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(790, 353);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Patient Groups";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // addGroupBtn
            // 
            this.addGroupBtn.Location = new System.Drawing.Point(651, 4);
            this.addGroupBtn.Name = "addGroupBtn";
            this.addGroupBtn.Size = new System.Drawing.Size(132, 51);
            this.addGroupBtn.TabIndex = 5;
            this.addGroupBtn.Text = "Add Patient Group";
            this.addGroupBtn.UseVisualStyleBackColor = true;
            this.addGroupBtn.Click += new System.EventHandler(this.addGroupBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Patients";
            // 
            // patientGroupsData
            // 
            this.patientGroupsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientGroupsData.Location = new System.Drawing.Point(0, 76);
            this.patientGroupsData.Name = "patientGroupsData";
            this.patientGroupsData.RowHeadersWidth = 62;
            this.patientGroupsData.RowTemplate.Height = 28;
            this.patientGroupsData.Size = new System.Drawing.Size(790, 272);
            this.patientGroupsData.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.txtSearchVisit);
            this.tabPage4.Controls.Add(this.addPatientVisitBtn);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.patientVisitData);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(790, 353);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Patient Visits";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(354, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Search Patient";
            // 
            // txtSearchVisit
            // 
            this.txtSearchVisit.Location = new System.Drawing.Point(358, 29);
            this.txtSearchVisit.Multiline = true;
            this.txtSearchVisit.Name = "txtSearchVisit";
            this.txtSearchVisit.Size = new System.Drawing.Size(207, 26);
            this.txtSearchVisit.TabIndex = 8;
            this.txtSearchVisit.TextChanged += new System.EventHandler(this.txtSearchVisit_TextChanged);
            // 
            // addPatientVisitBtn
            // 
            this.addPatientVisitBtn.Location = new System.Drawing.Point(651, 4);
            this.addPatientVisitBtn.Name = "addPatientVisitBtn";
            this.addPatientVisitBtn.Size = new System.Drawing.Size(132, 51);
            this.addPatientVisitBtn.TabIndex = 5;
            this.addPatientVisitBtn.Text = "Add Patient Visit";
            this.addPatientVisitBtn.UseVisualStyleBackColor = true;
            this.addPatientVisitBtn.Click += new System.EventHandler(this.addPatientVisitBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Patients";
            // 
            // patientVisitData
            // 
            this.patientVisitData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientVisitData.Location = new System.Drawing.Point(0, 76);
            this.patientVisitData.Name = "patientVisitData";
            this.patientVisitData.RowHeadersWidth = 62;
            this.patientVisitData.RowTemplate.Height = 28;
            this.patientVisitData.Size = new System.Drawing.Size(790, 272);
            this.patientVisitData.TabIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button5);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.patientSymptomsData);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(790, 353);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Patient Symptoms";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(651, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 51);
            this.button5.TabIndex = 5;
            this.button5.Text = "Add Patient Symptoms";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Patients";
            // 
            // patientSymptomsData
            // 
            this.patientSymptomsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientSymptomsData.Location = new System.Drawing.Point(0, 76);
            this.patientSymptomsData.Name = "patientSymptomsData";
            this.patientSymptomsData.RowHeadersWidth = 62;
            this.patientSymptomsData.RowTemplate.Height = 28;
            this.patientSymptomsData.Size = new System.Drawing.Size(790, 272);
            this.patientSymptomsData.TabIndex = 3;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.button6);
            this.tabPage6.Controls.Add(this.label6);
            this.tabPage6.Controls.Add(this.groupAssignData);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(790, 353);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Group Assignment";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(651, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 51);
            this.button6.TabIndex = 5;
            this.button6.Text = "Add Group Assignment";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Group Assignment";
            // 
            // groupAssignData
            // 
            this.groupAssignData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupAssignData.Location = new System.Drawing.Point(0, 76);
            this.groupAssignData.Name = "groupAssignData";
            this.groupAssignData.RowHeadersWidth = 62;
            this.groupAssignData.RowTemplate.Height = 28;
            this.groupAssignData.Size = new System.Drawing.Size(790, 272);
            this.groupAssignData.TabIndex = 3;
            // 
            // PatientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.patientControlTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientsForm";
            this.Text = "PatientsForm";
            this.Load += new System.EventHandler(this.PatientsForm_Load);
            this.patientControlTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsData)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDroppedData)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientGroupsData)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitData)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientSymptomsData)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupAssignData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl patientControlTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView patientsData;
        private System.Windows.Forms.Button addPatientBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView patientsDroppedData;
        private System.Windows.Forms.Button addGroupBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView patientGroupsData;
        private System.Windows.Forms.Button addPatientVisitBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView patientVisitData;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView patientSymptomsData;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView groupAssignData;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearchDropped;
        private System.Windows.Forms.Button dropPatientBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchVisit;
    }
}