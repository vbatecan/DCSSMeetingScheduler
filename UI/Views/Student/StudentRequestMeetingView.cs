using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DCSSMeetingScheduler.Models;
using DCSSMeetingScheduler.Services;
using DCSSMeetingScheduler.UI.Common;

namespace DCSSMeetingScheduler.UI.Views.Student {
    public class StudentRequestMeetingView : UserControl {
        private readonly IDataService _dataService = MockDataStore.Instance;

        private readonly ComboBox _cbFaculty = new();
        private readonly TextBox _txtSubject = new();
        private readonly TextBox _txtPurpose = new();
        private readonly DateTimePicker _dtpDate = new();
        private readonly ComboBox _cbTime = new();
        private readonly ComboBox _cbMeetingType = new();
        private readonly TextBox _txtLocationOrDetails = new();
        private readonly Label _lblFacultyConsultationInfo = new();

        public event EventHandler? RequestSubmitted;

        public StudentRequestMeetingView() {
            DoubleBuffered = true;
            Dock = DockStyle.Fill;
            BackColor = ThemeColors.CanvasBackground;
            AutoScroll = true;

            InitializeLayout();
            LoadFacultyList();
        }

        private void InitializeLayout() {
            // Header
            var pnlHeader = UIHelper.CreatePageHeader(
                "REQUEST A FACULTY CONSULTATION",
                "Submit a meeting request to DCSS faculty members for academic advisory, projects, or thesis"
            );
            Controls.Add(pnlHeader);

            // Body Container Panel
            var pnlBody = new Panel {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(24, 16, 24, 30)
            };

            // White Form Card
            var pnlFormCard = UIHelper.CreateCard(24);
            pnlFormCard.Dock = DockStyle.Top;
            pnlFormCard.Height = 620;
            pnlFormCard.MaximumSize = new Size(820, 0);

            var lblFormTitle = new Label {
                Text = "Consultation Request Form",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(20, 16),
                AutoSize = true
            };
            pnlFormCard.Controls.Add(lblFormTitle);

            var lblFormSubtitle = new Label {
                Text = "Please fill in all details carefully. The faculty member will review your request and confirm the schedule.",
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = ThemeColors.TextMuted,
                Location = new Point(20, 42),
                AutoSize = true
            };
            pnlFormCard.Controls.Add(lblFormSubtitle);

            int y = 75;

            // 1. Faculty Member Selection
            var lblFaculty = new Label {
                Text = "Faculty Member *",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(20, y),
                AutoSize = true
            };
            pnlFormCard.Controls.Add(lblFaculty);
            y += 22;

            _cbFaculty.Location = new Point(20, y);
            _cbFaculty.Size = new Size(720, 28);
            UIHelper.StyleComboBox(_cbFaculty);
            _cbFaculty.SelectedIndexChanged += OnFacultyChanged;
            pnlFormCard.Controls.Add(_cbFaculty);
            y += 32;

            // Faculty advisory info badge
            _lblFacultyConsultationInfo.Location = new Point(20, y);
            _lblFacultyConsultationInfo.Size = new Size(720, 24);
            _lblFacultyConsultationInfo.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            _lblFacultyConsultationInfo.ForeColor = ThemeColors.PrimaryRedDark;
            _lblFacultyConsultationInfo.BackColor = ThemeColors.LightRed;
            _lblFacultyConsultationInfo.Padding = new Padding(6, 4, 6, 4);
            _lblFacultyConsultationInfo.Visible = false;
            pnlFormCard.Controls.Add(_lblFacultyConsultationInfo);
            y += 30;

            // 2. Meeting Subject
            var lblSubject = new Label {
                Text = "Meeting Subject / Topic *",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(20, y),
                AutoSize = true
            };
            pnlFormCard.Controls.Add(lblSubject);
            y += 22;

            _txtSubject.Location = new Point(20, y);
            _txtSubject.Size = new Size(720, 26);
            _txtSubject.PlaceholderText = "e.g. Capstone 1 Chapter 2 Review, OJT Endorsement, Grade Consultation";
            UIHelper.StyleTextBox(_txtSubject);
            pnlFormCard.Controls.Add(_txtSubject);
            y += 38;

            // 3. Meeting Purpose / Description
            var lblPurpose = new Label {
                Text = "Meeting Purpose / Detailed Description *",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(20, y),
                AutoSize = true
            };
            pnlFormCard.Controls.Add(lblPurpose);
            y += 22;

            _txtPurpose.Location = new Point(20, y);
            _txtPurpose.Size = new Size(720, 80);
            _txtPurpose.Multiline = true;
            _txtPurpose.ScrollBars = ScrollBars.Vertical;
            _txtPurpose.PlaceholderText = "Explain specific items or questions you would like to discuss with the faculty member...";
            UIHelper.StyleTextBox(_txtPurpose);
            pnlFormCard.Controls.Add(_txtPurpose);
            y += 92;

            // 4. Preferred Date and Time (Two columns)
            var lblDate = new Label {
                Text = "Preferred Date *",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(20, y),
                AutoSize = true
            };
            pnlFormCard.Controls.Add(lblDate);

            var lblTime = new Label {
                Text = "Preferred Start Time *",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(390, y),
                AutoSize = true
            };
            pnlFormCard.Controls.Add(lblTime);
            y += 22;

            _dtpDate.Location = new Point(20, y);
            _dtpDate.Size = new Size(350, 26);
            _dtpDate.MinDate = DateTime.Today;
            _dtpDate.Value = DateTime.Today.AddDays(1);
            pnlFormCard.Controls.Add(_dtpDate);

            _cbTime.Location = new Point(390, y);
            _cbTime.Size = new Size(350, 28);
            _cbTime.Items.AddRange(new object[] {
                "08:00 AM", "08:30 AM", "09:00 AM", "09:30 AM",
                "10:00 AM", "10:30 AM", "11:00 AM", "11:30 AM",
                "01:00 PM", "01:30 PM", "02:00 PM", "02:30 PM",
                "03:00 PM", "03:30 PM", "04:00 PM", "04:30 PM"
            });
            _cbTime.SelectedIndex = 4; // 10:00 AM
            UIHelper.StyleComboBox(_cbTime);
            pnlFormCard.Controls.Add(_cbTime);
            y += 38;

            // 5. Meeting Type and Location Details
            var lblType = new Label {
                Text = "Meeting Type *",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(20, y),
                AutoSize = true
            };
            pnlFormCard.Controls.Add(lblType);

            var lblLocation = new Label {
                Text = "Location or Meeting Details *",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(260, y),
                AutoSize = true
            };
            pnlFormCard.Controls.Add(lblLocation);
            y += 22;

            _cbMeetingType.Location = new Point(20, y);
            _cbMeetingType.Size = new Size(220, 28);
            _cbMeetingType.Items.AddRange(new object[] { "Face-to-face", "Online" });
            _cbMeetingType.SelectedIndex = 0;
            UIHelper.StyleComboBox(_cbMeetingType);
            _cbMeetingType.SelectedIndexChanged += (s, e) => {
                if (_cbMeetingType.SelectedIndex == 0) {
                    _txtLocationOrDetails.Text = "DCSS Faculty Consultation Room (TYK Bldg 4th Flr)";
                } else {
                    _txtLocationOrDetails.Text = "Google Meet (UE GSuite link will be provided)";
                }
            };
            pnlFormCard.Controls.Add(_cbMeetingType);

            _txtLocationOrDetails.Location = new Point(260, y);
            _txtLocationOrDetails.Size = new Size(480, 26);
            _txtLocationOrDetails.Text = "DCSS Faculty Consultation Room (TYK Bldg 4th Flr)";
            UIHelper.StyleTextBox(_txtLocationOrDetails);
            pnlFormCard.Controls.Add(_txtLocationOrDetails);
            y += 48;

            // Action Buttons
            var btnClear = new Button {
                Text = "Clear Form",
                Location = new Point(480, y),
                Size = new Size(110, 38)
            };
            UIHelper.StyleSecondaryButton(btnClear);
            btnClear.Click += OnClearClick;
            pnlFormCard.Controls.Add(btnClear);

            var btnSubmit = new Button {
                Text = "Submit Request",
                Location = new Point(600, y),
                Size = new Size(140, 38)
            };
            UIHelper.StylePrimaryButton(btnSubmit);
            btnSubmit.Click += OnSubmitClick;
            pnlFormCard.Controls.Add(btnSubmit);

            pnlBody.Controls.Add(pnlFormCard);
            Controls.Add(pnlBody);
            pnlBody.BringToFront();
        }

