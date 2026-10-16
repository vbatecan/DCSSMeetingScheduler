using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DCSSMeetingScheduler.Models;
using DCSSMeetingScheduler.Services;
using DCSSMeetingScheduler.UI.Common;
using DCSSMeetingScheduler.UI.Dialogs;

namespace DCSSMeetingScheduler.UI.Views.Admin {
    public class AdminManageUsersView : UserControl {
        private readonly IDataService _dataService = MockDataStore.Instance;

        private readonly TextBox _txtSearch = new();
        private readonly ComboBox _cbRoleFilter = new();
        private readonly ComboBox _cbStatusFilter = new();
        private readonly DataGridView _dgvUsers = new();
        private readonly Label _lblRecordCount = new();

        private List<User> _allUsers = new();

        public AdminManageUsersView() {
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
                "USER ACCOUNT MANAGEMENT",
                "Create, modify, activate, or deactivate portal access for students, faculty, and administrative staff"
            );
            Controls.Add(pnlHeader);

            var pnlBody = new Panel {
                Dock = DockStyle.Fill,
                Padding = new Padding(24, 16, 24, 24)
            };

            var pnlCard = UIHelper.CreateCard(16);
            pnlCard.Dock = DockStyle.Fill;

            // Search & Filter Toolbar
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
            _txtSearch.Size = new Size(200, 26);
            _txtSearch.PlaceholderText = "Search by name, email, ID...";
            UIHelper.StyleTextBox(_txtSearch);
            _txtSearch.TextChanged += (s, e) => ApplyFilter();
            pnlToolbar.Controls.Add(_txtSearch);

            var lblRole = new Label {
                Text = "Role:",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(265, 12),
                AutoSize = true
            };
            pnlToolbar.Controls.Add(lblRole);

            _cbRoleFilter.Location = new Point(305, 8);
            _cbRoleFilter.Size = new Size(115, 26);
            _cbRoleFilter.Items.AddRange(new object[] { "All Roles", "Student", "Faculty", "Admin" });
            _cbRoleFilter.SelectedIndex = 0;
            UIHelper.StyleComboBox(_cbRoleFilter);
            _cbRoleFilter.SelectedIndexChanged += (s, e) => ApplyFilter();
            pnlToolbar.Controls.Add(_cbRoleFilter);

            var lblStatus = new Label {
                Text = "Status:",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(430, 12),
                AutoSize = true
            };
            pnlToolbar.Controls.Add(lblStatus);

            _cbStatusFilter.Location = new Point(480, 8);
            _cbStatusFilter.Size = new Size(100, 26);
            _cbStatusFilter.Items.AddRange(new object[] { "All", "Active", "Inactive" });
            _cbStatusFilter.SelectedIndex = 0;
            UIHelper.StyleComboBox(_cbStatusFilter);
            _cbStatusFilter.SelectedIndexChanged += (s, e) => ApplyFilter();
            pnlToolbar.Controls.Add(_cbStatusFilter);

