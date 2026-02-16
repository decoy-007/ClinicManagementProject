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
    public partial class DoctorsForm : Form
    {
        DataTable dtDoctors = new DataTable();
        DBaccess access = new DBaccess();
        public DoctorsForm()
        {
            InitializeComponent();
        }

        private void showDoctors()
        {
            dtDoctors.Clear(); 
            string query = "SELECT * FROM Doctor";
            access.readDatathroughAdapter(query, dtDoctors);

            doctorData.DataSource = dtDoctors;
        }

        //Future upgrade for admins only
        private void doctorData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DoctorsForm_Load(object sender, EventArgs e)
        {
            showDoctors();
        }
           
        // Future upgrade for admins only
        private void addDocBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
