using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DCSSMeetingScheduler.Models;
using DCSSMeetingScheduler.Services;
using DCSSMeetingScheduler.UI.Common;

namespace DCSSMeetingScheduler.UI.Views.Admin {
    public class AdminHomeView : UserControl {
        private readonly IDataService _dataService = MockDataStore.Instance;

        private readonly MetricCard _cardTotalUsers = new();
        private readonly MetricCard _cardStudents = new();
        private readonly MetricCard _cardFaculty = new();
        private readonly MetricCard _cardTotalMeetings = new();

        private readonly DataGridView _dgvRecentActivity = new();

        public AdminHomeView() {
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
                "ADMINISTRATOR SYSTEM DASHBOARD",
                "University of the East - Caloocan | DCSS Meeting Scheduler Administration"
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

            _cardTotalUsers.Title = "Total Users";
            _cardTotalUsers.Subtitle = "Registered accounts";
            _cardTotalUsers.IconGlyph = "👥";
            _cardTotalUsers.AccentColor = ThemeColors.PrimaryRed;
            _cardTotalUsers.Margin = new Padding(0, 0, 16, 0);

            _cardStudents.Title = "Total Students";
            _cardStudents.Subtitle = "CS, IT, and IS students";
            _cardStudents.IconGlyph = "🎓";
            _cardStudents.AccentColor = Color.FromArgb(16, 149, 93);
            _cardStudents.Margin = new Padding(0, 0, 16, 0);

            _cardFaculty.Title = "Total Faculty";
            _cardFaculty.Subtitle = "DCSS teaching staff";
            _cardFaculty.IconGlyph = "👨‍🏫";
            _cardFaculty.AccentColor = Color.FromArgb(217, 119, 6);
            _cardFaculty.Margin = new Padding(0, 0, 16, 0);

            _cardTotalMeetings.Title = "Total Requests";
            _cardTotalMeetings.Subtitle = "System-wide meetings";
            _cardTotalMeetings.IconGlyph = "📊";
            _cardTotalMeetings.AccentColor = ThemeColors.PrimaryRed;
            _cardTotalMeetings.Margin = new Padding(0);

            pnlCards.Controls.AddRange(new Control[] { _cardTotalUsers, _cardStudents, _cardFaculty, _cardTotalMeetings });
            pnlBody.Controls.Add(pnlCards);

            // System Overview & Status Card
            var pnlOverviewCard = UIHelper.CreateCard(16);
            pnlOverviewCard.Dock = DockStyle.Top;
            pnlOverviewCard.Height = 110;
            pnlOverviewCard.Margin = new Padding(0, 16, 0, 16);

            var lblOverviewTitle = new Label {
                Text = "Academic Department Status • College of Arts and Sciences",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(16, 14),
                AutoSize = true
            };
            pnlOverviewCard.Controls.Add(lblOverviewTitle);

            var lblDepartmentDetails = new Label {
                Text = "Department of Computer Studies and Systems (DCSS) • Academic Year 2026-2027\nActive Programs: Bachelor of Science in Computer Science (BSCS) & Bachelor of Science in Information Technology (BSIT)\nDatabase Mode: In-Memory Mock Service (Ready for MySQL DB Connection)",
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = ThemeColors.TextRegular,
                Location = new Point(16, 40),
                AutoSize = true
            };
            pnlOverviewCard.Controls.Add(lblDepartmentDetails);

            pnlBody.Controls.Add(pnlOverviewCard);

            // Recent Meeting Transactions Card
            var pnlTableCard = UIHelper.CreateCard(16);
            pnlTableCard.Dock = DockStyle.Top;
            pnlTableCard.Height = 320;
            pnlTableCard.Margin = new Padding(0, 16, 0, 0);

            var lblTableTitle = new Label {
                Text = "System Activity & Recent Meeting Logs",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(16, 14),
                AutoSize = true
            };
            pnlTableCard.Controls.Add(lblTableTitle);

            UIHelper.StyleDataGridView(_dgvRecentActivity);
            _dgvRecentActivity.Location = new Point(16, 48);
            _dgvRecentActivity.Size = new Size(pnlTableCard.Width - 32, 250);
            _dgvRecentActivity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _dgvRecentActivity.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "REQ ID", DataPropertyName = "RequestId", Width = 110 });
            _dgvRecentActivity.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STUDENT", DataPropertyName = "StudentName", Width = 180 });
            _dgvRecentActivity.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "FACULTY", DataPropertyName = "FacultyName", Width = 200 });
            _dgvRecentActivity.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "SUBJECT", DataPropertyName = "Subject", Width = 230 });
            _dgvRecentActivity.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "SCHEDULED DATE", DataPropertyName = "DisplayScheduledDate", Width = 140 });
            _dgvRecentActivity.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STATUS", DataPropertyName = "Status", Width = 120 });

            _dgvRecentActivity.CellPainting += (s, e) => {
                if (e.RowIndex >= 0 && e.ColumnIndex == 5 && e.Value is MeetingStatus st) {
                    UIHelper.RenderStatusCell(e, st.ToString(), st);
                }
            };

            pnlTableCard.Controls.Add(_dgvRecentActivity);
            pnlBody.Controls.Add(pnlTableCard);

            Controls.Add(pnlBody);
            pnlBody.BringToFront();
        }

        public void LoadData() {
            var (totalUsers, totalStudents, totalFaculty, totalMeetings) = _dataService.GetAdminStats();
            _cardTotalUsers.Value = totalUsers.ToString();
            _cardStudents.Value = totalStudents.ToString();
            _cardFaculty.Value = totalFaculty.ToString();
            _cardTotalMeetings.Value = totalMeetings.ToString();

            var meetings = _dataService.GetAllMeetings();
            _dgvRecentActivity.DataSource = null;
            _dgvRecentActivity.DataSource = meetings;
        }
    }
}
