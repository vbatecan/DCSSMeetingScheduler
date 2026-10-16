using DCSSMeetingScheduler.Shared;
using MySqlConnector;
using System;
using System.Windows.Forms;

namespace DCSSMeetingScheduler.Admin
{
    public partial class UpdateUserForm : Form
    {
        private int userIdToUpdate;

        public UpdateUserForm()
        {
            InitializeComponent();
        }

        public UpdateUserForm(int userId)
        {
            InitializeComponent();
            userIdToUpdate = userId;
        }

        private void UpdateUserForm_Load(object? sender, EventArgs e)
        {
            if (userIdToUpdate <= 0)
            {
                return;
            }

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
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
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

        private void btnUpdate_Click(object? sender, EventArgs e)
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

            if (!string.IsNullOrEmpty(password) && !LoginUtils.ValidatePassword(password))
            {
                lblErrorMessage.Text = "New password must be at least 6 characters long.";
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

                    string updateQuery;
                    if (!string.IsNullOrEmpty(password))
                    {
                        updateQuery = "UPDATE users SET ue_email = @email, user_password = @password, first_name = @firstName, last_name = @lastName, " +
                                      "role = @role, id_number = @idNumber, program_or_dept = @programOrDept, is_active = @isActive, must_change_password = @mustChangePassword " +
                                      "WHERE user_id = @id";
                    }
                    else
                    {
                        updateQuery = "UPDATE users SET ue_email = @email, first_name = @firstName, last_name = @lastName, " +
                                      "role = @role, id_number = @idNumber, program_or_dept = @programOrDept, is_active = @isActive, must_change_password = @mustChangePassword " +
                                      "WHERE user_id = @id";
                    }

                    using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@email", email);
                        if (!string.IsNullOrEmpty(password))
                        {
                            updateCmd.Parameters.AddWithValue("@password", password);
                        }
                        updateCmd.Parameters.AddWithValue("@firstName", firstName);
                        updateCmd.Parameters.AddWithValue("@lastName", lastName);
                        updateCmd.Parameters.AddWithValue("@role", role);
                        updateCmd.Parameters.AddWithValue("@idNumber", string.IsNullOrEmpty(idNumber) ? (object)DBNull.Value : idNumber);
                        updateCmd.Parameters.AddWithValue("@programOrDept", string.IsNullOrEmpty(programOrDept) ? (object)DBNull.Value : programOrDept);
                        updateCmd.Parameters.AddWithValue("@isActive", isActive ? 1 : 0);
                        updateCmd.Parameters.AddWithValue("@mustChangePassword", mustChangePassword ? 1 : 0);
                        updateCmd.Parameters.AddWithValue("@id", userIdToUpdate);

                        int rowsAffected = updateCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            lblErrorMessage.Text = "No changes were made or user was not found.";
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
