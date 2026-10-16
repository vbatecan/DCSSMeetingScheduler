using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DCSSMeetingScheduler.Models;
using DCSSMeetingScheduler.Services;
using DCSSMeetingScheduler.UI.Common;
using DCSSMeetingScheduler.UI.Dialogs;

namespace DCSSMeetingScheduler.UI.Views.Faculty {
    public class FacultyScheduleView : UserControl {
        private readonly IDataService _dataService = MockDataStore.Instance;

        private readonly MonthCalendar _calendar = new();
        private readonly DataGridView _dgvSchedule = new();
        private readonly Label _lblSelectedDateInfo = new();
        private readonly Button _btnComplete = new();
        private readonly Button _btnDetails = new();

        public FacultyScheduleView() {
            DoubleBuffered = true;
            Dock = DockStyle.Fill;
            BackColor = ThemeColors.CanvasBackground;

            InitializeLayout();
            LoadSchedule();

            _dataService.DataChanged += (s, e) => {
                if (!IsDisposed && IsHandleCreated) {
                    BeginInvoke(new Action(LoadSchedule));
                }
            };
        }

        private void InitializeLayout() {
            var pnlHeader = UIHelper.CreatePageHeader(
                "MY CONSULTATION SCHEDULE",
                "View and manage approved consultations, student appointments, and timetable"
            );
            Controls.Add(pnlHeader);

            var pnlBody = new Panel {
                Dock = DockStyle.Fill,
                Padding = new Padding(24, 16, 24, 24)
            };

            // Split Layout: Left side Calendar card, Right side Appointments table card
            var pnlLeftCard = UIHelper.CreateCard(16);
            pnlLeftCard.Dock = DockStyle.Left;
            pnlLeftCard.Width = 280;

            var lblCalTitle = new Label {
                Text = "Select Date",
                Font = new Font("Segoe UI", 10.5F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(16, 14),
                AutoSize = true
            };
            pnlLeftCard.Controls.Add(lblCalTitle);

            _calendar.Location = new Point(16, 45);
            _calendar.MaxSelectionCount = 1;
            _calendar.TitleBackColor = ThemeColors.PrimaryRedDark;
            _calendar.TitleForeColor = ThemeColors.White;
            _calendar.TrailingForeColor = ThemeColors.TextMuted;
            _calendar.DateChanged += (s, e) => FilterBySelectedDate();
            pnlLeftCard.Controls.Add(_calendar);

            var btnShowAll = new Button {
                Text = "Show All Upcoming",
                Location = new Point(16, 235),
                Size = new Size(227, 34)
            };
            UIHelper.StyleSecondaryButton(btnShowAll);
            btnShowAll.Click += (s, e) => LoadSchedule();
            pnlLeftCard.Controls.Add(btnShowAll);

            pnlBody.Controls.Add(pnlLeftCard);

            // Right Schedule Card
            var pnlRightCard = UIHelper.CreateCard(16);
            pnlRightCard.Dock = DockStyle.Fill;
            pnlRightCard.Margin = new Padding(16, 0, 0, 0);

            var pnlRightTop = new Panel {
                Dock = DockStyle.Top,
                Height = 44,
                BackColor = Color.Transparent
            };

            _lblSelectedDateInfo.Text = "Upcoming Consultations";
            _lblSelectedDateInfo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            _lblSelectedDateInfo.ForeColor = ThemeColors.TextDark;
            _lblSelectedDateInfo.Location = new Point(0, 10);
            _lblSelectedDateInfo.AutoSize = true;
            pnlRightTop.Controls.Add(_lblSelectedDateInfo);

            UIHelper.StylePrimaryButton(_btnComplete, "Mark as Completed");
            _btnComplete.Size = new Size(150, 32);
            _btnComplete.Location = new Point(pnlRightTop.Width - 160, 6);
            _btnComplete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnComplete.Click += OnCompleteMeetingClick;
            pnlRightTop.Controls.Add(_btnComplete);

            UIHelper.StyleSecondaryButton(_btnDetails, "View Details");
            _btnDetails.Size = new Size(110, 32);
            _btnDetails.Location = new Point(pnlRightTop.Width - 280, 6);
            _btnDetails.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnDetails.Click += OnViewDetailsClick;
            pnlRightTop.Controls.Add(_btnDetails);

            pnlRightCard.Controls.Add(pnlRightTop);

            // Schedule DataGridView
            UIHelper.StyleDataGridView(_dgvSchedule);
            _dgvSchedule.Dock = DockStyle.Fill;

            _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "REQ ID", DataPropertyName = "RequestId", Width = 110 });
            _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "DATE", DataPropertyName = "DisplayScheduledDate", Width = 130 });
            _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "TIME SLOT", DataPropertyName = "DisplayScheduledTime", Width = 130 });
            _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STUDENT", DataPropertyName = "StudentName", Width = 180 });
            _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "SUBJECT", DataPropertyName = "Subject", Width = 220 });
            _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "VENUE / LINK", DataPropertyName = "LocationOrLink", Width = 200 });
            _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STATUS", DataPropertyName = "Status", Width = 120 });

            _dgvSchedule.CellPainting += (s, e) => {
                if (e.RowIndex >= 0 && e.ColumnIndex == 6 && e.Value is MeetingStatus st) {
                    UIHelper.RenderStatusCell(e, st.ToString(), st);
                }
            };
            _dgvSchedule.CellDoubleClick += (s, e) => OnViewDetailsClick(s, e);

            pnlRightCard.Controls.Add(_dgvSchedule);
            _dgvSchedule.BringToFront();

            pnlBody.Controls.Add(pnlRightCard);
            pnlRightCard.BringToFront();

            Controls.Add(pnlBody);
            pnlBody.BringToFront();
        }

        public void LoadSchedule() {
            var currentUser = SessionManager.CurrentUser;
            if (currentUser == null) return;

            var list = _dataService.GetMeetingsForFaculty(currentUser.UserId)
                .Where(m => m.Status == MeetingStatus.Approved || m.Status == MeetingStatus.Rescheduled || m.Status == MeetingStatus.Completed)
                .OrderBy(m => m.ScheduledDate ?? m.PreferredDate)
                .ToList();

            _dgvSchedule.DataSource = null;
            _dgvSchedule.DataSource = list;
            _lblSelectedDateInfo.Text = $"All Upcoming & Recent Consultations ({list.Count} Total)";
        }

        private void FilterBySelectedDate() {
            var currentUser = SessionManager.CurrentUser;
            if (currentUser == null) return;

            var selectedDate = _calendar.SelectionStart.Date;
            var list = _dataService.GetMeetingsForFaculty(currentUser.UserId)
                .Where(m => (m.Status == MeetingStatus.Approved || m.Status == MeetingStatus.Rescheduled || m.Status == MeetingStatus.Completed) &&
                            ((m.ScheduledDate.HasValue && m.ScheduledDate.Value.Date == selectedDate) ||
                             (!m.ScheduledDate.HasValue && m.PreferredDate.Date == selectedDate)))
                .OrderBy(m => m.ScheduledTime ?? m.PreferredTime)
                .ToList();

            _dgvSchedule.DataSource = null;
            _dgvSchedule.DataSource = list;
            _lblSelectedDateInfo.Text = $"Consultations for {selectedDate:MMMM dd, yyyy} ({list.Count} Scheduled)";
        }

        private MeetingRequest? GetSelectedMeeting() {
            if (_dgvSchedule.CurrentRow?.DataBoundItem is MeetingRequest req) {
                return req;
            }
            return null;
        }

        private void OnViewDetailsClick(object? sender, EventArgs e) {
            var req = GetSelectedMeeting();
            if (req == null) {
                MessageBox.Show("Please select a meeting to view details.", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using var dlg = new MeetingDetailsDialog(req);
            dlg.ShowDialog(this);
        }

        private void OnCompleteMeetingClick(object? sender, EventArgs e) {
            var req = GetSelectedMeeting();
            if (req == null) {
                MessageBox.Show("Please select a meeting to mark as completed.", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (req.Status == MeetingStatus.Completed) {
                MessageBox.Show("This meeting is already completed.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show(
                $"Mark consultation '{req.Subject}' with {req.StudentName} as Completed?",
                "Complete Consultation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes) {
                _dataService.CompleteMeeting(req.RequestId);
                MessageBox.Show("Meeting marked as completed!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSchedule();
            }
        }
    }
}
