namespace DCSSMeetingScheduler.Admin {
    partial class AdminForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabHome = new TabPage();
            lblHomeTitle = new Label();
            lblHomeSubtitle = new Label();
            btnRefreshHome = new Button();
            pnlTotalFaculty = new Panel();
            lblFacultyTitle = new Label();
            lblFacultyCount = new Label();
            pnlTotalStudents = new Panel();
            lblStudentsTitle = new Label();
            lblStudentsCount = new Label();
            pnlTotalMeetings = new Panel();
            lblMeetingsTitle = new Label();
            lblMeetingsCount = new Label();
            pnlPendingRequests = new Panel();
            lblPendingTitle = new Label();
            lblPendingCount = new Label();
            lblAppointmentsTitle = new Label();
            lblFilterStatus = new Label();
            cmbFilterStatus = new ComboBox();
            lblSearchAppointment = new Label();
            txtSearchAppointment = new TextBox();
            btnSearchAppointment = new Button();
            btnResetAppointmentFilter = new Button();
            dgvAppointments = new DataGridView();
            tabUsers = new TabPage();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            btnSearch = new Button();
            txtSearchName = new TextBox();
            label2 = new Label();
            dgvUsers = new DataGridView();
            panel1 = new Panel();
            lblGreeting = new Label();
            btnLogout = new Button();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabHome.SuspendLayout();
            pnlTotalFaculty.SuspendLayout();
            pnlTotalStudents.SuspendLayout();
            pnlTotalMeetings.SuspendLayout();
            pnlPendingRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabHome);
            tabControl1.Controls.Add(tabUsers);
            tabControl1.Location = new Point(10, 68);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1242, 610);
            tabControl1.TabIndex = 1;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabHome
            // 
            tabHome.BorderStyle = BorderStyle.FixedSingle;
            tabHome.Controls.Add(lblHomeTitle);
            tabHome.Controls.Add(lblHomeSubtitle);
            tabHome.Controls.Add(btnRefreshHome);
            tabHome.Controls.Add(pnlTotalFaculty);
            tabHome.Controls.Add(pnlTotalStudents);
            tabHome.Controls.Add(pnlTotalMeetings);
            tabHome.Controls.Add(pnlPendingRequests);
            tabHome.Controls.Add(lblAppointmentsTitle);
            tabHome.Controls.Add(lblFilterStatus);
            tabHome.Controls.Add(cmbFilterStatus);
            tabHome.Controls.Add(lblSearchAppointment);
            tabHome.Controls.Add(txtSearchAppointment);
            tabHome.Controls.Add(btnSearchAppointment);
            tabHome.Controls.Add(btnResetAppointmentFilter);
            tabHome.Controls.Add(dgvAppointments);
            tabHome.Location = new Point(4, 22);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(3);
            tabHome.Size = new Size(1234, 584);
            tabHome.TabIndex = 0;
            tabHome.Text = "Home";
            tabHome.UseVisualStyleBackColor = true;
            // 
            // lblHomeTitle
            // 
            lblHomeTitle.AutoSize = true;
            lblHomeTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblHomeTitle.ForeColor = Color.DarkGreen;
            lblHomeTitle.Location = new Point(14, 12);
            lblHomeTitle.Name = "lblHomeTitle";
            lblHomeTitle.Size = new Size(217, 30);
            lblHomeTitle.TabIndex = 0;
            lblHomeTitle.Text = "Dashboard Overview";
            // 
            // lblHomeSubtitle
            // 
            lblHomeSubtitle.AutoSize = true;
            lblHomeSubtitle.Font = new Font("Segoe UI", 9.75F);
            lblHomeSubtitle.ForeColor = Color.DimGray;
            lblHomeSubtitle.Location = new Point(15, 42);
            lblHomeSubtitle.Name = "lblHomeSubtitle";
            lblHomeSubtitle.Size = new Size(417, 17);
            lblHomeSubtitle.TabIndex = 1;
            lblHomeSubtitle.Text = "View system statistics and scheduled meetings across the department.";
            // 
            // btnRefreshHome
            // 
            btnRefreshHome.BackColor = Color.CornflowerBlue;
            btnRefreshHome.FlatStyle = FlatStyle.Flat;
            btnRefreshHome.Font = new Font("Segoe UI", 9.75F);
            btnRefreshHome.ForeColor = Color.White;
            btnRefreshHome.Location = new Point(1108, 14);
            btnRefreshHome.Name = "btnRefreshHome";
            btnRefreshHome.Size = new Size(110, 32);
            btnRefreshHome.TabIndex = 2;
            btnRefreshHome.Text = "Refresh";
            btnRefreshHome.UseVisualStyleBackColor = false;
            btnRefreshHome.Click += btnRefreshHome_Click;
            // 
            // pnlTotalFaculty
            // 
            pnlTotalFaculty.BackColor = Color.White;
            pnlTotalFaculty.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalFaculty.Controls.Add(lblFacultyTitle);
            pnlTotalFaculty.Controls.Add(lblFacultyCount);
            pnlTotalFaculty.Location = new Point(14, 68);
            pnlTotalFaculty.Name = "pnlTotalFaculty";
            pnlTotalFaculty.Size = new Size(288, 82);
            pnlTotalFaculty.TabIndex = 3;
            // 
            // lblFacultyTitle
            // 
            lblFacultyTitle.AutoSize = true;
            lblFacultyTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFacultyTitle.ForeColor = Color.FromArgb(85, 121, 69);
            lblFacultyTitle.Location = new Point(14, 10);
            lblFacultyTitle.Name = "lblFacultyTitle";
            lblFacultyTitle.Size = new Size(115, 15);
            lblFacultyTitle.TabIndex = 0;
            lblFacultyTitle.Text = "FACULTY MEMBERS";
            // 
            // lblFacultyCount
            // 
            lblFacultyCount.AutoSize = true;
            lblFacultyCount.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblFacultyCount.Location = new Point(12, 30);
            lblFacultyCount.Name = "lblFacultyCount";
            lblFacultyCount.Size = new Size(35, 41);
            lblFacultyCount.TabIndex = 1;
            lblFacultyCount.Text = "0";
            // 
            // pnlTotalStudents
            // 
            pnlTotalStudents.BackColor = Color.White;
            pnlTotalStudents.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalStudents.Controls.Add(lblStudentsTitle);
            pnlTotalStudents.Controls.Add(lblStudentsCount);
            pnlTotalStudents.Location = new Point(320, 68);
            pnlTotalStudents.Name = "pnlTotalStudents";
            pnlTotalStudents.Size = new Size(288, 82);
            pnlTotalStudents.TabIndex = 4;
            // 
            // lblStudentsTitle
            // 
            lblStudentsTitle.AutoSize = true;
            lblStudentsTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStudentsTitle.ForeColor = Color.FromArgb(85, 121, 69);
            lblStudentsTitle.Location = new Point(14, 10);
            lblStudentsTitle.Name = "lblStudentsTitle";
            lblStudentsTitle.Size = new Size(68, 15);
            lblStudentsTitle.TabIndex = 0;
            lblStudentsTitle.Text = "STUDENTS";
            // 
            // lblStudentsCount
            // 
            lblStudentsCount.AutoSize = true;
            lblStudentsCount.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblStudentsCount.Location = new Point(12, 30);
            lblStudentsCount.Name = "lblStudentsCount";
            lblStudentsCount.Size = new Size(35, 41);
            lblStudentsCount.TabIndex = 1;
            lblStudentsCount.Text = "0";
            // 
            // pnlTotalMeetings
            // 
            pnlTotalMeetings.BackColor = Color.White;
            pnlTotalMeetings.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalMeetings.Controls.Add(lblMeetingsTitle);
            pnlTotalMeetings.Controls.Add(lblMeetingsCount);
            pnlTotalMeetings.Location = new Point(626, 68);
            pnlTotalMeetings.Name = "pnlTotalMeetings";
            pnlTotalMeetings.Size = new Size(288, 82);
            pnlTotalMeetings.TabIndex = 5;
            // 
            // lblMeetingsTitle
            // 
            lblMeetingsTitle.AutoSize = true;
            lblMeetingsTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMeetingsTitle.ForeColor = Color.FromArgb(85, 121, 69);
            lblMeetingsTitle.Location = new Point(14, 10);
            lblMeetingsTitle.Name = "lblMeetingsTitle";
            lblMeetingsTitle.Size = new Size(105, 15);
            lblMeetingsTitle.TabIndex = 0;
            lblMeetingsTitle.Text = "TOTAL MEETINGS";
            // 
            // lblMeetingsCount
            // 
            lblMeetingsCount.AutoSize = true;
            lblMeetingsCount.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblMeetingsCount.Location = new Point(12, 30);
            lblMeetingsCount.Name = "lblMeetingsCount";
            lblMeetingsCount.Size = new Size(35, 41);
            lblMeetingsCount.TabIndex = 1;
            lblMeetingsCount.Text = "0";
            // 
            // pnlPendingRequests
            // 
            pnlPendingRequests.BackColor = Color.White;
            pnlPendingRequests.BorderStyle = BorderStyle.FixedSingle;
            pnlPendingRequests.Controls.Add(lblPendingTitle);
            pnlPendingRequests.Controls.Add(lblPendingCount);
            pnlPendingRequests.Location = new Point(932, 68);
            pnlPendingRequests.Name = "pnlPendingRequests";
            pnlPendingRequests.Size = new Size(288, 82);
            pnlPendingRequests.TabIndex = 6;
            // 
            // lblPendingTitle
            // 
            lblPendingTitle.AutoSize = true;
            lblPendingTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPendingTitle.ForeColor = Color.DarkOrange;
            lblPendingTitle.Location = new Point(14, 10);
            lblPendingTitle.Name = "lblPendingTitle";
            lblPendingTitle.Size = new Size(122, 15);
            lblPendingTitle.TabIndex = 0;
            lblPendingTitle.Text = "PENDING REQUESTS";
            // 
            // lblPendingCount
            // 
            lblPendingCount.AutoSize = true;
            lblPendingCount.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblPendingCount.Location = new Point(12, 30);
            lblPendingCount.Name = "lblPendingCount";
            lblPendingCount.Size = new Size(35, 41);
            lblPendingCount.TabIndex = 1;
            lblPendingCount.Text = "0";
            // 
            // lblAppointmentsTitle
            // 
            lblAppointmentsTitle.AutoSize = true;
            lblAppointmentsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAppointmentsTitle.Location = new Point(14, 166);
            lblAppointmentsTitle.Name = "lblAppointmentsTitle";
            lblAppointmentsTitle.Size = new Size(165, 21);
            lblAppointmentsTitle.TabIndex = 7;
            lblAppointmentsTitle.Text = "Scheduled Meetings";
            // 
            // lblFilterStatus
            // 
            lblFilterStatus.AutoSize = true;
            lblFilterStatus.Font = new Font("Segoe UI", 9.75F);
            lblFilterStatus.Location = new Point(340, 168);
            lblFilterStatus.Name = "lblFilterStatus";
            lblFilterStatus.Size = new Size(46, 17);
            lblFilterStatus.TabIndex = 8;
            lblFilterStatus.Text = "Status:";
            // 
            // cmbFilterStatus
            // 
            cmbFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterStatus.Font = new Font("Segoe UI", 9.75F);
            cmbFilterStatus.FormattingEnabled = true;
            cmbFilterStatus.Items.AddRange(new object[] { "All", "Pending", "Approved", "Declined", "Completed", "Cancelled" });
            cmbFilterStatus.Location = new Point(390, 164);
            cmbFilterStatus.Name = "cmbFilterStatus";
            cmbFilterStatus.Size = new Size(130, 25);
            cmbFilterStatus.TabIndex = 9;
            cmbFilterStatus.SelectedIndexChanged += cmbFilterStatus_SelectedIndexChanged;
            // 
            // lblSearchAppointment
            // 
            lblSearchAppointment.AutoSize = true;
            lblSearchAppointment.Font = new Font("Segoe UI", 9.75F);
            lblSearchAppointment.Location = new Point(540, 168);
            lblSearchAppointment.Name = "lblSearchAppointment";
            lblSearchAppointment.Size = new Size(50, 17);
            lblSearchAppointment.TabIndex = 10;
            lblSearchAppointment.Text = "Search:";
            // 
            // txtSearchAppointment
            // 
            txtSearchAppointment.Font = new Font("Segoe UI", 9.75F);
            txtSearchAppointment.Location = new Point(595, 164);
            txtSearchAppointment.Name = "txtSearchAppointment";
            txtSearchAppointment.Size = new Size(385, 25);
            txtSearchAppointment.TabIndex = 11;
            txtSearchAppointment.TextChanged += txtSearchAppointment_TextChanged;
            txtSearchAppointment.KeyDown += txtSearchAppointment_KeyDown;
            // 
            // btnSearchAppointment
            // 
            btnSearchAppointment.BackColor = Color.CornflowerBlue;
            btnSearchAppointment.FlatStyle = FlatStyle.Flat;
            btnSearchAppointment.Font = new Font("Segoe UI", 9.75F);
            btnSearchAppointment.ForeColor = Color.White;
            btnSearchAppointment.Location = new Point(990, 163);
            btnSearchAppointment.Name = "btnSearchAppointment";
            btnSearchAppointment.Size = new Size(105, 28);
            btnSearchAppointment.TabIndex = 12;
            btnSearchAppointment.Text = "Search";
            btnSearchAppointment.UseVisualStyleBackColor = false;
            btnSearchAppointment.Click += btnSearchAppointment_Click;
            // 
            // btnResetAppointmentFilter
            // 
            btnResetAppointmentFilter.BackColor = Color.LightGray;
            btnResetAppointmentFilter.FlatStyle = FlatStyle.Flat;
            btnResetAppointmentFilter.Font = new Font("Segoe UI", 9.75F);
            btnResetAppointmentFilter.ForeColor = Color.Black;
            btnResetAppointmentFilter.Location = new Point(1105, 163);
            btnResetAppointmentFilter.Name = "btnResetAppointmentFilter";
            btnResetAppointmentFilter.Size = new Size(113, 28);
            btnResetAppointmentFilter.TabIndex = 13;
            btnResetAppointmentFilter.Text = "Reset";
            btnResetAppointmentFilter.UseVisualStyleBackColor = false;
            btnResetAppointmentFilter.Click += btnResetAppointmentFilter_Click;
            // 
            // dgvAppointments
            // 
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.AllowUserToDeleteRows = false;
            dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointments.BackgroundColor = SystemColors.Control;
            dgvAppointments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Font = new Font("Segoe UI", 9.75F);
            dgvAppointments.Location = new Point(14, 198);
            dgvAppointments.MultiSelect = false;
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(1204, 372);
            dgvAppointments.TabIndex = 14;
            // 
            // tabUsers
            // 
            tabUsers.BorderStyle = BorderStyle.FixedSingle;
            tabUsers.Controls.Add(btnDelete);
            tabUsers.Controls.Add(btnUpdate);
            tabUsers.Controls.Add(btnSave);
            tabUsers.Controls.Add(btnSearch);
            tabUsers.Controls.Add(txtSearchName);
            tabUsers.Controls.Add(label2);
            tabUsers.Controls.Add(dgvUsers);
            tabUsers.Font = new Font("Microsoft Sans Serif", 12.25F);
            tabUsers.Location = new Point(4, 24);
            tabUsers.Name = "tabUsers";
            tabUsers.Padding = new Padding(8);
            tabUsers.Size = new Size(1234, 582);
            tabUsers.TabIndex = 1;
            tabUsers.Text = "Users";
            tabUsers.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Tomato;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(849, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 31);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.CornflowerBlue;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(975, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 31);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(85, 121, 69);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(1101, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 31);
            btnSave.TabIndex = 5;
            btnSave.Text = "Add";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.CornflowerBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Microsoft Sans Serif", 10.25F);
            btnSearch.ForeColor = SystemColors.Control;
            btnSearch.Location = new Point(660, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 32);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(152, 5);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(502, 26);
            txtSearchName.TabIndex = 2;
            txtSearchName.TextChanged += txtSearchName_TextChanged;
            txtSearchName.KeyDown += txtSearchName_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 8);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 1;
            label2.Text = "Search by name:";
            // 
            // dgvUsers
            // 
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = SystemColors.Control;
            dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(11, 37);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(1210, 534);
            dgvUsers.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(lblGreeting);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.Control;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 63);
            panel1.TabIndex = 2;
            // 
            // lblGreeting
            // 
            lblGreeting.AutoSize = true;
            lblGreeting.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGreeting.Location = new Point(14, 32);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(190, 17);
            lblGreeting.TabIndex = 2;
            lblGreeting.Text = "Welcome Vince Angelo Batecan";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(192, 0, 0);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(1163, 31);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(79, 27);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 8);
            label1.Name = "label1";
            label1.Size = new Size(398, 25);
            label1.TabIndex = 0;
            label1.Text = "DCSS Meeting Scheduler Admin Dashboard";
            label1.Click += label1_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 690);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Form";
            FormClosed += Dashboard_FormClosed;
            Load += AdminForm_Load;
            tabControl1.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            tabHome.PerformLayout();
            pnlTotalFaculty.ResumeLayout(false);
            pnlTotalFaculty.PerformLayout();
            pnlTotalStudents.ResumeLayout(false);
            pnlTotalStudents.PerformLayout();
            pnlTotalMeetings.ResumeLayout(false);
            pnlTotalMeetings.PerformLayout();
            pnlPendingRequests.ResumeLayout(false);
            pnlPendingRequests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            tabUsers.ResumeLayout(false);
            tabUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabHome;
        private Label lblHomeTitle;
        private Label lblHomeSubtitle;
        private Button btnRefreshHome;
        private Panel pnlTotalFaculty;
        private Label lblFacultyTitle;
        private Label lblFacultyCount;
        private Panel pnlTotalStudents;
        private Label lblStudentsTitle;
        private Label lblStudentsCount;
        private Panel pnlTotalMeetings;
        private Label lblMeetingsTitle;
        private Label lblMeetingsCount;
        private Panel pnlPendingRequests;
        private Label lblPendingTitle;
        private Label lblPendingCount;
        private Label lblAppointmentsTitle;
        private Label lblFilterStatus;
        private ComboBox cmbFilterStatus;
        private Label lblSearchAppointment;
        private TextBox txtSearchAppointment;
        private Button btnSearchAppointment;
        private Button btnResetAppointmentFilter;
        private DataGridView dgvAppointments;
        private TabPage tabUsers;
        private Panel panel1;
        private Button btnLogout;
        private Label label1;
        private Label lblGreeting;
        private Button btnSearch;
        private TextBox txtSearchName;
        private Label label2;
        private DataGridView dgvUsers;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
    }
}