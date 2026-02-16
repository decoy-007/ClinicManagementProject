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
    public partial class DashForm : Form
    {
        DBaccess access = new DBaccess();

        private DashForm dashform;
        public DashForm()
        {
            InitializeComponent();
            usernameLbl.Text = UserSession.Username;

        }
        private void DashForm_Load(object sender, EventArgs e)
        {
            LoadDashBoard();
        }

        // Show the number of patients and doctors in the system
        private void LoadDashBoard()
        {
            totalDocLbl.Text = GetCount("SELECT COUNT(*) FROM Doctor").ToString();
            totalDropPatientsLbl.Text = GetCount("SELECT COUNT(*) FROM DroppedPatient").ToString();
            totalPatientsLbl.Text = GetCount("SELECT COUNT(*) FROM Patient WHERE Status = 'Active'").ToString();
            
        }

        private int GetCount(string query)
        {
            int count = 0;

            using (SqlCommand cmd = new SqlCommand(query, access.GetConnection()))
            {
                if (access.GetConnection().State == ConnectionState.Closed)
                    access.GetConnection().Open();

                count = (int)cmd.ExecuteScalar();
                access.closeConn();
            }

            return count;
        }

      
    }
}
