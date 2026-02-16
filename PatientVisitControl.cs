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
    public partial class PatientVisitControl : UserControl
    {
        DBaccess access = new DBaccess();
        public event EventHandler PatientAdded;
        public event EventHandler Cancelled;
        public PatientVisitControl()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string date = DateTime.Now.ToString("yyyy MMMM dd ");
                string query = "INSERT INTO PatientVisits(PatientKey,VisitDate,BloodPressure,Weight,Pulse,DepressionLevel,DoctorNotes)" +
                    "VALUES(@pk,@vd,@bp,@wht,@pls,@dl,@dn)";// prevent SQL injection 
                
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@pk", pkTxt.Text);
                cmd.Parameters.AddWithValue("@vd", DateTime.Now);
                cmd.Parameters.AddWithValue("@bp", bpTxt.Text);
                cmd.Parameters.AddWithValue("@wht",weightTxt.Text);
                cmd.Parameters.AddWithValue("@pls",pulseTxt.Text);
                cmd.Parameters.AddWithValue("@dl",dlTxt.Text);
                cmd.Parameters.AddWithValue("@dn", dnTxt.Text);

                int rows  = access.executeQuery(cmd);
                if (rows > 0) {
                    MessageBox.Show("Patient Visit Saved");
                    PatientAdded?.Invoke(this,EventArgs.Empty);
                    clearFields();
                }
                else
                {
                    MessageBox.Show("Something went wrong Patient Visit NOT saved");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Cancelled? .Invoke(this, EventArgs.Empty);
            clearFields();
        }

        private void clearFields()
        {
            pkTxt.Clear();
            dnTxt.Clear();
            weightTxt.Clear();
            bpTxt.Clear();
            dlTxt.Clear();
            pulseTxt.Clear();

        }
    }
}
