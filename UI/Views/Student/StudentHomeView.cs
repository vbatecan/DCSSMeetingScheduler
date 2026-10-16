using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DCSSMeetingScheduler.Models;
using DCSSMeetingScheduler.Services;
using DCSSMeetingScheduler.UI.Common;
using DCSSMeetingScheduler.UI.Dialogs;

namespace DCSSMeetingScheduler.UI.Views.Student {
    public class StudentHomeView : UserControl {
        private readonly IDataService _dataService = MockDataStore.Instance;
        private readonly MetricCard _cardPending = new();
        private readonly MetricCard _cardApproved = new();
        private readonly MetricCard _cardRescheduled = new();
        private readonly MetricCard _cardDeclined = new();

        private readonly DataGridView _dgvUpcoming = new();
        private readonly Panel _pnlNotifications = new();

        public StudentHomeView() {
            DoubleBuffered = true;
            Dock = DockStyle.Fill;
            BackColor = ThemeColors.CanvasBackground;
            AutoScroll = true;

            InitializeLayout();
            LoadData();

            _dataService.DataChanged += (s, e) => {
                if (!IsDisposed && IsHandleCreated) {
                    BeginInvoke(new Action(LoadData));
                }
            };
        }

        private void InitializeLayout() {
            // Header
            var pnlHeader = UIHelper.CreatePageHeader(
                "STUDENT DASHBOARD OVERVIEW",
                "Welcome to the UE Caloocan DCSS Meeting Scheduler"
            );
            Controls.Add(pnlHeader);

            // Container Panel for scrollable cards and content
            var pnlBody = new Panel {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(24, 16, 24, 24)
            };

            // Summary Cards Panel
            var pnlCards = new FlowLayoutPanel {
                Dock = DockStyle.Top,
                Height = 118,
                WrapContents = false,
                AutoScroll = false,
                Padding = new Padding(0, 0, 0, 8),
                BackColor = Color.Transparent
            };

            _cardPending.Title = "Pending Meetings";
            _cardPending.Subtitle = "Awaiting faculty response";
            _cardPending.IconGlyph = "⏳";
            _cardPending.AccentColor = Color.FromArgb(217, 119, 6);
            _cardPending.Margin = new Padding(0, 0, 16, 0);

            _cardApproved.Title = "Approved Meetings";
            _cardApproved.Subtitle = "Confirmed consultations";
            _cardApproved.IconGlyph = "✔";
            _cardApproved.AccentColor = Color.FromArgb(16, 149, 93);
            _cardApproved.Margin = new Padding(0, 0, 16, 0);

            _cardRescheduled.Title = "Rescheduled";
            _cardRescheduled.Subtitle = "Faculty adjusted time";
            _cardRescheduled.IconGlyph = "📅";
            _cardRescheduled.AccentColor = Color.FromArgb(202, 138, 4);
            _cardRescheduled.Margin = new Padding(0, 0, 16, 0);

            _cardDeclined.Title = "Declined Requests";
            _cardDeclined.Subtitle = "Needs rebooking or review";
            _cardDeclined.IconGlyph = "✕";
            _cardDeclined.AccentColor = ThemeColors.PrimaryRed;
            _cardDeclined.Margin = new Padding(0);

            pnlCards.Controls.AddRange(new Control[] { _cardPending, _cardApproved, _cardRescheduled, _cardDeclined });
            pnlBody.Controls.Add(pnlCards);

            // Upcoming Meetings Card Table
            var pnlTableCard = UIHelper.CreateCard(16);
            pnlTableCard.Dock = DockStyle.Top;
            pnlTableCard.Height = 280;
            pnlTableCard.Margin = new Padding(0, 16, 0, 16);

            var lblTableTitle = new Label {
                Text = "Upcoming Consultations & Active Meetings",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(16, 14),
                AutoSize = true
            };
            pnlTableCard.Controls.Add(lblTableTitle);

            // Quick action buttons for selected row
            var btnViewDetails = new Button {
                Text = "View Details",
                Location = new Point(pnlTableCard.Width - 250, 10),
                Size = new Size(110, 32),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            UIHelper.StyleSecondaryButton(btnViewDetails);
            btnViewDetails.Click += OnViewDetailsClick;
            pnlTableCard.Controls.Add(btnViewDetails);

            var btnCancel = new Button {
                Text = "Cancel Request",
                Location = new Point(pnlTableCard.Width - 130, 10),
                Size = new Size(115, 32),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            UIHelper.StyleDangerButton(btnCancel);
            btnCancel.Click += OnCancelMeetingClick;
            pnlTableCard.Controls.Add(btnCancel);

            // DataGridView setup
            UIHelper.StyleDataGridView(_dgvUpcoming);
            _dgvUpcoming.Location = new Point(16, 52);
            _dgvUpcoming.Size = new Size(pnlTableCard.Width - 32, 210);
            _dgvUpcoming.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _dgvUpcoming.Columns.Add(new DataGridViewTextBoxColumn {
                HeaderText = "REQUEST ID",
                DataPropertyName = "RequestId",
                Width = 110
            });
            _dgvUpcoming.Columns.Add(new DataGridViewTextBoxColumn {
                HeaderText = "FACULTY MEMBER",
                DataPropertyName = "FacultyName",
                Width = 200
            });
            _dgvUpcoming.Columns.Add(new DataGridViewTextBoxColumn {
                HeaderText = "SUBJECT",
                DataPropertyName = "Subject",
                Width = 220
            });
            _dgvUpcoming.Columns.Add(new DataGridViewTextBoxColumn {
                HeaderText = "DATE & TIME",
                DataPropertyName = "DisplayScheduledDate",
                Width = 150
            });
            _dgvUpcoming.Columns.Add(new DataGridViewTextBoxColumn {
                HeaderText = "TYPE",
                DataPropertyName = "DisplayMeetingType",
                Width = 120
            });
            _dgvUpcoming.Columns.Add(new DataGridViewTextBoxColumn {
                HeaderText = "STATUS",
                DataPropertyName = "Status",
                Width = 120
            });

            _dgvUpcoming.CellPainting += (s, e) => {
                if (e.RowIndex >= 0 && e.ColumnIndex == 5 && e.Value != null) {
                    if (e.Value is MeetingStatus status) {
                        UIHelper.RenderStatusCell(e, status.ToString(), status);
                    }
                }
            };

            pnlTableCard.Controls.Add(_dgvUpcoming);
            pnlBody.Controls.Add(pnlTableCard);

            // Recent Notifications Card Panel
            var pnlNotifCard = UIHelper.CreateCard(16);
            pnlNotifCard.Dock = DockStyle.Top;
            pnlNotifCard.Height = 220;
            pnlNotifCard.Margin = new Padding(0, 16, 0, 0);

            var lblNotifTitle = new Label {
                Text = "Recent Notification Updates",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(16, 14),
                AutoSize = true
            };
            pnlNotifCard.Controls.Add(lblNotifTitle);

            _pnlNotifications.Location = new Point(16, 45);
            _pnlNotifications.Size = new Size(pnlNotifCard.Width - 32, 160);
            _pnlNotifications.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _pnlNotifications.AutoScroll = true;
            _pnlNotifications.BackColor = ThemeColors.White;

            pnlNotifCard.Controls.Add(_pnlNotifications);
            pnlBody.Controls.Add(pnlNotifCard);

            Controls.Add(pnlBody);
            pnlBody.BringToFront();
        }

        public void LoadData() {
            var currentUser = SessionManager.CurrentUser;
            if (currentUser == null) return;

            // Load Stats
            var (pending, approved, rescheduled, declined) = _dataService.GetStudentStats(currentUser.UserId);
            _cardPending.Value = pending.ToString();
            _cardApproved.Value = approved.ToString();
            _cardRescheduled.Value = rescheduled.ToString();
            _cardDeclined.Value = declined.ToString();

            // Load Upcoming/Active Meetings
            var meetings = _dataService.GetMeetingsForStudent(currentUser.UserId)
                .Where(m => m.Status == MeetingStatus.Pending || m.Status == MeetingStatus.Approved || m.Status == MeetingStatus.Rescheduled)
                .ToList();

            _dgvUpcoming.DataSource = null;
            _dgvUpcoming.DataSource = meetings;

            // Load Recent Notifications
            _pnlNotifications.Controls.Clear();
            var notifs = _dataService.GetNotificationsForUser(currentUser.UserId).Take(4).ToList();
            int ny = 4;

            if (!notifs.Any()) {
                var lblEmpty = new Label {
                    Text = "No notifications yet.",
                    Font = new Font("Segoe UI", 9F, FontStyle.Italic),
                    ForeColor = ThemeColors.TextMuted,
                    Location = new Point(10, 10),
                    AutoSize = true
                };
                _pnlNotifications.Controls.Add(lblEmpty);
            } else {
                foreach (var n in notifs) {
                    var itemPanel = new Panel {
                        Location = new Point(0, ny),
                        Size = new Size(_pnlNotifications.Width - 20, 36),
                        Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                        BackColor = n.IsRead ? ThemeColors.White : ThemeColors.LightRed,
                        Cursor = Cursors.Hand
                    };
                    itemPanel.Paint += (s, e) => {
                        using var pen = new Pen(n.IsRead ? ThemeColors.BorderGray : ThemeColors.LightRedBorder, 1);
                        e.Graphics.DrawRectangle(pen, 0, 0, itemPanel.Width - 1, itemPanel.Height - 1);
                    };

                    var lblItem = new Label {
                        Text = $"• [{n.DisplayTime}] {n.Title}: {n.Message}",
                        Font = new Font("Segoe UI", 8.5F, n.IsRead ? FontStyle.Regular : FontStyle.Bold),
                        ForeColor = n.IsRead ? ThemeColors.TextRegular : ThemeColors.PrimaryRedDark,
                        Location = new Point(10, 8),
                        AutoSize = true
                    };
                    itemPanel.Controls.Add(lblItem);
                    _pnlNotifications.Controls.Add(itemPanel);
                    ny += 40;
                }
            }
        }

        private MeetingRequest? GetSelectedMeeting() {
            if (_dgvUpcoming.CurrentRow?.DataBoundItem is MeetingRequest req) {
                return req;
            }
            return null;
        }

        private void OnViewDetailsClick(object? sender, EventArgs e) {
            var req = GetSelectedMeeting();
            if (req == null) {
                MessageBox.Show("Please select a meeting request to view details.", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using var dlg = new MeetingDetailsDialog(req);
            dlg.ShowDialog(this);
        }

        private void OnCancelMeetingClick(object? sender, EventArgs e) {
            var req = GetSelectedMeeting();
            if (req == null) {
                MessageBox.Show("Please select a meeting request to cancel.", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (req.Status == MeetingStatus.Completed || req.Status == MeetingStatus.Cancelled || req.Status == MeetingStatus.Declined) {
                MessageBox.Show("This meeting request is already closed or cancelled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to cancel request '{req.Subject}' with {req.FacultyName}?",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes) {
                _dataService.CancelMeeting(req.RequestId);
                MessageBox.Show("Meeting request has been cancelled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }
    }
}
