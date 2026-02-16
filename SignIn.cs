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
    public partial class SignInForm : Form
    {
        DBaccess access = new DBaccess();
        DataTable dtAdmins = new DataTable();
        public SignInForm()
        {
            InitializeComponent();
        }


        private void SignInForm_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text.Trim();
            string password = passwordTxt.Text.Trim();

            try
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please type in all the field");
                    return;
                }
                else
                {
                    // Future upgrade Doctors will get their own  sign in page
                    string query = "SELECT * From Admins WHERE Email = '" + email + "'  AND Password ='" + password + "' ";
                    access.readDatathroughAdapter(query, dtAdmins);

                    if (dtAdmins.Rows.Count == 1)
                    {
                        MessageBox.Show("Logging in");
                        UserSession.Username = email;

                        this.Hide();
                        Dashboard db = new Dashboard();
                        db.Show();
                        access.closeConn();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect credentials");
                    }
                }
            }
            catch
            {
            }




        }

        private void signUpLbl_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            RegisterAdminControl registerAdmin = new RegisterAdminControl();
            registerAdmin.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(registerAdmin);


        }
    }
}
