namespace DCSSMeetingScheduler.Student
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
        private void InitializeComponent() {
            tabBookMeeting = new TabControl();
            tabHome = new TabPage();
            btnSubmitRequest = new Button();
            txtMessage = new TextBox();
            lbMessage = new Label();
            cmbAvailableTime = new ComboBox();
            label10 = new Label();
            lbMeetingDate = new Label();
            dtpMeetingDate = new DateTimePicker();
            txtPurpose = new TextBox();
            cmbFaculty = new ComboBox();
            lbPurpose = new Label();
            label9 = new Label();
            panelDeclined = new Panel();
            label7 = new Label();
            label4 = new Label();
            panelApproved = new Panel();
            label6 = new Label();
            label2 = new Label();
            panelPending = new Panel();
            label8 = new Label();
            label3 = new Label();
            panelRequest = new Panel();
            label5 = new Label();
            label1 = new Label();
            lbSubtitle = new Label();
            lbWelcome = new Label();
            Book = new TabPage();
            tabRequests = new TabPage();
            lbRequestsSubTitle = new Label();
            lbRequestsTitle = new Label();
            tabAvailability = new TabPage();
            tabSettings = new TabPage();
            tabBookMeeting.SuspendLayout();
            tabHome.SuspendLayout();
            panelDeclined.SuspendLayout();
            panelApproved.SuspendLayout();
            panelPending.SuspendLayout();
            panelRequest.SuspendLayout();
            tabRequests.SuspendLayout();
            SuspendLayout();
            // 
            // tabBookMeeting
            // 
            tabBookMeeting.Controls.Add(tabHome);
            tabBookMeeting.Controls.Add(Book);
            tabBookMeeting.Controls.Add(tabRequests);
            tabBookMeeting.Controls.Add(tabAvailability);
            tabBookMeeting.Controls.Add(tabSettings);
            tabBookMeeting.Dock = DockStyle.Fill;
            tabBookMeeting.Location = new Point(0, 0);
            tabBookMeeting.Name = "tabBookMeeting";
            tabBookMeeting.SelectedIndex = 0;
            tabBookMeeting.Size = new Size(1264, 681);
            tabBookMeeting.TabIndex = 0;
            // 
            // tabHome
            // 
            tabHome.Controls.Add(btnSubmitRequest);
            tabHome.Controls.Add(txtMessage);
            tabHome.Controls.Add(lbMessage);
            tabHome.Controls.Add(cmbAvailableTime);
            tabHome.Controls.Add(label10);
            tabHome.Controls.Add(lbMeetingDate);
            tabHome.Controls.Add(dtpMeetingDate);
            tabHome.Controls.Add(txtPurpose);
            tabHome.Controls.Add(cmbFaculty);
            tabHome.Controls.Add(lbPurpose);
            tabHome.Controls.Add(label9);
            tabHome.Controls.Add(panelDeclined);
            tabHome.Controls.Add(panelApproved);
            tabHome.Controls.Add(panelPending);
            tabHome.Controls.Add(panelRequest);
            tabHome.Controls.Add(lbSubtitle);
            tabHome.Controls.Add(lbWelcome);
            tabHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tabHome.Location = new Point(4, 24);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(3);
            tabHome.Size = new Size(1256, 653);
            tabHome.TabIndex = 0;
            tabHome.Text = "Home";
            tabHome.UseVisualStyleBackColor = true;
            tabHome.Click += tabPage1_Click;
            // 
            // btnSubmitRequest
            // 
            btnSubmitRequest.Location = new Point(61, 599);
            btnSubmitRequest.Name = "btnSubmitRequest";
            btnSubmitRequest.Size = new Size(559, 23);
            btnSubmitRequest.TabIndex = 16;
            btnSubmitRequest.Text = "Submit Request";
            btnSubmitRequest.UseVisualStyleBackColor = true;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(65, 557);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(555, 23);
            txtMessage.TabIndex = 15;
            // 
            // lbMessage
            // 
            lbMessage.AutoSize = true;
            lbMessage.Location = new Point(63, 539);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(113, 15);
            lbMessage.TabIndex = 14;
            lbMessage.Text = "Message To Faculty";
            // 
            // cmbAvailableTime
            // 
            cmbAvailableTime.FormattingEnabled = true;
            cmbAvailableTime.Location = new Point(397, 503);
            cmbAvailableTime.Name = "cmbAvailableTime";
            cmbAvailableTime.Size = new Size(223, 23);
            cmbAvailableTime.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(397, 482);
            label10.Name = "label10";
            label10.Size = new Size(88, 15);
            label10.TabIndex = 12;
            label10.Text = "Available Time";
            // 
            // lbMeetingDate
            // 
            lbMeetingDate.AutoSize = true;
            lbMeetingDate.Location = new Point(65, 482);
            lbMeetingDate.Name = "lbMeetingDate";
            lbMeetingDate.Size = new Size(84, 15);
            lbMeetingDate.TabIndex = 11;
            lbMeetingDate.Text = "Meeting Date";
            // 
            // dtpMeetingDate
            // 
            dtpMeetingDate.Format = DateTimePickerFormat.Short;
            dtpMeetingDate.Location = new Point(65, 500);
            dtpMeetingDate.Name = "dtpMeetingDate";
            dtpMeetingDate.Size = new Size(200, 23);
            dtpMeetingDate.TabIndex = 10;
            // 
            // txtPurpose
            // 
            txtPurpose.Location = new Point(65, 445);
            txtPurpose.Name = "txtPurpose";
            txtPurpose.Size = new Size(555, 23);
            txtPurpose.TabIndex = 9;
            // 
            // cmbFaculty
            // 
            cmbFaculty.FormattingEnabled = true;
            cmbFaculty.Location = new Point(63, 389);
            cmbFaculty.Name = "cmbFaculty";
            cmbFaculty.Size = new Size(557, 23);
            cmbFaculty.TabIndex = 8;
            // 
            // lbPurpose
            // 
            lbPurpose.AutoSize = true;
            lbPurpose.Location = new Point(61, 427);
            lbPurpose.Name = "lbPurpose";
            lbPurpose.Size = new Size(52, 15);
            lbPurpose.TabIndex = 7;
            lbPurpose.Text = "Purpose";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(63, 371);
            label9.Name = "label9";
            label9.Size = new Size(97, 15);
            label9.TabIndex = 6;
            label9.Text = "Faculty Member";
            // 
            // panelDeclined
            // 
            panelDeclined.BackColor = Color.White;
            panelDeclined.Controls.Add(label7);
            panelDeclined.Controls.Add(label4);
            panelDeclined.Location = new Point(660, 227);
            panelDeclined.Name = "panelDeclined";
            panelDeclined.Size = new Size(564, 110);
            panelDeclined.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 18F);
            label7.Location = new Point(15, 40);
            label7.Name = "label7";
            label7.Size = new Size(26, 29);
            label7.TabIndex = 3;
            label7.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(15, 11);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "DECLINED";
            // 
            // panelApproved
            // 
            panelApproved.BackColor = Color.White;
            panelApproved.Controls.Add(label6);
            panelApproved.Controls.Add(label2);
            panelApproved.Location = new Point(46, 227);
            panelApproved.Name = "panelApproved";
            panelApproved.Size = new Size(574, 110);
            panelApproved.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 18F);
            label6.Location = new Point(15, 40);
            label6.Name = "label6";
            label6.Size = new Size(26, 29);
            label6.TabIndex = 2;
            label6.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 11);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "APPROVED";
            // 
            // panelPending
            // 
            panelPending.BackColor = Color.White;
            panelPending.Controls.Add(label8);
            panelPending.Controls.Add(label3);
            panelPending.Location = new Point(660, 122);
            panelPending.Name = "panelPending";
            panelPending.Size = new Size(564, 110);
            panelPending.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 18F);
            label8.Location = new Point(15, 38);
            label8.Name = "label8";
            label8.Size = new Size(26, 29);
            label8.TabIndex = 4;
            label8.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 6);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "PENDING";
            // 
            // panelRequest
            // 
            panelRequest.BackColor = Color.White;
            panelRequest.Controls.Add(label5);
            panelRequest.Controls.Add(label1);
            panelRequest.Location = new Point(46, 122);
            panelRequest.Name = "panelRequest";
            panelRequest.Size = new Size(574, 110);
            panelRequest.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F);
            label5.Location = new Point(15, 38);
            label5.Name = "label5";
            label5.Size = new Size(26, 29);
            label5.TabIndex = 1;
            label5.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 6);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "MY REQUEST";
            // 
            // lbSubtitle
            // 
            lbSubtitle.AutoSize = true;
            lbSubtitle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSubtitle.Location = new Point(47, 62);
            lbSubtitle.Name = "lbSubtitle";
            lbSubtitle.Size = new Size(218, 17);
            lbSubtitle.TabIndex = 1;
            lbSubtitle.Text = "Manage your faculty consultations";
            lbSubtitle.Click += label2_Click;
            // 
            // lbWelcome
            // 
            lbWelcome.AutoSize = true;
            lbWelcome.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbWelcome.Location = new Point(40, 25);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new Size(259, 37);
            lbWelcome.TabIndex = 0;
            lbWelcome.Text = "Welcome, Student!";
            lbWelcome.Click += label1_Click;
            // 
            // Book
            // 
            Book.Location = new Point(4, 24);
            Book.Name = "Book";
            Book.Padding = new Padding(3);
            Book.Size = new Size(1256, 653);
            Book.TabIndex = 1;
            Book.Text = "Book a Meeting";
            Book.UseVisualStyleBackColor = true;
            // 
            // tabRequests
            // 
            tabRequests.Controls.Add(lbRequestsSubTitle);
            tabRequests.Controls.Add(lbRequestsTitle);
            tabRequests.Location = new Point(4, 24);
            tabRequests.Name = "tabRequests";
            tabRequests.Size = new Size(1256, 653);
            tabRequests.TabIndex = 0;
            tabRequests.Text = "My Request";
            tabRequests.UseVisualStyleBackColor = true;
            // 
            // lbRequestsSubTitle
            // 
            lbRequestsSubTitle.AutoSize = true;
            lbRequestsSubTitle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRequestsSubTitle.Location = new Point(38, 37);
            lbRequestsSubTitle.Name = "lbRequestsSubTitle";
            lbRequestsSubTitle.Size = new Size(211, 17);
            lbRequestsSubTitle.TabIndex = 1;
            lbRequestsSubTitle.Text = "Track Your Consultation Requests";
            // 
            // lbRequestsTitle
            // 
            lbRequestsTitle.AutoSize = true;
            lbRequestsTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRequestsTitle.Location = new Point(38, 0);
            lbRequestsTitle.Name = "lbRequestsTitle";
            lbRequestsTitle.Size = new Size(295, 37);
            lbRequestsTitle.TabIndex = 0;
            lbRequestsTitle.Text = "My Meeting Requests";
            // 
            // tabAvailability
            // 
            tabAvailability.Location = new Point(4, 24);
            tabAvailability.Name = "tabAvailability";
            tabAvailability.Size = new Size(1256, 653);
            tabAvailability.TabIndex = 0;
            tabAvailability.Text = "Availability";
            tabAvailability.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            tabSettings.Location = new Point(4, 24);
            tabSettings.Name = "tabSettings";
            tabSettings.Size = new Size(1256, 653);
            tabSettings.TabIndex = 0;
            tabSettings.Text = "Settings";
            tabSettings.UseVisualStyleBackColor = true;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(tabBookMeeting);
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Form";
            tabBookMeeting.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            tabHome.PerformLayout();
            panelDeclined.ResumeLayout(false);
            panelDeclined.PerformLayout();
            panelApproved.ResumeLayout(false);
            panelApproved.PerformLayout();
            panelPending.ResumeLayout(false);
            panelPending.PerformLayout();
            panelRequest.ResumeLayout(false);
            panelRequest.PerformLayout();
            tabRequests.ResumeLayout(false);
            tabRequests.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabBookMeeting;
        private TabPage tabHome;
        private TabPage Book;
        private TabPage tabRequests;
        private TabPage tabAvailability;
        private TabPage tabSettings;
        private Label lbSubtitle;
        private Label lbWelcome;
        private Panel panelRequest;
        private Panel panelDeclined;
        private Panel panelApproved;
        private Panel panelPending;
        private Label label1;
        private Label label7;
        private Label label4;
        private Label label6;
        private Label label2;
        private Label label8;
        private Label label3;
        private Label label5;
        private TextBox txtPurpose;
        private ComboBox cmbFaculty;
        private Label lbPurpose;
        private Label label9;
        private Label lbMeetingDate;
        private DateTimePicker dtpMeetingDate;
        private ComboBox cmbAvailableTime;
        private Label label10;
        private Button btnSubmitRequest;
        private TextBox txtMessage;
        private Label lbMessage;
        private Label lbRequestsTitle;
        private Label lbRequestsSubTitle;
    }
}