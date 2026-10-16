using System;
using System.Drawing;
using System.Windows.Forms;
using DCSSMeetingScheduler.Models;
using DCSSMeetingScheduler.UI.Common;

namespace DCSSMeetingScheduler.UI.Dialogs {
    public class RescheduleMeetingDialog : Form {
        public DateTime NewDate { get; private set; }
        public string NewTime { get; private set; } = string.Empty;
        public string Reason { get; private set; } = string.Empty;

        private readonly DateTimePicker _dtpDate = new();
        private readonly ComboBox _cbTime = new();
        private readonly TextBox _txtReason = new();

        public RescheduleMeetingDialog(MeetingRequest req) {
            InitializeComponent(req);
        }

        private void InitializeComponent(MeetingRequest req) {
            Text = $"Reschedule Meeting - {req.RequestId}";
            Size = new Size(500, 480);
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = ThemeColors.CanvasBackground;

            // Header Banner
            var pnlHeader = new Panel {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = ThemeColors.PrimaryRedDark,
                Padding = new Padding(20, 10, 20, 10)
            };

            var lblHeader = new Label {
                Text = "RESCHEDULE MEETING",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = ThemeColors.White,
                Location = new Point(20, 10),
                AutoSize = true
            };
            var lblSub = new Label {
                Text = $"Propose new consultation time for {req.StudentName}",
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = ThemeColors.SidebarTextMuted,
                Location = new Point(20, 32),
                AutoSize = true
            };
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Controls.Add(lblSub);
            Controls.Add(pnlHeader);

            // Card Panel
            var pnlCard = new Panel {
                Location = new Point(20, 75),
                Size = new Size(444, 320),
                BackColor = ThemeColors.White,
                Padding = new Padding(20)
            };
            pnlCard.Paint += (s, e) => {
                using var pen = new Pen(ThemeColors.BorderGray, 1);
                e.Graphics.DrawRectangle(pen, 0, 0, pnlCard.Width - 1, pnlCard.Height - 1);
            };

            int y = 15;

            // Current info
            var lblCurrentInfo = new Label {
                Text = $"Current: {req.PreferredDate:MMM dd, yyyy} at {req.PreferredTime} • {req.Subject}",
                Font = new Font("Segoe UI", 8.5F, FontStyle.Italic),
                ForeColor = ThemeColors.TextMuted,
                Location = new Point(15, y),
                AutoSize = true,
                MaximumSize = new Size(410, 0)
            };
            pnlCard.Controls.Add(lblCurrentInfo);
            y += lblCurrentInfo.PreferredHeight + 15;

            // New Date
            var lblDate = new Label {
                Text = "New Proposed Date *",
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(15, y),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblDate);
            y += 20;

            _dtpDate.Location = new Point(15, y);
            _dtpDate.Size = new Size(410, 26);
            _dtpDate.Format = DateTimePickerFormat.Long;
            _dtpDate.MinDate = DateTime.Today;
            _dtpDate.Value = req.PreferredDate < DateTime.Today ? DateTime.Today.AddDays(1) : req.PreferredDate.AddDays(1);
            pnlCard.Controls.Add(_dtpDate);
            y += 35;

            // New Time
            var lblTime = new Label {
                Text = "New Proposed Time Slot *",
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(15, y),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblTime);
            y += 20;

            _cbTime.Location = new Point(15, y);
            _cbTime.Size = new Size(410, 26);
            _cbTime.Items.AddRange(new object[] {
                "08:00 AM - 08:30 AM", "08:30 AM - 09:00 AM",
                "09:00 AM - 09:30 AM", "09:30 AM - 10:00 AM",
                "10:00 AM - 10:30 AM", "10:30 AM - 11:00 AM",
                "11:00 AM - 11:30 AM", "11:30 AM - 12:00 PM",
                "01:00 PM - 01:30 PM", "01:30 PM - 02:00 PM",
                "02:00 PM - 02:30 PM", "02:30 PM - 03:00 PM",
                "03:00 PM - 03:30 PM", "03:30 PM - 04:00 PM",
                "04:00 PM - 04:30 PM", "04:30 PM - 05:00 PM"
            });
            _cbTime.SelectedIndex = 4;
            UIHelper.StyleComboBox(_cbTime);
            pnlCard.Controls.Add(_cbTime);
            y += 35;

            // Reason
            var lblReason = new Label {
                Text = "Reason for Rescheduling *",
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(15, y),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblReason);
            y += 20;

            _txtReason.Location = new Point(15, y);
            _txtReason.Size = new Size(410, 60);
            _txtReason.Multiline = true;
            _txtReason.ScrollBars = ScrollBars.Vertical;
            _txtReason.Text = "Conflict with university department meeting.";
            UIHelper.StyleTextBox(_txtReason);
            pnlCard.Controls.Add(_txtReason);

            Controls.Add(pnlCard);

            // Bottom action buttons
            var btnCancel = new Button {
                Text = "Cancel",
                Location = new Point(220, 405),
                Size = new Size(110, 36)
            };
            UIHelper.StyleSecondaryButton(btnCancel);
            btnCancel.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
            Controls.Add(btnCancel);

            var btnSubmit = new Button {
                Text = "Confirm Reschedule",
                Location = new Point(340, 405),
                Size = new Size(140, 36)
            };
            UIHelper.StylePrimaryButton(btnSubmit);
            btnSubmit.Click += (s, e) => {
                if (string.IsNullOrWhiteSpace(_txtReason.Text)) {
                    MessageBox.Show("Please enter a reason for rescheduling.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                NewDate = _dtpDate.Value.Date;
                NewTime = _cbTime.SelectedItem?.ToString() ?? "10:00 AM";
                Reason = _txtReason.Text.Trim();
                DialogResult = DialogResult.OK;
                Close();
            };
            Controls.Add(btnSubmit);
        }
    }
}
