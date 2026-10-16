using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DCSSMeetingScheduler.Models;
using DCSSMeetingScheduler.Services;
using DCSSMeetingScheduler.UI.Common;
using DCSSMeetingScheduler.UI.Dialogs;

namespace DCSSMeetingScheduler.UI.Views.Student {
    public class StudentMeetingRequestsView : UserControl {
        private readonly IDataService _dataService = MockDataStore.Instance;

        private readonly TextBox _txtSearch = new();
        private readonly ComboBox _cbStatusFilter = new();
        private readonly DataGridView _dgvRequests = new();
        private readonly Label _lblRecordCount = new();

        private List<MeetingRequest> _allRequests = new();

        public StudentMeetingRequestsView() {
            DoubleBuffered = true;
            Dock = DockStyle.Fill;
            BackColor = ThemeColors.CanvasBackground;

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
                "MY MEETING REQUESTS",
                "Track, monitor, and manage your consultation requests submitted to DCSS faculty"
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

            // Filter & Search bar panel
            var pnlFilter = new Panel {
                Dock = DockStyle.Top,
                Height = 48,
                BackColor = Color.Transparent
            };

            var lblSearch = new Label {
                Text = "Search:",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(0, 12),
                AutoSize = true
            };
            pnlFilter.Controls.Add(lblSearch);

            _txtSearch.Location = new Point(55, 8);
            _txtSearch.Size = new Size(260, 26);
            _txtSearch.PlaceholderText = "Search by ID, faculty, subject...";
            UIHelper.StyleTextBox(_txtSearch);
            _txtSearch.TextChanged += (s, e) => ApplyFilter();
            pnlFilter.Controls.Add(_txtSearch);

            var lblStatus = new Label {
                Text = "Status:",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(335, 12),
                AutoSize = true
            };
            pnlFilter.Controls.Add(lblStatus);

            _cbStatusFilter.Location = new Point(385, 8);
            _cbStatusFilter.Size = new Size(160, 26);
            _cbStatusFilter.Items.AddRange(new object[] { "All Statuses", "Pending", "Approved", "Rescheduled", "Declined", "Cancelled", "Completed" });
            _cbStatusFilter.SelectedIndex = 0;
            UIHelper.StyleComboBox(_cbStatusFilter);
            _cbStatusFilter.SelectedIndexChanged += (s, e) => ApplyFilter();
            pnlFilter.Controls.Add(_cbStatusFilter);

            // Right-aligned action buttons
            var btnCancel = new Button {
                Text = "Cancel Request",
                Location = new Point(pnlFilter.Width - 130, 6),
                Size = new Size(120, 32),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            UIHelper.StyleDangerButton(btnCancel);
            btnCancel.Click += OnCancelClick;
            pnlFilter.Controls.Add(btnCancel);

            var btnView = new Button {
                Text = "View Details",
                Location = new Point(pnlFilter.Width - 250, 6),
                Size = new Size(110, 32),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            UIHelper.StyleSecondaryButton(btnView);
            btnView.Click += OnViewDetailsClick;
            pnlFilter.Controls.Add(btnView);

            var btnRefresh = new Button {
                Text = "Refresh",
                Location = new Point(pnlFilter.Width - 340, 6),
                Size = new Size(80, 32),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            UIHelper.StyleSecondaryButton(btnRefresh);
            btnRefresh.Click += (s, e) => LoadData();
            pnlFilter.Controls.Add(btnRefresh);

            pnlCard.Controls.Add(pnlFilter);

            // DataGridView setup
            UIHelper.StyleDataGridView(_dgvRequests);
            _dgvRequests.Dock = DockStyle.Fill;
            _dgvRequests.Margin = new Padding(0, 10, 0, 10);

            _dgvRequests.Columns.Add(new DataGridViewTextBoxColumn {
                HeaderText = "REQUEST ID",
                DataPropertyName = "RequestId",
                Width = 120
            });
            _dgvRequests.Columns.Add(new DataGridViewTextBoxColumn {
                HeaderText = "FACULTY MEMBER",
                DataPropertyName = "FacultyName",
                Width = 210
            });
            _dgvRequests.Columns.Add(new DataGridViewTextBoxColumn {
                HeaderText = "MEETING SUBJECT",
                DataPropertyName = "Subject",
                Width = 240
            });
            _dgvRequests.Columns.Add(new DataGridViewTextBoxColumn {
                HeaderText = "REQUESTED DATE",
                DataPropertyName = "DisplayScheduledDate",
                Width = 150
            });
            _dgvRequests.Columns.Add(new DataGridViewTextBoxColumn {
                HeaderText = "PREFERRED TIME",
                DataPropertyName = "DisplayScheduledTime",
                Width = 140
            });
            _dgvRequests.Columns.Add(new DataGridViewTextBoxColumn {
                HeaderText = "MEETING TYPE",
                DataPropertyName = "DisplayMeetingType",
                Width = 130
            });
            _dgvRequests.Columns.Add(new DataGridViewTextBoxColumn {
                HeaderText = "STATUS",
                DataPropertyName = "Status",
                Width = 130
            });

            _dgvRequests.CellPainting += (s, e) => {
                if (e.RowIndex >= 0 && e.ColumnIndex == 6 && e.Value != null) {
                    if (e.Value is MeetingStatus status) {
                        UIHelper.RenderStatusCell(e, status.ToString(), status);
                    }
                }
            };

            _dgvRequests.CellDoubleClick += (s, e) => OnViewDetailsClick(s, e);

            pnlCard.Controls.Add(_dgvRequests);
            _dgvRequests.BringToFront();

            // Bottom status bar inside card
            var pnlBottom = new Panel {
                Dock = DockStyle.Bottom,
                Height = 32,
                BackColor = ThemeColors.White
            };
            _lblRecordCount.Font = new Font("Segoe UI", 8.5F);
            _lblRecordCount.ForeColor = ThemeColors.TextMuted;
            _lblRecordCount.Location = new Point(4, 8);
            _lblRecordCount.AutoSize = true;
            pnlBottom.Controls.Add(_lblRecordCount);
            pnlCard.Controls.Add(pnlBottom);
            pnlBottom.BringToFront();

            pnlBody.Controls.Add(pnlCard);
            Controls.Add(pnlBody);
            pnlBody.BringToFront();
        }

        public void LoadData() {
            var currentUser = SessionManager.CurrentUser;
            if (currentUser == null) return;

            _allRequests = _dataService.GetMeetingsForStudent(currentUser.UserId);
            ApplyFilter();
        }

        private void ApplyFilter() {
            string search = _txtSearch.Text.Trim().ToLowerInvariant();
            string statusFilter = _cbStatusFilter.SelectedItem?.ToString() ?? "All Statuses";

            var filtered = _allRequests.Where(m => {
                bool matchesSearch = string.IsNullOrEmpty(search) ||
                    m.RequestId.ToLowerInvariant().Contains(search) ||
                    m.FacultyName.ToLowerInvariant().Contains(search) ||
                    m.Subject.ToLowerInvariant().Contains(search) ||
                    m.Purpose.ToLowerInvariant().Contains(search);

                bool matchesStatus = statusFilter == "All Statuses" || m.Status.ToString() == statusFilter;

                return matchesSearch && matchesStatus;
            }).ToList();

            _dgvRequests.DataSource = null;
            _dgvRequests.DataSource = filtered;
            _lblRecordCount.Text = $"Showing {filtered.Count} of {_allRequests.Count} meeting requests";
        }

        private MeetingRequest? GetSelectedMeeting() {
            if (_dgvRequests.CurrentRow?.DataBoundItem is MeetingRequest req) {
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

        private void OnCancelClick(object? sender, EventArgs e) {
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
