using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DCSSMeetingScheduler.Models;
using DCSSMeetingScheduler.Services;
using DCSSMeetingScheduler.UI.Common;
using DCSSMeetingScheduler.UI.Dialogs;

namespace DCSSMeetingScheduler.UI.Views.Faculty {
    public class FacultyHomeView : UserControl {
        private readonly IDataService _dataService = MockDataStore.Instance;

        private readonly MetricCard _cardTotal = new();
        private readonly MetricCard _cardPending = new();
        private readonly MetricCard _cardApproved = new();
        private readonly MetricCard _cardDeclined = new();
        private readonly MetricCard _cardCompleted = new();

        private readonly DataGridView _dgvToday = new();
        private readonly DataGridView _dgvPending = new();

        public FacultyHomeView() {
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
            var pnlHeader = UIHelper.CreatePageHeader(
                "FACULTY CONSULTATION OVERVIEW",
                "Monitor student meeting requests, consultation appointments, and advisory schedules"
            );
            Controls.Add(pnlHeader);

            var pnlBody = new Panel {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(24, 16, 24, 24)
            };

            // Summary Cards Flow Panel
            var pnlCards = new FlowLayoutPanel {
                Dock = DockStyle.Top,
                Height = 118,
                WrapContents = false,
                AutoScroll = false,
                Padding = new Padding(0, 0, 0, 8),
                BackColor = Color.Transparent
            };

            _cardTotal.Title = "Total Requests";
            _cardTotal.Subtitle = "All-time consultations";
            _cardTotal.IconGlyph = "📋";
            _cardTotal.AccentColor = ThemeColors.PrimaryRed;
            _cardTotal.Margin = new Padding(0, 0, 14, 0);

            _cardPending.Title = "Pending Requests";
            _cardPending.Subtitle = "Requires your review";
            _cardPending.IconGlyph = "⏳";
            _cardPending.AccentColor = Color.FromArgb(217, 119, 6);
            _cardPending.Margin = new Padding(0, 0, 14, 0);

            _cardApproved.Title = "Approved";
            _cardApproved.Subtitle = "Scheduled consultations";
            _cardApproved.IconGlyph = "✔";
            _cardApproved.AccentColor = Color.FromArgb(16, 149, 93);
            _cardApproved.Margin = new Padding(0, 0, 14, 0);

            _cardDeclined.Title = "Declined";
            _cardDeclined.Subtitle = "Closed without meeting";
            _cardDeclined.IconGlyph = "✕";
            _cardDeclined.AccentColor = ThemeColors.PrimaryRed;
            _cardDeclined.Margin = new Padding(0, 0, 14, 0);

            _cardCompleted.Title = "Completed";
            _cardCompleted.Subtitle = "Finished consultations";
            _cardCompleted.IconGlyph = "🎓";
            _cardCompleted.AccentColor = Color.FromArgb(75, 85, 99);
            _cardCompleted.Margin = new Padding(0);

            pnlCards.Controls.AddRange(new Control[] { _cardTotal, _cardPending, _cardApproved, _cardDeclined, _cardCompleted });
            pnlBody.Controls.Add(pnlCards);

            // Today's Scheduled Meetings Card
            var pnlTodayCard = UIHelper.CreateCard(16);
            pnlTodayCard.Dock = DockStyle.Top;
            pnlTodayCard.Height = 250;
            pnlTodayCard.Margin = new Padding(0, 16, 0, 16);

            var lblTodayTitle = new Label {
                Text = "Today's Consultations & Meetings",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(16, 14),
                AutoSize = true
            };
            pnlTodayCard.Controls.Add(lblTodayTitle);

            var btnViewToday = new Button {
                Text = "View Details",
                Location = new Point(pnlTodayCard.Width - 130, 10),
                Size = new Size(110, 32),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            UIHelper.StyleSecondaryButton(btnViewToday);
            btnViewToday.Click += (s, e) => {
                if (_dgvToday.CurrentRow?.DataBoundItem is MeetingRequest r) {
                    using var dlg = new MeetingDetailsDialog(r);
                    dlg.ShowDialog(this);
                } else {
                    MessageBox.Show("Please select a meeting.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
            pnlTodayCard.Controls.Add(btnViewToday);

            UIHelper.StyleDataGridView(_dgvToday);
            _dgvToday.Location = new Point(16, 50);
            _dgvToday.Size = new Size(pnlTodayCard.Width - 32, 180);
            _dgvToday.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _dgvToday.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "REQ ID", DataPropertyName = "RequestId", Width = 110 });
            _dgvToday.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STUDENT", DataPropertyName = "StudentName", Width = 200 });
            _dgvToday.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "SUBJECT", DataPropertyName = "Subject", Width = 240 });
            _dgvToday.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "TIME SLOT", DataPropertyName = "DisplayScheduledTime", Width = 140 });
            _dgvToday.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "VENUE / LINK", DataPropertyName = "LocationOrLink", Width = 220 });
            _dgvToday.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STATUS", DataPropertyName = "Status", Width = 120 });

            _dgvToday.CellPainting += (s, e) => {
                if (e.RowIndex >= 0 && e.ColumnIndex == 5 && e.Value is MeetingStatus st) {
                    UIHelper.RenderStatusCell(e, st.ToString(), st);
                }
            };
            pnlTodayCard.Controls.Add(_dgvToday);
            pnlBody.Controls.Add(pnlTodayCard);

            // Recent Pending Requests Card (Quick Action)
            var pnlPendingCard = UIHelper.CreateCard(16);
            pnlPendingCard.Dock = DockStyle.Top;
            pnlPendingCard.Height = 260;
            pnlPendingCard.Margin = new Padding(0, 16, 0, 0);

            var lblPendingTitle = new Label {
                Text = "Recent Pending Requests (Awaiting Action)",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(16, 14),
                AutoSize = true
            };
            pnlPendingCard.Controls.Add(lblPendingTitle);

            // Action buttons on pending card
            var btnApproveQuick = new Button {
                Text = "Approve",
                Location = new Point(pnlPendingCard.Width - 120, 10),
                Size = new Size(100, 32),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            UIHelper.StylePrimaryButton(btnApproveQuick);
            btnApproveQuick.Click += OnApproveQuickClick;
            pnlPendingCard.Controls.Add(btnApproveQuick);

            var btnViewPending = new Button {
                Text = "View Details",
                Location = new Point(pnlPendingCard.Width - 230, 10),
                Size = new Size(100, 32),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            UIHelper.StyleSecondaryButton(btnViewPending);
            btnViewPending.Click += (s, e) => {
                if (_dgvPending.CurrentRow?.DataBoundItem is MeetingRequest r) {
                    using var dlg = new MeetingDetailsDialog(r);
                    dlg.ShowDialog(this);
                } else {
                    MessageBox.Show("Please select a request.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
            pnlPendingCard.Controls.Add(btnViewPending);

            UIHelper.StyleDataGridView(_dgvPending);
            _dgvPending.Location = new Point(16, 50);
            _dgvPending.Size = new Size(pnlPendingCard.Width - 32, 190);
            _dgvPending.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _dgvPending.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "REQ ID", DataPropertyName = "RequestId", Width = 110 });
            _dgvPending.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STUDENT", DataPropertyName = "StudentName", Width = 180 });
            _dgvPending.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "PROGRAM", DataPropertyName = "StudentProgram", Width = 110 });
            _dgvPending.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "SUBJECT", DataPropertyName = "Subject", Width = 230 });
            _dgvPending.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "REQUESTED DATE & TIME", DataPropertyName = "DisplayScheduledDate", Width = 180 });
            _dgvPending.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STATUS", DataPropertyName = "Status", Width = 120 });

            _dgvPending.CellPainting += (s, e) => {
                if (e.RowIndex >= 0 && e.ColumnIndex == 5 && e.Value is MeetingStatus st) {
                    UIHelper.RenderStatusCell(e, st.ToString(), st);
                }
            };
            pnlPendingCard.Controls.Add(_dgvPending);
            pnlBody.Controls.Add(pnlPendingCard);

            Controls.Add(pnlBody);
            pnlBody.BringToFront();
        }

        public void LoadData() {
            var currentUser = SessionManager.CurrentUser;
            if (currentUser == null) return;

            var (total, pending, approved, declined, completed) = _dataService.GetFacultyStats(currentUser.UserId);
            _cardTotal.Value = total.ToString();
            _cardPending.Value = pending.ToString();
            _cardApproved.Value = approved.ToString();
            _cardDeclined.Value = declined.ToString();
            _cardCompleted.Value = completed.ToString();

            var allFacultyMeetings = _dataService.GetMeetingsForFaculty(currentUser.UserId);

            // Today's meetings (or today + upcoming approved)
            var todayMeetings = allFacultyMeetings
                .Where(m => (m.Status == MeetingStatus.Approved || m.Status == MeetingStatus.Rescheduled) &&
                            (m.ScheduledDate?.Date == DateTime.Today || m.PreferredDate.Date == DateTime.Today || m.ScheduledDate >= DateTime.Today))
                .OrderBy(m => m.ScheduledDate)
                .ToList();

            _dgvToday.DataSource = null;
            _dgvToday.DataSource = todayMeetings;

            // Pending requests
            var pendingRequests = allFacultyMeetings
                .Where(m => m.Status == MeetingStatus.Pending)
                .OrderByDescending(m => m.CreatedAt)
                .ToList();

            _dgvPending.DataSource = null;
            _dgvPending.DataSource = pendingRequests;
        }

        private void OnApproveQuickClick(object? sender, EventArgs e) {
            if (_dgvPending.CurrentRow?.DataBoundItem is not MeetingRequest req) {
                MessageBox.Show("Please select a pending request to approve.", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show(
                $"Approve meeting '{req.Subject}' with {req.StudentName} for {req.DisplayScheduledDate} at {req.DisplayScheduledTime}?",
                "Confirm Approval",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes) {
                _dataService.ApproveMeeting(req.RequestId, "Approved by faculty during review.", req.LocationOrLink);
                MessageBox.Show("Meeting request has been approved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }
    }
}
