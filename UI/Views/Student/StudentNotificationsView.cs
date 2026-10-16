using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DCSSMeetingScheduler.Models;
using DCSSMeetingScheduler.Services;
using DCSSMeetingScheduler.UI.Common;

namespace DCSSMeetingScheduler.UI.Views.Student {
    public class StudentNotificationsView : UserControl {
        private readonly IDataService _dataService = MockDataStore.Instance;
        private readonly FlowLayoutPanel _flpNotifications = new();
        private readonly Button _btnMarkAllRead = new();
        private readonly ComboBox _cbFilter = new();
        private readonly Label _lblUnreadBadge = new();

        public StudentNotificationsView() {
            DoubleBuffered = true;
            Dock = DockStyle.Fill;
            BackColor = ThemeColors.CanvasBackground;

            InitializeLayout();
            LoadNotifications();

            _dataService.DataChanged += (s, e) => {
                if (!IsDisposed && IsHandleCreated) {
                    BeginInvoke(new Action(LoadNotifications));
                }
            };
        }

        private void InitializeLayout() {
            // Header
            var pnlHeader = UIHelper.CreatePageHeader(
                "NOTIFICATIONS & ALERTS",
                "Stay updated on consultation approvals, schedule adjustments, and messages from faculty"
            );
            Controls.Add(pnlHeader);

            // Body Panel
            var pnlBody = new Panel {
                Dock = DockStyle.Fill,
                Padding = new Padding(24, 16, 24, 24)
            };

            // Main Card
            var pnlCard = UIHelper.CreateCard(16);
            pnlCard.Dock = DockStyle.Fill;

            // Toolbar inside card
            var pnlToolbar = new Panel {
                Dock = DockStyle.Top,
                Height = 44,
                BackColor = Color.Transparent
            };

            _lblUnreadBadge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            _lblUnreadBadge.ForeColor = ThemeColors.PrimaryRedDark;
            _lblUnreadBadge.Location = new Point(4, 12);
            _lblUnreadBadge.AutoSize = true;
            pnlToolbar.Controls.Add(_lblUnreadBadge);

            var lblFilter = new Label {
                Text = "Filter:",
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(220, 12),
                AutoSize = true
            };
            pnlToolbar.Controls.Add(lblFilter);

            _cbFilter.Location = new Point(265, 8);
            _cbFilter.Size = new Size(140, 26);
            _cbFilter.Items.AddRange(new object[] { "All Messages", "Unread Only" });
            _cbFilter.SelectedIndex = 0;
            UIHelper.StyleComboBox(_cbFilter);
            _cbFilter.SelectedIndexChanged += (s, e) => LoadNotifications();
            pnlToolbar.Controls.Add(_cbFilter);

            UIHelper.StyleSecondaryButton(_btnMarkAllRead, "Mark All as Read");
            _btnMarkAllRead.Size = new Size(140, 32);
            _btnMarkAllRead.Location = new Point(pnlToolbar.Width - 150, 6);
            _btnMarkAllRead.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnMarkAllRead.Click += (s, e) => {
                var user = SessionManager.CurrentUser;
                if (user != null) {
                    _dataService.MarkAllNotificationsAsRead(user.UserId);
                    LoadNotifications();
                }
            };
            pnlToolbar.Controls.Add(_btnMarkAllRead);

            pnlCard.Controls.Add(pnlToolbar);

            // Notifications Flow Panel
            _flpNotifications.Dock = DockStyle.Fill;
            _flpNotifications.AutoScroll = true;
            _flpNotifications.FlowDirection = FlowDirection.TopDown;
            _flpNotifications.WrapContents = false;
            _flpNotifications.Padding = new Padding(0, 10, 0, 10);
            _flpNotifications.BackColor = ThemeColors.White;

            pnlCard.Controls.Add(_flpNotifications);
            _flpNotifications.BringToFront();

            pnlBody.Controls.Add(pnlCard);
            Controls.Add(pnlBody);
            pnlBody.BringToFront();
        }

