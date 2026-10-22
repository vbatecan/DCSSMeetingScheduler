namespace DCSSMeetingScheduler.Faculty
{
    partial class Faculty
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            tabFaculty = new TabControl();
            tabHome = new TabPage();
            grpRecentMeet = new GroupBox();
            dgvRecentRequest = new DataGridView();
            request_id = new DataGridViewTextBoxColumn();
            stud_name = new DataGridViewTextBoxColumn();
            meeting_date = new DataGridViewTextBoxColumn();
            start_time = new DataGridViewTextBoxColumn();
            end_time = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            faculty_remarks = new DataGridViewTextBoxColumn();
            pnlNotifs = new Panel();
            btnRefresh = new Button();
            lblNotifs = new Label();
            grpOverview = new GroupBox();
            panel2 = new Panel();
            label1 = new Label();
            lblTotalUpMeet = new Label();
            panel1 = new Panel();
            lblTodaysMeeting = new Label();
            lblTotalMeeting = new Label();
            panel5 = new Panel();
            lblOverviewSub = new Label();
            lblDashboard = new Label();
            pnlPending = new Panel();
            lblPendingTotal = new Label();
            label4 = new Label();
            pnlTotal = new Panel();
            lblTotal = new Label();
            label3 = new Label();
            pnlDeclined = new Panel();
            lblDeclinedTotal = new Label();
            label6 = new Label();
            pnlApproved = new Panel();
            lblApprovedTotal = new Label();
            label5 = new Label();
            tabRequest = new TabPage();
            tabAvailability = new TabPage();
            groupBox2 = new GroupBox();
            Tips = new TextBox();
            EditBTN = new Button();
            DeleteBTN = new Button();
            SearchBTN = new Button();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            button1 = new Button();
            AddBTN = new Button();
            textBox1 = new TextBox();
            lblLocation = new Label();
            dateTimePicker3 = new DateTimePicker();
            lblEndTime = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblStartTime = new Label();
            comboBox1 = new ComboBox();
            lblDayOfWeek = new Label();
            tabSettings = new TabPage();
            btnLogout = new Button();
            pnlPreferences = new Panel();
            btnRefreshPreferences = new Button();
            btnSavePreferences = new Button();
            chkShowRecentRequestDashboard = new CheckBox();
            chkShowRequestDashboard = new CheckBox();
            lblDisplaySettings = new Label();
            lblNotifications = new Label();
            chkConsultationReminder = new CheckBox();
            chkDesktopNotif = new CheckBox();
            chkEmailNotif = new CheckBox();
            cmbDefaultTab = new ComboBox();
            lblDefaultTab = new Label();
            lblTheme = new Label();
            cmbTheme = new ComboBox();
            lblPreferencesSub = new Label();
            lblPreferencesHeading = new Label();
            pnlAccountSettings = new Panel();
            btnChangePassword = new Button();
            lblAccountSub = new Label();
            txtConfirmPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtCurrentPassword = new TextBox();
            lblConfirmPassword = new Label();
            lblNewPassword = new Label();
            lblCurrentPassword = new Label();
            lblAccountSettingsHeading = new Label();
            pnlAppInfo = new Panel();
            lblLastLoginValue = new Label();
            lblDatabaseValue = new Label();
            lblVersionValue = new Label();
            lblLastLogin = new Label();
            lblDatabase = new Label();
            lblVersion = new Label();
            lblAppInfoSub = new Label();
            lblAppInforHeading = new Label();
            pnlFacultyProfile = new Panel();
            btnEditProfile = new Button();
            lblProfilSub = new Label();
            lblPosition = new Label();
            lblDepartment = new Label();
            lblEmail = new Label();
            lblName = new Label();
            txtPosition = new TextBox();
            txtDepartment = new TextBox();
            txtFacultyEmail = new TextBox();
            txtFacultyName = new TextBox();
            lblProfileHeading = new Label();
            pnlHeaderSetting = new Panel();
            lblSettingSub = new Label();
            lblTitleSetting = new Label();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlHeader = new Panel();
            tabFaculty.SuspendLayout();
            tabHome.SuspendLayout();
            grpRecentMeet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentRequest).BeginInit();
            pnlNotifs.SuspendLayout();
            grpOverview.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            pnlPending.SuspendLayout();
            pnlTotal.SuspendLayout();
            pnlDeclined.SuspendLayout();
            pnlApproved.SuspendLayout();
            tabAvailability.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            tabSettings.SuspendLayout();
            pnlPreferences.SuspendLayout();
            pnlAccountSettings.SuspendLayout();
            pnlAppInfo.SuspendLayout();
            pnlFacultyProfile.SuspendLayout();
            pnlHeaderSetting.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // tabFaculty
            // 
            tabFaculty.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabFaculty.Controls.Add(tabHome);
            tabFaculty.Controls.Add(tabRequest);
            tabFaculty.Controls.Add(tabAvailability);
            tabFaculty.Controls.Add(tabSettings);
            tabFaculty.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabFaculty.Location = new Point(0, 101);
            tabFaculty.Margin = new Padding(2);
            tabFaculty.Name = "tabFaculty";
            tabFaculty.SelectedIndex = 0;
            tabFaculty.Size = new Size(1266, 671);
            tabFaculty.TabIndex = 0;
            // 
            // tabHome
            // 
            tabHome.BackColor = Color.WhiteSmoke;
            tabHome.Controls.Add(grpRecentMeet);
            tabHome.Controls.Add(pnlNotifs);
            tabHome.Controls.Add(grpOverview);
            tabHome.Controls.Add(panel5);
            tabHome.Controls.Add(pnlPending);
            tabHome.Controls.Add(pnlTotal);
            tabHome.Controls.Add(pnlDeclined);
            tabHome.Controls.Add(pnlApproved);
            tabHome.Location = new Point(4, 24);
            tabHome.Margin = new Padding(2);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(2);
            tabHome.Size = new Size(1258, 643);
            tabHome.TabIndex = 0;
            tabHome.Text = "Home";
            // 
            // grpRecentMeet
            // 
            grpRecentMeet.BackColor = Color.White;
            grpRecentMeet.Controls.Add(dgvRecentRequest);
            grpRecentMeet.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            grpRecentMeet.ForeColor = Color.DarkGreen;
            grpRecentMeet.Location = new Point(16, 386);
            grpRecentMeet.Name = "grpRecentMeet";
            grpRecentMeet.Size = new Size(1230, 244);
            grpRecentMeet.TabIndex = 13;
            grpRecentMeet.TabStop = false;
            grpRecentMeet.Text = "Recent Meetings Request";
            // 
            // dgvRecentRequest
            // 
            dgvRecentRequest.AllowUserToAddRows = false;
            dgvRecentRequest.AllowUserToDeleteRows = false;
            dgvRecentRequest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentRequest.BackgroundColor = SystemColors.ControlLight;
            dgvRecentRequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentRequest.Columns.AddRange(new DataGridViewColumn[] { request_id, stud_name, meeting_date, start_time, end_time, status, faculty_remarks });
            dgvRecentRequest.GridColor = SystemColors.ActiveBorder;
            dgvRecentRequest.Location = new Point(15, 40);
            dgvRecentRequest.MultiSelect = false;
            dgvRecentRequest.Name = "dgvRecentRequest";
            dgvRecentRequest.ReadOnly = true;
            dgvRecentRequest.RowHeadersVisible = false;
            dgvRecentRequest.RowHeadersWidth = 20;
            dgvRecentRequest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentRequest.Size = new Size(1200, 188);
            dgvRecentRequest.TabIndex = 9;
            dgvRecentRequest.CellContentClick += dgvRecentRequest_CellContentClick_1;
            // 
            // request_id
            // 
            request_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            request_id.HeaderText = "Request ID";
            request_id.Name = "request_id";
            request_id.ReadOnly = true;
            request_id.Width = 146;
            // 
            // stud_name
            // 
            stud_name.HeaderText = "Student Name";
            stud_name.Name = "stud_name";
            stud_name.ReadOnly = true;
            // 
            // meeting_date
            // 
            meeting_date.HeaderText = "Meeting Date";
            meeting_date.Name = "meeting_date";
            meeting_date.ReadOnly = true;
            // 
            // start_time
            // 
            start_time.HeaderText = "Start Time";
            start_time.Name = "start_time";
            start_time.ReadOnly = true;
            // 
            // end_time
            // 
            end_time.HeaderText = "End Time";
            end_time.Name = "end_time";
            end_time.ReadOnly = true;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // faculty_remarks
            // 
            faculty_remarks.HeaderText = "Faculty Remarks";
            faculty_remarks.Name = "faculty_remarks";
            faculty_remarks.ReadOnly = true;
            // 
            // pnlNotifs
            // 
            pnlNotifs.BackColor = Color.MintCream;
            pnlNotifs.BorderStyle = BorderStyle.FixedSingle;
            pnlNotifs.Controls.Add(btnRefresh);
            pnlNotifs.Controls.Add(lblNotifs);
            pnlNotifs.Location = new Point(16, 317);
            pnlNotifs.Name = "pnlNotifs";
            pnlNotifs.Size = new Size(1230, 62);
            pnlNotifs.TabIndex = 12;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.SeaGreen;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1099, 14);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(115, 35);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // lblNotifs
            // 
            lblNotifs.AutoSize = true;
            lblNotifs.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotifs.Location = new Point(14, 20);
            lblNotifs.Name = "lblNotifs";
            lblNotifs.Size = new Size(240, 17);
            lblNotifs.TabIndex = 13;
            lblNotifs.Text = "You have new meeting request updates.";
            // 
            // grpOverview
            // 
            grpOverview.BackColor = Color.White;
            grpOverview.Controls.Add(panel2);
            grpOverview.Controls.Add(panel1);
            grpOverview.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            grpOverview.ForeColor = Color.DarkGreen;
            grpOverview.Location = new Point(16, 198);
            grpOverview.Name = "grpOverview";
            grpOverview.Size = new Size(1230, 116);
            grpOverview.TabIndex = 11;
            grpOverview.TabStop = false;
            grpOverview.Text = "Today's Overview";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblTotalUpMeet);
            panel2.Location = new Point(615, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 51);
            panel2.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(14, 16);
            label1.Name = "label1";
            label1.Size = new Size(137, 17);
            label1.TabIndex = 12;
            label1.Text = "Upcoming Meetings: ";
            label1.Click += label1_Click;
            // 
            // lblTotalUpMeet
            // 
            lblTotalUpMeet.AutoSize = true;
            lblTotalUpMeet.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTotalUpMeet.ForeColor = Color.Black;
            lblTotalUpMeet.Location = new Point(148, 16);
            lblTotalUpMeet.Name = "lblTotalUpMeet";
            lblTotalUpMeet.Size = new Size(17, 19);
            lblTotalUpMeet.TabIndex = 12;
            lblTotalUpMeet.Text = "0";
            lblTotalUpMeet.Click += lblTotalUpMeet_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblTodaysMeeting);
            panel1.Controls.Add(lblTotalMeeting);
            panel1.Location = new Point(15, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(594, 51);
            panel1.TabIndex = 12;
            // 
            // lblTodaysMeeting
            // 
            lblTodaysMeeting.AutoSize = true;
            lblTodaysMeeting.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodaysMeeting.ForeColor = Color.Black;
            lblTodaysMeeting.Location = new Point(14, 15);
            lblTodaysMeeting.Name = "lblTodaysMeeting";
            lblTodaysMeeting.Size = new Size(119, 17);
            lblTodaysMeeting.TabIndex = 0;
            lblTodaysMeeting.Text = "Today's Meetings: ";
            // 
            // lblTotalMeeting
            // 
            lblTotalMeeting.AutoSize = true;
            lblTotalMeeting.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTotalMeeting.ForeColor = Color.Black;
            lblTotalMeeting.Location = new Point(130, 15);
            lblTotalMeeting.Name = "lblTotalMeeting";
            lblTotalMeeting.Size = new Size(17, 19);
            lblTotalMeeting.TabIndex = 1;
            lblTotalMeeting.Text = "0";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(lblOverviewSub);
            panel5.Controls.Add(lblDashboard);
            panel5.Location = new Point(5, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(1248, 89);
            panel5.TabIndex = 10;
            // 
            // lblOverviewSub
            // 
            lblOverviewSub.AutoSize = true;
            lblOverviewSub.Location = new Point(16, 51);
            lblOverviewSub.Name = "lblOverviewSub";
            lblOverviewSub.Size = new Size(224, 15);
            lblOverviewSub.TabIndex = 3;
            lblOverviewSub.Text = "Overview of student consultation request";
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.ForeColor = Color.DarkGreen;
            lblDashboard.Location = new Point(10, 12);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(225, 32);
            lblDashboard.TabIndex = 2;
            lblDashboard.Text = "Faculty Dashboard";
            // 
            // pnlPending
            // 
            pnlPending.BackColor = Color.White;
            pnlPending.BorderStyle = BorderStyle.FixedSingle;
            pnlPending.Controls.Add(lblPendingTotal);
            pnlPending.Controls.Add(label4);
            pnlPending.Location = new Point(318, 100);
            pnlPending.Margin = new Padding(3, 2, 3, 2);
            pnlPending.Name = "pnlPending";
            pnlPending.Size = new Size(307, 93);
            pnlPending.TabIndex = 9;
            // 
            // lblPendingTotal
            // 
            lblPendingTotal.AutoSize = true;
            lblPendingTotal.Font = new Font("Segoe UI", 14F);
            lblPendingTotal.Location = new Point(18, 41);
            lblPendingTotal.Name = "lblPendingTotal";
            lblPendingTotal.Size = new Size(22, 25);
            lblPendingTotal.TabIndex = 1;
            lblPendingTotal.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(18, 15);
            label4.Name = "label4";
            label4.Size = new Size(60, 19);
            label4.TabIndex = 0;
            label4.Text = "Pending";
            // 
            // pnlTotal
            // 
            pnlTotal.BackColor = Color.White;
            pnlTotal.BorderStyle = BorderStyle.FixedSingle;
            pnlTotal.Controls.Add(lblTotal);
            pnlTotal.Controls.Add(label3);
            pnlTotal.Location = new Point(5, 100);
            pnlTotal.Margin = new Padding(3, 2, 3, 2);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(307, 93);
            pnlTotal.TabIndex = 8;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14F);
            lblTotal.Location = new Point(16, 41);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(22, 25);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(16, 15);
            label3.Name = "label3";
            label3.Size = new Size(100, 19);
            label3.TabIndex = 0;
            label3.Text = "Total Requests";
            // 
            // pnlDeclined
            // 
            pnlDeclined.BackColor = Color.White;
            pnlDeclined.BorderStyle = BorderStyle.FixedSingle;
            pnlDeclined.Controls.Add(lblDeclinedTotal);
            pnlDeclined.Controls.Add(label6);
            pnlDeclined.Location = new Point(944, 100);
            pnlDeclined.Margin = new Padding(3, 2, 3, 2);
            pnlDeclined.Name = "pnlDeclined";
            pnlDeclined.Size = new Size(307, 93);
            pnlDeclined.TabIndex = 7;
            // 
            // lblDeclinedTotal
            // 
            lblDeclinedTotal.AutoSize = true;
            lblDeclinedTotal.Font = new Font("Segoe UI", 14F);
            lblDeclinedTotal.Location = new Point(18, 41);
            lblDeclinedTotal.Name = "lblDeclinedTotal";
            lblDeclinedTotal.Size = new Size(22, 25);
            lblDeclinedTotal.TabIndex = 2;
            lblDeclinedTotal.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(18, 15);
            label6.Name = "label6";
            label6.Size = new Size(64, 19);
            label6.TabIndex = 0;
            label6.Text = "Declined";
            // 
            // pnlApproved
            // 
            pnlApproved.BackColor = Color.White;
            pnlApproved.BorderStyle = BorderStyle.FixedSingle;
            pnlApproved.Controls.Add(lblApprovedTotal);
            pnlApproved.Controls.Add(label5);
            pnlApproved.Location = new Point(631, 100);
            pnlApproved.Margin = new Padding(3, 2, 3, 2);
            pnlApproved.Name = "pnlApproved";
            pnlApproved.Size = new Size(307, 93);
            pnlApproved.TabIndex = 6;
            // 
            // lblApprovedTotal
            // 
            lblApprovedTotal.AutoSize = true;
            lblApprovedTotal.Font = new Font("Segoe UI", 14F);
            lblApprovedTotal.Location = new Point(16, 41);
            lblApprovedTotal.Name = "lblApprovedTotal";
            lblApprovedTotal.Size = new Size(22, 25);
            lblApprovedTotal.TabIndex = 1;
            lblApprovedTotal.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(16, 15);
            label5.Name = "label5";
            label5.Size = new Size(69, 19);
            label5.TabIndex = 0;
            label5.Text = "Approved";
            // 
            // tabRequest
            // 
            tabRequest.BackColor = Color.WhiteSmoke;
            tabRequest.Location = new Point(4, 24);
            tabRequest.Margin = new Padding(2);
            tabRequest.Name = "tabRequest";
            tabRequest.Padding = new Padding(2);
            tabRequest.Size = new Size(1258, 643);
            tabRequest.TabIndex = 1;
            tabRequest.Text = "Request";
            // 
            // tabAvailability
            // 
            tabAvailability.BackColor = Color.WhiteSmoke;
            tabAvailability.Controls.Add(groupBox2);
            tabAvailability.Controls.Add(groupBox1);
            tabAvailability.Location = new Point(4, 24);
            tabAvailability.Margin = new Padding(2);
            tabAvailability.Name = "tabAvailability";
            tabAvailability.Padding = new Padding(2);
            tabAvailability.Size = new Size(1258, 643);
            tabAvailability.TabIndex = 2;
            tabAvailability.Text = "Availabillity";
            tabAvailability.Click += AvailabilityPage_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Tips);
            groupBox2.Controls.Add(EditBTN);
            groupBox2.Controls.Add(DeleteBTN);
            groupBox2.Controls.Add(SearchBTN);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(290, 76);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(573, 328);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Weekly Consultation Hours";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // Tips
            // 
            Tips.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tips.Location = new Point(5, 290);
            Tips.Margin = new Padding(3, 2, 3, 2);
            Tips.Name = "Tips";
            Tips.Size = new Size(405, 23);
            Tips.TabIndex = 5;
            Tips.Text = "Tips Click \"Add New\" to create new  consultation hours. ";
            // 
            // EditBTN
            // 
            EditBTN.Location = new Point(427, 289);
            EditBTN.Margin = new Padding(3, 2, 3, 2);
            EditBTN.Name = "EditBTN";
            EditBTN.Size = new Size(59, 25);
            EditBTN.TabIndex = 4;
            EditBTN.Text = "Edit";
            EditBTN.UseVisualStyleBackColor = true;
            // 
            // DeleteBTN
            // 
            DeleteBTN.Location = new Point(491, 289);
            DeleteBTN.Margin = new Padding(3, 2, 3, 2);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(59, 25);
            DeleteBTN.TabIndex = 3;
            DeleteBTN.Text = "Delete";
            DeleteBTN.UseVisualStyleBackColor = true;
            // 
            // SearchBTN
            // 
            SearchBTN.Location = new Point(351, 12);
            SearchBTN.Margin = new Padding(3, 2, 3, 2);
            SearchBTN.Name = "SearchBTN";
            SearchBTN.Size = new Size(59, 25);
            SearchBTN.TabIndex = 1;
            SearchBTN.Text = "Search";
            SearchBTN.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(351, 15);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.FromArgb(240, 243, 246);
            dataGridView1.Location = new Point(5, 43);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(544, 241);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(AddBTN);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(lblLocation);
            groupBox1.Controls.Add(dateTimePicker3);
            groupBox1.Controls.Add(lblEndTime);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(lblStartTime);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(lblDayOfWeek);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(11, 76);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(260, 328);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add / Consultation Hours";
            // 
            // button1
            // 
            button1.Location = new Point(143, 249);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(83, 25);
            button1.TabIndex = 7;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            // 
            // AddBTN
            // 
            AddBTN.Location = new Point(29, 249);
            AddBTN.Margin = new Padding(3, 2, 3, 2);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(83, 25);
            AddBTN.TabIndex = 1;
            AddBTN.Text = "+   Add";
            AddBTN.UseVisualStyleBackColor = true;
            AddBTN.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(18, 205);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "  e.g Room 101, Online etc.";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLocation.Location = new Point(18, 188);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(90, 12);
            lblLocation.TabIndex = 6;
            lblLocation.Text = "Location (Optional)";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CustomFormat = "hh:mm";
            dateTimePicker3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Location = new Point(21, 154);
            dateTimePicker3.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.ShowUpDown = true;
            dateTimePicker3.Size = new Size(220, 23);
            dateTimePicker3.TabIndex = 5;
            // 
            // lblEndTime
            // 
            lblEndTime.AutoSize = true;
            lblEndTime.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEndTime.Location = new Point(18, 137);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new Size(46, 12);
            lblEndTime.TabIndex = 4;
            lblEndTime.Text = "End Time";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "hh:mm";
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(21, 100);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(220, 23);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStartTime.Location = new Point(18, 84);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(48, 12);
            lblStartTime.TabIndex = 3;
            lblStartTime.Text = "Start Time";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" });
            comboBox1.Location = new Point(18, 43);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(224, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // lblDayOfWeek
            // 
            lblDayOfWeek.AutoSize = true;
            lblDayOfWeek.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDayOfWeek.Location = new Point(18, 25);
            lblDayOfWeek.Name = "lblDayOfWeek";
            lblDayOfWeek.Size = new Size(61, 12);
            lblDayOfWeek.TabIndex = 2;
            lblDayOfWeek.Text = "Day of Week";
            lblDayOfWeek.Click += label2_Click;
            // 
            // tabSettings
            // 
            tabSettings.AutoScroll = true;
            tabSettings.BackColor = Color.WhiteSmoke;
            tabSettings.Controls.Add(btnLogout);
            tabSettings.Controls.Add(pnlPreferences);
            tabSettings.Controls.Add(pnlAccountSettings);
            tabSettings.Controls.Add(pnlAppInfo);
            tabSettings.Controls.Add(pnlFacultyProfile);
            tabSettings.Controls.Add(pnlHeaderSetting);
            tabSettings.Location = new Point(4, 24);
            tabSettings.Margin = new Padding(2);
            tabSettings.Name = "tabSettings";
            tabSettings.Padding = new Padding(2);
            tabSettings.Size = new Size(1258, 643);
            tabSettings.TabIndex = 3;
            tabSettings.Text = "Setting";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.SeaGreen;
            btnLogout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(8, 590);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 40);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnlPreferences
            // 
            pnlPreferences.BackColor = Color.White;
            pnlPreferences.BorderStyle = BorderStyle.FixedSingle;
            pnlPreferences.Controls.Add(btnRefreshPreferences);
            pnlPreferences.Controls.Add(btnSavePreferences);
            pnlPreferences.Controls.Add(chkShowRecentRequestDashboard);
            pnlPreferences.Controls.Add(chkShowRequestDashboard);
            pnlPreferences.Controls.Add(lblDisplaySettings);
            pnlPreferences.Controls.Add(lblNotifications);
            pnlPreferences.Controls.Add(chkConsultationReminder);
            pnlPreferences.Controls.Add(chkDesktopNotif);
            pnlPreferences.Controls.Add(chkEmailNotif);
            pnlPreferences.Controls.Add(cmbDefaultTab);
            pnlPreferences.Controls.Add(lblDefaultTab);
            pnlPreferences.Controls.Add(lblTheme);
            pnlPreferences.Controls.Add(cmbTheme);
            pnlPreferences.Controls.Add(lblPreferencesSub);
            pnlPreferences.Controls.Add(lblPreferencesHeading);
            pnlPreferences.Location = new Point(366, 350);
            pnlPreferences.Name = "pnlPreferences";
            pnlPreferences.Size = new Size(887, 233);
            pnlPreferences.TabIndex = 4;
            // 
            // btnRefreshPreferences
            // 
            btnRefreshPreferences.BackColor = Color.SeaGreen;
            btnRefreshPreferences.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshPreferences.ForeColor = Color.White;
            btnRefreshPreferences.Location = new Point(763, 182);
            btnRefreshPreferences.Name = "btnRefreshPreferences";
            btnRefreshPreferences.Size = new Size(101, 33);
            btnRefreshPreferences.TabIndex = 14;
            btnRefreshPreferences.Text = "Refresh";
            btnRefreshPreferences.UseVisualStyleBackColor = false;
            btnRefreshPreferences.Click += btnRefreshPreferences_Click;
            // 
            // btnSavePreferences
            // 
            btnSavePreferences.BackColor = Color.SeaGreen;
            btnSavePreferences.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSavePreferences.ForeColor = Color.White;
            btnSavePreferences.Location = new Point(761, 139);
            btnSavePreferences.Name = "btnSavePreferences";
            btnSavePreferences.Size = new Size(103, 34);
            btnSavePreferences.TabIndex = 13;
            btnSavePreferences.Text = "Save Changes";
            btnSavePreferences.UseVisualStyleBackColor = false;
            btnSavePreferences.Click += btnSavePreferences_Click;
            // 
            // chkShowRecentRequestDashboard
            // 
            chkShowRecentRequestDashboard.AutoSize = true;
            chkShowRecentRequestDashboard.Location = new Point(479, 180);
            chkShowRecentRequestDashboard.Name = "chkShowRecentRequestDashboard";
            chkShowRecentRequestDashboard.Size = new Size(249, 19);
            chkShowRecentRequestDashboard.TabIndex = 12;
            chkShowRecentRequestDashboard.Text = "Show recent request on faculty Dashboard";
            chkShowRecentRequestDashboard.UseVisualStyleBackColor = true;
            // 
            // chkShowRequestDashboard
            // 
            chkShowRequestDashboard.AutoSize = true;
            chkShowRequestDashboard.Location = new Point(479, 158);
            chkShowRequestDashboard.Name = "chkShowRequestDashboard";
            chkShowRequestDashboard.Size = new Size(215, 19);
            chkShowRequestDashboard.TabIndex = 11;
            chkShowRequestDashboard.Text = "Show request on Faculty Dashboard\r\n";
            chkShowRequestDashboard.UseVisualStyleBackColor = true;
            // 
            // lblDisplaySettings
            // 
            lblDisplaySettings.AutoSize = true;
            lblDisplaySettings.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisplaySettings.Location = new Point(469, 135);
            lblDisplaySettings.Name = "lblDisplaySettings";
            lblDisplaySettings.Size = new Size(104, 17);
            lblDisplaySettings.TabIndex = 10;
            lblDisplaySettings.Text = "Display Settings";
            // 
            // lblNotifications
            // 
            lblNotifications.AutoSize = true;
            lblNotifications.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotifications.Location = new Point(21, 135);
            lblNotifications.Name = "lblNotifications";
            lblNotifications.Size = new Size(84, 17);
            lblNotifications.TabIndex = 9;
            lblNotifications.Text = "Notifications";
            // 
            // chkConsultationReminder
            // 
            chkConsultationReminder.AutoSize = true;
            chkConsultationReminder.Location = new Point(26, 204);
            chkConsultationReminder.Name = "chkConsultationReminder";
            chkConsultationReminder.Size = new Size(232, 19);
            chkConsultationReminder.TabIndex = 8;
            chkConsultationReminder.Text = "Reminders for upcoming consultations";
            chkConsultationReminder.UseVisualStyleBackColor = true;
            // 
            // chkDesktopNotif
            // 
            chkDesktopNotif.AutoSize = true;
            chkDesktopNotif.Location = new Point(26, 181);
            chkDesktopNotif.Name = "chkDesktopNotif";
            chkDesktopNotif.Size = new Size(133, 19);
            chkDesktopNotif.TabIndex = 7;
            chkDesktopNotif.Text = "Desktop notification";
            chkDesktopNotif.UseVisualStyleBackColor = true;
            // 
            // chkEmailNotif
            // 
            chkEmailNotif.AutoSize = true;
            chkEmailNotif.Location = new Point(26, 158);
            chkEmailNotif.Name = "chkEmailNotif";
            chkEmailNotif.Size = new Size(229, 19);
            chkEmailNotif.TabIndex = 6;
            chkEmailNotif.Text = "Email notifications for request updates";
            chkEmailNotif.UseVisualStyleBackColor = true;
            // 
            // cmbDefaultTab
            // 
            cmbDefaultTab.FormattingEnabled = true;
            cmbDefaultTab.Location = new Point(469, 88);
            cmbDefaultTab.Name = "cmbDefaultTab";
            cmbDefaultTab.Size = new Size(395, 23);
            cmbDefaultTab.TabIndex = 5;
            // 
            // lblDefaultTab
            // 
            lblDefaultTab.AutoSize = true;
            lblDefaultTab.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDefaultTab.Location = new Point(469, 66);
            lblDefaultTab.Name = "lblDefaultTab";
            lblDefaultTab.Size = new Size(76, 17);
            lblDefaultTab.TabIndex = 4;
            lblDefaultTab.Text = "Default Tab";
            // 
            // lblTheme
            // 
            lblTheme.AutoSize = true;
            lblTheme.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTheme.Location = new Point(21, 66);
            lblTheme.Name = "lblTheme";
            lblTheme.Size = new Size(49, 17);
            lblTheme.TabIndex = 3;
            lblTheme.Text = "Theme";
            // 
            // cmbTheme
            // 
            cmbTheme.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTheme.FormattingEnabled = true;
            cmbTheme.Location = new Point(21, 88);
            cmbTheme.Name = "cmbTheme";
            cmbTheme.Size = new Size(395, 23);
            cmbTheme.TabIndex = 2;
            cmbTheme.SelectedIndexChanged += cmbTheme_SelectedIndexChanged;
            // 
            // lblPreferencesSub
            // 
            lblPreferencesSub.AutoSize = true;
            lblPreferencesSub.Font = new Font("Segoe UI", 9F);
            lblPreferencesSub.Location = new Point(21, 39);
            lblPreferencesSub.Name = "lblPreferencesSub";
            lblPreferencesSub.Size = new Size(211, 15);
            lblPreferencesSub.TabIndex = 1;
            lblPreferencesSub.Text = "Customize your application experience";
            // 
            // lblPreferencesHeading
            // 
            lblPreferencesHeading.AutoSize = true;
            lblPreferencesHeading.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreferencesHeading.ForeColor = Color.DarkGreen;
            lblPreferencesHeading.Location = new Point(17, 8);
            lblPreferencesHeading.Name = "lblPreferencesHeading";
            lblPreferencesHeading.Size = new Size(123, 30);
            lblPreferencesHeading.TabIndex = 0;
            lblPreferencesHeading.Text = "Preferences";
            // 
            // pnlAccountSettings
            // 
            pnlAccountSettings.BackColor = Color.White;
            pnlAccountSettings.BorderStyle = BorderStyle.FixedSingle;
            pnlAccountSettings.Controls.Add(btnChangePassword);
            pnlAccountSettings.Controls.Add(lblAccountSub);
            pnlAccountSettings.Controls.Add(txtConfirmPassword);
            pnlAccountSettings.Controls.Add(txtNewPassword);
            pnlAccountSettings.Controls.Add(txtCurrentPassword);
            pnlAccountSettings.Controls.Add(lblConfirmPassword);
            pnlAccountSettings.Controls.Add(lblNewPassword);
            pnlAccountSettings.Controls.Add(lblCurrentPassword);
            pnlAccountSettings.Controls.Add(lblAccountSettingsHeading);
            pnlAccountSettings.Location = new Point(366, 102);
            pnlAccountSettings.Name = "pnlAccountSettings";
            pnlAccountSettings.Size = new Size(887, 241);
            pnlAccountSettings.TabIndex = 3;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.SeaGreen;
            btnChangePassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(718, 186);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(146, 34);
            btnChangePassword.TabIndex = 8;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // lblAccountSub
            // 
            lblAccountSub.AutoSize = true;
            lblAccountSub.Location = new Point(18, 45);
            lblAccountSub.Name = "lblAccountSub";
            lblAccountSub.Size = new Size(236, 15);
            lblAccountSub.TabIndex = 7;
            lblAccountSub.Text = "Update your password and security settings";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(247, 146);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(617, 23);
            txtConfirmPassword.TabIndex = 6;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(247, 113);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(617, 23);
            txtNewPassword.TabIndex = 5;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(247, 80);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(617, 23);
            txtCurrentPassword.TabIndex = 4;
            txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmPassword.Location = new Point(45, 153);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(149, 17);
            lblConfirmPassword.TabIndex = 3;
            lblConfirmPassword.Text = "Confirm New Password";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewPassword.Location = new Point(45, 120);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(97, 17);
            lblNewPassword.TabIndex = 2;
            lblNewPassword.Text = "New Password";
            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentPassword.Location = new Point(45, 87);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(116, 17);
            lblCurrentPassword.TabIndex = 1;
            lblCurrentPassword.Text = "Current Password";
            // 
            // lblAccountSettingsHeading
            // 
            lblAccountSettingsHeading.AutoSize = true;
            lblAccountSettingsHeading.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountSettingsHeading.ForeColor = Color.DarkGreen;
            lblAccountSettingsHeading.Location = new Point(17, 11);
            lblAccountSettingsHeading.Name = "lblAccountSettingsHeading";
            lblAccountSettingsHeading.Size = new Size(175, 30);
            lblAccountSettingsHeading.TabIndex = 0;
            lblAccountSettingsHeading.Text = "Account Settings";
            // 
            // pnlAppInfo
            // 
            pnlAppInfo.BackColor = Color.White;
            pnlAppInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlAppInfo.Controls.Add(lblLastLoginValue);
            pnlAppInfo.Controls.Add(lblDatabaseValue);
            pnlAppInfo.Controls.Add(lblVersionValue);
            pnlAppInfo.Controls.Add(lblLastLogin);
            pnlAppInfo.Controls.Add(lblDatabase);
            pnlAppInfo.Controls.Add(lblVersion);
            pnlAppInfo.Controls.Add(lblAppInfoSub);
            pnlAppInfo.Controls.Add(lblAppInforHeading);
            pnlAppInfo.Location = new Point(5, 375);
            pnlAppInfo.Name = "pnlAppInfo";
            pnlAppInfo.Size = new Size(355, 208);
            pnlAppInfo.TabIndex = 2;
            // 
            // lblLastLoginValue
            // 
            lblLastLoginValue.AutoSize = true;
            lblLastLoginValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastLoginValue.ForeColor = Color.DimGray;
            lblLastLoginValue.Location = new Point(130, 155);
            lblLastLoginValue.Name = "lblLastLoginValue";
            lblLastLoginValue.Size = new Size(0, 17);
            lblLastLoginValue.TabIndex = 7;
            // 
            // lblDatabaseValue
            // 
            lblDatabaseValue.AutoSize = true;
            lblDatabaseValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDatabaseValue.ForeColor = Color.DimGray;
            lblDatabaseValue.Location = new Point(130, 121);
            lblDatabaseValue.Name = "lblDatabaseValue";
            lblDatabaseValue.Size = new Size(0, 17);
            lblDatabaseValue.TabIndex = 6;
            // 
            // lblVersionValue
            // 
            lblVersionValue.AutoSize = true;
            lblVersionValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVersionValue.ForeColor = Color.DimGray;
            lblVersionValue.Location = new Point(130, 83);
            lblVersionValue.Name = "lblVersionValue";
            lblVersionValue.Size = new Size(0, 17);
            lblVersionValue.TabIndex = 5;
            // 
            // lblLastLogin
            // 
            lblLastLogin.AutoSize = true;
            lblLastLogin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblLastLogin.Location = new Point(30, 155);
            lblLastLogin.Name = "lblLastLogin";
            lblLastLogin.Size = new Size(73, 19);
            lblLastLogin.TabIndex = 4;
            lblLastLogin.Text = "Last Login";
            // 
            // lblDatabase
            // 
            lblDatabase.AutoSize = true;
            lblDatabase.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatabase.Location = new Point(30, 121);
            lblDatabase.Name = "lblDatabase";
            lblDatabase.Size = new Size(64, 17);
            lblDatabase.TabIndex = 3;
            lblDatabase.Text = "Database";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblVersion.Location = new Point(30, 83);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(55, 19);
            lblVersion.TabIndex = 2;
            lblVersion.Text = "Version";
            // 
            // lblAppInfoSub
            // 
            lblAppInfoSub.AutoSize = true;
            lblAppInfoSub.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppInfoSub.Location = new Point(18, 45);
            lblAppInfoSub.Name = "lblAppInfoSub";
            lblAppInfoSub.Size = new Size(127, 15);
            lblAppInfoSub.TabIndex = 1;
            lblAppInfoSub.Text = "Current system details.";
            // 
            // lblAppInforHeading
            // 
            lblAppInforHeading.AutoSize = true;
            lblAppInforHeading.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppInforHeading.ForeColor = Color.DarkGreen;
            lblAppInforHeading.Location = new Point(18, 15);
            lblAppInforHeading.Name = "lblAppInforHeading";
            lblAppInforHeading.Size = new Size(218, 25);
            lblAppInforHeading.TabIndex = 0;
            lblAppInforHeading.Text = "Application Information";
            // 
            // pnlFacultyProfile
            // 
            pnlFacultyProfile.BackColor = Color.White;
            pnlFacultyProfile.BorderStyle = BorderStyle.FixedSingle;
            pnlFacultyProfile.Controls.Add(btnEditProfile);
            pnlFacultyProfile.Controls.Add(lblProfilSub);
            pnlFacultyProfile.Controls.Add(lblPosition);
            pnlFacultyProfile.Controls.Add(lblDepartment);
            pnlFacultyProfile.Controls.Add(lblEmail);
            pnlFacultyProfile.Controls.Add(lblName);
            pnlFacultyProfile.Controls.Add(txtPosition);
            pnlFacultyProfile.Controls.Add(txtDepartment);
            pnlFacultyProfile.Controls.Add(txtFacultyEmail);
            pnlFacultyProfile.Controls.Add(txtFacultyName);
            pnlFacultyProfile.Controls.Add(lblProfileHeading);
            pnlFacultyProfile.Location = new Point(5, 102);
            pnlFacultyProfile.Name = "pnlFacultyProfile";
            pnlFacultyProfile.Size = new Size(355, 266);
            pnlFacultyProfile.TabIndex = 1;
            pnlFacultyProfile.Paint += pnlFacultyProfile_Paint;
            // 
            // btnEditProfile
            // 
            btnEditProfile.BackColor = Color.SeaGreen;
            btnEditProfile.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditProfile.ForeColor = Color.White;
            btnEditProfile.Location = new Point(240, 219);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(94, 34);
            btnEditProfile.TabIndex = 10;
            btnEditProfile.Text = "Edit Profile";
            btnEditProfile.UseVisualStyleBackColor = false;
            btnEditProfile.Click += btnEditProfile_Click;
            // 
            // lblProfilSub
            // 
            lblProfilSub.AutoSize = true;
            lblProfilSub.Font = new Font("Segoe UI", 9F);
            lblProfilSub.Location = new Point(18, 45);
            lblProfilSub.Name = "lblProfilSub";
            lblProfilSub.Size = new Size(239, 15);
            lblProfilSub.TabIndex = 9;
            lblProfilSub.Text = "View and update your personal information.";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblPosition.Location = new Point(30, 186);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(57, 17);
            lblPosition.TabIndex = 8;
            lblPosition.Text = "Position";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblDepartment.Location = new Point(30, 153);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(81, 17);
            lblDepartment.TabIndex = 7;
            lblDepartment.Text = "Department";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblEmail.Location = new Point(30, 120);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(40, 17);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblName.Location = new Point(30, 87);
            lblName.Name = "lblName";
            lblName.Size = new Size(44, 17);
            lblName.TabIndex = 5;
            lblName.Text = "Name";
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(124, 179);
            txtPosition.Name = "txtPosition";
            txtPosition.ReadOnly = true;
            txtPosition.Size = new Size(210, 23);
            txtPosition.TabIndex = 4;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(124, 146);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.ReadOnly = true;
            txtDepartment.Size = new Size(210, 23);
            txtDepartment.TabIndex = 3;
            // 
            // txtFacultyEmail
            // 
            txtFacultyEmail.Location = new Point(124, 113);
            txtFacultyEmail.Name = "txtFacultyEmail";
            txtFacultyEmail.ReadOnly = true;
            txtFacultyEmail.Size = new Size(210, 23);
            txtFacultyEmail.TabIndex = 2;
            // 
            // txtFacultyName
            // 
            txtFacultyName.Location = new Point(124, 80);
            txtFacultyName.Name = "txtFacultyName";
            txtFacultyName.ReadOnly = true;
            txtFacultyName.Size = new Size(210, 23);
            txtFacultyName.TabIndex = 1;
            txtFacultyName.TextChanged += txtFacultyName_TextChanged;
            // 
            // lblProfileHeading
            // 
            lblProfileHeading.AutoSize = true;
            lblProfileHeading.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblProfileHeading.ForeColor = Color.DarkGreen;
            lblProfileHeading.Location = new Point(15, 11);
            lblProfileHeading.Name = "lblProfileHeading";
            lblProfileHeading.Size = new Size(154, 30);
            lblProfileHeading.TabIndex = 0;
            lblProfileHeading.Text = "Faculty Profile";
            // 
            // pnlHeaderSetting
            // 
            pnlHeaderSetting.BackColor = Color.White;
            pnlHeaderSetting.BorderStyle = BorderStyle.FixedSingle;
            pnlHeaderSetting.Controls.Add(lblSettingSub);
            pnlHeaderSetting.Controls.Add(lblTitleSetting);
            pnlHeaderSetting.Location = new Point(5, 6);
            pnlHeaderSetting.Name = "pnlHeaderSetting";
            pnlHeaderSetting.Size = new Size(1248, 89);
            pnlHeaderSetting.TabIndex = 0;
            // 
            // lblSettingSub
            // 
            lblSettingSub.AutoSize = true;
            lblSettingSub.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSettingSub.Location = new Point(18, 50);
            lblSettingSub.Name = "lblSettingSub";
            lblSettingSub.Size = new Size(373, 17);
            lblSettingSub.TabIndex = 1;
            lblSettingSub.Text = "Manage your account information and application preferences";
            // 
            // lblTitleSetting
            // 
            lblTitleSetting.AutoSize = true;
            lblTitleSetting.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleSetting.ForeColor = Color.DarkGreen;
            lblTitleSetting.Location = new Point(12, 8);
            lblTitleSetting.Name = "lblTitleSetting";
            lblTitleSetting.Size = new Size(122, 37);
            lblTitleSetting.TabIndex = 1;
            lblTitleSetting.Text = "Settings";
            lblTitleSetting.Click += label2_Click_1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.InactiveBorder;
            lblTitle.Location = new Point(8, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(194, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Faculty Portal";
            lblTitle.Click += label7_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.Silver;
            lblSubtitle.Location = new Point(14, 49);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(224, 17);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Faculty Request Management System";
            // 
            // pnlHeader
            // 
            pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeader.BackColor = Color.DarkGreen;
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(0, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1262, 121);
            pnlHeader.TabIndex = 11;
            // 
            // Faculty
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1264, 772);
            Controls.Add(tabFaculty);
            Controls.Add(pnlHeader);
            Margin = new Padding(2);
            Name = "Faculty";
            Text = "Faculty Form";
            Load += Faculty_Load;
            tabFaculty.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            grpRecentMeet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecentRequest).EndInit();
            pnlNotifs.ResumeLayout(false);
            pnlNotifs.PerformLayout();
            grpOverview.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            pnlPending.ResumeLayout(false);
            pnlPending.PerformLayout();
            pnlTotal.ResumeLayout(false);
            pnlTotal.PerformLayout();
            pnlDeclined.ResumeLayout(false);
            pnlDeclined.PerformLayout();
            pnlApproved.ResumeLayout(false);
            pnlApproved.PerformLayout();
            tabAvailability.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabSettings.ResumeLayout(false);
            pnlPreferences.ResumeLayout(false);
            pnlPreferences.PerformLayout();
            pnlAccountSettings.ResumeLayout(false);
            pnlAccountSettings.PerformLayout();
            pnlAppInfo.ResumeLayout(false);
            pnlAppInfo.PerformLayout();
            pnlFacultyProfile.ResumeLayout(false);
            pnlFacultyProfile.PerformLayout();
            pnlHeaderSetting.ResumeLayout(false);
            pnlHeaderSetting.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabFaculty;
        private TabPage tabHome;
        private TabPage tabRequest;
        private TabPage tabAvailability;
        private TabPage tabSettings;
        private Label lblDashboard;
        private Panel pnlDeclined;
        private Panel pnlApproved;
        private Panel pnlPending;
        private Panel pnlTotal;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblPendingTotal;
        private Label lblTotal;
        private Label lblDeclinedTotal;
        private Label lblApprovedTotal;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label lblDayOfWeek;
        private Label lblStartTime;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker3;
        private Label lblEndTime;
        private Button AddBTN;
        private TextBox textBox1;
        private Label lblLocation;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private Button SearchBTN;
        private TextBox Tips;
        private Button EditBTN;
        private Button DeleteBTN;
        private Button button1;
        private Panel panel5;
        private Panel pnlHeader;
        private Label lblOverviewSub;
        private GroupBox grpOverview;
        private Label label1;
        private Label lblTotalMeeting;
        private Label lblTodaysMeeting;
        private Panel panel2;
        private Panel panel1;
        private Label lblTotalUpMeet;
        private Button btnRefresh;
        private Panel pnlNotifs;
        private Label lblNotifs;
        private DataGridView dgvRecentRequest;
        private GroupBox grpRecentMeet;
        private Panel pnlHeaderSetting;
        private Label lblTitleSetting;
        private Label lblSettingSub;
        private Panel pnlFacultyProfile;
        private TextBox txtFacultyName;
        private Label lblProfileHeading;
        private TextBox txtPosition;
        private TextBox txtDepartment;
        private TextBox txtFacultyEmail;
        private Label lblPosition;
        private Label lblDepartment;
        private Label lblEmail;
        private Label lblName;
        private Label lblProfilSub;
        private Panel pnlAppInfo;
        private Button btnEditProfile;
        private Label lblAppInforHeading;
        private Panel pnlAccountSettings;
        private Label lblLastLogin;
        private Label lblDatabase;
        private Label lblVersion;
        private Label lblLastLoginValue;
        private Label lblDatabaseValue;
        private Label lblVersionValue;
        private Label lblAppInfoSub;
        private Panel pnlPreferences;
        private Label lblAccountSub;
        private TextBox txtConfirmPassword;
        private TextBox txtNewPassword;
        private TextBox txtCurrentPassword;
        private Label lblConfirmPassword;
        private Label lblNewPassword;
        private Label lblCurrentPassword;
        private Label lblAccountSettingsHeading;
        private ComboBox cmbTheme;
        private Label lblPreferencesSub;
        private Label lblPreferencesHeading;
        private Button btnChangePassword;
        private CheckBox chkConsultationReminder;
        private CheckBox chkDesktopNotif;
        private CheckBox chkEmailNotif;
        private ComboBox cmbDefaultTab;
        private Label lblDefaultTab;
        private Label lblTheme;
        private Button btnRefreshPreferences;
        private Button btnSavePreferences;
        private CheckBox chkShowRecentRequestDashboard;
        private CheckBox chkShowRequestDashboard;
        private Label lblDisplaySettings;
        private Label lblNotifications;
        private Button btnLogout;
        private DataGridViewTextBoxColumn request_id;
        private DataGridViewTextBoxColumn stud_name;
        private DataGridViewTextBoxColumn meeting_date;
        private DataGridViewTextBoxColumn start_time;
        private DataGridViewTextBoxColumn end_time;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn faculty_remarks;
    }
}