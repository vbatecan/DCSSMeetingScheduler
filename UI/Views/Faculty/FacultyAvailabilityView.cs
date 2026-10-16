using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DCSSMeetingScheduler.Models;
using DCSSMeetingScheduler.Services;
using DCSSMeetingScheduler.UI.Common;

namespace DCSSMeetingScheduler.UI.Views.Faculty {
    public class FacultyAvailabilityView : UserControl {
        private readonly IDataService _dataService = MockDataStore.Instance;

        private readonly CheckBox _chkMon = new() { Text = "Monday", AutoSize = true, Font = new Font("Segoe UI", 9F) };
        private readonly CheckBox _chkTue = new() { Text = "Tuesday", AutoSize = true, Font = new Font("Segoe UI", 9F) };
        private readonly CheckBox _chkWed = new() { Text = "Wednesday", AutoSize = true, Font = new Font("Segoe UI", 9F) };
        private readonly CheckBox _chkThu = new() { Text = "Thursday", AutoSize = true, Font = new Font("Segoe UI", 9F) };
        private readonly CheckBox _chkFri = new() { Text = "Friday", AutoSize = true, Font = new Font("Segoe UI", 9F) };
        private readonly CheckBox _chkSat = new() { Text = "Saturday", AutoSize = true, Font = new Font("Segoe UI", 9F) };

        private readonly ComboBox _cbStartTime = new();
        private readonly ComboBox _cbEndTime = new();
        private readonly NumericUpDown _nudMaxMeetings = new();
        private readonly ComboBox _cbPreferredMode = new();
        private readonly TextBox _txtDefaultLocation = new();
        private readonly TextBox _txtOnlinePlatform = new();
        private readonly TextBox _txtNotes = new();

        public FacultyAvailabilityView() {
            DoubleBuffered = true;
            Dock = DockStyle.Fill;
            BackColor = ThemeColors.CanvasBackground;
            AutoScroll = true;

            InitializeLayout();
            LoadAvailability();
        }

        private void InitializeLayout() {
            var pnlHeader = UIHelper.CreatePageHeader(
                "FACULTY AVAILABILITY CONFIGURATION",
                "Configure your weekly consultation schedule, available timeslots, and meeting parameters"
            );
            Controls.Add(pnlHeader);

            var pnlBody = new Panel {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(24, 16, 24, 30)
            };

            var pnlCard = UIHelper.CreateCard(24);
            pnlCard.Dock = DockStyle.Top;
            pnlCard.Height = 630;
            pnlCard.MaximumSize = new Size(820, 0);

            var lblTitle = new Label {
                Text = "Consultation Timetable & Capacity Settings",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(20, 16),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblTitle);

            var lblSubtitle = new Label {
                Text = "These settings govern what days and times students can request consultations with you.",
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = ThemeColors.TextMuted,
                Location = new Point(20, 42),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblSubtitle);

            int y = 75;

            // 1. Available Days
            var lblDays = new Label {
                Text = "Weekly Consultation Days *",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(20, y),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblDays);
            y += 24;

            var pnlDays = new FlowLayoutPanel {
                Location = new Point(20, y),
                Size = new Size(740, 32),
                WrapContents = false,
                BackColor = Color.Transparent
            };
            pnlDays.Controls.AddRange(new Control[] { _chkMon, _chkTue, _chkWed, _chkThu, _chkFri, _chkSat });
            pnlCard.Controls.Add(pnlDays);
            y += 40;

            // 2. Start Time and End Time
            var lblStartTime = new Label {
                Text = "Consultation Start Time *",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(20, y),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblStartTime);

            var lblEndTime = new Label {
                Text = "Consultation End Time *",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(390, y),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblEndTime);
            y += 22;

            string[] times = {
                "07:30 AM", "08:00 AM", "08:30 AM", "09:00 AM", "09:30 AM",
                "10:00 AM", "10:30 AM", "11:00 AM", "11:30 AM", "12:00 PM",
                "01:00 PM", "01:30 PM", "02:00 PM", "02:30 PM", "03:00 PM",
                "03:30 PM", "04:00 PM", "04:30 PM", "05:00 PM", "05:30 PM"
            };

            _cbStartTime.Location = new Point(20, y);
            _cbStartTime.Size = new Size(350, 28);
            _cbStartTime.Items.AddRange(times);
            _cbStartTime.SelectedIndex = 3; // 09:00 AM
            UIHelper.StyleComboBox(_cbStartTime);
            pnlCard.Controls.Add(_cbStartTime);

            _cbEndTime.Location = new Point(390, y);
            _cbEndTime.Size = new Size(350, 28);
            _cbEndTime.Items.AddRange(times);
            _cbEndTime.SelectedIndex = 16; // 04:00 PM
            UIHelper.StyleComboBox(_cbEndTime);
            pnlCard.Controls.Add(_cbEndTime);
            y += 40;

            // 3. Max Meetings Per Day and Preferred Mode
            var lblMax = new Label {
                Text = "Max Consultation Limit / Day *",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(20, y),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblMax);

            var lblMode = new Label {
                Text = "Preferred Meeting Mode *",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(390, y),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblMode);
            y += 22;

            _nudMaxMeetings.Location = new Point(20, y);
            _nudMaxMeetings.Size = new Size(350, 26);
            _nudMaxMeetings.Minimum = 1;
            _nudMaxMeetings.Maximum = 15;
            _nudMaxMeetings.Value = 4;
            _nudMaxMeetings.Font = new Font("Segoe UI", 9.5F);
            pnlCard.Controls.Add(_nudMaxMeetings);

            _cbPreferredMode.Location = new Point(390, y);
            _cbPreferredMode.Size = new Size(350, 28);
            _cbPreferredMode.Items.AddRange(new object[] { "Face-to-face", "Online" });
            _cbPreferredMode.SelectedIndex = 0;
            UIHelper.StyleComboBox(_cbPreferredMode);
            pnlCard.Controls.Add(_cbPreferredMode);
            y += 40;

            // 4. Default Office / Consultation Room
            var lblLoc = new Label {
                Text = "Default Office / Consultation Room *",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(20, y),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblLoc);
            y += 22;

            _txtDefaultLocation.Location = new Point(20, y);
            _txtDefaultLocation.Size = new Size(720, 26);
            UIHelper.StyleTextBox(_txtDefaultLocation);
            pnlCard.Controls.Add(_txtDefaultLocation);
            y += 38;

            // 5. Consultation Notes / Guidelines
            var lblNotes = new Label {
                Text = "Consultation Guidelines & Instructions for Students",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(20, y),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblNotes);
            y += 22;

            _txtNotes.Location = new Point(20, y);
            _txtNotes.Size = new Size(720, 75);
            _txtNotes.Multiline = true;
            _txtNotes.ScrollBars = ScrollBars.Vertical;
            UIHelper.StyleTextBox(_txtNotes);
            pnlCard.Controls.Add(_txtNotes);
            y += 90;

            // Save Button
            var btnSave = new Button {
                Text = "Save Availability Settings",
                Location = new Point(540, y),
                Size = new Size(200, 38)
            };
            UIHelper.StylePrimaryButton(btnSave);
            btnSave.Click += OnSaveAvailability;
            pnlCard.Controls.Add(btnSave);

            pnlBody.Controls.Add(pnlCard);
            Controls.Add(pnlBody);
            pnlBody.BringToFront();
        }

