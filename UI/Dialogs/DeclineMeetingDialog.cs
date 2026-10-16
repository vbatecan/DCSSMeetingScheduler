using System;
using System.Drawing;
using System.Windows.Forms;
using DCSSMeetingScheduler.Models;
using DCSSMeetingScheduler.UI.Common;

namespace DCSSMeetingScheduler.UI.Dialogs {
    public class DeclineMeetingDialog : Form {
        public string DeclineReason { get; private set; } = string.Empty;

        private readonly ComboBox _cbPresetReason = new();
        private readonly TextBox _txtDetailedReason = new();

        public DeclineMeetingDialog(MeetingRequest req) {
            InitializeComponent(req);
        }

        private void InitializeComponent(MeetingRequest req) {
            Text = $"Decline Meeting - {req.RequestId}";
            Size = new Size(500, 440);
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
                Text = "DECLINE MEETING REQUEST",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = ThemeColors.White,
                Location = new Point(20, 10),
                AutoSize = true
            };
            var lblSub = new Label {
                Text = $"Decline consultation request for {req.StudentName}",
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
                Size = new Size(444, 280),
                BackColor = ThemeColors.White,
                Padding = new Padding(20)
            };
            pnlCard.Paint += (s, e) => {
                using var pen = new Pen(ThemeColors.BorderGray, 1);
                e.Graphics.DrawRectangle(pen, 0, 0, pnlCard.Width - 1, pnlCard.Height - 1);
            };

            int y = 15;

            var lblSubject = new Label {
                Text = $"Subject: {req.Subject}",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(15, y),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblSubject);
            y += 25;

            // Preset reasons dropdown
            var lblPreset = new Label {
                Text = "Select Primary Reason *",
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(15, y),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblPreset);
            y += 20;

            _cbPresetReason.Location = new Point(15, y);
            _cbPresetReason.Size = new Size(410, 26);
            _cbPresetReason.Items.AddRange(new object[] {
                "Schedule conflict with university classes / academic activities",
                "Consultation quota for the day is already full",
                "Consultation topic is outside faculty advisory domain",
                "Incomplete prerequisite manuscripts or requirements",
                "Outside official faculty consultation hours",
                "Other custom reason"
            });
            _cbPresetReason.SelectedIndex = 0;
            UIHelper.StyleComboBox(_cbPresetReason);
            _cbPresetReason.SelectedIndexChanged += (s, e) => {
                if (_cbPresetReason.SelectedIndex < 5) {
                    _txtDetailedReason.Text = _cbPresetReason.SelectedItem?.ToString();
                } else {
                    _txtDetailedReason.Text = "";
                    _txtDetailedReason.Focus();
                }
            };
            pnlCard.Controls.Add(_cbPresetReason);
            y += 35;

            // Detailed note
            var lblNote = new Label {
                Text = "Additional Notes / Message to Student",
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(15, y),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblNote);
            y += 20;

            _txtDetailedReason.Location = new Point(15, y);
            _txtDetailedReason.Size = new Size(410, 80);
            _txtDetailedReason.Multiline = true;
            _txtDetailedReason.ScrollBars = ScrollBars.Vertical;
            _txtDetailedReason.Text = _cbPresetReason.SelectedItem?.ToString() ?? "";
            UIHelper.StyleTextBox(_txtDetailedReason);
            pnlCard.Controls.Add(_txtDetailedReason);

            Controls.Add(pnlCard);

            // Bottom Buttons
            var btnCancel = new Button {
                Text = "Cancel",
                Location = new Point(230, 365),
                Size = new Size(100, 36)
            };
            UIHelper.StyleSecondaryButton(btnCancel);
            btnCancel.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
            Controls.Add(btnCancel);

            var btnDecline = new Button {
                Text = "Decline Request",
                Location = new Point(340, 365),
                Size = new Size(130, 36)
            };
            UIHelper.StylePrimaryButton(btnDecline);
            btnDecline.BackColor = Color.FromArgb(185, 28, 28);
            btnDecline.Click += (s, e) => {
                if (string.IsNullOrWhiteSpace(_txtDetailedReason.Text)) {
                    MessageBox.Show("Please enter or select a reason for declining.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DeclineReason = _txtDetailedReason.Text.Trim();
                DialogResult = DialogResult.OK;
                Close();
            };
            Controls.Add(btnDecline);
        }
    }
}
