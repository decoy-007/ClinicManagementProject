using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementProject
{
    public partial class AddPatientControl : UserControl
    {
        DBaccess access = new DBaccess();
        public event EventHandler PatientAdded;
        public event EventHandler Cancelled;
        public AddPatientControl()
        {
            InitializeComponent();
        }
        private void LogActivity(string actionType, int patientKey)
        {
            string query =
                "INSERT INTO ActivityLog (ActionType, PatientKey, PerformedBy) " +
                "VALUES (@action, @pk, @by)";

            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@action", actionType);
            cmd.Parameters.AddWithValue("@pk", patientKey);
            cmd.Parameters.AddWithValue("@by", UserSession.Username);

            access.executeQuery(cmd);
        }

        // Check if patientID is in droppedPatient
        private bool PatientExists(int patientKey)
        {
            string query = $"SELECT COUNT (*) FROM DroppedPatient WHERE PatientKey =@pk";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@pk", patientKey);
            access.createConn();
            cmd.Connection = access.GetConnection();

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            access.closeConn();
            return count > 0;

        }

        // If patientId exists in DroppedPatient execute this
        private void RestorePatient(int patientKey)
        {
            string query = "UPDATE Patient SET Status = 'Active' WHERE PatientKey = @pk";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@pk", patientKey);

            access.executeQuery(cmd);

            string deleteDropped =
                "DELETE FROM DroppedPatient WHERE PatientKey = @pk";
            SqlCommand delCmd = new SqlCommand(deleteDropped);
            delCmd.Parameters.AddWithValue("@pk", patientKey);

            access.executeQuery(delCmd);

            LogActivity("Restored", patientKey);
            
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int patientKey = Convert.ToInt32(pkTxt.Text);

                // CHECK DROPPED PATIENT
                if (PatientExists(patientKey))
                {
                    DialogResult result = MessageBox.Show(
                        "This patient was previously dropped.\nDo you want to restore them?",
                        "Restore Patient",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        RestorePatient(patientKey);

                        MessageBox.Show("Patient restored successfully.");
                        ClearFields();
                        PatientAdded?.Invoke(this, EventArgs.Empty);
                        LogActivity("Patient Restored",patientKey);
                    }

                    return; 
                }

                // ADD Patient
                string query =
                    "INSERT INTO Patient (PatientKey, DoctorKey, FirstName, MiddleName, LastName, PhoneNumber) " +
                    "VALUES (@pk, @dk, @fn, @mn, @ln, @celln)";

                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@pk", patientKey);
                cmd.Parameters.AddWithValue("@dk", dkTxt.Text);
                cmd.Parameters.AddWithValue("@fn", fnTxt.Text);
                cmd.Parameters.AddWithValue("@mn", mnTxt.Text);
                cmd.Parameters.AddWithValue("@ln", lnTxt.Text);
                cmd.Parameters.AddWithValue("@celln", pnTxt.Text);

                int rows = access.executeQuery(cmd);

                if (rows > 0)
                {
                    MessageBox.Show("Patient added successfully.");
                    ClearFields();
                    PatientAdded?.Invoke(this, EventArgs.Empty);

                    LogActivity("Patient Added", patientKey);
                }
                else
                {
                    MessageBox.Show("Failed to add patient.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
           
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Cancelled?.Invoke(this, EventArgs.Empty);
            ClearFields() ;
        }
        private void ClearFields()
        {
            pkTxt.Clear();
            dkTxt.Clear();
            fnTxt.Clear();
            lnTxt.Clear();
            pnTxt.Clear();
            mnTxt.Clear();
            pkTxt.Focus();
        }
    }
}