        public void LoadNotifications() {
            var currentUser = SessionManager.CurrentUser;
            if (currentUser == null) return;

            var notifs = _dataService.GetNotificationsForUser(currentUser.UserId);
            int unread = notifs.Count(n => !n.IsRead);
            _lblUnreadBadge.Text = unread > 0 ? $"📬 {unread} Unread Notifications" : "📬 All notifications read";

            if (_cbFilter.SelectedIndex == 1) {
                notifs = notifs.Where(n => !n.IsRead).ToList();
            }

            _flpNotifications.SuspendLayout();
            _flpNotifications.Controls.Clear();

            if (!notifs.Any()) {
                var lblEmpty = new Label {
                    Text = "No notifications found.",
                    Font = new Font("Segoe UI", 10F, FontStyle.Italic),
                    ForeColor = ThemeColors.TextMuted,
                    Padding = new Padding(12),
                    AutoSize = true
                };
                _flpNotifications.Controls.Add(lblEmpty);
            } else {
                foreach (var item in notifs) {
                    var itemPanel = CreateNotificationItemPanel(item);
                    _flpNotifications.Controls.Add(itemPanel);
                }
            }

            _flpNotifications.ResumeLayout(true);
        }

        private Panel CreateNotificationItemPanel(NotificationItem item) {
            var pnl = new Panel {
                Size = new Size(_flpNotifications.ClientSize.Width - 25, 76),
                Margin = new Padding(0, 0, 0, 10),
                BackColor = item.IsRead ? ThemeColors.White : ThemeColors.LightRed,
                Cursor = Cursors.Hand
            };

            pnl.Paint += (s, e) => {
                var g = e.Graphics;
                using var pen = new Pen(item.IsRead ? ThemeColors.BorderGray : ThemeColors.LightRedBorder, 1);
                g.DrawRectangle(pen, 0, 0, pnl.Width - 1, pnl.Height - 1);

                // Left unread accent bar
                if (!item.IsRead) {
                    using var redBrush = new SolidBrush(ThemeColors.PrimaryRed);
                    g.FillRectangle(redBrush, 0, 0, 4, pnl.Height);
                }
            };

            // Icon glyph based on status or type
            string glyph = item.RelatedStatus switch {
                MeetingStatus.Approved => "✔",
                MeetingStatus.Rescheduled => "📅",
                MeetingStatus.Declined => "✕",
                MeetingStatus.Cancelled => "🚫",
                MeetingStatus.Completed => "🎓",
                _ => "🔔"
            };

            var lblIcon = new Label {
                Text = glyph,
                Font = new Font("Segoe UI Emoji", 14F),
                ForeColor = !item.IsRead ? ThemeColors.PrimaryRed : ThemeColors.TextMuted,
                Location = new Point(14, 16),
                Size = new Size(32, 32),
                TextAlign = ContentAlignment.MiddleCenter
            };
            pnl.Controls.Add(lblIcon);

            var lblTitle = new Label {
                Text = item.Title,
                Font = new Font("Segoe UI", 9.5F, item.IsRead ? FontStyle.Bold : FontStyle.Bold),
                ForeColor = item.IsRead ? ThemeColors.TextDark : ThemeColors.PrimaryRedDark,
                Location = new Point(54, 12),
                AutoSize = true
            };
            pnl.Controls.Add(lblTitle);

            var lblTime = new Label {
                Text = item.DisplayTime,
                Font = new Font("Segoe UI", 8F),
                ForeColor = ThemeColors.TextMuted,
                Location = new Point(pnl.Width - 120, 12),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                AutoSize = true
            };
            pnl.Controls.Add(lblTime);

            var lblMsg = new Label {
                Text = item.Message,
                Font = new Font("Segoe UI", 9F),
                ForeColor = ThemeColors.TextRegular,
                Location = new Point(54, 34),
                Size = new Size(pnl.Width - 70, 36),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            pnl.Controls.Add(lblMsg);

            EventHandler onClick = (s, e) => {
                if (!item.IsRead) {
                    _dataService.MarkNotificationAsRead(item.NotificationId);
                    LoadNotifications();
                }
            };

            pnl.Click += onClick;
            lblTitle.Click += onClick;
            lblMsg.Click += onClick;

            return pnl;
        }
    }
}
