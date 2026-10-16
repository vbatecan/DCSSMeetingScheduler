using DCSSMeetingScheduler.Shared;
using MySqlConnector;
using System;
using System.Windows.Forms;

namespace DCSSMeetingScheduler.Admin
{
    public partial class SaveUserForm : Form
    {
        public SaveUserForm()
        {
            InitializeComponent();
        }

        private void chkShowPassword_CheckedChanged(object? sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            lblErrorMessage.Text = "";

            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.SelectedItem != null ? cmbRole.SelectedItem.ToString()! : "";
            string idNumber = txtIdNumber.Text.Trim();
            string programOrDept = txtProgramOrDept.Text.Trim();
            bool isActive = chkIsActive.Checked;
            bool mustChangePassword = chkMustChangePassword.Checked;

            if (string.IsNullOrEmpty(firstName))
            {
                lblErrorMessage.Text = "Please enter the first name.";
                txtFirstName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(lastName))
            {
                lblErrorMessage.Text = "Please enter the last name.";
                txtLastName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                lblErrorMessage.Text = "Please enter the UE email.";
                txtEmail.Focus();
                return;
            }

            if (!LoginUtils.ValidateEmail(email))
            {
                lblErrorMessage.Text = "Please enter a valid UE email address (e.g. name@ue.edu.ph).";
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                lblErrorMessage.Text = "Please enter a password.";
                txtPassword.Focus();
                return;
            }

            if (!LoginUtils.ValidatePassword(password))
            {
                lblErrorMessage.Text = "Password must be at least 6 characters long.";
                txtPassword.Focus();
                return;
            }

            if (string.IsNullOrEmpty(role))
            {
                lblErrorMessage.Text = "Please select a user role.";
                cmbRole.Focus();
                return;
            }

            try
            {
                using (MySqlConnection conn = Connection.GetConnection())
                {
                    string checkQuery = "SELECT COUNT(*) FROM users WHERE ue_email = @email";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@email", email);
                        long count = Convert.ToInt64(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            lblErrorMessage.Text = "A user with this UE email already exists.";
                            txtEmail.Focus();
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO users (ue_email, user_password, first_name, last_name, role, id_number, program_or_dept, is_active, must_change_password) " +
                                         "VALUES (@email, @password, @firstName, @lastName, @role, @idNumber, @programOrDept, @isActive, @mustChangePassword)";

                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@email", email);
                        insertCmd.Parameters.AddWithValue("@password", password);
                        insertCmd.Parameters.AddWithValue("@firstName", firstName);
                        insertCmd.Parameters.AddWithValue("@lastName", lastName);
                        insertCmd.Parameters.AddWithValue("@role", role);
                        insertCmd.Parameters.AddWithValue("@idNumber", string.IsNullOrEmpty(idNumber) ? (object)DBNull.Value : idNumber);
                        insertCmd.Parameters.AddWithValue("@programOrDept", string.IsNullOrEmpty(programOrDept) ? (object)DBNull.Value : programOrDept);
                        insertCmd.Parameters.AddWithValue("@isActive", isActive ? 1 : 0);
                        insertCmd.Parameters.AddWithValue("@mustChangePassword", mustChangePassword ? 1 : 0);

                        int rowsAffected = insertCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            lblErrorMessage.Text = "Failed to save user. Please try again.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = "Database Error: " + ex.Message;
            }
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
