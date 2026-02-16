using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementProject
{
    public partial class DropReasonForm : Form
    {
        public string DropReason { get; set; }
        public DropReasonForm()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(reasonTxt.Text)) {
                MessageBox.Show("Please enter reason for dropping the patient");
                return;
            }

            DropReason = reasonTxt.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
