using System;
using System.Windows.Forms;
using DCSSMeetingScheduler.Shared;
using MySqlConnector;

namespace DCSSMeetingScheduler.ChangePassword
{
    public partial class ChangePasswordForm : Form
    {
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
                using (MySqlConnection conn = Connection.GetConnection())
                {
                }

                MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCurrentPassword.Clear();
                txtNewPassword.Clear();
                txtConfirmPassword.Clear();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
