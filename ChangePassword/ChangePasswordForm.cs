using System;
using System.Windows.Forms;
using MySqlConnector;

namespace DCSSMeetingScheduler.ChangePassword
{
    public partial class ChangePasswordForm : Form
    {
        private string connectionString = "server=localhost;port=3306;database=dcss_db;uid=root;pwd=;";
        private int loggedInUserId = 1;

        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        public ChangePasswordForm(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
        }

        public ChangePasswordForm(int userId, string connStr)
        {
            InitializeComponent();
            loggedInUserId = userId;
            if (!string.IsNullOrEmpty(connStr))
            {
                connectionString = connStr;
            }
        }

        private void chkShowPassword_CheckedChanged(object? sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtCurrentPassword.UseSystemPasswordChar = false;
                txtNewPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtCurrentPassword.UseSystemPasswordChar = true;
                txtNewPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangePassword_Click(object? sender, EventArgs e)
        {
            string currentPassword = txtCurrentPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (currentPassword == "" || newPassword == "" || confirmPassword == "")
            {
                MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return;
            }

            if (currentPassword == newPassword)
            {
                MessageBox.Show("New password cannot be the same as your current password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string idColumn = "id";
                    string checkQuery = $"SELECT password FROM users WHERE {idColumn} = @id LIMIT 1";
                    string? storedPassword = null;

                    try
                    {
                        using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@id", loggedInUserId);
                            object? result = checkCmd.ExecuteScalar();
                            if (result != null)
                            {
                                storedPassword = result.ToString();
                            }
                        }
                    }
                    catch (MySqlException ex) when (ex.Number == 1054)
                    {
                        idColumn = "user_id";
                        string fallbackQuery = $"SELECT password FROM users WHERE {idColumn} = @id LIMIT 1";
                        using (MySqlCommand fallbackCmd = new MySqlCommand(fallbackQuery, conn))
                        {
                            fallbackCmd.Parameters.AddWithValue("@id", loggedInUserId);
                            object? result = fallbackCmd.ExecuteScalar();
                            if (result != null)
                            {
                                storedPassword = result.ToString();
                            }
                        }
                    }

                    if (storedPassword == null)
                    {
                        MessageBox.Show("User not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (currentPassword != storedPassword)
                    {
                        MessageBox.Show("Current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCurrentPassword.Focus();
                        return;
                    }

                    string updateQuery = $"UPDATE users SET password = @newPassword WHERE {idColumn} = @id";
                    using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@newPassword", newPassword);
                        updateCmd.Parameters.AddWithValue("@id", loggedInUserId);

                        int rows = updateCmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtCurrentPassword.Clear();
                            txtNewPassword.Clear();
                            txtConfirmPassword.Clear();

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to change password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
