using DCSSMeetingScheduler.Shared;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DCSSMeetingScheduler.Admin {
    public partial class AdminForm : Form
    {

        public AdminForm()
        {
            InitializeComponent();
        }

        public AdminForm(User user)
        {
            InitializeComponent();
            if (user != null)
            {
                lblGreeting.Text = "Welcome " + user.FirstName + " " + user.LastName;
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            cmbFilterStatus.SelectedIndex = 0;
            LoadDashboardStatistics();
            LoadAppointments();
            LoadUsers();
        }

        private void LoadDashboardStatistics()
        {
            try
            {
                using (MySqlConnection conn = Connection.GetConnection())
                {
                    string facultyQuery = "SELECT COUNT(*) FROM users WHERE role = 'Faculty'";
                    using (MySqlCommand facultyCmd = new MySqlCommand(facultyQuery, conn))
                    {
                        int facultyCount = Convert.ToInt32(facultyCmd.ExecuteScalar());
                        lblFacultyCount.Text = facultyCount.ToString();
                    }

                    string studentQuery = "SELECT COUNT(*) FROM users WHERE role = 'Student'";
                    using (MySqlCommand studentCmd = new MySqlCommand(studentQuery, conn))
                    {
                        int studentCount = Convert.ToInt32(studentCmd.ExecuteScalar());
                        lblStudentsCount.Text = studentCount.ToString();
                    }

                    string meetingsQuery = "SELECT COUNT(*) FROM appointments";
                    using (MySqlCommand meetingsCmd = new MySqlCommand(meetingsQuery, conn))
                    {
                        int meetingsCount = Convert.ToInt32(meetingsCmd.ExecuteScalar());
                        lblMeetingsCount.Text = meetingsCount.ToString();
                    }

                    string pendingQuery = "SELECT COUNT(*) FROM appointments WHERE status = 'Pending'";
                    using (MySqlCommand pendingCmd = new MySqlCommand(pendingQuery, conn))
                    {
                        int pendingCount = Convert.ToInt32(pendingCmd.ExecuteScalar());
                        lblPendingCount.Text = pendingCount.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading statistics: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAppointments(string searchKeyword = "", string statusFilter = "All")
        {
            try
            {
                using (MySqlConnection conn = Connection.GetConnection())
                {
                    string query = "SELECT a.appointment_id AS 'ID', " +
                                   "CONCAT(s.first_name, ' ', s.last_name) AS 'Student', " +
                                   "CONCAT(f.first_name, ' ', f.last_name) AS 'Faculty', " +
                                   "a.meeting_datetime AS 'Date & Time', " +
                                   "a.purpose AS 'Purpose', " +
                                   "a.status AS 'Status', " +
                                   "a.faculty_remarks AS 'Faculty Remarks', " +
                                   "a.created_at AS 'Created At' " +
                                   "FROM appointments a " +
                                   "INNER JOIN users s ON a.student_id = s.user_id " +
                                   "INNER JOIN users f ON a.faculty_id = f.user_id ";

                    if (!string.IsNullOrWhiteSpace(statusFilter) && statusFilter != "All")
                    {
                        query += " AND a.status = @status";
                    }

                    if (!string.IsNullOrWhiteSpace(searchKeyword))
                    {
                        query += " AND (s.first_name LIKE @search OR s.last_name LIKE @search OR CONCAT(s.first_name, ' ', s.last_name) LIKE @search OR f.first_name LIKE @search OR f.last_name LIKE @search OR CONCAT(f.first_name, ' ', f.last_name) LIKE @search OR a.purpose LIKE @search)";
                    }

                    query += " ORDER BY a.meeting_datetime DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(statusFilter) && statusFilter != "All")
                        {
                            cmd.Parameters.AddWithValue("@status", statusFilter);
                        }

                        if (!string.IsNullOrWhiteSpace(searchKeyword))
                        {
                            cmd.Parameters.AddWithValue("@search", "%" + searchKeyword.Trim() + "%");
                        }

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvAppointments.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointments: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshHome_Click(object sender, EventArgs e)
        {
            LoadDashboardStatistics();
            string selectedStatus = cmbFilterStatus.SelectedItem != null ? cmbFilterStatus.SelectedItem.ToString()! : "All";
            string searchKeyword = txtSearchAppointment.Text.Trim();
            LoadAppointments(searchKeyword, selectedStatus);
        }

        private void cmbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = cmbFilterStatus.SelectedItem != null ? cmbFilterStatus.SelectedItem.ToString()! : "All";
            string searchKeyword = txtSearchAppointment.Text.Trim();
            LoadAppointments(searchKeyword, selectedStatus);
        }

        private void btnSearchAppointment_Click(object sender, EventArgs e)
        {
            string selectedStatus = cmbFilterStatus.SelectedItem != null ? cmbFilterStatus.SelectedItem.ToString()! : "All";
            string searchKeyword = txtSearchAppointment.Text.Trim();
            LoadAppointments(searchKeyword, selectedStatus);
        }

        private void txtSearchAppointment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSearchAppointment_Click(sender, e);
            }
        }

        private void txtSearchAppointment_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchAppointment.Text))
            {
                string selectedStatus = cmbFilterStatus.SelectedItem != null ? cmbFilterStatus.SelectedItem.ToString()! : "All";
                LoadAppointments("", selectedStatus);
            }
        }

        private void btnResetAppointmentFilter_Click(object sender, EventArgs e)
        {
            txtSearchAppointment.Text = "";
            cmbFilterStatus.SelectedIndex = 0;
            LoadAppointments("", "All");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabHome)
            {
                LoadDashboardStatistics();
                string selectedStatus = cmbFilterStatus.SelectedItem != null ? cmbFilterStatus.SelectedItem.ToString()! : "All";
                string searchKeyword = txtSearchAppointment.Text.Trim();
                LoadAppointments(searchKeyword, selectedStatus);
            }
            else if (tabControl1.SelectedTab == tabUsers)
            {
                LoadUsers();
            }
        }

        private void LoadUsers(string searchKeyword = "")
        {
            try
            {
                using (MySqlConnection conn = Connection.GetConnection())
                {
                    string query = "SELECT user_id, ue_email, first_name, last_name, role, id_number, program_or_dept, is_active, must_change_password, created_at FROM users";
                    if (!string.IsNullOrWhiteSpace(searchKeyword))
                    {
                        query = "SELECT user_id, ue_email, first_name, last_name, role, id_number, program_or_dept, is_active, must_change_password, created_at FROM users " +
                                "WHERE first_name LIKE @search OR last_name LIKE @search OR CONCAT(first_name, ' ', last_name) LIKE @search OR ue_email LIKE @search OR id_number LIKE @search";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(searchKeyword))
                        {
                            cmd.Parameters.AddWithValue("@search", "%" + searchKeyword.Trim() + "%");
                        }

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvUsers.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtSearchName.Text.Trim();
            LoadUsers(searchKeyword);
        }

        private void txtSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSearch_Click(sender, e);
            }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchName.Text))
            {
                LoadUsers();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null || dgvUsers.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select a user to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["user_id"].Value);
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = Connection.GetConnection())
                    {
                        string query = "DELETE FROM users WHERE user_id = @id";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", userId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null || dgvUsers.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select a user to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["user_id"].Value);
            UserForm userForm = new UserForm(userId);
            DialogResult result = userForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            DialogResult result = userForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void Dashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (Owner is LoginForm loginForm)
                loginForm.DashboardClosed(this);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
