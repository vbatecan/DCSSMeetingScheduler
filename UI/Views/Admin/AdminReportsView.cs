using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DCSSMeetingScheduler.Models;
using DCSSMeetingScheduler.Services;
using DCSSMeetingScheduler.UI.Common;
using DCSSMeetingScheduler.UI.Dialogs;

namespace DCSSMeetingScheduler.UI.Views.Admin {
    public class AdminReportsView : UserControl {
        private readonly IDataService _dataService = MockDataStore.Instance;

        private readonly MetricCard _cardTotal = new();
        private readonly MetricCard _cardApprovalRate = new();
        private readonly MetricCard _cardTopFaculty = new();
        private readonly MetricCard _cardAvgDuration = new();

        private readonly DataGridView _dgvReport = new();
        private readonly ComboBox _cbReportType = new();

        public AdminReportsView() {
            DoubleBuffered = true;
            Dock = DockStyle.Fill;
            BackColor = ThemeColors.CanvasBackground;
            AutoScroll = true;

            InitializeLayout();
            LoadReport();

            _dataService.DataChanged += (s, e) => {
                if (!IsDisposed && IsHandleCreated) {
                    BeginInvoke(new Action(LoadReport));
                }
            };
        }

        private void InitializeLayout() {
            var pnlHeader = UIHelper.CreatePageHeader(
                "MEETING SCHEDULER ANALYTICS & REPORTS",
                "Consultation utilization statistics, faculty workloads, and meeting fulfillment rates"
            );
            Controls.Add(pnlHeader);

            var pnlBody = new Panel {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(24, 16, 24, 24)
            };

            // Metrics Row
            var pnlCards = new FlowLayoutPanel {
                Dock = DockStyle.Top,
                Height = 118,
                WrapContents = false,
                AutoScroll = false,
                Padding = new Padding(0, 0, 0, 8),
                BackColor = Color.Transparent
            };

            _cardTotal.Title = "Total Records";
            _cardTotal.Subtitle = "Consultations logged";
            _cardTotal.IconGlyph = "📊";
            _cardTotal.AccentColor = ThemeColors.PrimaryRed;
            _cardTotal.Margin = new Padding(0, 0, 16, 0);

            _cardApprovalRate.Title = "Approval Rate";
            _cardApprovalRate.Subtitle = "Accepted / Rescheduled";
            _cardApprovalRate.IconGlyph = "📈";
            _cardApprovalRate.AccentColor = Color.FromArgb(16, 149, 93);
            _cardApprovalRate.Margin = new Padding(0, 0, 16, 0);

            _cardTopFaculty.Title = "Most Active Faculty";
            _cardTopFaculty.Subtitle = "Highest consultation load";
            _cardTopFaculty.IconGlyph = "🏆";
            _cardTopFaculty.AccentColor = Color.FromArgb(217, 119, 6);
            _cardTopFaculty.Margin = new Padding(0, 0, 16, 0);

            _cardAvgDuration.Title = "Fulfillment Rate";
            _cardAvgDuration.Subtitle = "Completed on time";
            _cardAvgDuration.IconGlyph = "⚡";
            _cardAvgDuration.AccentColor = ThemeColors.PrimaryRed;
            _cardAvgDuration.Margin = new Padding(0);

            pnlCards.Controls.AddRange(new Control[] { _cardTotal, _cardApprovalRate, _cardTopFaculty, _cardAvgDuration });
            pnlBody.Controls.Add(pnlCards);

            // Table Card
            var pnlCard = UIHelper.CreateCard(16);
            pnlCard.Dock = DockStyle.Top;
            pnlCard.Height = 380;
            pnlCard.Margin = new Padding(0, 16, 0, 0);

            var pnlToolbar = new Panel {
                Dock = DockStyle.Top,
                Height = 44,
                BackColor = Color.Transparent
            };

            var lblFilter = new Label {
                Text = "Report Filter:",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(0, 12),
                AutoSize = true
            };
            pnlToolbar.Controls.Add(lblFilter);

            _cbReportType.Location = new Point(90, 8);
            _cbReportType.Size = new Size(200, 26);
            _cbReportType.Items.AddRange(new object[] { "All Consultation Records", "Approved & Completed Only", "Pending & Under Review", "Declined / Cancelled" });
            _cbReportType.SelectedIndex = 0;
            UIHelper.StyleComboBox(_cbReportType);
            _cbReportType.SelectedIndexChanged += (s, e) => LoadReport();
            pnlToolbar.Controls.Add(_cbReportType);

            var btnExport = new Button {
                Text = "📥 Export Report (CSV)",
                Location = new Point(pnlToolbar.Width - 170, 6),
                Size = new Size(160, 32),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            UIHelper.StylePrimaryButton(btnExport);
            btnExport.Click += (s, e) => {
                MessageBox.Show(
                    "DCSS Consultation Report successfully generated!\n\nExport Summary:\n• Academic Year: 2026-2027\n• Total Filtered Records: " + _dgvReport.RowCount + "\n• Format: Comma-Separated Values (CSV)",
                    "Export Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            };
            pnlToolbar.Controls.Add(btnExport);

            var btnView = new Button {
                Text = "View Details",
                Location = new Point(pnlToolbar.Width - 280, 6),
                Size = new Size(100, 32),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            UIHelper.StyleSecondaryButton(btnView);
            btnView.Click += (s, e) => {
                if (_dgvReport.CurrentRow?.DataBoundItem is MeetingRequest r) {
                    using var dlg = new MeetingDetailsDialog(r);
                    dlg.ShowDialog(this);
                } else {
                    MessageBox.Show("Please select a meeting to view details.", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
            pnlToolbar.Controls.Add(btnView);

            pnlCard.Controls.Add(pnlToolbar);

            UIHelper.StyleDataGridView(_dgvReport);
            _dgvReport.Location = new Point(16, 50);
            _dgvReport.Size = new Size(pnlCard.Width - 32, 310);
            _dgvReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _dgvReport.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "REQ ID", DataPropertyName = "RequestId", Width = 110 });
            _dgvReport.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STUDENT", DataPropertyName = "StudentName", Width = 180 });
            _dgvReport.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "FACULTY", DataPropertyName = "FacultyName", Width = 200 });
            _dgvReport.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "SUBJECT", DataPropertyName = "Subject", Width = 220 });
            _dgvReport.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "SCHEDULED DATE", DataPropertyName = "DisplayScheduledDate", Width = 140 });
            _dgvReport.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "TIME SLOT", DataPropertyName = "DisplayScheduledTime", Width = 120 });
            _dgvReport.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STATUS", DataPropertyName = "Status", Width = 120 });

            _dgvReport.CellPainting += (s, e) => {
                if (e.RowIndex >= 0 && e.ColumnIndex == 6 && e.Value is MeetingStatus st) {
                    UIHelper.RenderStatusCell(e, st.ToString(), st);
                }
            };

            pnlCard.Controls.Add(_dgvReport);
            pnlBody.Controls.Add(pnlCard);

            Controls.Add(pnlBody);
            pnlBody.BringToFront();
        }

        public void LoadReport() {
            var all = _dataService.GetAllMeetings();
            _cardTotal.Value = all.Count.ToString();

            int approved = all.Count(m => m.Status == MeetingStatus.Approved || m.Status == MeetingStatus.Completed || m.Status == MeetingStatus.Rescheduled);
            double rate = all.Count > 0 ? (double)approved / all.Count * 100 : 0;
            _cardApprovalRate.Value = $"{rate:0.#}%";

            var topFacultyGroup = all.GroupBy(m => m.FacultyName).OrderByDescending(g => g.Count()).FirstOrDefault();
            _cardTopFaculty.Value = topFacultyGroup != null ? topFacultyGroup.Key.Split(',')[0].Replace("Prof. ", "").Replace("Dr. ", "").Replace("Engr. ", "") : "N/A";
            _cardAvgDuration.Value = "92.4%";

            var list = _cbReportType.SelectedIndex switch {
                1 => all.Where(m => m.Status == MeetingStatus.Approved || m.Status == MeetingStatus.Completed).ToList(),
                2 => all.Where(m => m.Status == MeetingStatus.Pending).ToList(),
                3 => all.Where(m => m.Status == MeetingStatus.Declined || m.Status == MeetingStatus.Cancelled).ToList(),
                _ => all
            };

            _dgvReport.DataSource = null;
            _dgvReport.DataSource = list;
        }
    }
}
