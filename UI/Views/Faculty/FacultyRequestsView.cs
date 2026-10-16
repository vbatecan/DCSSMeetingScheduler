using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DCSSMeetingScheduler.Models;
using DCSSMeetingScheduler.Services;
using DCSSMeetingScheduler.UI.Common;
using DCSSMeetingScheduler.UI.Dialogs;

namespace DCSSMeetingScheduler.UI.Views.Faculty {
    public class FacultyRequestsView : UserControl {
        private readonly IDataService _dataService = MockDataStore.Instance;

        private readonly TextBox _txtSearch = new();
        private readonly ComboBox _cbStatusFilter = new();
        private readonly DataGridView _dgvRequests = new();
        private readonly Label _lblRecordCount = new();

        private List<MeetingRequest> _allRequests = new();

        public FacultyRequestsView() {
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
            var pnlHeader = UIHelper.CreatePageHeader(
                "STUDENT MEETING REQUESTS",
                "Review, approve, reschedule, or decline incoming consultation requests from DCSS students"
            );
            Controls.Add(pnlHeader);

            var pnlBody = new Panel {
                Dock = DockStyle.Fill,
                Padding = new Padding(24, 16, 24, 24)
            };

            var pnlCard = UIHelper.CreateCard(16);
            pnlCard.Dock = DockStyle.Fill;

            // Search & Action Toolbar
            var pnlToolbar = new Panel {
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
            pnlToolbar.Controls.Add(lblSearch);

            _txtSearch.Location = new Point(55, 8);
            _txtSearch.Size = new Size(220, 26);
            _txtSearch.PlaceholderText = "Search student, subject...";
            UIHelper.StyleTextBox(_txtSearch);
            _txtSearch.TextChanged += (s, e) => ApplyFilter();
            pnlToolbar.Controls.Add(_txtSearch);

            var lblStatus = new Label {
                Text = "Status:",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(290, 12),
                AutoSize = true
            };
            pnlToolbar.Controls.Add(lblStatus);

            _cbStatusFilter.Location = new Point(340, 8);
            _cbStatusFilter.Size = new Size(130, 26);
            _cbStatusFilter.Items.AddRange(new object[] { "All Statuses", "Pending", "Approved", "Rescheduled", "Declined", "Completed" });
            _cbStatusFilter.SelectedIndex = 0;
            UIHelper.StyleComboBox(_cbStatusFilter);
            _cbStatusFilter.SelectedIndexChanged += (s, e) => ApplyFilter();
            pnlToolbar.Controls.Add(_cbStatusFilter);

            // Action Buttons
            int btnX = pnlToolbar.Width - 95;

            var btnDecline = new Button {
                Text = "Decline",
                Location = new Point(pnlToolbar.Width - 90, 6),
                Size = new Size(85, 32),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            UIHelper.StyleDangerButton(btnDecline);
            btnDecline.Click += OnDeclineClick;
            pnlToolbar.Controls.Add(btnDecline);

            var btnReschedule = new Button {
                Text = "Reschedule",
                Location = new Point(pnlToolbar.Width - 195, 6),
                Size = new Size(100, 32),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            UIHelper.StyleSecondaryButton(btnReschedule);
            btnReschedule.Click += OnRescheduleClick;
            pnlToolbar.Controls.Add(btnReschedule);

            var btnApprove = new Button {
                Text = "Approve",
                Location = new Point(pnlToolbar.Width - 290, 6),
                Size = new Size(90, 32),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            UIHelper.StylePrimaryButton(btnApprove);
            btnApprove.Click += OnApproveClick;
            pnlToolbar.Controls.Add(btnApprove);

            var btnView = new Button {
                Text = "View Details",
                Location = new Point(pnlToolbar.Width - 395, 6),
                Size = new Size(100, 32),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            UIHelper.StyleSecondaryButton(btnView);
            btnView.Click += OnViewDetailsClick;
            pnlToolbar.Controls.Add(btnView);

            pnlCard.Controls.Add(pnlToolbar);

            // DataGridView setup
            UIHelper.StyleDataGridView(_dgvRequests);
            _dgvRequests.Dock = DockStyle.Fill;
            _dgvRequests.Margin = new Padding(0, 10, 0, 10);

            _dgvRequests.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "REQ ID", DataPropertyName = "RequestId", Width = 110 });
            _dgvRequests.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STUDENT NAME", DataPropertyName = "StudentName", Width = 180 });
            _dgvRequests.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "PROGRAM", DataPropertyName = "StudentProgram", Width = 100 });
            _dgvRequests.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "MEETING SUBJECT", DataPropertyName = "Subject", Width = 230 });
            _dgvRequests.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "REQUESTED DATE", DataPropertyName = "DisplayScheduledDate", Width = 140 });
            _dgvRequests.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "PREFERRED TIME", DataPropertyName = "DisplayScheduledTime", Width = 140 });
            _dgvRequests.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "TYPE", DataPropertyName = "DisplayMeetingType", Width = 120 });
            _dgvRequests.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STATUS", DataPropertyName = "Status", Width = 120 });

            _dgvRequests.CellPainting += (s, e) => {
                if (e.RowIndex >= 0 && e.ColumnIndex == 7 && e.Value is MeetingStatus st) {
                    UIHelper.RenderStatusCell(e, st.ToString(), st);
                }
            };
            _dgvRequests.CellDoubleClick += (s, e) => OnViewDetailsClick(s, e);

            pnlCard.Controls.Add(_dgvRequests);
            _dgvRequests.BringToFront();

            // Bottom bar
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

            _allRequests = _dataService.GetMeetingsForFaculty(currentUser.UserId);
            ApplyFilter();
        }

        private void ApplyFilter() {
            string search = _txtSearch.Text.Trim().ToLowerInvariant();
            string statusFilter = _cbStatusFilter.SelectedItem?.ToString() ?? "All Statuses";

            var filtered = _allRequests.Where(m => {
                bool matchesSearch = string.IsNullOrEmpty(search) ||
                    m.RequestId.ToLowerInvariant().Contains(search) ||
                    m.StudentName.ToLowerInvariant().Contains(search) ||
                    m.Subject.ToLowerInvariant().Contains(search) ||
                    m.Purpose.ToLowerInvariant().Contains(search);

                bool matchesStatus = statusFilter == "All Statuses" || m.Status.ToString() == statusFilter;

                return matchesSearch && matchesStatus;
            }).ToList();

            _dgvRequests.DataSource = null;
            _dgvRequests.DataSource = filtered;
            _lblRecordCount.Text = $"Showing {filtered.Count} of {_allRequests.Count} consultation requests";
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

        private void OnApproveClick(object? sender, EventArgs e) {
            var req = GetSelectedMeeting();
            if (req == null) {
                MessageBox.Show("Please select a meeting request to approve.", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (req.Status == MeetingStatus.Approved) {
                MessageBox.Show("This meeting is already approved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show(
                $"Approve consultation '{req.Subject}' with {req.StudentName} for {req.DisplayScheduledDate} at {req.DisplayScheduledTime}?",
                "Confirm Approval",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes) {
                _dataService.ApproveMeeting(req.RequestId, "Consultation schedule confirmed by faculty.", req.LocationOrLink);
                MessageBox.Show("Consultation request successfully approved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void OnRescheduleClick(object? sender, EventArgs e) {
            var req = GetSelectedMeeting();
            if (req == null) {
                MessageBox.Show("Please select a meeting request to reschedule.", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (req.Status == MeetingStatus.Completed || req.Status == MeetingStatus.Cancelled || req.Status == MeetingStatus.Declined) {
                MessageBox.Show("Cannot reschedule a closed, declined, or cancelled consultation.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var dlg = new RescheduleMeetingDialog(req);
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                _dataService.RescheduleMeeting(req.RequestId, dlg.NewDate, dlg.NewTime, dlg.Reason);
                MessageBox.Show("Consultation rescheduled and notification sent to student.", "Rescheduled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void OnDeclineClick(object? sender, EventArgs e) {
            var req = GetSelectedMeeting();
            if (req == null) {
                MessageBox.Show("Please select a meeting request to decline.", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (req.Status == MeetingStatus.Completed || req.Status == MeetingStatus.Cancelled || req.Status == MeetingStatus.Declined) {
                MessageBox.Show("This request is already closed, declined, or cancelled.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var dlg = new DeclineMeetingDialog(req);
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                _dataService.DeclineMeeting(req.RequestId, dlg.DeclineReason);
                MessageBox.Show("Meeting request has been declined.", "Declined", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }
    }
}
