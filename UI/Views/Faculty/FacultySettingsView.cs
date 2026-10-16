using System;
using System.Drawing;
using System.Windows.Forms;
using DCSSMeetingScheduler.Models;
using DCSSMeetingScheduler.Services;
using DCSSMeetingScheduler.UI.Common;

namespace DCSSMeetingScheduler.UI.Views.Faculty {
    public class FacultySettingsView : UserControl {
        private readonly IDataService _dataService = MockDataStore.Instance;

        private readonly TextBox _txtPhone = new();
        private readonly CheckBox _chkEmailNotif = new() { Text = "Receive email alerts on new student meeting requests", Checked = true, AutoSize = true };
        private readonly CheckBox _chkReminders = new() { Text = "Send consultation reminders 1 hour before scheduled time", Checked = true, AutoSize = true };
        private readonly TextBox _txtOldPass = new();
        private readonly TextBox _txtNewPass = new();
        private readonly TextBox _txtConfirmPass = new();

        public FacultySettingsView() {
            DoubleBuffered = true;
            Dock = DockStyle.Fill;
            BackColor = ThemeColors.CanvasBackground;
            AutoScroll = true;

            InitializeLayout();
            LoadSettings();
        }

        private void InitializeLayout() {
            var pnlHeader = UIHelper.CreatePageHeader(
                "FACULTY ACCOUNT SETTINGS",
                "Manage contact info, notifications, and portal security"
            );
            Controls.Add(pnlHeader);

            var pnlBody = new Panel {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(24, 16, 24, 30)
            };

            // Card 1: Notification & Contact Preferences
            var pnlCard1 = UIHelper.CreateCard(20);
            pnlCard1.Dock = DockStyle.Top;
            pnlCard1.Height = 220;
            pnlCard1.MaximumSize = new Size(760, 0);

            var lblTitle1 = new Label {
                Text = "Notification & Communication Preferences",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(20, 16),
                AutoSize = true
            };
            pnlCard1.Controls.Add(lblTitle1);

            int y = 50;

            var lblPhone = new Label {
                Text = "Faculty Office Contact Number",
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(20, y),
                AutoSize = true
            };
            pnlCard1.Controls.Add(lblPhone);
            y += 20;

            _txtPhone.Location = new Point(20, y);
            _txtPhone.Size = new Size(680, 26);
            UIHelper.StyleTextBox(_txtPhone);
            pnlCard1.Controls.Add(_txtPhone);
            y += 35;

            _chkEmailNotif.Location = new Point(20, y);
            _chkEmailNotif.Font = new Font("Segoe UI", 9F);
            pnlCard1.Controls.Add(_chkEmailNotif);
            y += 28;

            _chkReminders.Location = new Point(20, y);
            _chkReminders.Font = new Font("Segoe UI", 9F);
            pnlCard1.Controls.Add(_chkReminders);
            y += 35;

            var btnSaveContact = new Button {
                Text = "Save Preferences",
                Location = new Point(560, 165),
                Size = new Size(140, 34)
            };
            UIHelper.StylePrimaryButton(btnSaveContact);
            btnSaveContact.Click += OnSavePreferences;
            pnlCard1.Controls.Add(btnSaveContact);

            pnlBody.Controls.Add(pnlCard1);

            // Card 2: Security & Password
            var pnlCard2 = UIHelper.CreateCard(20);
            pnlCard2.Dock = DockStyle.Top;
            pnlCard2.Height = 260;
            pnlCard2.Margin = new Padding(0, 16, 0, 0);
            pnlCard2.MaximumSize = new Size(760, 0);

            var lblTitle2 = new Label {
                Text = "Security & Password Change",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(20, 16),
                AutoSize = true
            };
            pnlCard2.Controls.Add(lblTitle2);

            int py = 50;

            void AddPassField(string label, TextBox tb) {
                var lbl = new Label {
                    Text = label,
                    Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                    ForeColor = ThemeColors.TextDark,
                    Location = new Point(20, py),
                    AutoSize = true
                };
                pnlCard2.Controls.Add(lbl);
                py += 20;

                tb.Location = new Point(20, py);
                tb.Size = new Size(680, 26);
                tb.PasswordChar = '●';
                UIHelper.StyleTextBox(tb);
                pnlCard2.Controls.Add(tb);
                py += 35;
            }

            AddPassField("Current Password", _txtOldPass);
            AddPassField("New Password", _txtNewPass);
            AddPassField("Confirm New Password", _txtConfirmPass);

            var btnChangePass = new Button {
                Text = "Update Password",
                Location = new Point(560, py),
                Size = new Size(140, 34)
            };
            UIHelper.StyleSecondaryButton(btnChangePass);
            btnChangePass.Click += OnUpdatePassword;
            pnlCard2.Controls.Add(btnChangePass);

            pnlBody.Controls.Add(pnlCard2);
            pnlCard2.BringToFront();

            Controls.Add(pnlBody);
            pnlBody.BringToFront();
        }

        private void LoadSettings() {
            var user = SessionManager.CurrentUser;
            if (user == null) return;
            _txtPhone.Text = user.Phone;
        }

        private void OnSavePreferences(object? sender, EventArgs e) {
            var user = SessionManager.CurrentUser;
            if (user == null) return;

            user.Phone = _txtPhone.Text.Trim();
            _dataService.UpdateUser(user);
            MessageBox.Show("Preferences saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OnUpdatePassword(object? sender, EventArgs e) {
            var user = SessionManager.CurrentUser;
            if (user == null) return;

            if (_txtOldPass.Text != user.Password) {
                MessageBox.Show("Current password is incorrect.", "Security Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(_txtNewPass.Text) || _txtNewPass.Text.Length < 6) {
                MessageBox.Show("New password must be at least 6 characters long.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_txtNewPass.Text != _txtConfirmPass.Text) {
                MessageBox.Show("New password and confirmation do not match.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _dataService.ResetPassword(user.UserId, _txtNewPass.Text);
            _txtOldPass.Clear();
            _txtNewPass.Clear();
            _txtConfirmPass.Clear();
            MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
