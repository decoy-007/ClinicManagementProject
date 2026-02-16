using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementProject
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
           
            loadForm(new DashForm());

        }

        // caching forms for faster performance
        private Dictionary<string, Form> formCache = new Dictionary<string, Form>();

        public void loadForm(Form form)
        {
            string key = form.GetType().Name;

            // Remove current form
            mainPanel.Controls.Clear();

            if (!formCache.ContainsKey(key))
            {
                formCache[key] = form;
            }

            Form cachedForm = formCache[key];

            // ALWAYS enforce these
            cachedForm.TopLevel = false;
            cachedForm.FormBorderStyle = FormBorderStyle.None;
            cachedForm.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(cachedForm);
            cachedForm.Show();
            cachedForm.BringToFront();
        }


        private void patientsLbl_Click(object sender, EventArgs e)
        {
            
            loadForm(new PatientsForm());

        }

        private void dashboardLbl_Click(object sender, EventArgs e)
        {
         
           loadForm(new DashForm());
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
           Application.Exit();
            
        }

        private void doctorsLbl_Click(object sender, EventArgs e)
        {
            loadForm(new DoctorsForm());
        }

        private void myAccLbl_Click(object sender, EventArgs e)
        {
            loadForm(new AccountForm());
        }

        private void activityLbl_Click(object sender, EventArgs e)
        {

            if (!formCache.ContainsKey("ActivityForm"))
            {
                ActivityForm af = new ActivityForm();
                formCache["ActivityForm"] = af;
                loadForm(af);
            }
            else
            {
                loadForm(formCache["ActivityForm"]);
                ((ActivityForm)formCache["ActivityForm"]).LoadActivity();
            }
        }
    }


}