        private void LoadFacultyList() {
            var facultyList = _dataService.GetFacultyMembers();
            _cbFaculty.DataSource = null;
            _cbFaculty.DisplayMember = "DisplayInfo";
            _cbFaculty.ValueMember = "UserId";

            var items = facultyList.Select(f => new {
                f.UserId,
                DisplayInfo = $"{f.FullName} ({f.ProgramOrTitle})"
            }).ToList();

            _cbFaculty.DataSource = items;
            if (items.Any()) {
                _cbFaculty.SelectedIndex = 0;
                OnFacultyChanged(null, EventArgs.Empty);
            }
        }

        private void OnFacultyChanged(object? sender, EventArgs e) {
            if (_cbFaculty.SelectedValue is string facId) {
                var avail = _dataService.GetFacultyAvailability(facId);
                var days = string.Join(", ", avail.AvailableDays);
                _lblFacultyConsultationInfo.Text = $"ℹ Faculty Consultation Hours: {days} ({avail.StartTime} - {avail.EndTime}) • Preferred Mode: {avail.PreferredMode}";
                _lblFacultyConsultationInfo.Visible = true;
            }
        }

        private void OnClearClick(object? sender, EventArgs e) {
            _txtSubject.Clear();
            _txtPurpose.Clear();
            _dtpDate.Value = DateTime.Today.AddDays(1);
            _cbTime.SelectedIndex = 4;
            _cbMeetingType.SelectedIndex = 0;
            _txtLocationOrDetails.Text = "DCSS Faculty Consultation Room (TYK Bldg 4th Flr)";
        }

