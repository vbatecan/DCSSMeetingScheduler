using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DCSSMeetingScheduler;
using DCSSMeetingScheduler.Shared;
using MySqlConnector;

namespace DCSSMeetingScheduler.Faculty
{
    public partial class Faculty : Form
    {
        private User? loggedInUser = null;

        public Faculty()
        {
            InitializeComponent();
        }

        public Faculty(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void Faculty_Load(object sender, EventArgs e)
        {
            LoadFacultyProfile();
            LoadApplicationInfo();
            InitializePreferences();
        }

        private void LoadFacultyProfile()
        {
            if (loggedInUser == null)
            {
                try
                {
                    using (MySqlConnection conn = Connection.GetConnection())
                    {
                        string query = "SELECT * FROM users WHERE role = 'Faculty' LIMIT 1";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    loggedInUser = User.FromReader(reader);
                                }
                            }
                        }
                    }
                }
                catch
                {
                }
            }

            if (loggedInUser != null)
            {
                txtFacultyName.Text = loggedInUser.FirstName + " " + loggedInUser.LastName;
                txtFacultyEmail.Text = loggedInUser.UeEmail;
                txtDepartment.Text = loggedInUser.ProgramOrDept;
                txtPosition.Text = loggedInUser.Role.ToString();
            }
        }

        private void LoadApplicationInfo()
        {
            lblVersionValue.Text = "1.0.0";
            lblDatabaseValue.Text = "Connected (dcss_db)";
            lblLastLoginValue.Text = DateTime.Now.ToString("MMM dd, yyyy hh:mm tt");
        }

        private void InitializePreferences()
        {
            cmbTheme.Items.Clear();
            cmbTheme.Items.Add("Default (Green)");
            cmbTheme.Items.Add("Light");
            cmbTheme.Items.Add("Dark");
            cmbTheme.SelectedIndex = 0;

            cmbDefaultTab.Items.Clear();
            cmbDefaultTab.Items.Add("Home");
            cmbDefaultTab.Items.Add("Request");
            cmbDefaultTab.Items.Add("Availability");
            cmbDefaultTab.Items.Add("Setting");
            cmbDefaultTab.SelectedIndex = 0;

            chkEmailNotif.Checked = true;
            chkDesktopNotif.Checked = true;
            chkConsultationReminder.Checked = true;
            chkShowRequestDashboard.Checked = true;
            chkShowRecentRequestDashboard.Checked = true;
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            if (btnEditProfile.Text == "Edit Profile")
            {
                txtFacultyName.ReadOnly = false;
                txtDepartment.ReadOnly = false;
                txtFacultyName.Focus();
                btnEditProfile.Text = "Save Profile";
                btnEditProfile.BackColor = Color.ForestGreen;
            }
            else if (btnEditProfile.Text == "Save Profile")
            {
                string fullName = txtFacultyName.Text.Trim();
                string department = txtDepartment.Text.Trim();

                if (string.IsNullOrWhiteSpace(fullName))
                {
                    MessageBox.Show("Please enter your name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFacultyName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(department))
                {
                    MessageBox.Show("Please enter your department.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDepartment.Focus();
                    return;
                }

                string firstName = fullName;
                string lastName = "";

                int spaceIndex = fullName.IndexOf(' ');
                if (spaceIndex > 0)
                {
                    firstName = fullName.Substring(0, spaceIndex);
                    lastName = fullName.Substring(spaceIndex + 1).Trim();
                }

                try
                {
                    if (loggedInUser != null)
                    {
                        using (MySqlConnection conn = Connection.GetConnection())
                        {
                            string updateQuery = "UPDATE users SET first_name = @firstName, last_name = @lastName, program_or_dept = @department WHERE user_id = @userId";
                            using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@firstName", firstName);
                                cmd.Parameters.AddWithValue("@lastName", lastName);
                                cmd.Parameters.AddWithValue("@department", department);
                                cmd.Parameters.AddWithValue("@userId", loggedInUser.UserId);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        loggedInUser.FirstName = firstName;
                        loggedInUser.LastName = lastName;
                        loggedInUser.ProgramOrDept = department;
                    }

                    txtFacultyName.ReadOnly = true;
                    txtDepartment.ReadOnly = true;
                    btnEditProfile.Text = "Edit Profile";
                    btnEditProfile.BackColor = Color.SeaGreen;

                    MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating profile: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string currentPassword = txtCurrentPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(currentPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in all password fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (loggedInUser != null && currentPassword != loggedInUser.UserPassword)
            {
                MessageBox.Show("Current password is incorrect.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCurrentPassword.Focus();
                return;
            }

            if (newPassword.Length < 6)
            {
                MessageBox.Show("New password must be at least 6 characters long.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            if (newPassword == currentPassword)
            {
                MessageBox.Show("New password cannot be the same as your current password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return;
            }

            try
            {
                if (loggedInUser != null)
                {
                    using (MySqlConnection conn = Connection.GetConnection())
                    {
                        string updatePasswordQuery = "UPDATE users SET user_password = @password, must_change_password = 0 WHERE user_id = @userId";
                        using (MySqlCommand cmd = new MySqlCommand(updatePasswordQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@password", newPassword);
                            cmd.Parameters.AddWithValue("@userId", loggedInUser.UserId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    loggedInUser.UserPassword = newPassword;
                    loggedInUser.MustChangePassword = false;
                }

                MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCurrentPassword.Clear();
                txtNewPassword.Clear();
                txtConfirmPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSavePreferences_Click(object sender, EventArgs e)
        {
            grpRecentMeet.Visible = chkShowRecentRequestDashboard.Checked;
            grpOverview.Visible = chkShowRequestDashboard.Checked;

            MessageBox.Show("Preferences saved successfully!", "Preferences", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRefreshPreferences_Click(object sender, EventArgs e)
        {
            cmbTheme.SelectedIndex = 0;
            cmbDefaultTab.SelectedIndex = 0;

            chkEmailNotif.Checked = true;
            chkDesktopNotif.Checked = true;
            chkConsultationReminder.Checked = true;

            chkShowRequestDashboard.Checked = true;
            chkShowRecentRequestDashboard.Checked = true;

            grpRecentMeet.Visible = true;
            grpOverview.Visible = true;

            ApplyTheme("Default (Green)");

            MessageBox.Show("Preferences reset to default values.", "Preferences", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Dispose();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTheme.SelectedItem != null)
            {
                string? selectedTheme = cmbTheme.SelectedItem.ToString();
                if (selectedTheme != null)
                {
                    ApplyTheme(selectedTheme);
                }
            }
        }

        private void ApplyTheme(string theme)
        {
            if (theme == "Dark")
            {
                tabSettings.BackColor = Color.FromArgb(45, 45, 48);
                tabHome.BackColor = Color.FromArgb(45, 45, 48);
                tabRequest.BackColor = Color.FromArgb(45, 45, 48);
                tabAvailability.BackColor = Color.FromArgb(45, 45, 48);

                pnlFacultyProfile.BackColor = Color.FromArgb(60, 60, 65);
                pnlAppInfo.BackColor = Color.FromArgb(60, 60, 65);
                pnlAccountSettings.BackColor = Color.FromArgb(60, 60, 65);
                pnlPreferences.BackColor = Color.FromArgb(60, 60, 65);
                pnlHeaderSetting.BackColor = Color.FromArgb(60, 60, 65);

                lblTitleSetting.ForeColor = Color.LightGreen;
                lblProfileHeading.ForeColor = Color.LightGreen;
                lblAppInforHeading.ForeColor = Color.LightGreen;
                lblAccountSettingsHeading.ForeColor = Color.LightGreen;
                lblPreferencesHeading.ForeColor = Color.LightGreen;

                lblSettingSub.ForeColor = Color.WhiteSmoke;
                lblProfilSub.ForeColor = Color.WhiteSmoke;
                lblAppInfoSub.ForeColor = Color.WhiteSmoke;
                lblAccountSub.ForeColor = Color.WhiteSmoke;
                lblPreferencesSub.ForeColor = Color.WhiteSmoke;

                lblName.ForeColor = Color.WhiteSmoke;
                lblEmail.ForeColor = Color.WhiteSmoke;
                lblDepartment.ForeColor = Color.WhiteSmoke;
                lblPosition.ForeColor = Color.WhiteSmoke;

                lblCurrentPassword.ForeColor = Color.WhiteSmoke;
                lblNewPassword.ForeColor = Color.WhiteSmoke;
                lblConfirmPassword.ForeColor = Color.WhiteSmoke;

                lblTheme.ForeColor = Color.WhiteSmoke;
                lblDefaultTab.ForeColor = Color.WhiteSmoke;
                lblNotifications.ForeColor = Color.WhiteSmoke;
                lblDisplaySettings.ForeColor = Color.WhiteSmoke;

                chkEmailNotif.ForeColor = Color.WhiteSmoke;
                chkDesktopNotif.ForeColor = Color.WhiteSmoke;
                chkConsultationReminder.ForeColor = Color.WhiteSmoke;
                chkShowRequestDashboard.ForeColor = Color.WhiteSmoke;
                chkShowRecentRequestDashboard.ForeColor = Color.WhiteSmoke;

                lblVersion.ForeColor = Color.WhiteSmoke;
                lblDatabase.ForeColor = Color.WhiteSmoke;
                lblLastLogin.ForeColor = Color.WhiteSmoke;
                lblVersionValue.ForeColor = Color.LightGray;
                lblDatabaseValue.ForeColor = Color.LightGray;
                lblLastLoginValue.ForeColor = Color.LightGray;
            }
            else
            {
                tabSettings.BackColor = Color.WhiteSmoke;
                tabHome.BackColor = Color.WhiteSmoke;
                tabRequest.BackColor = Color.WhiteSmoke;
                tabAvailability.BackColor = Color.WhiteSmoke;

                pnlFacultyProfile.BackColor = Color.White;
                pnlAppInfo.BackColor = Color.White;
                pnlAccountSettings.BackColor = Color.White;
                pnlPreferences.BackColor = Color.White;
                pnlHeaderSetting.BackColor = Color.White;

                lblTitleSetting.ForeColor = Color.DarkGreen;
                lblProfileHeading.ForeColor = Color.DarkGreen;
                lblAppInforHeading.ForeColor = Color.DarkGreen;
                lblAccountSettingsHeading.ForeColor = Color.DarkGreen;
                lblPreferencesHeading.ForeColor = Color.DarkGreen;

                lblSettingSub.ForeColor = Color.Black;
                lblProfilSub.ForeColor = Color.Black;
                lblAppInfoSub.ForeColor = Color.Black;
                lblAccountSub.ForeColor = Color.Black;
                lblPreferencesSub.ForeColor = Color.Black;

                lblName.ForeColor = Color.Black;
                lblEmail.ForeColor = Color.Black;
                lblDepartment.ForeColor = Color.Black;
                lblPosition.ForeColor = Color.Black;

                lblCurrentPassword.ForeColor = Color.Black;
                lblNewPassword.ForeColor = Color.Black;
                lblConfirmPassword.ForeColor = Color.Black;

                lblTheme.ForeColor = Color.Black;
                lblDefaultTab.ForeColor = Color.Black;
                lblNotifications.ForeColor = Color.Black;
                lblDisplaySettings.ForeColor = Color.Black;

                chkEmailNotif.ForeColor = Color.Black;
                chkDesktopNotif.ForeColor = Color.Black;
                chkConsultationReminder.ForeColor = Color.Black;
                chkShowRequestDashboard.ForeColor = Color.Black;
                chkShowRecentRequestDashboard.ForeColor = Color.Black;

                lblVersion.ForeColor = Color.Black;
                lblDatabase.ForeColor = Color.Black;
                lblLastLogin.ForeColor = Color.Black;
                lblVersionValue.ForeColor = Color.DimGray;
                lblDatabaseValue.ForeColor = Color.DimGray;
                lblLastLoginValue.ForeColor = Color.DimGray;
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AvailabilityPage_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalUpMeet_Click(object sender, EventArgs e)
        {

        }

        private void dgvRecentRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pnlFacultyProfile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvRecentRequest_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFacultyName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
