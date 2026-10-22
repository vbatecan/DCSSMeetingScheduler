using System.Data;
using DCSSMeetingScheduler.Shared;
using MySqlConnector;

namespace DCSSMeetingScheduler.Forms.Student
{
    public partial class StudentForm : Form {

        private User? loggedUser = null;

        public StudentForm(User user) {
            InitializeComponent();
            this.loggedUser = user;
        }

        private void Student_Load(object sender, EventArgs e) {
            LoadKPI();
            LoadMeetingRequests();
            LoadFaculty();
        }

        private void LoadKPI() {
            // lblTotalCount, lblApprovedCount, lblPendingCount, lblCompletedCount
            string kpiQuery = "SELECT COUNT(*) AS TotalCount, SUM(CASE WHEN status = 'Approved' THEN 1 ELSE 0 END) AS ApprovedCount, SUM(CASE WHEN status = 'Pending' THEN 1 ELSE 0 END) AS PendingCount, SUM(CASE WHEN status = 'Completed' THEN 1 ELSE 0 END) AS CompletedCount FROM appointments WHERE student_id = @StudentId";
            using (MySqlConnection conn = Connection.GetConnection()) {
                using (MySqlCommand cmd = new MySqlCommand(kpiQuery, conn)) {
                    cmd.Parameters.AddWithValue("@StudentId", loggedUser?.IdNumber);
                    using (MySqlDataReader reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            lblTotalCount.Text = reader["TotalCount"].ToString();
                            lblApprovedCount.Text = reader["ApprovedCount"].ToString();
                            lblPendingCount.Text = reader["PendingCount"].ToString();
                            lblCompletedCount.Text = reader["CompletedCount"].ToString();
                        }
                    }
                }
            }
        }

        private void LoadMeetingRequests() {
            string loadRequestsQuery = "SELECT appointment_id, purpose, status, meeting_datetime FROM appointments WHERE student_id = @StudentId";

            using (MySqlConnection conn = Connection.GetConnection()) {
                using (MySqlCommand cmd = new MySqlCommand(loadRequestsQuery, conn)) {
                    cmd.Parameters.AddWithValue("@StudentId", loggedUser?.IdNumber);
                    using (MySqlDataReader reader = cmd.ExecuteReader()) {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dgvMyRequests.DataSource = dt;
                    }
                }
            }
        }

        private void LoadFaculty() {
            string facultyQuery = "SELECT role, first_name, last_name FROM users WHERE role = 'Faculty'";
            using (MySqlConnection conn = Connection.GetConnection()) {
                using (MySqlCommand cmd = new MySqlCommand(facultyQuery, conn)) {
                    using (MySqlDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read())
                        {
                            string firstName = reader.GetString("first_name");
                            string lastName = reader.GetString("last_name");
                            cmbFaculty.Items.Add($"{firstName} {lastName}");
                        }
                    }
                }
            }
        }

        private void tabPage3_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void label3_Click_1(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void dgvMyRequests_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void pnlHomeTitle_Paint(object sender, PaintEventArgs e) {

        }

        private void tabPage2_Click(object sender, EventArgs e) {

        }

        private void pblHeader_Paint(object sender, PaintEventArgs e) {

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void pnlProfile_Paint(object sender, PaintEventArgs e) {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e) {

        }

        private void btnSubmitRequest_Click(object sender, EventArgs e) {

        }
    }
}