        private void OnSubmitClick(object? sender, EventArgs e) {
            var currentUser = SessionManager.CurrentUser;
            if (currentUser == null) return;

            if (_cbFaculty.SelectedValue is not string facId) {
                MessageBox.Show("Please select a faculty member.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(_txtSubject.Text)) {
                MessageBox.Show("Please enter a meeting subject.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _txtSubject.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(_txtPurpose.Text)) {
                MessageBox.Show("Please enter the meeting purpose / description.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _txtPurpose.Focus();
                return;
            }

            var faculty = _dataService.GetUserById(facId);
            if (faculty == null) return;

            var meeting = new MeetingRequest {
                StudentId = currentUser.UserId,
                StudentName = currentUser.FullName,
                StudentEmail = currentUser.Email,
                StudentProgram = currentUser.ProgramOrTitle,
                FacultyId = faculty.UserId,
                FacultyName = faculty.FullName,
                FacultyEmail = faculty.Email,
                Subject = _txtSubject.Text.Trim(),
                Purpose = _txtPurpose.Text.Trim(),
                PreferredDate = _dtpDate.Value.Date,
                PreferredTime = _cbTime.SelectedItem?.ToString() ?? "10:00 AM",
                MeetingType = _cbMeetingType.SelectedIndex == 0 ? MeetingType.FaceToFace : MeetingType.Online,
                LocationOrLink = _txtLocationOrDetails.Text.Trim(),
                Status = MeetingStatus.Pending
            };

            bool success = _dataService.CreateMeetingRequest(meeting);
            if (success) {
                MessageBox.Show(
                    $"Meeting request {meeting.RequestId} successfully submitted to {faculty.FullName}!\n\nYou can track the status in 'My Meeting Requests'.",
                    "Request Submitted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                OnClearClick(null, EventArgs.Empty);
                RequestSubmitted?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
