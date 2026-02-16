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
    public partial class RegisterAdminControl : UserControl
    {
        public string name, lastName, email, password;
        DBaccess access = new DBaccess();
        

  
        // Register admin page , future upgrade add one for doctors 
        public RegisterAdminControl()
        {
            InitializeComponent();
        }

        private void loginLbl_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null) { 
                parentForm.Hide(); 

                SignInForm signInForm = new SignInForm();
                signInForm.Show();


            }
            
        }


        private void registerAccBtn_Click(object sender, EventArgs e)
        {
            name = firstNameTxt.Text;
            lastName = lastNameTxt.Text;
            email = emailTxt.Text;
            password = passwordTxt.Text;

            try
            {
                if (string.IsNullOrEmpty(name) ||
                    string.IsNullOrEmpty(lastName) ||
                    string.IsNullOrEmpty(email) ||
                    string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter all fields");
                    return;
                }
                else
                {
                    SqlCommand cmdRegisterAdmin = new SqlCommand(
                       "INSERT INTO Admins(FirstName,LastName,Email,Password)" +
                       "VALUES(@firstname,@lastname,@email,@password)");

                    cmdRegisterAdmin.Parameters.AddWithValue("@firstname", name);
                    cmdRegisterAdmin.Parameters.AddWithValue("@lastname", lastName);
                    cmdRegisterAdmin.Parameters.AddWithValue("@email", email);
                    cmdRegisterAdmin.Parameters.AddWithValue("@password", password);

                    int rows = access.executeQuery(cmdRegisterAdmin);
                    if (rows == 1 )
                    {
                        MessageBox.Show("Successfully Registered Account");

                        Form parentForm = this.FindForm();
                        if (parentForm != null)
                        {
                            parentForm.Hide();
                        }
                        SignInForm signInForm = new SignInForm();
                        signInForm.Show();
                        access.closeConn();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong failed to Register Account");
                    }
                }
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }

            } 
    }
}