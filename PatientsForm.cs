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
    public partial class PatientsForm : Form
    {
        DataTable dtPatients =  new DataTable();
        DataTable dtPatientsDropped = new DataTable();
        DataTable dtPatientGroups = new DataTable();
        DataTable dtPatientVisits = new DataTable();
        DataTable dtPatientSymptoms = new DataTable();
        DataTable dtPatientGroupAssignment = new DataTable();
        AddPatientControl addPatientControl = new AddPatientControl();
        PatientVisitControl patientVisitControl = new PatientVisitControl();
       
        DBaccess access = new DBaccess();
        public PatientsForm()
        {
            InitializeComponent();
            InitializeAddPatientControl();
            InitializeAddPatientVisitControl();
         
        }
        private void PatientsForm_Load(object sender, EventArgs e)
        {
            showPatients();
            showDroppedPatients();
            showPatientGroups();
            showPatientVisits();
            showPatientSymptoms();
            showPatientGroupAssignments();
        }

        private void InitializeAddPatientControl()
        {
            addPatientControl.Dock = DockStyle.Fill;
            addPatientControl.Visible = false;

            addPatientControl.PatientAdded += AddPatientControl_PatientAdded;
            addPatientControl.Cancelled += AddPatientControl_Cancelled;
            this.Controls.Add(addPatientControl);
        }
        private void InitializeAddPatientVisitControl()
        {
            patientVisitControl.Dock = DockStyle.Fill;
            patientVisitControl.Visible = false;

            patientVisitControl.PatientAdded += PatientVisitControl_PatientAdded;
            patientVisitControl.Cancelled += PatientVisitControl_Cancelled;
            this.Controls.Add(patientVisitControl);
        }

        private void PatientVisitControl_Cancelled(object sender, EventArgs e)
        {
          patientVisitControl.Visible=false;
            patientVisitData.Visible=true;
        }

        private void PatientVisitControl_PatientAdded(object sender, EventArgs e)
        {
            patientVisitControl.Visible =false;
            patientVisitData.Visible=true;
            showPatientVisits();

        }

        private void AddPatientControl_Cancelled(object sender, EventArgs e)
        {
            addPatientControl.Visible = false;
            patientsData.Visible = true;
          
        }

        private void AddPatientControl_PatientAdded(object sender, EventArgs e)
        {
            showPatients();
            showDroppedPatients();

            addPatientControl.Visible = false ; 
            patientsData.Visible = true ;
            
        }

        private void showPatients()
        {
            dtPatients.Clear();
            string query = "SELECT * FROM Patient WHERE Status = 'Active'";
            access.readDatathroughAdapter(query, dtPatients);

            patientsData.DataSource = dtPatients;
        }
        private void showDroppedPatients()
        {
            dtPatientsDropped.Clear();
            string query = "SELECT * FROM DroppedPatient";
            access.readDatathroughAdapter(query,dtPatientsDropped);
            patientsDroppedData.DataSource = dtPatientsDropped;
        }
        private void showPatientGroups()
        {
            dtPatientGroups.Clear();
            string query = "SELECT *FROM Groups ";
            access.readDatathroughAdapter(query,dtPatientGroups);

            patientGroupsData.DataSource = dtPatientGroups;
        }
        private void showPatientVisits()
        {
            dtPatientVisits.Clear();
            string query = "SELECT * FROM PatientVisits";
            access.readDatathroughAdapter(query ,dtPatientVisits);

            patientVisitData.DataSource = dtPatientVisits;
        }
        private void showPatientSymptoms()
        {
            dtPatientSymptoms.Clear();
            string query = "SELECT *FROM PatientVisitSymptoms";
            access.readDatathroughAdapter (query ,dtPatientSymptoms);
            patientSymptomsData.DataSource = dtPatientSymptoms;
        }
        private void showPatientGroupAssignments()
        {
            dtPatientGroupAssignment.Clear();
            string query = "SELECT * FROM PatientGroupAssignment";
            access.readDatathroughAdapter(query, dtPatientGroupAssignment);

            groupAssignData.DataSource = dtPatientGroupAssignment;
        }

        private void addPatientBtn_Click(object sender, EventArgs e)
        {


            patientsData.Visible = false;
            addPatientControl.Visible = true;
            addPatientControl.BringToFront();
        }

            // Search Bar
        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            string filter = searchTxt.Text.Trim();

            if (string.IsNullOrEmpty(filter)) {
                dtPatients.DefaultView.RowFilter = string.Empty;
                patientsData.DataSource = dtPatients;

            }
            else
            {
                DataView dv = dtPatients.DefaultView;
                dv.RowFilter = $"Convert(PatientKey, 'System.String') LIKE '%{filter}%' " +
                               $"OR FirstName LIKE '%{filter}%' " +
                               $"OR LastName LIKE '%{filter}%' " +
                               $"OR PhoneNumber LIKE '%{filter}%'";
                patientsData.DataSource = dv;
            }

        }
         // Search bar for patientId only
        private void txtSearchDropped_TextChanged(object sender, EventArgs e)
        {
            string filter = txtSearchDropped.Text.Trim();
             if (string.IsNullOrEmpty(filter))
           
                {
                    dtPatientsDropped.DefaultView.RowFilter = string.Empty;
                    patientsDroppedData.DataSource = dtPatientsDropped;
            }
            else
            {
                DataView dv = dtPatientsDropped.DefaultView;
                dv.RowFilter = $"Convert(PatientKey, 'System.String') LIKE '%{filter}%' ";
                patientsDroppedData.DataSource = dv;
            }
        }
        // Add patient to droppedPatient table 
        private void dropPatientBtn_Click(object sender, EventArgs e)
        {
            if (patientsData.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a Patient to drop");
                return; 
            }
            DropReasonForm dropReasonForm = new DropReasonForm();
            if(dropReasonForm.ShowDialog() != DialogResult.OK)
                return;
            
            string dropReason = dropReasonForm.DropReason;
            string droppedBy = UserSession.Username;
            
            int patientKey = Convert.ToInt32(patientsData.SelectedRows[0].Cells["PatientKey"].Value);
            string date = DateTime.Now.ToString("dddd,dd MMMM yyyy HH:mm");

            string query = "INSERT INTO DroppedPatient (PatientKey,DateDropped,ReasonDropped,DroppedBy)" +
                "VALUES(@pk,@dd,@rd,@db)";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@pk",patientKey);
            command.Parameters.AddWithValue("@dd",DateTime.Now);
            command.Parameters.AddWithValue("@rd",dropReason);
            command.Parameters.AddWithValue("@db",droppedBy);

            access.executeQuery(command);

            // Update patient table to set patient status to dropped 
            string UpdateQuery = "UPDATE Patient SET Status = 'Dropped' WHERE PatientKey = @pk";
            SqlCommand cmd = new SqlCommand(UpdateQuery);
            cmd.Parameters.AddWithValue("@pk", patientKey);
            access.executeQuery(cmd);

            showPatients();
            showDroppedPatients();

            MessageBox.Show($"Successfully Dropped by {droppedBy}.");
            LogActivity("Patient Dropped" , patientKey);
        }

        // Activity log tab
        public void LogActivity(string actionType, int patientKey)
        {
            string query =
                "INSERT INTO ActivityLog (ActionType, PatientKey, PerformedBy) " +
                "VALUES (@action, @pk, @by)";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@action", actionType);
            command.Parameters.AddWithValue("@pk", patientKey);
            command.Parameters.AddWithValue("@by", UserSession.Username);

            access.executeQuery(command);
        }



        private void addPatientVisitBtn_Click(object sender, EventArgs e)
        {
            patientVisitData.Visible = false;
            patientVisitControl.Visible = true;
            patientVisitControl.BringToFront();
        }

        private void txtSearchVisit_TextChanged(object sender, EventArgs e)
        {
            string filter = txtSearchVisit.Text.Trim();
            if (string.IsNullOrEmpty(filter))
            {
                dtPatientVisits.DefaultView.RowFilter = string.Empty;
                patientVisitData.DataSource = dtPatientVisits;
            }
            else
            {
                DataView dv = dtPatientVisits.DefaultView;
                dv.RowFilter = $"Convert(PatientKey ,'System.String') LIKE '%{filter}%'";
                patientVisitData.DataSource= dv;
            }
        }

        private void addGroupBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