        private void LoadAvailability() {
            var currentUser = SessionManager.CurrentUser;
            if (currentUser == null) return;

            var avail = _dataService.GetFacultyAvailability(currentUser.UserId);

            _chkMon.Checked = avail.AvailableDays.Contains(DayOfWeek.Monday);
            _chkTue.Checked = avail.AvailableDays.Contains(DayOfWeek.Tuesday);
            _chkWed.Checked = avail.AvailableDays.Contains(DayOfWeek.Wednesday);
            _chkThu.Checked = avail.AvailableDays.Contains(DayOfWeek.Thursday);
            _chkFri.Checked = avail.AvailableDays.Contains(DayOfWeek.Friday);
            _chkSat.Checked = avail.AvailableDays.Contains(DayOfWeek.Saturday);

            if (_cbStartTime.Items.Contains(avail.StartTime)) _cbStartTime.SelectedItem = avail.StartTime;
            if (_cbEndTime.Items.Contains(avail.EndTime)) _cbEndTime.SelectedItem = avail.EndTime;

            _nudMaxMeetings.Value = Math.Max(1, Math.Min(15, avail.MaxMeetingsPerDay));
            _cbPreferredMode.SelectedIndex = avail.PreferredMode == MeetingType.FaceToFace ? 0 : 1;
            _txtDefaultLocation.Text = avail.DefaultLocation;
            _txtNotes.Text = avail.ConsultationNotes;
        }

        private void OnSaveAvailability(object? sender, EventArgs e) {
            var currentUser = SessionManager.CurrentUser;
            if (currentUser == null) return;

            var days = new List<DayOfWeek>();
            if (_chkMon.Checked) days.Add(DayOfWeek.Monday);
            if (_chkTue.Checked) days.Add(DayOfWeek.Tuesday);
            if (_chkWed.Checked) days.Add(DayOfWeek.Wednesday);
            if (_chkThu.Checked) days.Add(DayOfWeek.Thursday);
            if (_chkFri.Checked) days.Add(DayOfWeek.Friday);
            if (_chkSat.Checked) days.Add(DayOfWeek.Saturday);

            if (!days.Any()) {
                MessageBox.Show("Please select at least one consultation day.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var avail = new FacultyAvailability {
                FacultyId = currentUser.UserId,
                AvailableDays = days,
                StartTime = _cbStartTime.SelectedItem?.ToString() ?? "09:00 AM",
                EndTime = _cbEndTime.SelectedItem?.ToString() ?? "04:00 PM",
                MaxMeetingsPerDay = (int)_nudMaxMeetings.Value,
                PreferredMode = _cbPreferredMode.SelectedIndex == 0 ? MeetingType.FaceToFace : MeetingType.Online,
                DefaultLocation = _txtDefaultLocation.Text.Trim(),
                ConsultationNotes = _txtNotes.Text.Trim()
            };

            _dataService.SaveFacultyAvailability(avail);
            MessageBox.Show("Your consultation availability settings have been updated successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
