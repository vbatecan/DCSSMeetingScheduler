using DCSSMeetingScheduler.Shared;
using MySqlConnector;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DCSSMeetingScheduler
{
    public partial class SignUpForm : Form
    {
        public string RegisteredEmail { get; private set; } = string.Empty;

        public SignUpForm()
        {
            InitializeComponent();
            cmbRole.SelectedIndex = 0;
            cmbProgramOrDept.SelectedIndex = 0;
        }

        private void chkShowPassword_CheckedChanged(object? sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnSignUp_Click(object? sender, EventArgs e)
        {
            lblErrorMessage.Text = "";

            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string role = cmbRole.SelectedItem != null ? cmbRole.SelectedItem.ToString()! : "";
            string idNumber = txtIdNumber.Text.Trim();
            string programOrDept = cmbProgramOrDept.SelectedItem != null ? cmbProgramOrDept.SelectedItem.ToString()! : "";
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(firstName))
            {
                lblErrorMessage.Text = "Please enter your first name.";
                txtFirstName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(lastName))
            {
                lblErrorMessage.Text = "Please enter your last name.";
                txtLastName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                lblErrorMessage.Text = "Please enter your UE email.";
                txtEmail.Focus();
                return;
            }

            if (!LoginUtils.ValidateEmail(email))
            {
                lblErrorMessage.Text = "Please enter a valid UE email (e.g. name@ue.edu.ph).";
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrEmpty(role))
            {
                lblErrorMessage.Text = "Please select a role.";
                cmbRole.Focus();
                return;
            }

            if (string.IsNullOrEmpty(programOrDept))
            {
                lblErrorMessage.Text = "Please select a program or department.";
                cmbProgramOrDept.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                lblErrorMessage.Text = "Please enter a password.";
                txtPassword.Focus();
                return;
            }

            if (password.Length < 8)
            {
                lblErrorMessage.Text = "Password must be at least 8 characters long.";
                txtPassword.Focus();
                return;
            }

            if (password != confirmPassword)
            {
                lblErrorMessage.Text = "Passwords do not match.";
                txtConfirmPassword.Focus();
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
                            lblErrorMessage.Text = "An account with this UE email already exists.";
                            txtEmail.Focus();
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO users (ue_email, user_password, first_name, last_name, role, id_number, program_or_dept, is_active, must_change_password) " +
                                         "VALUES (@email, @password, @firstName, @lastName, @role, @idNumber, @programOrDept, 1, 0)";

                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@email", email);
                        insertCmd.Parameters.AddWithValue("@password", password);
                        insertCmd.Parameters.AddWithValue("@firstName", firstName);
                        insertCmd.Parameters.AddWithValue("@lastName", lastName);
                        insertCmd.Parameters.AddWithValue("@role", role);
                        insertCmd.Parameters.AddWithValue("@idNumber", string.IsNullOrEmpty(idNumber) ? (object)DBNull.Value : idNumber);
                        insertCmd.Parameters.AddWithValue("@programOrDept", string.IsNullOrEmpty(programOrDept) ? (object)DBNull.Value : programOrDept);

                        int rowsAffected = insertCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            RegisteredEmail = email;
                            MessageBox.Show("Account created successfully! You can now log in.", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        else
                        {
                            lblErrorMessage.Text = "Failed to create account. Please try again.";
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
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
