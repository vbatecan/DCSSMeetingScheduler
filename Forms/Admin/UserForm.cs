using DCSSMeetingScheduler.Shared;
using MySqlConnector;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DCSSMeetingScheduler.Admin
{
    public partial class UserForm : Form
    {
        private int userIdToUpdate;
        private bool isEditMode;

        public UserForm()
        {
            InitializeComponent();
            isEditMode = false;
            userIdToUpdate = 0;
            Text = "Save User - DCSS Meeting Scheduler";
            lblTitle.Text = "Add New User";
            lblSubtitle.Text = "Enter account details to create a new user";
            btnSubmit.Text = "Save User";
            btnSubmit.BackColor = Color.FromArgb(85, 121, 69);
        }

        public UserForm(int userId)
        {
            InitializeComponent();
            isEditMode = true;
            userIdToUpdate = userId;
            Text = "Update User - DCSS Meeting Scheduler";
            lblTitle.Text = "Update User";
            lblSubtitle.Text = "Modify user account details below";
            lblPassword.Text = "New Password";
            txtPassword.PlaceholderText = "Leave empty to keep current password";
            btnSubmit.Text = "Update User";
            btnSubmit.BackColor = Color.CornflowerBlue;
            chkIsActive.Checked = false;
            chkMustChangePassword.Checked = false;
        }

        private void UserForm_Load(object? sender, EventArgs e)
        {
            if (isEditMode && userIdToUpdate > 0)
            {
                try
                {
                    using (MySqlConnection conn = Connection.GetConnection())
                    {
                        string selectQuery = "SELECT * FROM users WHERE user_id = @id";
                        using (MySqlCommand cmd = new MySqlCommand(selectQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", userIdToUpdate);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtFirstName.Text = reader.GetString("first_name");
                                    txtLastName.Text = reader.GetString("last_name");
                                    txtEmail.Text = reader.GetString("ue_email");

                                    string userRole = reader.GetString("role");
                                    cmbRole.SelectedItem = userRole;

                                    int idNumberIndex = reader.GetOrdinal("id_number");
                                    if (!reader.IsDBNull(idNumberIndex))
                                    {
                                        txtIdNumber.Text = reader.GetString(idNumberIndex);
                                    }

                                    int programOrDeptIndex = reader.GetOrdinal("program_or_dept");
                                    if (!reader.IsDBNull(programOrDeptIndex))
                                    {
                                        txtProgramOrDept.Text = reader.GetString(programOrDeptIndex);
                                    }

                                    chkIsActive.Checked = reader.GetBoolean("is_active");
                                    chkMustChangePassword.Checked = reader.GetBoolean("must_change_password");

                                    lblSubtitle.Text = "Editing account for: " + txtFirstName.Text + " " + txtLastName.Text;
                                }
                                else
                                {
                                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    Close();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading user: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
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

        private void btnSubmit_Click(object? sender, EventArgs e)
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

            if (!isEditMode)
            {
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
            }
            else
            {
                if (!string.IsNullOrEmpty(password) && !LoginUtils.ValidatePassword(password))
                {
                    lblErrorMessage.Text = "New password must be at least 6 characters long.";
                    txtPassword.Focus();
                    return;
                }
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
                    string checkQuery = "SELECT COUNT(*) FROM users WHERE ue_email = @email AND user_id != @id";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@email", email);
                        checkCmd.Parameters.AddWithValue("@id", userIdToUpdate);
                        long count = Convert.ToInt64(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            lblErrorMessage.Text = "A user with this UE email already exists.";
                            txtEmail.Focus();
                            return;
                        }
                    }

                    string query;
                    if (!isEditMode)
                    {
                        query = "INSERT INTO users (ue_email, user_password, first_name, last_name, role, id_number, program_or_dept, is_active, must_change_password) " +
                                "VALUES (@email, @password, @firstName, @lastName, @role, @idNumber, @programOrDept, @isActive, @mustChangePassword)";
                    }
                    else if (!string.IsNullOrEmpty(password))
                    {
                        query = "UPDATE users SET ue_email = @email, user_password = @password, first_name = @firstName, last_name = @lastName, " +
                                "role = @role, id_number = @idNumber, program_or_dept = @programOrDept, is_active = @isActive, must_change_password = @mustChangePassword " +
                                "WHERE user_id = @id";
                    }
                    else
                    {
                        query = "UPDATE users SET ue_email = @email, first_name = @firstName, last_name = @lastName, " +
                                "role = @role, id_number = @idNumber, program_or_dept = @programOrDept, is_active = @isActive, must_change_password = @mustChangePassword " +
                                "WHERE user_id = @id";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        if (!isEditMode || !string.IsNullOrEmpty(password))
                        {
                            cmd.Parameters.AddWithValue("@password", password);
                        }
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@idNumber", string.IsNullOrEmpty(idNumber) ? (object)DBNull.Value : idNumber);
                        cmd.Parameters.AddWithValue("@programOrDept", string.IsNullOrEmpty(programOrDept) ? (object)DBNull.Value : programOrDept);
                        cmd.Parameters.AddWithValue("@isActive", isActive ? 1 : 0);
                        cmd.Parameters.AddWithValue("@mustChangePassword", mustChangePassword ? 1 : 0);
                        if (isEditMode)
                        {
                            cmd.Parameters.AddWithValue("@id", userIdToUpdate);
                        }

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            string successMessage = isEditMode ? "User updated successfully!" : "User saved successfully!";
                            MessageBox.Show(successMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        else
                        {
                            lblErrorMessage.Text = isEditMode ? "No changes were made or user was not found." : "Failed to save user. Please try again.";
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
