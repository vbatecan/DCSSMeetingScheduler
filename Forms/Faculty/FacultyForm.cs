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
    public partial class FacultyForm : Form
    {
        private User? loggedInUser = null;
        private int selectedAvailabilityId = -1;
        private static int defaultTabIndex = 0;

        public FacultyForm()
        {
            InitializeComponent();
        }

        public FacultyForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void Faculty_Load(object sender, EventArgs e)
        {
            LoadFacultyProfile();
            LoadApplicationInfo();
            InitializePreferences();
            LoadAvailability();

            if (defaultTabIndex >= 0 && defaultTabIndex < tabFaculty.TabCount)
            {
                tabFaculty.SelectedIndex = defaultTabIndex;
            }
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
            cmbDefaultTab.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDefaultTab.Items.Clear();
            cmbDefaultTab.Items.Add("Home");
            cmbDefaultTab.Items.Add("Request");
            cmbDefaultTab.Items.Add("Availability");
            cmbDefaultTab.Items.Add("Setting");

            if (defaultTabIndex >= 0 && defaultTabIndex < cmbDefaultTab.Items.Count)
            {
                cmbDefaultTab.SelectedIndex = defaultTabIndex;
            }
            else
            {
                cmbDefaultTab.SelectedIndex = 0;
            }

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
            if (cmbDefaultTab.SelectedIndex >= 0)
            {
                defaultTabIndex = cmbDefaultTab.SelectedIndex;
                tabFaculty.SelectedIndex = defaultTabIndex;
            }

            grpRecentMeet.Visible = chkShowRecentRequestDashboard.Checked;
            grpOverview.Visible = chkShowRequestDashboard.Checked;

            MessageBox.Show("Preferences saved successfully!", "Preferences", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRefreshPreferences_Click(object sender, EventArgs e)
        {
            defaultTabIndex = 0;
            cmbDefaultTab.SelectedIndex = 0;
            tabFaculty.SelectedIndex = 0;

            chkEmailNotif.Checked = true;
            chkDesktopNotif.Checked = true;
            chkConsultationReminder.Checked = true;

            chkShowRequestDashboard.Checked = true;
            chkShowRecentRequestDashboard.Checked = true;

            grpRecentMeet.Visible = true;
            grpOverview.Visible = true;

            MessageBox.Show("Preferences reset to default values.", "Preferences", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbDefaultTab_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbDefaultTab.SelectedIndex >= 0)
            {
                defaultTabIndex = cmbDefaultTab.SelectedIndex;
            }
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


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LoadAvailability(string search = "")
        {
            if (loggedInUser == null)
            {
                return;
            }

            try
            {
                using (MySqlConnection conn = Connection.GetConnection())
                {
                    string query = "SELECT availability_id, days AS 'Day', TIME_FORMAT(start_time, '%h:%i %p') AS 'Start Time', TIME_FORMAT(end_time, '%h:%i %p') AS 'End Time', location AS 'Location' FROM faculty_availability WHERE faculty_id = @facultyId";

                    if (!string.IsNullOrWhiteSpace(search))
                    {
                        query += " AND (days LIKE @search OR location LIKE @search)";
                    }

                    query += " ORDER BY FIELD(days, 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday'), start_time";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@facultyId", loggedInUser.UserId);

                        if (!string.IsNullOrWhiteSpace(search))
                        {
                            cmd.Parameters.AddWithValue("@search", "%" + search.Trim() + "%");
                        }

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;

                            DataGridViewColumn? col = dataGridView1.Columns["availability_id"];
                            if (col != null)
                            {
                                col.Visible = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading availability: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loggedInUser == null)
            {
                MessageBox.Show("Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox1.SelectedIndex == -1 || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a day of week.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Focus();
                return;
            }

            TimeSpan startTime = dateTimePicker1.Value.TimeOfDay;
            TimeSpan endTime = dateTimePicker3.Value.TimeOfDay;

            if (startTime >= endTime)
            {
                MessageBox.Show("Start time must be earlier than end time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string day = comboBox1.SelectedItem.ToString() ?? "";
            string location = textBox1.Text.Trim();
            if (location == "e.g Room 101, Online etc.")
            {
                location = "";
            }

            try
            {
                using (MySqlConnection conn = Connection.GetConnection())
                {
                    if (selectedAvailabilityId == -1)
                    {
                        string insertQuery = "INSERT INTO faculty_availability (faculty_id, days, start_time, end_time, location) VALUES (@facultyId, @days, @startTime, @endTime, @location)";
                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@facultyId", loggedInUser.UserId);
                            cmd.Parameters.AddWithValue("@days", day);
                            cmd.Parameters.AddWithValue("@startTime", startTime.ToString(@"hh\:mm\:ss"));
                            cmd.Parameters.AddWithValue("@endTime", endTime.ToString(@"hh\:mm\:ss"));
                            cmd.Parameters.AddWithValue("@location", location);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Consultation hours added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string updateQuery = "UPDATE faculty_availability SET days = @days, start_time = @startTime, end_time = @endTime, location = @location WHERE availability_id = @id AND faculty_id = @facultyId";
                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@days", day);
                            cmd.Parameters.AddWithValue("@startTime", startTime.ToString(@"hh\:mm\:ss"));
                            cmd.Parameters.AddWithValue("@endTime", endTime.ToString(@"hh\:mm\:ss"));
                            cmd.Parameters.AddWithValue("@location", location);
                            cmd.Parameters.AddWithValue("@id", selectedAvailabilityId);
                            cmd.Parameters.AddWithValue("@facultyId", loggedInUser.UserId);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Consultation hours updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                ClearAvailabilityInputs();
                LoadAvailability();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving consultation hours: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ClearAvailabilityInputs();
        }

        private void ClearAvailabilityInputs()
        {
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Today.AddHours(8);
            dateTimePicker3.Value = DateTime.Today.AddHours(9);
            textBox1.Text = "  e.g Room 101, Online etc.";
            selectedAvailabilityId = -1;
            AddBTN.Text = "+ Add";
        }

        private void EditBTN_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select an item to edit.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            selectedAvailabilityId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["availability_id"].Value);
            string day = dataGridView1.CurrentRow.Cells["Day"].Value?.ToString() ?? "";
            string startTimeStr = dataGridView1.CurrentRow.Cells["Start Time"].Value?.ToString() ?? "";
            string endTimeStr = dataGridView1.CurrentRow.Cells["End Time"].Value?.ToString() ?? "";
            string location = dataGridView1.CurrentRow.Cells["Location"].Value?.ToString() ?? "";

            comboBox1.SelectedItem = day;

            if (DateTime.TryParse(startTimeStr, out DateTime sTime))
            {
                dateTimePicker1.Value = sTime;
            }

            if (DateTime.TryParse(endTimeStr, out DateTime eTime))
            {
                dateTimePicker3.Value = eTime;
            }

            textBox1.Text = location;
            AddBTN.Text = "Save";
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (loggedInUser == null)
            {
                MessageBox.Show("Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select an item to delete.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this schedule?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["availability_id"].Value);

                try
                {
                    using (MySqlConnection conn = Connection.GetConnection())
                    {
                        string deleteQuery = "DELETE FROM faculty_availability WHERE availability_id = @id AND faculty_id = @facultyId";
                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@facultyId", loggedInUser.UserId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Consultation hours deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAvailabilityInputs();
                    LoadAvailability();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting schedule: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            LoadAvailability(textBox2.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            LoadAvailability(textBox2.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void AvailabilityPage_Click(object sender, EventArgs e)
        {
            LoadAvailability();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
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

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void tabRequest_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void tabHome_Click(object sender, EventArgs e)
        {

        }
    }
}
