using System;
using System.Drawing;
using System.Windows.Forms;
using DCSSMeetingScheduler.Models;
using DCSSMeetingScheduler.UI.Common;

namespace DCSSMeetingScheduler.UI.Dialogs {
    public class MeetingDetailsDialog : Form {
        public MeetingDetailsDialog(MeetingRequest req) {
            InitializeComponent(req);
        }

        private void InitializeComponent(MeetingRequest req) {
            Text = $"Meeting Details - {req.RequestId}";
            Size = new Size(580, 640);
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = ThemeColors.CanvasBackground;

            // Top Header Banner
            var pnlHeader = new Panel {
                Dock = DockStyle.Top,
                Height = 65,
                BackColor = ThemeColors.PrimaryRedDark,
                Padding = new Padding(20, 12, 20, 12)
            };

            var lblHeaderTitle = new Label {
                Text = "MEETING DETAILS",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = ThemeColors.White,
                AutoSize = true,
                Location = new Point(20, 12)
            };

            var lblRequestId = new Label {
                Text = $"Request Reference: {req.RequestId}",
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = ThemeColors.SidebarTextMuted,
                AutoSize = true,
                Location = new Point(20, 36)
            };

            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Controls.Add(lblRequestId);
            Controls.Add(pnlHeader);

            // Scrollable Content Card
            var pnlContent = new Panel {
                Location = new Point(20, 80),
                Size = new Size(524, 470),
                BackColor = ThemeColors.White,
                AutoScroll = true,
                Padding = new Padding(20)
            };
            pnlContent.Paint += (s, e) => {
                using var pen = new Pen(ThemeColors.BorderGray, 1);
                e.Graphics.DrawRectangle(pen, 0, 0, pnlContent.Width - 1, pnlContent.Height - 1);
            };

            int y = 15;

            void AddRow(string label, string value, bool isHighlight = false) {
                var lblField = new Label {
                    Text = label.ToUpperInvariant(),
                    Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                    ForeColor = ThemeColors.TextMuted,
                    Location = new Point(15, y),
                    AutoSize = true
                };
                pnlContent.Controls.Add(lblField);

                var lblVal = new Label {
                    Text = string.IsNullOrWhiteSpace(value) ? "—" : value,
                    Font = new Font("Segoe UI", 9.5F, isHighlight ? FontStyle.Bold : FontStyle.Regular),
                    ForeColor = isHighlight ? ThemeColors.PrimaryRedDark : ThemeColors.TextDark,
                    Location = new Point(15, y + 17),
                    AutoSize = true,
                    MaximumSize = new Size(470, 0)
                };
                pnlContent.Controls.Add(lblVal);
                y += lblVal.PreferredHeight + 25;
            }

            // Status Row
            var lblStatusLabel = new Label {
                Text = "STATUS",
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                ForeColor = ThemeColors.TextMuted,
                Location = new Point(15, y),
                AutoSize = true
            };
            pnlContent.Controls.Add(lblStatusLabel);

            var pnlBadgeContainer = new Panel {
                Location = new Point(15, y + 18),
                Size = new Size(130, 26),
                BackColor = Color.Transparent
            };
            pnlBadgeContainer.Paint += (s, e) => {
                var (bg, fg) = req.Status switch {
                    MeetingStatus.Approved => (ThemeColors.StatusApprovedBg, ThemeColors.StatusApprovedText),
                    MeetingStatus.Pending => (ThemeColors.StatusPendingBg, ThemeColors.StatusPendingText),
                    MeetingStatus.Rescheduled => (ThemeColors.StatusRescheduledBg, ThemeColors.StatusRescheduledText),
                    MeetingStatus.Declined => (ThemeColors.StatusDeclinedBg, ThemeColors.StatusDeclinedText),
                    MeetingStatus.Cancelled => (ThemeColors.StatusCancelledBg, ThemeColors.StatusCancelledText),
                    MeetingStatus.Completed => (ThemeColors.StatusCompletedBg, ThemeColors.StatusCompletedText),
                    _ => (ThemeColors.LightGray, ThemeColors.TextRegular)
                };
                UIHelper.DrawBadge(e.Graphics, new Rectangle(0, 0, pnlBadgeContainer.Width, pnlBadgeContainer.Height), req.Status.ToString(), bg, fg);
            };
            pnlContent.Controls.Add(pnlBadgeContainer);
            y += 50;

            AddRow("Subject", req.Subject, isHighlight: true);
            AddRow("Student", $"{req.StudentName} ({req.StudentProgram}) • {req.StudentEmail}");
            AddRow("Faculty Member", $"{req.FacultyName} • {req.FacultyEmail}");
            AddRow("Meeting Type", req.DisplayMeetingType);
            AddRow("Preferred Schedule", $"{req.PreferredDate:MMMM dd, yyyy (dddd)} at {req.PreferredTime}");

            if (req.ScheduledDate.HasValue) {
                AddRow("Confirmed / Rescheduled Schedule", $"{req.ScheduledDate.Value:MMMM dd, yyyy (dddd)} at {req.ScheduledTime}", isHighlight: true);
            }

            AddRow("Venue / Online Meeting Link", req.LocationOrLink);
            AddRow("Purpose & Description", req.Purpose);

            if (!string.IsNullOrEmpty(req.FacultyNotes)) {
                AddRow("Faculty Remarks & Instructions", req.FacultyNotes, isHighlight: true);
            }

            if (!string.IsNullOrEmpty(req.RescheduleReason)) {
                AddRow("Reschedule Reason", req.RescheduleReason, isHighlight: true);
            }

            if (!string.IsNullOrEmpty(req.DeclineReason)) {
                AddRow("Decline Reason", req.DeclineReason, isHighlight: true);
            }

            Controls.Add(pnlContent);

            // Bottom Buttons
            var btnClose = new Button {
                Text = "Close",
                Location = new Point(424, 560),
                Size = new Size(120, 36)
            };
            UIHelper.StyleSecondaryButton(btnClose);
            btnClose.Click += (s, e) => Close();
            Controls.Add(btnClose);
        }
    }
}
