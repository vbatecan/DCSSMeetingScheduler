namespace DCSSMeetingScheduler.Forms.Student
{
    partial class StudentForm
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
            pblHeader = new Panel();
            label1 = new Label();
            lblPortalTitle = new Label();
            tabPage3 = new TabPage();
            pnlRequestsHeader = new Panel();
            btnCancelRequest = new Button();
            dgvMyRequests = new DataGridView();
            request_id = new DataGridViewTextBoxColumn();
            faculty_name = new DataGridViewTextBoxColumn();
            meeting_date = new DataGridViewTextBoxColumn();
            start_time = new DataGridViewTextBoxColumn();
            end_time = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            faculty_remarks = new DataGridViewTextBoxColumn();
            label3 = new Label();
            pnlNotification = new Panel();
            btnMarkAsRead = new Button();
            lblNotification = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            lblCompletedCount = new Label();
            lblCompletedTitle = new Label();
            panel3 = new Panel();
            lblPendingCount = new Label();
            lblPendingTitle = new Label();
            panel2 = new Panel();
            lblApprovedCount = new Label();
            lblApprovedTitle = new Label();
            panel1 = new Panel();
            lblTotalCount = new Label();
            lblTotalTitle = new Label();
            label2 = new Label();
            pnlHomeTitle = new Panel();
            lblHomeTitle = new Label();
            tabStudent = new TabControl();
            tabPage1 = new TabPage();
            dateTimePicker2 = new DateTimePicker();
            txtPurposeOfTheMeeting = new RichTextBox();
            btnSubmitRequest = new Button();
            lbPurposeofMeeting = new Label();
            dtpEndTime = new DateTimePicker();
            lblEndTime = new Label();
            dtpStartTime = new DateTimePicker();
            lblStartTime = new Label();
            dtpMeetingDate = new DateTimePicker();
            lblMeetingDate = new Label();
            dgvFacultyHours = new DataGridView();
            colDay = new DataGridViewTextBoxColumn();
            colStartTime = new DataGridViewTextBoxColumn();
            colEndTime = new DataGridViewTextBoxColumn();
            colLocation = new DataGridViewTextBoxColumn();
            label5 = new Label();
            cmbFaculty = new ComboBox();
            lblFaculty = new Label();
            pnlRequestTitle = new Panel();
            label4 = new Label();
            lblRequestTitle = new Label();
            tabPage2 = new TabPage();
            tlpSettingsLayout = new TableLayoutPanel();
            pnlStudentProfile = new Panel();
            lblStudentProfileTitle = new Label();
            pnlSettingsHeader = new Panel();
            lblSettingsSubtitle = new Label();
            lblSettingsTitle = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtStudentName = new TextBox();
            txtStudentId = new TextBox();
            txtStudentEmail = new TextBox();
            txtStudentProgram = new TextBox();
            textBox1 = new TextBox();
            cmbYearLevel = new ComboBox();
            pblHeader.SuspendLayout();
            tabPage3.SuspendLayout();
            pnlRequestsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyRequests).BeginInit();
            pnlNotification.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            pnlHomeTitle.SuspendLayout();
            tabStudent.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFacultyHours).BeginInit();
            pnlRequestTitle.SuspendLayout();
            tabPage2.SuspendLayout();
            tlpSettingsLayout.SuspendLayout();
            pnlStudentProfile.SuspendLayout();
            pnlSettingsHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pblHeader
            // 
            pblHeader.BackColor = Color.DarkGreen;
            pblHeader.Controls.Add(label1);
            pblHeader.Controls.Add(lblPortalTitle);
            pblHeader.Dock = DockStyle.Top;
            pblHeader.Location = new Point(0, 0);
            pblHeader.Name = "pblHeader";
            pblHeader.Size = new Size(1270, 100);
            pblHeader.TabIndex = 0;
            pblHeader.Paint += pblHeader_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.25F, FontStyle.Bold);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(270, 17);
            label1.TabIndex = 2;
            label1.Text = "Student Consultation Management System";
            label1.Click += label1_Click;
            // 
            // lblPortalTitle
            // 
            lblPortalTitle.AutoSize = true;
            lblPortalTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPortalTitle.ForeColor = Color.White;
            lblPortalTitle.Location = new Point(7, 0);
            lblPortalTitle.Name = "lblPortalTitle";
            lblPortalTitle.Size = new Size(203, 37);
            lblPortalTitle.TabIndex = 1;
            lblPortalTitle.Text = "Student Portal";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(pnlRequestsHeader);
            tabPage3.Controls.Add(pnlNotification);
            tabPage3.Controls.Add(tableLayoutPanel1);
            tabPage3.Controls.Add(pnlHomeTitle);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1262, 579);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Home";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnlRequestsHeader
            // 
            pnlRequestsHeader.Controls.Add(btnCancelRequest);
            pnlRequestsHeader.Controls.Add(dgvMyRequests);
            pnlRequestsHeader.Controls.Add(label3);
            pnlRequestsHeader.Dock = DockStyle.Top;
            pnlRequestsHeader.Location = new Point(3, 377);
            pnlRequestsHeader.Name = "pnlRequestsHeader";
            pnlRequestsHeader.Size = new Size(1256, 202);
            pnlRequestsHeader.TabIndex = 3;
            // 
            // btnCancelRequest
            // 
            btnCancelRequest.FlatStyle = FlatStyle.Flat;
            btnCancelRequest.Location = new Point(1165, 173);
            btnCancelRequest.Name = "btnCancelRequest";
            btnCancelRequest.Size = new Size(75, 23);
            btnCancelRequest.TabIndex = 3;
            btnCancelRequest.Text = "Cancel Request";
            btnCancelRequest.UseVisualStyleBackColor = true;
            // 
            // dgvMyRequests
            // 
            dgvMyRequests.AllowUserToAddRows = false;
            dgvMyRequests.AllowUserToDeleteRows = false;
            dgvMyRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMyRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyRequests.Columns.AddRange(new DataGridViewColumn[] { request_id, faculty_name, meeting_date, start_time, end_time, status, faculty_remarks });
            dgvMyRequests.Location = new Point(198, 34);
            dgvMyRequests.Name = "dgvMyRequests";
            dgvMyRequests.ReadOnly = true;
            dgvMyRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMyRequests.Size = new Size(920, 160);
            dgvMyRequests.TabIndex = 2;
            dgvMyRequests.CellContentClick += dgvMyRequests_CellContentClick;
            // 
            // request_id
            // 
            request_id.HeaderText = "Request ID";
            request_id.Name = "request_id";
            request_id.ReadOnly = true;
            // 
            // faculty_name
            // 
            faculty_name.HeaderText = "Faculty Name";
            faculty_name.Name = "faculty_name";
            faculty_name.ReadOnly = true;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(5, 6);
            label3.Name = "label3";
            label3.Size = new Size(203, 25);
            label3.TabIndex = 0;
            label3.Text = "My Meeting Requests";
            // 
            // pnlNotification
            // 
            pnlNotification.Controls.Add(btnMarkAsRead);
            pnlNotification.Controls.Add(lblNotification);
            pnlNotification.Dock = DockStyle.Top;
            pnlNotification.Location = new Point(3, 277);
            pnlNotification.Name = "pnlNotification";
            pnlNotification.Size = new Size(1256, 100);
            pnlNotification.TabIndex = 2;
            // 
            // btnMarkAsRead
            // 
            btnMarkAsRead.Location = new Point(1136, 6);
            btnMarkAsRead.Name = "btnMarkAsRead";
            btnMarkAsRead.Size = new Size(115, 23);
            btnMarkAsRead.TabIndex = 3;
            btnMarkAsRead.Text = "Mark as Read";
            btnMarkAsRead.UseVisualStyleBackColor = true;
            // 
            // lblNotification
            // 
            lblNotification.AutoSize = true;
            lblNotification.Location = new Point(5, 14);
            lblNotification.Name = "lblNotification";
            lblNotification.Size = new Size(179, 15);
            lblNotification.TabIndex = 3;
            lblNotification.Text = "You have a new meeting update.";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel4, 1, 1);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 103);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1256, 174);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(lblCompletedCount);
            panel4.Controls.Add(lblCompletedTitle);
            panel4.Location = new Point(631, 90);
            panel4.Name = "panel4";
            panel4.Size = new Size(622, 81);
            panel4.TabIndex = 1;
            // 
            // lblCompletedCount
            // 
            lblCompletedCount.AutoSize = true;
            lblCompletedCount.Font = new Font("Segoe UI", 14F);
            lblCompletedCount.Location = new Point(17, 49);
            lblCompletedCount.Name = "lblCompletedCount";
            lblCompletedCount.Size = new Size(22, 25);
            lblCompletedCount.TabIndex = 7;
            lblCompletedCount.Text = "0";
            // 
            // lblCompletedTitle
            // 
            lblCompletedTitle.AutoSize = true;
            lblCompletedTitle.Font = new Font("Segoe UI", 12F);
            lblCompletedTitle.Location = new Point(17, 25);
            lblCompletedTitle.Name = "lblCompletedTitle";
            lblCompletedTitle.Size = new Size(86, 21);
            lblCompletedTitle.TabIndex = 6;
            lblCompletedTitle.Text = "Completed";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblPendingCount);
            panel3.Controls.Add(lblPendingTitle);
            panel3.Location = new Point(631, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(622, 81);
            panel3.TabIndex = 1;
            // 
            // lblPendingCount
            // 
            lblPendingCount.AutoSize = true;
            lblPendingCount.Font = new Font("Segoe UI", 14F);
            lblPendingCount.Location = new Point(17, 50);
            lblPendingCount.Name = "lblPendingCount";
            lblPendingCount.Size = new Size(22, 25);
            lblPendingCount.TabIndex = 8;
            lblPendingCount.Text = "0";
            // 
            // lblPendingTitle
            // 
            lblPendingTitle.AutoSize = true;
            lblPendingTitle.Font = new Font("Segoe UI", 12F);
            lblPendingTitle.Location = new Point(17, 16);
            lblPendingTitle.Name = "lblPendingTitle";
            lblPendingTitle.Size = new Size(66, 21);
            lblPendingTitle.TabIndex = 5;
            lblPendingTitle.Text = "Pending";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblApprovedCount);
            panel2.Controls.Add(lblApprovedTitle);
            panel2.Location = new Point(3, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(622, 81);
            panel2.TabIndex = 1;
            // 
            // lblApprovedCount
            // 
            lblApprovedCount.AutoSize = true;
            lblApprovedCount.Font = new Font("Segoe UI", 14F);
            lblApprovedCount.Location = new Point(22, 49);
            lblApprovedCount.Name = "lblApprovedCount";
            lblApprovedCount.Size = new Size(22, 25);
            lblApprovedCount.TabIndex = 6;
            lblApprovedCount.Text = "0";
            lblApprovedCount.Click += label4_Click;
            // 
            // lblApprovedTitle
            // 
            lblApprovedTitle.AutoSize = true;
            lblApprovedTitle.Font = new Font("Segoe UI", 12F);
            lblApprovedTitle.Location = new Point(22, 25);
            lblApprovedTitle.Name = "lblApprovedTitle";
            lblApprovedTitle.Size = new Size(78, 21);
            lblApprovedTitle.TabIndex = 4;
            lblApprovedTitle.Text = "Approved";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblTotalCount);
            panel1.Controls.Add(lblTotalTitle);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(622, 81);
            panel1.TabIndex = 0;
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Font = new Font("Segoe UI", 14F);
            lblTotalCount.Location = new Point(22, 42);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(22, 25);
            lblTotalCount.TabIndex = 5;
            lblTotalCount.Text = "0";
            lblTotalCount.Click += label3_Click_1;
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.AutoSize = true;
            lblTotalTitle.Font = new Font("Segoe UI", 12F);
            lblTotalTitle.Location = new Point(22, 16);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(109, 21);
            lblTotalTitle.TabIndex = 3;
            lblTotalTitle.Text = "Total Requests";
            lblTotalTitle.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 11);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 2;
            // 
            // pnlHomeTitle
            // 
            pnlHomeTitle.BackColor = Color.White;
            pnlHomeTitle.Controls.Add(lblHomeTitle);
            pnlHomeTitle.Dock = DockStyle.Top;
            pnlHomeTitle.Location = new Point(3, 3);
            pnlHomeTitle.Name = "pnlHomeTitle";
            pnlHomeTitle.Size = new Size(1256, 100);
            pnlHomeTitle.TabIndex = 0;
            pnlHomeTitle.Paint += pnlHomeTitle_Paint;
            // 
            // lblHomeTitle
            // 
            lblHomeTitle.AutoSize = true;
            lblHomeTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHomeTitle.ForeColor = Color.DarkGreen;
            lblHomeTitle.Location = new Point(5, 10);
            lblHomeTitle.Name = "lblHomeTitle";
            lblHomeTitle.Size = new Size(233, 32);
            lblHomeTitle.TabIndex = 1;
            lblHomeTitle.Text = "Student Dashboard";
            // 
            // tabStudent
            // 
            tabStudent.Controls.Add(tabPage3);
            tabStudent.Controls.Add(tabPage1);
            tabStudent.Controls.Add(tabPage2);
            tabStudent.Dock = DockStyle.Fill;
            tabStudent.ImeMode = ImeMode.Disable;
            tabStudent.Location = new Point(0, 100);
            tabStudent.Name = "tabStudent";
            tabStudent.SelectedIndex = 0;
            tabStudent.Size = new Size(1270, 607);
            tabStudent.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dateTimePicker2);
            tabPage1.Controls.Add(txtPurposeOfTheMeeting);
            tabPage1.Controls.Add(btnSubmitRequest);
            tabPage1.Controls.Add(lbPurposeofMeeting);
            tabPage1.Controls.Add(dtpEndTime);
            tabPage1.Controls.Add(lblEndTime);
            tabPage1.Controls.Add(dtpStartTime);
            tabPage1.Controls.Add(lblStartTime);
            tabPage1.Controls.Add(dtpMeetingDate);
            tabPage1.Controls.Add(lblMeetingDate);
            tabPage1.Controls.Add(dgvFacultyHours);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(cmbFaculty);
            tabPage1.Controls.Add(lblFaculty);
            tabPage1.Controls.Add(pnlRequestTitle);
            tabPage1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1262, 579);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Request Meeting";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "YYYY-MM-DD, HH:MM";
            dateTimePicker2.Location = new Point(381, 355);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 25);
            dateTimePicker2.TabIndex = 16;
            // 
            // txtPurposeOfTheMeeting
            // 
            txtPurposeOfTheMeeting.Location = new Point(11, 426);
            txtPurposeOfTheMeeting.Name = "txtPurposeOfTheMeeting";
            txtPurposeOfTheMeeting.Size = new Size(1243, 89);
            txtPurposeOfTheMeeting.TabIndex = 14;
            txtPurposeOfTheMeeting.Text = "";
            // 
            // btnSubmitRequest
            // 
            btnSubmitRequest.Location = new Point(11, 521);
            btnSubmitRequest.Name = "btnSubmitRequest";
            btnSubmitRequest.Size = new Size(1243, 40);
            btnSubmitRequest.TabIndex = 13;
            btnSubmitRequest.Text = "Submit Request";
            btnSubmitRequest.UseVisualStyleBackColor = true;
            btnSubmitRequest.Click += btnSubmitRequest_Click;
            // 
            // lbPurposeofMeeting
            // 
            lbPurposeofMeeting.AutoSize = true;
            lbPurposeofMeeting.Location = new Point(11, 406);
            lbPurposeofMeeting.Name = "lbPurposeofMeeting";
            lbPurposeofMeeting.Size = new Size(130, 17);
            lbPurposeofMeeting.TabIndex = 11;
            lbPurposeofMeeting.Text = "Purpose of Meeting";
            // 
            // dtpEndTime
            // 
            dtpEndTime.CustomFormat = "hh:mm tt";
            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.Location = new Point(11, 371);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.ShowUpDown = true;
            dtpEndTime.Size = new Size(200, 25);
            dtpEndTime.TabIndex = 10;
            // 
            // lblEndTime
            // 
            lblEndTime.AutoSize = true;
            lblEndTime.Location = new Point(11, 353);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new Size(66, 17);
            lblEndTime.TabIndex = 9;
            lblEndTime.Text = "End Time";
            // 
            // dtpStartTime
            // 
            dtpStartTime.CustomFormat = "hh:mm tt";
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.Location = new Point(546, 317);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(200, 25);
            dtpStartTime.TabIndex = 8;
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStartTime.Location = new Point(546, 299);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(72, 17);
            lblStartTime.TabIndex = 0;
            lblStartTime.Text = "Start Time";
            // 
            // dtpMeetingDate
            // 
            dtpMeetingDate.Format = DateTimePickerFormat.Short;
            dtpMeetingDate.Location = new Point(11, 317);
            dtpMeetingDate.MinDate = new DateTime(2026, 10, 20, 0, 0, 0, 0);
            dtpMeetingDate.Name = "dtpMeetingDate";
            dtpMeetingDate.Size = new Size(200, 25);
            dtpMeetingDate.TabIndex = 7;
            // 
            // lblMeetingDate
            // 
            lblMeetingDate.AutoSize = true;
            lblMeetingDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMeetingDate.Location = new Point(8, 299);
            lblMeetingDate.Name = "lblMeetingDate";
            lblMeetingDate.Size = new Size(99, 19);
            lblMeetingDate.TabIndex = 6;
            lblMeetingDate.Text = "Meeting Date";
            // 
            // dgvFacultyHours
            // 
            dgvFacultyHours.AllowUserToAddRows = false;
            dgvFacultyHours.AllowUserToDeleteRows = false;
            dgvFacultyHours.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFacultyHours.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvFacultyHours.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacultyHours.Columns.AddRange(new DataGridViewColumn[] { colDay, colStartTime, colEndTime, colLocation });
            dgvFacultyHours.Location = new Point(11, 146);
            dgvFacultyHours.Name = "dgvFacultyHours";
            dgvFacultyHours.ReadOnly = true;
            dgvFacultyHours.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFacultyHours.Size = new Size(1243, 150);
            dgvFacultyHours.TabIndex = 5;
            // 
            // colDay
            // 
            colDay.HeaderText = "Day";
            colDay.Name = "colDay";
            colDay.ReadOnly = true;
            // 
            // colStartTime
            // 
            colStartTime.HeaderText = "Start Time";
            colStartTime.Name = "colStartTime";
            colStartTime.ReadOnly = true;
            // 
            // colEndTime
            // 
            colEndTime.HeaderText = "End Time";
            colEndTime.Name = "colEndTime";
            colEndTime.ReadOnly = true;
            // 
            // colLocation
            // 
            colLocation.HeaderText = "Location";
            colLocation.Name = "colLocation";
            colLocation.ReadOnly = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(6, 124);
            label5.Name = "label5";
            label5.Size = new Size(203, 19);
            label5.TabIndex = 4;
            label5.Text = "Available Consultation Hours";
            // 
            // cmbFaculty
            // 
            cmbFaculty.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFaculty.FormattingEnabled = true;
            cmbFaculty.Location = new Point(8, 98);
            cmbFaculty.Name = "cmbFaculty";
            cmbFaculty.Size = new Size(1246, 25);
            cmbFaculty.TabIndex = 3;
            // 
            // lblFaculty
            // 
            lblFaculty.AutoSize = true;
            lblFaculty.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFaculty.Location = new Point(8, 76);
            lblFaculty.Name = "lblFaculty";
            lblFaculty.Size = new Size(161, 19);
            lblFaculty.TabIndex = 2;
            lblFaculty.Text = "Select Faculty Member";
            // 
            // pnlRequestTitle
            // 
            pnlRequestTitle.BackColor = Color.White;
            pnlRequestTitle.Controls.Add(label4);
            pnlRequestTitle.Controls.Add(lblRequestTitle);
            pnlRequestTitle.Dock = DockStyle.Top;
            pnlRequestTitle.Location = new Point(3, 3);
            pnlRequestTitle.Name = "pnlRequestTitle";
            pnlRequestTitle.Size = new Size(1256, 70);
            pnlRequestTitle.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(5, 42);
            label4.Name = "label4";
            label4.Size = new Size(487, 19);
            label4.TabIndex = 1;
            label4.Text = "Select a faculty member and choose an available consultation schedule.";
            // 
            // lblRequestTitle
            // 
            lblRequestTitle.AutoSize = true;
            lblRequestTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRequestTitle.ForeColor = Color.DarkGreen;
            lblRequestTitle.Location = new Point(3, 10);
            lblRequestTitle.Name = "lblRequestTitle";
            lblRequestTitle.Size = new Size(227, 32);
            lblRequestTitle.TabIndex = 0;
            lblRequestTitle.Text = "Request a Meeting";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tlpSettingsLayout);
            tabPage2.Controls.Add(pnlSettingsHeader);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1262, 579);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "Settings";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click_1;
            // 
            // tlpSettingsLayout
            // 
            tlpSettingsLayout.ColumnCount = 2;
            tlpSettingsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpSettingsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpSettingsLayout.Controls.Add(pnlStudentProfile, 0, 0);
            tlpSettingsLayout.Dock = DockStyle.Fill;
            tlpSettingsLayout.Location = new Point(0, 85);
            tlpSettingsLayout.Name = "tlpSettingsLayout";
            tlpSettingsLayout.Padding = new Padding(8);
            tlpSettingsLayout.RowCount = 2;
            tlpSettingsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 75.94142F));
            tlpSettingsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 24.0585766F));
            tlpSettingsLayout.Size = new Size(1262, 494);
            tlpSettingsLayout.TabIndex = 13;
            // 
            // pnlStudentProfile
            // 
            pnlStudentProfile.BackColor = Color.White;
            pnlStudentProfile.BorderStyle = BorderStyle.FixedSingle;
            pnlStudentProfile.Controls.Add(cmbYearLevel);
            pnlStudentProfile.Controls.Add(textBox1);
            pnlStudentProfile.Controls.Add(txtStudentProgram);
            pnlStudentProfile.Controls.Add(txtStudentEmail);
            pnlStudentProfile.Controls.Add(txtStudentId);
            pnlStudentProfile.Controls.Add(txtStudentName);
            pnlStudentProfile.Controls.Add(label11);
            pnlStudentProfile.Controls.Add(label10);
            pnlStudentProfile.Controls.Add(label9);
            pnlStudentProfile.Controls.Add(label8);
            pnlStudentProfile.Controls.Add(label7);
            pnlStudentProfile.Controls.Add(label6);
            pnlStudentProfile.Controls.Add(lblStudentProfileTitle);
            pnlStudentProfile.Dock = DockStyle.Fill;
            pnlStudentProfile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            pnlStudentProfile.Location = new Point(11, 11);
            pnlStudentProfile.Name = "pnlStudentProfile";
            pnlStudentProfile.Padding = new Padding(10);
            pnlStudentProfile.Size = new Size(367, 357);
            pnlStudentProfile.TabIndex = 0;
            pnlStudentProfile.Paint += pnlStudentProfile_Paint;
            // 
            // lblStudentProfileTitle
            // 
            lblStudentProfileTitle.AutoSize = true;
            lblStudentProfileTitle.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentProfileTitle.Location = new Point(-1, -1);
            lblStudentProfileTitle.Name = "lblStudentProfileTitle";
            lblStudentProfileTitle.Size = new Size(132, 23);
            lblStudentProfileTitle.TabIndex = 0;
            lblStudentProfileTitle.Text = "Student Profile";
            // 
            // pnlSettingsHeader
            // 
            pnlSettingsHeader.BackColor = Color.White;
            pnlSettingsHeader.Controls.Add(lblSettingsSubtitle);
            pnlSettingsHeader.Controls.Add(lblSettingsTitle);
            pnlSettingsHeader.Dock = DockStyle.Top;
            pnlSettingsHeader.Location = new Point(0, 0);
            pnlSettingsHeader.Name = "pnlSettingsHeader";
            pnlSettingsHeader.Size = new Size(1262, 85);
            pnlSettingsHeader.TabIndex = 0;
            // 
            // lblSettingsSubtitle
            // 
            lblSettingsSubtitle.AutoSize = true;
            lblSettingsSubtitle.ForeColor = Color.DimGray;
            lblSettingsSubtitle.Location = new Point(8, 42);
            lblSettingsSubtitle.Name = "lblSettingsSubtitle";
            lblSettingsSubtitle.Size = new Size(189, 15);
            lblSettingsSubtitle.TabIndex = 1;
            lblSettingsSubtitle.Text = "Manage your account information";
            // 
            // lblSettingsTitle
            // 
            lblSettingsTitle.AutoSize = true;
            lblSettingsTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSettingsTitle.ForeColor = Color.DarkGreen;
            lblSettingsTitle.Location = new Point(3, 10);
            lblSettingsTitle.Name = "lblSettingsTitle";
            lblSettingsTitle.Size = new Size(106, 32);
            lblSettingsTitle.TabIndex = 1;
            lblSettingsTitle.Text = "Settings";
            lblSettingsTitle.Click += label6_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(-1, 22);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 1;
            label6.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(-1, 77);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 2;
            label7.Text = "Student ID";
            label7.Click += this.label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(-1, 132);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 3;
            label8.Text = "Email";
            label8.Click += this.label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(-1, 178);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 4;
            label9.Text = "Program";
            label9.Click += this.label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(-1, 233);
            label10.Name = "label10";
            label10.Size = new Size(64, 15);
            label10.TabIndex = 5;
            label10.Text = "Year Level";
            label10.Click += this.label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(-1, 288);
            label11.Name = "label11";
            label11.Size = new Size(49, 15);
            label11.TabIndex = 6;
            label11.Text = "Section";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(-1, 40);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(150, 23);
            txtStudentName.TabIndex = 7;
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(-1, 95);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(150, 23);
            txtStudentId.TabIndex = 8;
            // 
            // txtStudentEmail
            // 
            txtStudentEmail.Location = new Point(-1, 150);
            txtStudentEmail.Name = "txtStudentEmail";
            txtStudentEmail.Size = new Size(150, 23);
            txtStudentEmail.TabIndex = 9;
            // 
            // txtStudentProgram
            // 
            txtStudentProgram.Location = new Point(-1, 196);
            txtStudentProgram.Name = "txtStudentProgram";
            txtStudentProgram.Size = new Size(150, 23);
            txtStudentProgram.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(-1, 306);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 11;
            // 
            // cmbYearLevel
            // 
            cmbYearLevel.FormattingEnabled = true;
            cmbYearLevel.Location = new Point(-1, 251);
            cmbYearLevel.Name = "cmbYearLevel";
            cmbYearLevel.Size = new Size(150, 23);
            cmbYearLevel.TabIndex = 12;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1270, 707);
            Controls.Add(tabStudent);
            Controls.Add(pblHeader);
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Portal";
            Load += Student_Load;
            pblHeader.ResumeLayout(false);
            pblHeader.PerformLayout();
            tabPage3.ResumeLayout(false);
            pnlRequestsHeader.ResumeLayout(false);
            pnlRequestsHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyRequests).EndInit();
            pnlNotification.ResumeLayout(false);
            pnlNotification.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlHomeTitle.ResumeLayout(false);
            pnlHomeTitle.PerformLayout();
            tabStudent.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFacultyHours).EndInit();
            pnlRequestTitle.ResumeLayout(false);
            pnlRequestTitle.PerformLayout();
            tabPage2.ResumeLayout(false);
            tlpSettingsLayout.ResumeLayout(false);
            pnlStudentProfile.ResumeLayout(false);
            pnlStudentProfile.PerformLayout();
            pnlSettingsHeader.ResumeLayout(false);
            pnlSettingsHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pblHeader;
        private Label lblPortalTitle;
        private Label label1;
        private TabPage tabPage3;
        private Panel pnlRequestsHeader;
        private Button btnCancelRequest;
        private DataGridView dgvMyRequests;
        private DataGridViewTextBoxColumn request_id;
        private DataGridViewTextBoxColumn faculty_name;
        private DataGridViewTextBoxColumn meeting_date;
        private DataGridViewTextBoxColumn start_time;
        private DataGridViewTextBoxColumn end_time;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn faculty_remarks;
        private Label label3;
        private Panel pnlNotification;
        private Button btnMarkAsRead;
        private Label lblNotification;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private Label lblCompletedCount;
        private Label lblCompletedTitle;
        private Panel panel3;
        private Label lblPendingCount;
        private Label lblPendingTitle;
        private Panel panel2;
        private Label lblApprovedCount;
        private Label lblApprovedTitle;
        private Panel panel1;
        private Label lblTotalCount;
        private Label lblTotalTitle;
        private Label label2;
        private TabControl tabStudent;
        private Panel pnlHomeTitle;
        private Label lblHomeTitle;
        private TabPage tabPage1;
        private Label lblRequestTitle;
        private Panel pnlRequestTitle;
        private ComboBox cmbFaculty;
        private Label lblFaculty;
        private Label label4;
        private DataGridView dgvFacultyHours;
        private DataGridViewTextBoxColumn colDay;
        private DataGridViewTextBoxColumn colStartTime;
        private DataGridViewTextBoxColumn colEndTime;
        private DataGridViewTextBoxColumn colLocation;
        private Label label5;
        private DateTimePicker dtpMeetingDate;
        private Label lblMeetingDate;
        private Label lblEndTime;
        private DateTimePicker dtpStartTime;
        private Label lblStartTime;
        private DateTimePicker dtpEndTime;
        private Label lbPurposeofMeeting;
        private Button btnSubmitRequest;
        private RichTextBox txtPurposeOfTheMeeting;
        private DateTimePicker dateTimePicker2;
        private TabPage tabPage2;
        private TableLayoutPanel tlpSettingsLayout;
        private Panel pnlSettingsHeader;
        private Label lblSettingsSubtitle;
        private Label lblSettingsTitle;
        private Panel pnlStudentProfile;
        private Label lblStudentProfileTitle;
        private TextBox textBox1;
        private TextBox txtStudentProgram;
        private TextBox txtStudentEmail;
        private TextBox txtStudentId;
        private TextBox txtStudentName;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox cmbYearLevel;
    }
}