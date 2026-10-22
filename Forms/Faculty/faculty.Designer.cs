namespace DCSSMeetingScheduler.Faculty
{
    partial class faculty
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            button5 = new Button();
            panel4 = new Panel();
            button4 = new Button();
            button3 = new Button();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            label20 = new Label();
            label19 = new Label();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            comboBox3 = new ComboBox();
            label18 = new Label();
            label17 = new Label();
            comboBox2 = new ComboBox();
            label16 = new Label();
            label15 = new Label();
            panel3 = new Panel();
            button2 = new Button();
            label14 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            pnlAppInfo = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label2 = new Label();
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
            panel4.SuspendLayout();
            panel3.SuspendLayout();
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
            tabFaculty.Location = new Point(0, 148);
            tabFaculty.Name = "tabFaculty";
            tabFaculty.SelectedIndex = 0;
            tabFaculty.Size = new Size(1757, 987);
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
            tabHome.Location = new Point(4, 34);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(3, 3, 3, 3);
            tabHome.Size = new Size(1749, 949);
            tabHome.TabIndex = 0;
            tabHome.Text = "Home";
            // 
            // grpRecentMeet
            // 
            grpRecentMeet.BackColor = Color.White;
            grpRecentMeet.Controls.Add(dgvRecentRequest);
            grpRecentMeet.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            grpRecentMeet.ForeColor = Color.DarkGreen;
            grpRecentMeet.Location = new Point(23, 568);
            grpRecentMeet.Margin = new Padding(4, 5, 4, 5);
            grpRecentMeet.Name = "grpRecentMeet";
            grpRecentMeet.Padding = new Padding(4, 5, 4, 5);
            grpRecentMeet.Size = new Size(1757, 358);
            grpRecentMeet.TabIndex = 13;
            grpRecentMeet.TabStop = false;
            grpRecentMeet.Text = "Recent Meetings Request";
            // 
            // dgvRecentRequest
            // 
            dgvRecentRequest.AllowUserToAddRows = false;
            dgvRecentRequest.AllowUserToDeleteRows = false;
            dgvRecentRequest.AllowUserToResizeColumns = false;
            dgvRecentRequest.AllowUserToResizeRows = false;
            dgvRecentRequest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentRequest.BackgroundColor = SystemColors.ControlLight;
            dgvRecentRequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentRequest.Columns.AddRange(new DataGridViewColumn[] { request_id, stud_name, meeting_date, start_time, end_time, status, faculty_remarks });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRecentRequest.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRecentRequest.GridColor = SystemColors.ActiveBorder;
            dgvRecentRequest.Location = new Point(21, 58);
            dgvRecentRequest.Margin = new Padding(4, 5, 4, 5);
            dgvRecentRequest.MultiSelect = false;
            dgvRecentRequest.Name = "dgvRecentRequest";
            dgvRecentRequest.ReadOnly = true;
            dgvRecentRequest.RowHeadersVisible = false;
            dgvRecentRequest.RowHeadersWidth = 20;
            dgvRecentRequest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentRequest.Size = new Size(1714, 277);
            dgvRecentRequest.TabIndex = 14;
            // 
            // request_id
            // 
            request_id.HeaderText = "Request ID";
            request_id.MinimumWidth = 8;
            request_id.Name = "request_id";
            request_id.ReadOnly = true;
            // 
            // stud_name
            // 
            stud_name.HeaderText = "Student Name";
            stud_name.MinimumWidth = 8;
            stud_name.Name = "stud_name";
            stud_name.ReadOnly = true;
            // 
            // meeting_date
            // 
            meeting_date.HeaderText = "Meeting Date";
            meeting_date.MinimumWidth = 8;
            meeting_date.Name = "meeting_date";
            meeting_date.ReadOnly = true;
            // 
            // start_time
            // 
            start_time.HeaderText = "Start Time";
            start_time.MinimumWidth = 8;
            start_time.Name = "start_time";
            start_time.ReadOnly = true;
            // 
            // end_time
            // 
            end_time.HeaderText = "End Time";
            end_time.MinimumWidth = 8;
            end_time.Name = "end_time";
            end_time.ReadOnly = true;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.MinimumWidth = 8;
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // faculty_remarks
            // 
            faculty_remarks.HeaderText = "Faculty Remarks";
            faculty_remarks.MinimumWidth = 8;
            faculty_remarks.Name = "faculty_remarks";
            faculty_remarks.ReadOnly = true;
            // 
            // pnlNotifs
            // 
            pnlNotifs.BackColor = Color.MintCream;
            pnlNotifs.BorderStyle = BorderStyle.FixedSingle;
            pnlNotifs.Controls.Add(btnRefresh);
            pnlNotifs.Controls.Add(lblNotifs);
            pnlNotifs.Location = new Point(23, 467);
            pnlNotifs.Margin = new Padding(4, 5, 4, 5);
            pnlNotifs.Name = "pnlNotifs";
            pnlNotifs.Size = new Size(1756, 90);
            pnlNotifs.TabIndex = 12;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.SeaGreen;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1570, 20);
            btnRefresh.Margin = new Padding(4, 5, 4, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(164, 52);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // lblNotifs
            // 
            lblNotifs.AutoSize = true;
            lblNotifs.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotifs.Location = new Point(20, 30);
            lblNotifs.Margin = new Padding(4, 0, 4, 0);
            lblNotifs.Name = "lblNotifs";
            lblNotifs.Size = new Size(356, 28);
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
            grpOverview.Location = new Point(23, 292);
            grpOverview.Margin = new Padding(4, 5, 4, 5);
            grpOverview.Name = "grpOverview";
            grpOverview.Padding = new Padding(4, 5, 4, 5);
            grpOverview.Size = new Size(1757, 170);
            grpOverview.TabIndex = 11;
            grpOverview.TabStop = false;
            grpOverview.Text = "Today's Overview";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblTotalUpMeet);
            panel2.Location = new Point(879, 60);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(856, 74);
            panel2.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(20, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(208, 28);
            label1.TabIndex = 12;
            label1.Text = "Upcoming Meetings: ";
            label1.Click += label1_Click;
            // 
            // lblTotalUpMeet
            // 
            lblTotalUpMeet.AutoSize = true;
            lblTotalUpMeet.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTotalUpMeet.ForeColor = Color.Black;
            lblTotalUpMeet.Location = new Point(211, 23);
            lblTotalUpMeet.Margin = new Padding(4, 0, 4, 0);
            lblTotalUpMeet.Name = "lblTotalUpMeet";
            lblTotalUpMeet.Size = new Size(23, 28);
            lblTotalUpMeet.TabIndex = 12;
            lblTotalUpMeet.Text = "0";
            lblTotalUpMeet.Click += lblTotalUpMeet_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblTodaysMeeting);
            panel1.Controls.Add(lblTotalMeeting);
            panel1.Location = new Point(21, 60);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(848, 74);
            panel1.TabIndex = 12;
            // 
            // lblTodaysMeeting
            // 
            lblTodaysMeeting.AutoSize = true;
            lblTodaysMeeting.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodaysMeeting.ForeColor = Color.Black;
            lblTodaysMeeting.Location = new Point(20, 22);
            lblTodaysMeeting.Margin = new Padding(4, 0, 4, 0);
            lblTodaysMeeting.Name = "lblTodaysMeeting";
            lblTodaysMeeting.Size = new Size(180, 28);
            lblTodaysMeeting.TabIndex = 0;
            lblTodaysMeeting.Text = "Today's Meetings: ";
            // 
            // lblTotalMeeting
            // 
            lblTotalMeeting.AutoSize = true;
            lblTotalMeeting.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTotalMeeting.ForeColor = Color.Black;
            lblTotalMeeting.Location = new Point(186, 22);
            lblTotalMeeting.Margin = new Padding(4, 0, 4, 0);
            lblTotalMeeting.Name = "lblTotalMeeting";
            lblTotalMeeting.Size = new Size(23, 28);
            lblTotalMeeting.TabIndex = 1;
            lblTotalMeeting.Text = "0";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(lblOverviewSub);
            panel5.Controls.Add(lblDashboard);
            panel5.Location = new Point(7, 8);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(1782, 130);
            panel5.TabIndex = 10;
            // 
            // lblOverviewSub
            // 
            lblOverviewSub.AutoSize = true;
            lblOverviewSub.Location = new Point(23, 75);
            lblOverviewSub.Margin = new Padding(4, 0, 4, 0);
            lblOverviewSub.Name = "lblOverviewSub";
            lblOverviewSub.Size = new Size(338, 25);
            lblOverviewSub.TabIndex = 3;
            lblOverviewSub.Text = "Overview of student consultation request";
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.ForeColor = Color.DarkGreen;
            lblDashboard.Location = new Point(14, 18);
            lblDashboard.Margin = new Padding(4, 0, 4, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(332, 48);
            lblDashboard.TabIndex = 2;
            lblDashboard.Text = "Faculty Dashboard";
            // 
            // pnlPending
            // 
            pnlPending.BackColor = Color.White;
            pnlPending.BorderStyle = BorderStyle.FixedSingle;
            pnlPending.Controls.Add(lblPendingTotal);
            pnlPending.Controls.Add(label4);
            pnlPending.Location = new Point(454, 147);
            pnlPending.Margin = new Padding(4, 3, 4, 3);
            pnlPending.Name = "pnlPending";
            pnlPending.Size = new Size(438, 135);
            pnlPending.TabIndex = 9;
            // 
            // lblPendingTotal
            // 
            lblPendingTotal.AutoSize = true;
            lblPendingTotal.Font = new Font("Segoe UI", 14F);
            lblPendingTotal.Location = new Point(26, 60);
            lblPendingTotal.Margin = new Padding(4, 0, 4, 0);
            lblPendingTotal.Name = "lblPendingTotal";
            lblPendingTotal.Size = new Size(32, 38);
            lblPendingTotal.TabIndex = 1;
            lblPendingTotal.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(26, 22);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 28);
            label4.TabIndex = 0;
            label4.Text = "Pending";
            // 
            // pnlTotal
            // 
            pnlTotal.BackColor = Color.White;
            pnlTotal.BorderStyle = BorderStyle.FixedSingle;
            pnlTotal.Controls.Add(lblTotal);
            pnlTotal.Controls.Add(label3);
            pnlTotal.Location = new Point(7, 147);
            pnlTotal.Margin = new Padding(4, 3, 4, 3);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(438, 135);
            pnlTotal.TabIndex = 8;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14F);
            lblTotal.Location = new Point(23, 60);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(32, 38);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(23, 22);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(143, 28);
            label3.TabIndex = 0;
            label3.Text = "Total Requests";
            // 
            // pnlDeclined
            // 
            pnlDeclined.BackColor = Color.White;
            pnlDeclined.BorderStyle = BorderStyle.FixedSingle;
            pnlDeclined.Controls.Add(lblDeclinedTotal);
            pnlDeclined.Controls.Add(label6);
            pnlDeclined.Location = new Point(1349, 147);
            pnlDeclined.Margin = new Padding(4, 3, 4, 3);
            pnlDeclined.Name = "pnlDeclined";
            pnlDeclined.Size = new Size(438, 135);
            pnlDeclined.TabIndex = 7;
            // 
            // lblDeclinedTotal
            // 
            lblDeclinedTotal.AutoSize = true;
            lblDeclinedTotal.Font = new Font("Segoe UI", 14F);
            lblDeclinedTotal.Location = new Point(26, 60);
            lblDeclinedTotal.Margin = new Padding(4, 0, 4, 0);
            lblDeclinedTotal.Name = "lblDeclinedTotal";
            lblDeclinedTotal.Size = new Size(32, 38);
            lblDeclinedTotal.TabIndex = 2;
            lblDeclinedTotal.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(26, 22);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(91, 28);
            label6.TabIndex = 0;
            label6.Text = "Declined";
            // 
            // pnlApproved
            // 
            pnlApproved.BackColor = Color.White;
            pnlApproved.BorderStyle = BorderStyle.FixedSingle;
            pnlApproved.Controls.Add(lblApprovedTotal);
            pnlApproved.Controls.Add(label5);
            pnlApproved.Location = new Point(901, 147);
            pnlApproved.Margin = new Padding(4, 3, 4, 3);
            pnlApproved.Name = "pnlApproved";
            pnlApproved.Size = new Size(438, 135);
            pnlApproved.TabIndex = 6;
            // 
            // lblApprovedTotal
            // 
            lblApprovedTotal.AutoSize = true;
            lblApprovedTotal.Font = new Font("Segoe UI", 14F);
            lblApprovedTotal.Location = new Point(23, 60);
            lblApprovedTotal.Margin = new Padding(4, 0, 4, 0);
            lblApprovedTotal.Name = "lblApprovedTotal";
            lblApprovedTotal.Size = new Size(32, 38);
            lblApprovedTotal.TabIndex = 1;
            lblApprovedTotal.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(23, 22);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(101, 28);
            label5.TabIndex = 0;
            label5.Text = "Approved";
            // 
            // tabRequest
            // 
            tabRequest.BackColor = Color.WhiteSmoke;
            tabRequest.Location = new Point(4, 34);
            tabRequest.Name = "tabRequest";
            tabRequest.Padding = new Padding(3, 3, 3, 3);
            tabRequest.Size = new Size(1801, 949);
            tabRequest.TabIndex = 1;
            tabRequest.Text = "Request";
            // 
            // tabAvailability
            // 
            tabAvailability.BackColor = Color.WhiteSmoke;
            tabAvailability.Controls.Add(groupBox2);
            tabAvailability.Controls.Add(groupBox1);
            tabAvailability.Location = new Point(4, 34);
            tabAvailability.Name = "tabAvailability";
            tabAvailability.Padding = new Padding(3, 3, 3, 3);
            tabAvailability.Size = new Size(1801, 949);
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
            groupBox2.Location = new Point(414, 112);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(819, 482);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Weekly Consultation Hours";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // Tips
            // 
            Tips.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tips.Location = new Point(7, 427);
            Tips.Margin = new Padding(4, 3, 4, 3);
            Tips.Name = "Tips";
            Tips.Size = new Size(577, 31);
            Tips.TabIndex = 5;
            Tips.Text = "Tips Click \"Add New\" to create new  consultation hours. ";
            // 
            // EditBTN
            // 
            EditBTN.Location = new Point(610, 425);
            EditBTN.Margin = new Padding(4, 3, 4, 3);
            EditBTN.Name = "EditBTN";
            EditBTN.Size = new Size(84, 37);
            EditBTN.TabIndex = 4;
            EditBTN.Text = "Edit";
            EditBTN.UseVisualStyleBackColor = true;
            // 
            // DeleteBTN
            // 
            DeleteBTN.Location = new Point(701, 425);
            DeleteBTN.Margin = new Padding(4, 3, 4, 3);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(84, 37);
            DeleteBTN.TabIndex = 3;
            DeleteBTN.Text = "Delete";
            DeleteBTN.UseVisualStyleBackColor = true;
            // 
            // SearchBTN
            // 
            SearchBTN.Location = new Point(501, 18);
            SearchBTN.Margin = new Padding(4, 3, 4, 3);
            SearchBTN.Name = "SearchBTN";
            SearchBTN.Size = new Size(84, 37);
            SearchBTN.TabIndex = 1;
            SearchBTN.Text = "Search";
            SearchBTN.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(501, 22);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(283, 31);
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
            dataGridView1.Location = new Point(7, 63);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(777, 355);
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
            groupBox1.Location = new Point(16, 112);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(371, 482);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add / Consultation Hours";
            // 
            // button1
            // 
            button1.Location = new Point(204, 367);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(119, 37);
            button1.TabIndex = 7;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            // 
            // AddBTN
            // 
            AddBTN.Location = new Point(41, 367);
            AddBTN.Margin = new Padding(4, 3, 4, 3);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(119, 37);
            AddBTN.TabIndex = 1;
            AddBTN.Text = "+   Add";
            AddBTN.UseVisualStyleBackColor = true;
            AddBTN.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(26, 302);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(318, 31);
            textBox1.TabIndex = 2;
            textBox1.Text = "  e.g Room 101, Online etc.";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLocation.Location = new Point(26, 277);
            lblLocation.Margin = new Padding(4, 0, 4, 0);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(138, 20);
            lblLocation.TabIndex = 6;
            lblLocation.Text = "Location (Optional)";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CustomFormat = "hh:mm";
            dateTimePicker3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Location = new Point(30, 227);
            dateTimePicker3.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.ShowUpDown = true;
            dateTimePicker3.Size = new Size(313, 31);
            dateTimePicker3.TabIndex = 5;
            // 
            // lblEndTime
            // 
            lblEndTime.AutoSize = true;
            lblEndTime.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEndTime.Location = new Point(26, 202);
            lblEndTime.Margin = new Padding(4, 0, 4, 0);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new Size(71, 20);
            lblEndTime.TabIndex = 4;
            lblEndTime.Text = "End Time";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "hh:mm";
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(30, 147);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(313, 31);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStartTime.Location = new Point(26, 123);
            lblStartTime.Margin = new Padding(4, 0, 4, 0);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(77, 20);
            lblStartTime.TabIndex = 3;
            lblStartTime.Text = "Start Time";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" });
            comboBox1.Location = new Point(26, 63);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(318, 33);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // lblDayOfWeek
            // 
            lblDayOfWeek.AutoSize = true;
            lblDayOfWeek.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDayOfWeek.Location = new Point(26, 37);
            lblDayOfWeek.Margin = new Padding(4, 0, 4, 0);
            lblDayOfWeek.Name = "lblDayOfWeek";
            lblDayOfWeek.Size = new Size(93, 20);
            lblDayOfWeek.TabIndex = 2;
            lblDayOfWeek.Text = "Day of Week";
            lblDayOfWeek.Click += label2_Click;
            // 
            // tabSettings
            // 
            tabSettings.AutoScroll = true;
            tabSettings.BackColor = Color.WhiteSmoke;
            tabSettings.Controls.Add(button5);
            tabSettings.Controls.Add(panel4);
            tabSettings.Controls.Add(panel3);
            tabSettings.Controls.Add(pnlAppInfo);
            tabSettings.Controls.Add(pnlFacultyProfile);
            tabSettings.Controls.Add(pnlHeaderSetting);
            tabSettings.Location = new Point(4, 34);
            tabSettings.Name = "tabSettings";
            tabSettings.Padding = new Padding(3, 3, 3, 3);
            tabSettings.Size = new Size(1749, 949);
            tabSettings.TabIndex = 3;
            tabSettings.Text = "Setting";
            // 
            // button5
            // 
            button5.BackColor = Color.SeaGreen;
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(11, 868);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(160, 58);
            button5.TabIndex = 5;
            button5.Text = "Log Out";
            button5.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(checkBox5);
            panel4.Controls.Add(checkBox4);
            panel4.Controls.Add(label20);
            panel4.Controls.Add(label19);
            panel4.Controls.Add(checkBox3);
            panel4.Controls.Add(checkBox2);
            panel4.Controls.Add(checkBox1);
            panel4.Controls.Add(comboBox3);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(comboBox2);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label15);
            panel4.Location = new Point(523, 515);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(1266, 342);
            panel4.TabIndex = 4;
            // 
            // button4
            // 
            button4.BackColor = Color.SeaGreen;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(1090, 268);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(144, 48);
            button4.TabIndex = 14;
            button4.Text = "Refresh";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.SeaGreen;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1087, 205);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(147, 50);
            button3.TabIndex = 13;
            button3.Text = "Save Changes";
            button3.UseVisualStyleBackColor = false;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(684, 265);
            checkBox5.Margin = new Padding(4, 5, 4, 5);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(375, 29);
            checkBox5.TabIndex = 12;
            checkBox5.Text = "Show recent request on faculty Dashboard";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(684, 232);
            checkBox4.Margin = new Padding(4, 5, 4, 5);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(324, 29);
            checkBox4.TabIndex = 11;
            checkBox4.Text = "Show request on Faculty Dashboard\r\n";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(670, 198);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(157, 28);
            label20.TabIndex = 10;
            label20.Text = "Display Settings";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(30, 198);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(127, 28);
            label19.TabIndex = 9;
            label19.Text = "Notifications";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(37, 300);
            checkBox3.Margin = new Padding(4, 5, 4, 5);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(345, 29);
            checkBox3.TabIndex = 8;
            checkBox3.Text = "Reminders for upcoming consultations";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(37, 267);
            checkBox2.Margin = new Padding(4, 5, 4, 5);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(199, 29);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "Desktop notification";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(37, 232);
            checkBox1.Margin = new Padding(4, 5, 4, 5);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(343, 29);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Email notifications for request updates";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(670, 130);
            comboBox3.Margin = new Padding(4, 5, 4, 5);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(563, 33);
            comboBox3.TabIndex = 5;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(670, 97);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(115, 28);
            label18.TabIndex = 4;
            label18.Text = "Default Tab";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(30, 97);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(75, 28);
            label17.TabIndex = 3;
            label17.Text = "Theme";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(30, 130);
            comboBox2.Margin = new Padding(4, 5, 4, 5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(563, 33);
            comboBox2.TabIndex = 2;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F);
            label16.Location = new Point(30, 57);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(316, 25);
            label16.TabIndex = 1;
            label16.Text = "Customize your application experience";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.DarkGreen;
            label15.Location = new Point(24, 12);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(190, 45);
            label15.TabIndex = 0;
            label15.Text = "Preferences";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(523, 150);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1266, 354);
            panel3.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.SeaGreen;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1026, 273);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(209, 50);
            button2.TabIndex = 8;
            button2.Text = "Change Password";
            button2.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(26, 67);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(360, 25);
            label14.TabIndex = 7;
            label14.Text = "Update your password and security settings";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(353, 215);
            textBox5.Margin = new Padding(4, 5, 4, 5);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(880, 31);
            textBox5.TabIndex = 6;
            textBox5.UseSystemPasswordChar = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(353, 167);
            textBox4.Margin = new Padding(4, 5, 4, 5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(880, 31);
            textBox4.TabIndex = 5;
            textBox4.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(353, 118);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(880, 31);
            textBox3.TabIndex = 4;
            textBox3.UseSystemPasswordChar = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(64, 225);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(223, 28);
            label13.TabIndex = 3;
            label13.Text = "Confirm New Password";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(64, 177);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(144, 28);
            label12.TabIndex = 2;
            label12.Text = "New Password";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(64, 128);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(171, 28);
            label11.TabIndex = 1;
            label11.Text = "Current Password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkGreen;
            label10.Location = new Point(24, 17);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(267, 45);
            label10.TabIndex = 0;
            label10.Text = "Account Settings";
            // 
            // pnlAppInfo
            // 
            pnlAppInfo.BackColor = Color.White;
            pnlAppInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlAppInfo.Controls.Add(label9);
            pnlAppInfo.Controls.Add(label8);
            pnlAppInfo.Controls.Add(label7);
            pnlAppInfo.Controls.Add(label2);
            pnlAppInfo.Controls.Add(lblAppInforHeading);
            pnlAppInfo.Location = new Point(7, 552);
            pnlAppInfo.Margin = new Padding(4, 5, 4, 5);
            pnlAppInfo.Name = "pnlAppInfo";
            pnlAppInfo.Size = new Size(506, 305);
            pnlAppInfo.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.Location = new Point(43, 228);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(105, 28);
            label9.TabIndex = 4;
            label9.Text = "Last Login";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(43, 178);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(95, 28);
            label8.TabIndex = 3;
            label8.Text = "Database";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.Location = new Point(43, 122);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(80, 28);
            label7.TabIndex = 2;
            label7.Text = "Version";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 67);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(191, 25);
            label2.TabIndex = 1;
            label2.Text = "Current system details.";
            // 
            // lblAppInforHeading
            // 
            lblAppInforHeading.AutoSize = true;
            lblAppInforHeading.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppInforHeading.ForeColor = Color.DarkGreen;
            lblAppInforHeading.Location = new Point(26, 22);
            lblAppInforHeading.Margin = new Padding(4, 0, 4, 0);
            lblAppInforHeading.Name = "lblAppInforHeading";
            lblAppInforHeading.Size = new Size(331, 40);
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
            pnlFacultyProfile.Location = new Point(7, 150);
            pnlFacultyProfile.Margin = new Padding(4, 5, 4, 5);
            pnlFacultyProfile.Name = "pnlFacultyProfile";
            pnlFacultyProfile.Size = new Size(506, 390);
            pnlFacultyProfile.TabIndex = 1;
            pnlFacultyProfile.Paint += pnlFacultyProfile_Paint;
            // 
            // btnEditProfile
            // 
            btnEditProfile.BackColor = Color.SeaGreen;
            btnEditProfile.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditProfile.ForeColor = Color.White;
            btnEditProfile.Location = new Point(343, 322);
            btnEditProfile.Margin = new Padding(4, 5, 4, 5);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(134, 50);
            btnEditProfile.TabIndex = 10;
            btnEditProfile.Text = "Edit Profile";
            btnEditProfile.UseVisualStyleBackColor = false;
            // 
            // lblProfilSub
            // 
            lblProfilSub.AutoSize = true;
            lblProfilSub.Font = new Font("Segoe UI", 9F);
            lblProfilSub.Location = new Point(26, 67);
            lblProfilSub.Margin = new Padding(4, 0, 4, 0);
            lblProfilSub.Name = "lblProfilSub";
            lblProfilSub.Size = new Size(361, 25);
            lblProfilSub.TabIndex = 9;
            lblProfilSub.Text = "View and update your personal information.";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblPosition.Location = new Point(43, 273);
            lblPosition.Margin = new Padding(4, 0, 4, 0);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(85, 28);
            lblPosition.TabIndex = 8;
            lblPosition.Text = "Position";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblDepartment.Location = new Point(43, 225);
            lblDepartment.Margin = new Padding(4, 0, 4, 0);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(122, 28);
            lblDepartment.TabIndex = 7;
            lblDepartment.Text = "Department";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblEmail.Location = new Point(43, 177);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 28);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblName.Location = new Point(43, 128);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(66, 28);
            lblName.TabIndex = 5;
            lblName.Text = "Name";
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(177, 263);
            txtPosition.Margin = new Padding(4, 5, 4, 5);
            txtPosition.Name = "txtPosition";
            txtPosition.ReadOnly = true;
            txtPosition.Size = new Size(298, 31);
            txtPosition.TabIndex = 4;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(177, 215);
            txtDepartment.Margin = new Padding(4, 5, 4, 5);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.ReadOnly = true;
            txtDepartment.Size = new Size(298, 31);
            txtDepartment.TabIndex = 3;
            // 
            // txtFacultyEmail
            // 
            txtFacultyEmail.Location = new Point(177, 167);
            txtFacultyEmail.Margin = new Padding(4, 5, 4, 5);
            txtFacultyEmail.Name = "txtFacultyEmail";
            txtFacultyEmail.ReadOnly = true;
            txtFacultyEmail.Size = new Size(298, 31);
            txtFacultyEmail.TabIndex = 2;
            // 
            // txtFacultyName
            // 
            txtFacultyName.Location = new Point(177, 118);
            txtFacultyName.Margin = new Padding(4, 5, 4, 5);
            txtFacultyName.Name = "txtFacultyName";
            txtFacultyName.ReadOnly = true;
            txtFacultyName.Size = new Size(298, 31);
            txtFacultyName.TabIndex = 1;
            // 
            // lblProfileHeading
            // 
            lblProfileHeading.AutoSize = true;
            lblProfileHeading.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblProfileHeading.ForeColor = Color.DarkGreen;
            lblProfileHeading.Location = new Point(21, 17);
            lblProfileHeading.Margin = new Padding(4, 0, 4, 0);
            lblProfileHeading.Name = "lblProfileHeading";
            lblProfileHeading.Size = new Size(224, 45);
            lblProfileHeading.TabIndex = 0;
            lblProfileHeading.Text = "Faculty Profile";
            // 
            // pnlHeaderSetting
            // 
            pnlHeaderSetting.BackColor = Color.White;
            pnlHeaderSetting.BorderStyle = BorderStyle.FixedSingle;
            pnlHeaderSetting.Controls.Add(lblSettingSub);
            pnlHeaderSetting.Controls.Add(lblTitleSetting);
            pnlHeaderSetting.Location = new Point(7, 8);
            pnlHeaderSetting.Margin = new Padding(4, 5, 4, 5);
            pnlHeaderSetting.Name = "pnlHeaderSetting";
            pnlHeaderSetting.Size = new Size(1782, 130);
            pnlHeaderSetting.TabIndex = 0;
            // 
            // lblSettingSub
            // 
            lblSettingSub.AutoSize = true;
            lblSettingSub.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSettingSub.Location = new Point(26, 73);
            lblSettingSub.Margin = new Padding(4, 0, 4, 0);
            lblSettingSub.Name = "lblSettingSub";
            lblSettingSub.Size = new Size(556, 28);
            lblSettingSub.TabIndex = 1;
            lblSettingSub.Text = "Manage your account information and application preferences";
            // 
            // lblTitleSetting
            // 
            lblTitleSetting.AutoSize = true;
            lblTitleSetting.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleSetting.ForeColor = Color.DarkGreen;
            lblTitleSetting.Location = new Point(17, 12);
            lblTitleSetting.Margin = new Padding(4, 0, 4, 0);
            lblTitleSetting.Name = "lblTitleSetting";
            lblTitleSetting.Size = new Size(181, 55);
            lblTitleSetting.TabIndex = 1;
            lblTitleSetting.Text = "Settings";
            lblTitleSetting.Click += label2_Click_1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.InactiveBorder;
            lblTitle.Location = new Point(11, 8);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(282, 54);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Faculty Portal";
            lblTitle.Click += label7_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.Silver;
            lblSubtitle.Location = new Point(20, 72);
            lblSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(306, 25);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Faculty Request Management System";
            // 
            // pnlHeader
            // 
            pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeader.BackColor = Color.DarkGreen;
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(0, 2);
            pnlHeader.Margin = new Padding(4, 5, 4, 5);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1803, 178);
            pnlHeader.TabIndex = 11;
            // 
            // faculty
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1806, 1135);
            Controls.Add(tabFaculty);
            Controls.Add(pnlHeader);
            Name = "faculty";
            Text = "Faculty Form";
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
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private DataGridViewTextBoxColumn request_id;
        private DataGridViewTextBoxColumn stud_name;
        private DataGridViewTextBoxColumn meeting_date;
        private DataGridViewTextBoxColumn start_time;
        private DataGridViewTextBoxColumn end_time;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn faculty_remarks;
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
        private Panel panel3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label2;
        private Panel panel4;
        private Label label14;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private ComboBox comboBox2;
        private Label label16;
        private Label label15;
        private Button button2;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private ComboBox comboBox3;
        private Label label18;
        private Label label17;
        private Button button4;
        private Button button3;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private Label label20;
        private Label label19;
        private Button button5;
    }
}