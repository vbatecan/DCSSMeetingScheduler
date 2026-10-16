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
        }

        private void AdminForm_Load(object sender, EventArgs e) {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                cmd.ExecuteNonQuery();
                da.Fill(ds, "users");
                dgvUsers.DataSource = ds;
                dgvUsers.DataMember = "users";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {

        }

        private void btnUpdate_Click(object sender, EventArgs e) {

        }

        private void btnSave_Click(object sender, EventArgs e) {

        }

        private void btnLogout_Click(object sender, EventArgs e) {
            Dispose();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
