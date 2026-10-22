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
            cmbFaculty.SelectedIndexChanged += cmbFaculty_SelectedIndexChanged;
        }

        private void Student_Load(object sender, EventArgs e) {
            LoadKPI();
            LoadMeetingRequests();
            LoadFaculty();
        }

        private void LoadKPI() {
            // lblTotalCount, lblApprovedCount, lblPendingCount, lblCompletedCount
            string kpiQuery = "SELECT COUNT(*) AS TotalCount, COUNT(CASE WHEN status = 'Approved' THEN 1 END) AS ApprovedCount, COUNT(CASE WHEN status = 'Pending' THEN 1 END) AS PendingCount, COUNT(CASE WHEN status = 'Completed' THEN 1 END) AS CompletedCount FROM appointments WHERE student_id = @StudentId";
            using (MySqlConnection conn = Connection.GetConnection()) {
                using (MySqlCommand cmd = new MySqlCommand(kpiQuery, conn)) {
                    cmd.Parameters.AddWithValue("@StudentId", loggedUser?.UserId);
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
            string loadRequestsQuery = "SELECT a.appointment_id, CONCAT(u.first_name, ' ', u.last_name) AS faculty_name, DATE(a.meeting_datetime) AS meeting_date, DATE_FORMAT(a.meeting_datetime, '%h:%i %p') AS start_time, DATE_FORMAT(a.meeting_end_datetime, '%h:%i %p') AS end_time, a.status, a.faculty_remarks FROM appointments a INNER JOIN users u ON u.user_id = a.faculty_id WHERE a.student_id = @StudentId ORDER BY a.meeting_datetime DESC";

            dgvMyRequests.AutoGenerateColumns = false;
            request_id.DataPropertyName = "appointment_id";
            faculty_name.DataPropertyName = "faculty_name";
            meeting_date.DataPropertyName = "meeting_date";
            meeting_date.DefaultCellStyle.Format = "MMM dd, yyyy";
            start_time.DataPropertyName = "start_time";
            end_time.DataPropertyName = "end_time";
            status.DataPropertyName = "status";
            faculty_remarks.DataPropertyName = "faculty_remarks";

            using (MySqlConnection conn = Connection.GetConnection()) {
                using (MySqlCommand cmd = new MySqlCommand(loadRequestsQuery, conn)) {
                    cmd.Parameters.AddWithValue("@StudentId", loggedUser?.UserId);
                    using (MySqlDataReader reader = cmd.ExecuteReader()) {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dgvMyRequests.DataSource = dt;
                    }
                }
            }
        }

        private void LoadAvailabilityHours()
        {
            dgvFacultyHours.Rows.Clear();

            if (cmbFaculty.SelectedItem is not DataRowView selectedFaculty)
            {
                return;
            }

            string query = "SELECT days, start_time, end_time, location FROM faculty_availability WHERE faculty_id = @FacultyId ORDER BY FIELD(days, 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday'), start_time";

            try
            {
                using (MySqlConnection conn = Connection.GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FacultyId", selectedFaculty["user_id"]);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime startTime = DateTime.Today.Add(reader.GetTimeSpan("start_time"));
                            DateTime endTime = DateTime.Today.Add(reader.GetTimeSpan("end_time"));
                            string location = string.Empty;
                            if (!reader.IsDBNull(reader.GetOrdinal("location")))
                            {
                                location = reader.GetString("location");
                            }

                            dgvFacultyHours.Rows.Add(
                                reader.GetString("days"),
                                startTime.ToString("hh:mm tt"),
                                endTime.ToString("hh:mm tt"),
                                location);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                dgvFacultyHours.Rows.Clear();
                MessageBox.Show("Unable to load consultation hours: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbFaculty_SelectedIndexChanged(object? sender, EventArgs e)
        {
            LoadAvailabilityHours();
        }

        private void LoadFaculty() {
            string facultyQuery = "SELECT user_id, CONCAT(first_name, ' ', last_name) AS faculty_name FROM users WHERE role = 'Faculty' AND is_active = 1 ORDER BY last_name, first_name, user_id";
            DataTable faculty = new DataTable();
            using (MySqlConnection conn = Connection.GetConnection()) {
                using (MySqlCommand cmd = new MySqlCommand(facultyQuery, conn)) {
                    using (MySqlDataReader reader = cmd.ExecuteReader()) {
                        faculty.Load(reader);
                    }
                }
            }

            cmbFaculty.DisplayMember = "faculty_name";
            cmbFaculty.ValueMember = "user_id";
            cmbFaculty.DataSource = faculty;
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
            if (loggedUser == null)
            {
                MessageBox.Show("Please log in before submitting a request.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbFaculty.SelectedItem is not DataRowView selectedFaculty)
            {
                MessageBox.Show("Please select a faculty member.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbFaculty.Focus();
                return;
            }

            string purpose = txtPurposeOfTheMeeting.Text.Trim();
            if (purpose.Length == 0 || purpose.Length > 255)
            {
                MessageBox.Show("Please enter a meeting purpose of 1 to 255 characters.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPurposeOfTheMeeting.Focus();
                return;
            }

            DateTime meetingDate = dtpMeetingDate.Value.Date;
            DateTime meetingStart = meetingDate.AddHours(dtpStartTime.Value.Hour)
                .AddMinutes(dtpStartTime.Value.Minute);
            DateTime meetingEnd = meetingDate.AddHours(dtpEndTime.Value.Hour)
                .AddMinutes(dtpEndTime.Value.Minute);

            if (meetingStart <= DateTime.Now)
            {
                MessageBox.Show("Please select a future meeting date and start time.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpMeetingDate.Focus();
                return;
            }

            if (meetingEnd <= meetingStart)
            {
                MessageBox.Show("End time must be after start time on the same day.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpEndTime.Focus();
                return;
            }

            int facultyId = Convert.ToInt32(selectedFaculty["user_id"]);
            btnSubmitRequest.Enabled = false;

            try
            {
                using (MySqlConnection conn = Connection.GetConnection())
                using (MySqlTransaction transaction = conn.BeginTransaction())
                {
                    string lockQuery = "SELECT user_id FROM users WHERE user_id IN (@StudentId, @FacultyId) ORDER BY user_id FOR UPDATE";
                    using (MySqlCommand cmd = new MySqlCommand(lockQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@StudentId", loggedUser.UserId);
                        cmd.Parameters.AddWithValue("@FacultyId", facultyId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                            }
                        }
                    }

                    string availabilityQuery = "SELECT COUNT(*) FROM faculty_availability f INNER JOIN users u ON u.user_id = f.faculty_id WHERE f.faculty_id = @FacultyId AND u.role = 'Faculty' AND u.is_active = 1 AND f.days = @Day AND f.start_time <= @StartTime AND f.end_time >= @EndTime";
                    using (MySqlCommand cmd = new MySqlCommand(availabilityQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@FacultyId", facultyId);
                        cmd.Parameters.AddWithValue("@Day", meetingDate.DayOfWeek.ToString());
                        cmd.Parameters.AddWithValue("@StartTime", meetingStart.TimeOfDay);
                        cmd.Parameters.AddWithValue("@EndTime", meetingEnd.TimeOfDay);
                        if (Convert.ToInt64(cmd.ExecuteScalar()) == 0)
                        {
                            MessageBox.Show("Select a time range within the faculty member's consultation hours.",
                                "Unavailable Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string conflictQuery = "SELECT COUNT(*) FROM appointments WHERE (faculty_id = @FacultyId OR student_id = @StudentId) AND status IN ('Pending', 'Approved') AND meeting_datetime < @MeetingEnd AND (meeting_end_datetime > @MeetingStart OR (meeting_end_datetime IS NULL AND meeting_datetime >= @MeetingStart))";
                    using (MySqlCommand cmd = new MySqlCommand(conflictQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@FacultyId", facultyId);
                        cmd.Parameters.AddWithValue("@StudentId", loggedUser.UserId);
                        cmd.Parameters.AddWithValue("@MeetingStart", meetingStart);
                        cmd.Parameters.AddWithValue("@MeetingEnd", meetingEnd);
                        if (Convert.ToInt64(cmd.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("You or the faculty member already have a pending or approved meeting during this time.",
                                "Scheduling Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO appointments (student_id, faculty_id, meeting_datetime, meeting_end_datetime, purpose, status) VALUES (@StudentId, @FacultyId, @MeetingStart, @MeetingEnd, @Purpose, 'Pending')";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@StudentId", loggedUser.UserId);
                        cmd.Parameters.AddWithValue("@FacultyId", facultyId);
                        cmd.Parameters.AddWithValue("@MeetingStart", meetingStart);
                        cmd.Parameters.AddWithValue("@MeetingEnd", meetingEnd);
                        cmd.Parameters.AddWithValue("@Purpose", purpose);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to save the meeting request: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                btnSubmitRequest.Enabled = true;
            }

            txtPurposeOfTheMeeting.Clear();
            MessageBox.Show("Meeting request submitted successfully. It is pending faculty approval.",
                "Request Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                LoadKPI();
                LoadMeetingRequests();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Your request was saved, but the dashboard could not be refreshed: " + ex.Message,
                    "Refresh Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
