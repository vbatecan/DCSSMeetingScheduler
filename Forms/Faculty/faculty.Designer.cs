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
            tabFaculty = new TabControl();
            tabHome = new TabPage();
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
            lblDashboard = new Label();
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
            lblTitle = new Label();
            lblSubtitle = new Label();
            panel5 = new Panel();
            pnlHeader = new Panel();
            lblOverviewSub = new Label();
            grpOverview = new GroupBox();
            lblTodaysMeeting = new Label();
            lblTotalMeeting = new Label();
            label1 = new Label();
            lblTotalUpMeet = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            pnlNotifs = new Panel();
            lblNotifs = new Label();
            btnRefresh = new Button();
            grpRecentMeet = new GroupBox();
            dgvRecentRequest = new DataGridView();
            faculty_remarks = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            end_time = new DataGridViewTextBoxColumn();
            start_time = new DataGridViewTextBoxColumn();
            meeting_date = new DataGridViewTextBoxColumn();
            stud_name = new DataGridViewTextBoxColumn();
            request_id = new DataGridViewTextBoxColumn();
            tabFaculty.SuspendLayout();
            tabHome.SuspendLayout();
            pnlPending.SuspendLayout();
            pnlTotal.SuspendLayout();
            pnlDeclined.SuspendLayout();
            pnlApproved.SuspendLayout();
            tabAvailability.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            panel5.SuspendLayout();
            pnlHeader.SuspendLayout();
            grpOverview.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlNotifs.SuspendLayout();
            grpRecentMeet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentRequest).BeginInit();
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
            tabFaculty.Location = new Point(0, 89);
            tabFaculty.Margin = new Padding(2);
            tabFaculty.Name = "tabFaculty";
            tabFaculty.SelectedIndex = 0;
            tabFaculty.Size = new Size(1266, 592);
            tabFaculty.TabIndex = 0;
            // 
            // tabHome
            // 
            tabHome.BackColor = Color.White;
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
            tabHome.Size = new Size(1258, 564);
            tabHome.TabIndex = 0;
            tabHome.Text = "Home";
            // 
            // pnlPending
            // 
            pnlPending.BorderStyle = BorderStyle.FixedSingle;
            pnlPending.Controls.Add(lblPendingTotal);
            pnlPending.Controls.Add(label4);
            pnlPending.Location = new Point(318, 88);
            pnlPending.Margin = new Padding(3, 2, 3, 2);
            pnlPending.Name = "pnlPending";
            pnlPending.Size = new Size(307, 82);
            pnlPending.TabIndex = 9;
            // 
            // lblPendingTotal
            // 
            lblPendingTotal.AutoSize = true;
            lblPendingTotal.Font = new Font("Segoe UI", 14F);
            lblPendingTotal.Location = new Point(18, 36);
            lblPendingTotal.Name = "lblPendingTotal";
            lblPendingTotal.Size = new Size(22, 25);
            lblPendingTotal.TabIndex = 1;
            lblPendingTotal.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(18, 13);
            label4.Name = "label4";
            label4.Size = new Size(60, 19);
            label4.TabIndex = 0;
            label4.Text = "Pending";
            // 
            // pnlTotal
            // 
            pnlTotal.BorderStyle = BorderStyle.FixedSingle;
            pnlTotal.Controls.Add(lblTotal);
            pnlTotal.Controls.Add(label3);
            pnlTotal.Location = new Point(5, 88);
            pnlTotal.Margin = new Padding(3, 2, 3, 2);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(307, 82);
            pnlTotal.TabIndex = 8;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14F);
            lblTotal.Location = new Point(16, 36);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(22, 25);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(16, 13);
            label3.Name = "label3";
            label3.Size = new Size(100, 19);
            label3.TabIndex = 0;
            label3.Text = "Total Requests";
            // 
            // pnlDeclined
            // 
            pnlDeclined.BorderStyle = BorderStyle.FixedSingle;
            pnlDeclined.Controls.Add(lblDeclinedTotal);
            pnlDeclined.Controls.Add(label6);
            pnlDeclined.Location = new Point(944, 88);
            pnlDeclined.Margin = new Padding(3, 2, 3, 2);
            pnlDeclined.Name = "pnlDeclined";
            pnlDeclined.Size = new Size(307, 82);
            pnlDeclined.TabIndex = 7;
            // 
            // lblDeclinedTotal
            // 
            lblDeclinedTotal.AutoSize = true;
            lblDeclinedTotal.Font = new Font("Segoe UI", 14F);
            lblDeclinedTotal.Location = new Point(18, 36);
            lblDeclinedTotal.Name = "lblDeclinedTotal";
            lblDeclinedTotal.Size = new Size(22, 25);
            lblDeclinedTotal.TabIndex = 2;
            lblDeclinedTotal.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(18, 13);
            label6.Name = "label6";
            label6.Size = new Size(64, 19);
            label6.TabIndex = 0;
            label6.Text = "Declined";
            // 
            // pnlApproved
            // 
            pnlApproved.BorderStyle = BorderStyle.FixedSingle;
            pnlApproved.Controls.Add(lblApprovedTotal);
            pnlApproved.Controls.Add(label5);
            pnlApproved.Location = new Point(631, 88);
            pnlApproved.Margin = new Padding(3, 2, 3, 2);
            pnlApproved.Name = "pnlApproved";
            pnlApproved.Size = new Size(307, 82);
            pnlApproved.TabIndex = 6;
            // 
            // lblApprovedTotal
            // 
            lblApprovedTotal.AutoSize = true;
            lblApprovedTotal.Font = new Font("Segoe UI", 14F);
            lblApprovedTotal.Location = new Point(16, 36);
            lblApprovedTotal.Name = "lblApprovedTotal";
            lblApprovedTotal.Size = new Size(22, 25);
            lblApprovedTotal.TabIndex = 1;
            lblApprovedTotal.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(16, 13);
            label5.Name = "label5";
            label5.Size = new Size(69, 19);
            label5.TabIndex = 0;
            label5.Text = "Approved";
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.ForeColor = Color.DarkGreen;
            lblDashboard.Location = new Point(10, 11);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(225, 32);
            lblDashboard.TabIndex = 2;
            lblDashboard.Text = "Faculty Dashboard";
            // 
            // tabRequest
            // 
            tabRequest.Location = new Point(4, 24);
            tabRequest.Margin = new Padding(2);
            tabRequest.Name = "tabRequest";
            tabRequest.Padding = new Padding(2);
            tabRequest.Size = new Size(1258, 564);
            tabRequest.TabIndex = 1;
            tabRequest.Text = "Request";
            tabRequest.UseVisualStyleBackColor = true;
            // 
            // tabAvailability
            // 
            tabAvailability.BackColor = Color.Transparent;
            tabAvailability.Controls.Add(groupBox2);
            tabAvailability.Controls.Add(groupBox1);
            tabAvailability.Location = new Point(4, 24);
            tabAvailability.Margin = new Padding(2);
            tabAvailability.Name = "tabAvailability";
            tabAvailability.Padding = new Padding(2);
            tabAvailability.Size = new Size(1258, 564);
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
            groupBox2.Location = new Point(290, 67);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(573, 289);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Weekly Consultation Hours";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // Tips
            // 
            Tips.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tips.Location = new Point(5, 256);
            Tips.Margin = new Padding(3, 2, 3, 2);
            Tips.Name = "Tips";
            Tips.Size = new Size(405, 23);
            Tips.TabIndex = 5;
            Tips.Text = "Tips Click \"Add New\" to create new  consultation hours. ";
            // 
            // EditBTN
            // 
            EditBTN.Location = new Point(427, 255);
            EditBTN.Margin = new Padding(3, 2, 3, 2);
            EditBTN.Name = "EditBTN";
            EditBTN.Size = new Size(59, 22);
            EditBTN.TabIndex = 4;
            EditBTN.Text = "Edit";
            EditBTN.UseVisualStyleBackColor = true;
            // 
            // DeleteBTN
            // 
            DeleteBTN.Location = new Point(491, 255);
            DeleteBTN.Margin = new Padding(3, 2, 3, 2);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(59, 22);
            DeleteBTN.TabIndex = 3;
            DeleteBTN.Text = "Delete";
            DeleteBTN.UseVisualStyleBackColor = true;
            // 
            // SearchBTN
            // 
            SearchBTN.Location = new Point(351, 11);
            SearchBTN.Margin = new Padding(3, 2, 3, 2);
            SearchBTN.Name = "SearchBTN";
            SearchBTN.Size = new Size(59, 22);
            SearchBTN.TabIndex = 1;
            SearchBTN.Text = "Search";
            SearchBTN.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(351, 13);
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
            dataGridView1.Location = new Point(5, 38);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(544, 213);
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
            groupBox1.Location = new Point(11, 67);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(260, 289);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add / Consultation Hours";
            // 
            // button1
            // 
            button1.Location = new Point(143, 220);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(83, 22);
            button1.TabIndex = 7;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            // 
            // AddBTN
            // 
            AddBTN.Location = new Point(29, 220);
            AddBTN.Margin = new Padding(3, 2, 3, 2);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(83, 22);
            AddBTN.TabIndex = 1;
            AddBTN.Text = "+   Add";
            AddBTN.UseVisualStyleBackColor = true;
            AddBTN.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(18, 181);
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
            lblLocation.Location = new Point(18, 166);
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
            dateTimePicker3.Location = new Point(21, 136);
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
            lblEndTime.Location = new Point(18, 121);
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
            dateTimePicker1.Location = new Point(21, 88);
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
            lblStartTime.Location = new Point(18, 74);
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
            comboBox1.Location = new Point(18, 38);
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
            lblDayOfWeek.Location = new Point(18, 22);
            lblDayOfWeek.Name = "lblDayOfWeek";
            lblDayOfWeek.Size = new Size(61, 12);
            lblDayOfWeek.TabIndex = 2;
            lblDayOfWeek.Text = "Day of Week";
            lblDayOfWeek.Click += label2_Click;
            // 
            // tabSettings
            // 
            tabSettings.Location = new Point(4, 24);
            tabSettings.Margin = new Padding(2);
            tabSettings.Name = "tabSettings";
            tabSettings.Padding = new Padding(2);
            tabSettings.Size = new Size(1258, 564);
            tabSettings.TabIndex = 3;
            tabSettings.Text = "Setting";
            tabSettings.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.InactiveBorder;
            lblTitle.Location = new Point(8, 5);
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
            lblSubtitle.Location = new Point(14, 43);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(205, 15);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Faculty Request Management System";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(lblOverviewSub);
            panel5.Controls.Add(lblDashboard);
            panel5.Location = new Point(5, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(1248, 79);
            panel5.TabIndex = 10;
            // 
            // pnlHeader
            // 
            pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeader.BackColor = Color.DarkGreen;
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(0, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1262, 107);
            pnlHeader.TabIndex = 11;
            // 
            // lblOverviewSub
            // 
            lblOverviewSub.AutoSize = true;
            lblOverviewSub.Location = new Point(16, 45);
            lblOverviewSub.Name = "lblOverviewSub";
            lblOverviewSub.Size = new Size(224, 15);
            lblOverviewSub.TabIndex = 3;
            lblOverviewSub.Text = "Overview of student consultation request";
            // 
            // grpOverview
            // 
            grpOverview.Controls.Add(panel2);
            grpOverview.Controls.Add(panel1);
            grpOverview.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            grpOverview.ForeColor = Color.DarkGreen;
            grpOverview.Location = new Point(16, 175);
            grpOverview.Name = "grpOverview";
            grpOverview.Size = new Size(1230, 102);
            grpOverview.TabIndex = 11;
            grpOverview.TabStop = false;
            grpOverview.Text = "Today's Overview";
            // 
            // lblTodaysMeeting
            // 
            lblTodaysMeeting.AutoSize = true;
            lblTodaysMeeting.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodaysMeeting.ForeColor = Color.Black;
            lblTodaysMeeting.Location = new Point(14, 13);
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
            lblTotalMeeting.Location = new Point(130, 13);
            lblTotalMeeting.Name = "lblTotalMeeting";
            lblTotalMeeting.Size = new Size(17, 19);
            lblTotalMeeting.TabIndex = 1;
            lblTotalMeeting.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(14, 14);
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
            lblTotalUpMeet.Location = new Point(148, 14);
            lblTotalUpMeet.Name = "lblTotalUpMeet";
            lblTotalUpMeet.Size = new Size(17, 19);
            lblTotalUpMeet.TabIndex = 12;
            lblTotalUpMeet.Text = "0";
            lblTotalUpMeet.Click += this.lblTotalUpMeet_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblTodaysMeeting);
            panel1.Controls.Add(lblTotalMeeting);
            panel1.Location = new Point(15, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(594, 45);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblTotalUpMeet);
            panel2.Location = new Point(615, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 45);
            panel2.TabIndex = 12;
            // 
            // pnlNotifs
            // 
            pnlNotifs.BackColor = Color.MintCream;
            pnlNotifs.BorderStyle = BorderStyle.FixedSingle;
            pnlNotifs.Controls.Add(btnRefresh);
            pnlNotifs.Controls.Add(lblNotifs);
            pnlNotifs.Location = new Point(16, 280);
            pnlNotifs.Name = "pnlNotifs";
            pnlNotifs.Size = new Size(1230, 55);
            pnlNotifs.TabIndex = 12;
            // 
            // lblNotifs
            // 
            lblNotifs.AutoSize = true;
            lblNotifs.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotifs.Location = new Point(14, 18);
            lblNotifs.Name = "lblNotifs";
            lblNotifs.Size = new Size(240, 17);
            lblNotifs.TabIndex = 13;
            lblNotifs.Text = "You have new meeting request updates.";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.SeaGreen;
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1099, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(115, 31);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // grpRecentMeet
            // 
            grpRecentMeet.BackColor = Color.White;
            grpRecentMeet.Controls.Add(dgvRecentRequest);
            grpRecentMeet.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            grpRecentMeet.ForeColor = Color.DarkGreen;
            grpRecentMeet.Location = new Point(16, 341);
            grpRecentMeet.Name = "grpRecentMeet";
            grpRecentMeet.Size = new Size(1230, 194);
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
            dgvRecentRequest.Location = new Point(15, 35);
            dgvRecentRequest.MultiSelect = false;
            dgvRecentRequest.Name = "dgvRecentRequest";
            dgvRecentRequest.ReadOnly = true;
            dgvRecentRequest.RowHeadersVisible = false;
            dgvRecentRequest.RowHeadersWidth = 20;
            dgvRecentRequest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentRequest.Size = new Size(1200, 145);
            dgvRecentRequest.TabIndex = 14;
            // 
            // faculty_remarks
            // 
            faculty_remarks.HeaderText = "Faculty Remarks";
            faculty_remarks.Name = "faculty_remarks";
            faculty_remarks.ReadOnly = true;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // end_time
            // 
            end_time.HeaderText = "End Time";
            end_time.Name = "end_time";
            end_time.ReadOnly = true;
            // 
            // start_time
            // 
            start_time.HeaderText = "Start Time";
            start_time.Name = "start_time";
            start_time.ReadOnly = true;
            // 
            // meeting_date
            // 
            meeting_date.HeaderText = "Meeting Date";
            meeting_date.Name = "meeting_date";
            meeting_date.ReadOnly = true;
            // 
            // stud_name
            // 
            stud_name.HeaderText = "Student Name";
            stud_name.Name = "stud_name";
            stud_name.ReadOnly = true;
            // 
            // request_id
            // 
            request_id.HeaderText = "Request ID";
            request_id.Name = "request_id";
            request_id.ReadOnly = true;
            // 
            // faculty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1264, 681);
            Controls.Add(tabFaculty);
            Controls.Add(pnlHeader);
            Margin = new Padding(2);
            Name = "faculty";
            Text = "Faculty Form";
            tabFaculty.ResumeLayout(false);
            tabHome.ResumeLayout(false);
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
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpOverview.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlNotifs.ResumeLayout(false);
            pnlNotifs.PerformLayout();
            grpRecentMeet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecentRequest).EndInit();
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
    }
}