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
    public partial class ActivityForm : Form
    {
        DBaccess access =  new DBaccess();
        DataTable dtActivity = new DataTable();
        public ActivityForm()
        {
            InitializeComponent();
        }

        private void ActivityForm_Load(object sender, EventArgs e)
        {
            LoadActivity();
        }

        // show any changes on activity log tab
        public void LoadActivity()
        {
            dtActivity.Clear();

            string query = "SELECT ActionType ,PatientKey ,PerformedBy,ActionDate " +
                "FROM ActivityLog ORDER BY ActionDate DESC";

            access.readDatathroughAdapter(query, dtActivity);
            activityDataGrid.DataSource = dtActivity;

            activityDataGrid.Columns["ActionDate"].DefaultCellStyle.Format = "dd MMM yyyy HH:mm";
        }
    }
}
