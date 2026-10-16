using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DCSSMeetingScheduler.Models;
using DCSSMeetingScheduler.Services;
using DCSSMeetingScheduler.UI.Common;

namespace DCSSMeetingScheduler.UI.Views.Admin {
    public class AdminResetPasswordView : UserControl {
        private readonly IDataService _dataService = MockDataStore.Instance;

        private readonly ComboBox _cbSelectUser = new();
        private readonly Label _lblUserDetails = new();
        private readonly TextBox _txtNewPassword = new();
        private readonly CheckBox _chkForceChange = new() {
            Text = "Require user to change password on their next login",
            Checked = true,
            AutoSize = true,
            Font = new Font("Segoe UI", 9F)
        };
        private readonly CheckBox _chkSendEmail = new() {
            Text = "Send notification email with reset credentials to user's UE email",
            Checked = true,
            AutoSize = true,
            Font = new Font("Segoe UI", 9F)
        };

        public AdminResetPasswordView() {
            DoubleBuffered = true;
            Dock = DockStyle.Fill;
            BackColor = ThemeColors.CanvasBackground;
            AutoScroll = true;

            InitializeLayout();
            LoadUserDropdown();
        }

        private void InitializeLayout() {
            var pnlHeader = UIHelper.CreatePageHeader(
                "ADMINISTRATIVE PASSWORD RESET",
                "Initiate secure credentials reset and temporary password generation for student and faculty accounts"
            );
            Controls.Add(pnlHeader);

            var pnlBody = new Panel {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(24, 16, 24, 30)
            };

            var pnlCard = UIHelper.CreateCard(24);
            pnlCard.Dock = DockStyle.Top;
            pnlCard.Height = 490;
            pnlCard.MaximumSize = new Size(760, 0);

            var lblTitle = new Label {
                Text = "Reset User Portal Credentials",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(20, 16),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblTitle);

            var lblSub = new Label {
                Text = "Select an account to generate a new temporary password and restore portal access.",
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = ThemeColors.TextMuted,
                Location = new Point(20, 42),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblSub);

            int y = 75;

            // 1. Select User
            var lblSelect = new Label {
                Text = "Select Account / User *",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(20, y),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblSelect);
            y += 22;

            _cbSelectUser.Location = new Point(20, y);
            _cbSelectUser.Size = new Size(680, 28);
            UIHelper.StyleComboBox(_cbSelectUser);
            _cbSelectUser.SelectedIndexChanged += OnUserSelected;
            pnlCard.Controls.Add(_cbSelectUser);
            y += 35;

            // User Info Highlight Card
            var pnlUserInfo = new Panel {
                Location = new Point(20, y),
                Size = new Size(680, 60),
                BackColor = ThemeColors.LightRed,
                Padding = new Padding(12)
            };
            pnlUserInfo.Paint += (s, e) => {
                using var pen = new Pen(ThemeColors.LightRedBorder, 1);
                e.Graphics.DrawRectangle(pen, 0, 0, pnlUserInfo.Width - 1, pnlUserInfo.Height - 1);
            };

            _lblUserDetails.Text = "Please select a user account above to view details.";
            _lblUserDetails.Font = new Font("Segoe UI", 9F);
            _lblUserDetails.ForeColor = ThemeColors.PrimaryRedDark;
            _lblUserDetails.Location = new Point(12, 12);
            _lblUserDetails.Size = new Size(656, 36);
            pnlUserInfo.Controls.Add(_lblUserDetails);
            pnlCard.Controls.Add(pnlUserInfo);
            y += 75;

            // 2. New Temporary Password
            var lblNewPass = new Label {
                Text = "New Temporary Password *",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(20, y),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblNewPass);
            y += 22;

            _txtNewPassword.Location = new Point(20, y);
            _txtNewPassword.Size = new Size(510, 26);
            _txtNewPassword.Text = "UE@Temp2026!";
            UIHelper.StyleTextBox(_txtNewPassword);
            pnlCard.Controls.Add(_txtNewPassword);

            var btnGenerate = new Button {
                Text = "🎲 Generate New",
                Location = new Point(540, y - 1),
                Size = new Size(160, 28)
            };
            UIHelper.StyleSecondaryButton(btnGenerate);
            btnGenerate.Click += (s, e) => {
                var random = new Random();
                int pin = random.Next(100000, 999999);
                _txtNewPassword.Text = $"UE-DCSS-{pin}";
            };
            pnlCard.Controls.Add(btnGenerate);
            y += 38;

            // Checkboxes
            _chkForceChange.Location = new Point(20, y);
            pnlCard.Controls.Add(_chkForceChange);
            y += 28;

            _chkSendEmail.Location = new Point(20, y);
            pnlCard.Controls.Add(_chkSendEmail);
            y += 45;

            // Reset Button
            var btnReset = new Button {
                Text = "Reset User Password",
                Location = new Point(500, y),
                Size = new Size(200, 38)
            };
            UIHelper.StylePrimaryButton(btnReset);
            btnReset.Click += OnResetPasswordClick;
            pnlCard.Controls.Add(btnReset);

            pnlBody.Controls.Add(pnlCard);
            Controls.Add(pnlBody);
            pnlBody.BringToFront();
        }

        private void LoadUserDropdown() {
            var users = _dataService.GetAllUsers();
            _cbSelectUser.DataSource = null;
            _cbSelectUser.DisplayMember = "DisplayText";
            _cbSelectUser.ValueMember = "UserId";

            var items = users.Select(u => new {
                u.UserId,
                DisplayText = $"{u.FullName} ({u.Role}) • {u.Email}"
            }).ToList();

            _cbSelectUser.DataSource = items;
            if (items.Any()) {
                _cbSelectUser.SelectedIndex = 0;
                OnUserSelected(null, EventArgs.Empty);
            }
        }

        private void OnUserSelected(object? sender, EventArgs e) {
            if (_cbSelectUser.SelectedValue is string uid) {
                var user = _dataService.GetUserById(uid);
                if (user != null) {
                    _lblUserDetails.Text = $"Selected Account: {user.FullName} | Role: {user.DisplayRole} | Dept: {user.Department} | ID: {user.IdNumber}\nStatus: {user.Status} | Current Registered Email: {user.Email}";
                }
            }
        }

        private void OnResetPasswordClick(object? sender, EventArgs e) {
            if (_cbSelectUser.SelectedValue is not string uid) {
                MessageBox.Show("Please select a user account.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(_txtNewPassword.Text)) {
                MessageBox.Show("Please enter or generate a temporary password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = _dataService.GetUserById(uid);
            if (user == null) return;

            var confirm = MessageBox.Show(
                $"Are you sure you want to reset password for {user.FullName} ({user.Email})?\n\nTemporary Password: {_txtNewPassword.Text.Trim()}",
                "Confirm Administrative Password Reset",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes) {
                _dataService.ResetPassword(user.UserId, _txtNewPassword.Text.Trim());
                MessageBox.Show(
                    $"Password for {user.FullName} successfully reset!\n\nNew Credentials:\nUsername/Email: {user.Email}\nTemporary Password: {_txtNewPassword.Text.Trim()}",
                    "Password Reset Completed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}