            // Action Buttons
            var btnToggleStatus = new Button {
                Text = "Activate / Deactivate",
                Location = new Point(pnlToolbar.Width - 160, 6),
                Size = new Size(150, 32),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            UIHelper.StyleSecondaryButton(btnToggleStatus);
            btnToggleStatus.Click += OnToggleStatusClick;
            pnlToolbar.Controls.Add(btnToggleStatus);

            var btnEdit = new Button {
                Text = "Edit User",
                Location = new Point(pnlToolbar.Width - 260, 6),
                Size = new Size(90, 32),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            UIHelper.StyleSecondaryButton(btnEdit);
            btnEdit.Click += OnEditUserClick;
            pnlToolbar.Controls.Add(btnEdit);

            var btnCreate = new Button {
                Text = "+ Create User",
                Location = new Point(pnlToolbar.Width - 380, 6),
                Size = new Size(110, 32),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            UIHelper.StylePrimaryButton(btnCreate);
            btnCreate.Click += OnCreateUserClick;
            pnlToolbar.Controls.Add(btnCreate);

            pnlCard.Controls.Add(pnlToolbar);

            // DataGridView setup
            UIHelper.StyleDataGridView(_dgvUsers);
            _dgvUsers.Dock = DockStyle.Fill;
            _dgvUsers.Margin = new Padding(0, 10, 0, 10);

            _dgvUsers.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "USER ID", DataPropertyName = "UserId", Width = 110 });
            _dgvUsers.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "FULL NAME", DataPropertyName = "FullName", Width = 200 });
            _dgvUsers.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "UE EMAIL", DataPropertyName = "Email", Width = 220 });
            _dgvUsers.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ROLE", DataPropertyName = "DisplayRole", Width = 140 });
            _dgvUsers.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "PROGRAM / DESIGNATION", DataPropertyName = "ProgramOrTitle", Width = 220 });
            _dgvUsers.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID NUMBER", DataPropertyName = "IdNumber", Width = 130 });
            _dgvUsers.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STATUS", DataPropertyName = "Status", Width = 110 });

            _dgvUsers.CellPainting += (s, e) => {
                if (e.RowIndex >= 0 && e.ColumnIndex == 6 && e.Value is AccountStatus st) {
                    UIHelper.RenderAccountStatusCell(e, st.ToString(), st);
                }
            };
            _dgvUsers.CellDoubleClick += (s, e) => OnEditUserClick(s, e);

            pnlCard.Controls.Add(_dgvUsers);
            _dgvUsers.BringToFront();

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
            _allUsers = _dataService.GetAllUsers();
            ApplyFilter();
        }

        private void ApplyFilter() {
            string search = _txtSearch.Text.Trim().ToLowerInvariant();
            string roleFilter = _cbRoleFilter.SelectedItem?.ToString() ?? "All Roles";
            string statusFilter = _cbStatusFilter.SelectedItem?.ToString() ?? "All";

            var filtered = _allUsers.Where(u => {
                bool matchesSearch = string.IsNullOrEmpty(search) ||
                    u.UserId.ToLowerInvariant().Contains(search) ||
                    u.FullName.ToLowerInvariant().Contains(search) ||
                    u.Email.ToLowerInvariant().Contains(search) ||
                    u.IdNumber.ToLowerInvariant().Contains(search) ||
                    u.ProgramOrTitle.ToLowerInvariant().Contains(search);

                bool matchesRole = roleFilter == "All Roles" || u.Role.ToString() == roleFilter;
                bool matchesStatus = statusFilter == "All" || u.Status.ToString() == statusFilter;

                return matchesSearch && matchesRole && matchesStatus;
            }).ToList();

            _dgvUsers.DataSource = null;
            _dgvUsers.DataSource = filtered;
            _lblRecordCount.Text = $"Showing {filtered.Count} of {_allUsers.Count} user accounts";
        }

        private User? GetSelectedUser() {
            if (_dgvUsers.CurrentRow?.DataBoundItem is User u) {
                return u;
            }
            return null;
        }

        private void OnCreateUserClick(object? sender, EventArgs e) {
            using var dlg = new UserEditDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                bool ok = _dataService.CreateUser(dlg.ResultUser);
                if (ok) {
                    MessageBox.Show($"User account {dlg.ResultUser.FullName} successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                } else {
                    MessageBox.Show("Failed to create user. A user with this email may already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OnEditUserClick(object? sender, EventArgs e) {
            var user = GetSelectedUser();
            if (user == null) {
                MessageBox.Show("Please select a user to edit.", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var dlg = new UserEditDialog(user);
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                _dataService.UpdateUser(dlg.ResultUser);
                MessageBox.Show("User account details updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void OnToggleStatusClick(object? sender, EventArgs e) {
            var user = GetSelectedUser();
            if (user == null) {
                MessageBox.Show("Please select a user.", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var newStatus = user.Status == AccountStatus.Active ? "Inactive" : "Active";
            var confirm = MessageBox.Show(
                $"Are you sure you want to change account status for {user.FullName} ({user.Email}) to {newStatus}?",
                "Confirm Account Status Change",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes) {
                _dataService.ToggleUserStatus(user.UserId);
                MessageBox.Show($"User account has been set to {newStatus}.", "Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }
    }
}
