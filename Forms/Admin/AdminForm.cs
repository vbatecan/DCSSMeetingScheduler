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
    public partial class AdminForm : Form {

        public AdminForm() {
            InitializeComponent();
        }

        public AdminForm(User user) {
            InitializeComponent();
            if (user != null) {
                lblGreeting.Text = "Welcome " + user.FirstName + " " + user.LastName;
            }
        }

        private void AdminForm_Load(object sender, EventArgs e) {
            LoadUsers();
        }

        private void LoadUsers(string searchKeyword = "") {
            try {
                using (MySqlConnection conn = Connection.GetConnection()) {
                    string query = "SELECT user_id, ue_email, first_name, last_name, role, id_number, program_or_dept, is_active, must_change_password, created_at FROM users";
                    if (!string.IsNullOrWhiteSpace(searchKeyword)) {
                        query = "SELECT user_id, ue_email, first_name, last_name, role, id_number, program_or_dept, is_active, must_change_password, created_at FROM users " +
                                "WHERE first_name LIKE @search OR last_name LIKE @search OR CONCAT(first_name, ' ', last_name) LIKE @search OR ue_email LIKE @search OR id_number LIKE @search";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn)) {
                        if (!string.IsNullOrWhiteSpace(searchKeyword)) {
                            cmd.Parameters.AddWithValue("@search", "%" + searchKeyword.Trim() + "%");
                        }

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd)) {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvUsers.DataSource = dt;
                        }
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error loading users: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            string searchKeyword = txtSearchName.Text.Trim();
            LoadUsers(searchKeyword);
        }

        private void txtSearchName_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
                btnSearch_Click(sender, e);
            }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtSearchName.Text)) {
                LoadUsers();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (dgvUsers.CurrentRow == null || dgvUsers.CurrentRow.Index < 0) {
                MessageBox.Show("Please select a user to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["user_id"].Value);
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes) {
                try {
                    using (MySqlConnection conn = Connection.GetConnection()) {
                        string query = "DELETE FROM users WHERE user_id = @id";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn)) {
                            cmd.Parameters.AddWithValue("@id", userId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                } catch (Exception ex) {
                    MessageBox.Show("Error deleting user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            if (dgvUsers.CurrentRow == null || dgvUsers.CurrentRow.Index < 0) {
                MessageBox.Show("Please select a user to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["user_id"].Value);
            UserForm userForm = new UserForm(userId);
            DialogResult result = userForm.ShowDialog();
            if (result == DialogResult.OK) {
                LoadUsers();
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            UserForm userForm = new UserForm();
            DialogResult result = userForm.ShowDialog();
            if (result == DialogResult.OK) {
                LoadUsers();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e) {
            Dispose();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
